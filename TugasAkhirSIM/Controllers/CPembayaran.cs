using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace TugasAkhirSIM.Controllers
{
    class CPembayaran
    {
        public static List<Models.penjualan> get_penjualan()
        {
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    return db.penjualans
                        .Include(t => t.konsumen)
                        .Where(t => t.status == 0).ToList();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new List<Models.penjualan>();
        }

        public static Models.penjualan get_detail_penjualan(string strNoFaktur)
        {
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    return db.penjualans
                        .Include(t => t.konsumen)
                        .Include(t => t.karyawan)
                        .Where(t => t.no_faktur == strNoFaktur && t.status == 0).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new Models.penjualan();
        }

        public static List<Models.detail_penjualan> get_detail_barang(string strNoFaktur)
        {
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    return db.detail_penjualan
                        .Include(t => t.barang)
                        .Where(t => t.no_faktur == strNoFaktur).ToList();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new List<Models.detail_penjualan>();
        }

        public static bool insert(Models.pembayaran data)
        {
            bool result = false;
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            List<Models.detail_penjualan> detail = db.detail_penjualan.Where(t => t.no_faktur == data.no_faktur).ToList();
                            foreach (var dt in detail)
                            {
                                var barang = db.barangs.Where(t => t.kd_barang == dt.kd_barang).Single();
                                barang.stok -= dt.jumlah;
                                db.Entry(barang).State = EntityState.Modified;
                            }

                            db.Entry(data).State = EntityState.Added;
                            db.SaveChanges();
                            result = true;
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static List<Models.pembayaran> search(string param)
        {
            var result = new List<Models.pembayaran>();
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    result = db.pembayarans
                        .Include(t => t.penjualan)
                        .Include(t => t.penjualan.konsumen)
                        .Where(t => t.no_faktur.Contains(param) || t.penjualan.konsumen.kd_konsumen.Contains(param) || t.penjualan.konsumen.nama.Contains(param))
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static DataSet1 get_faktur(string no_faktur)
        {
            DataSet1 result = new DataSet1();
            try
            {
                string[] table1 = { "pembayaran", "penjualan", "detail_penjualan" };
                foreach (var table in table1)
                {
                    string sql = string.Format("select * from {0} where no_faktur = '{1}'", table, no_faktur);

                    using (var db = new Models.sim_penjualanContext())
                    {
                        db.Database.Connection.Open();
                        using (var cmd = db.Database.Connection.CreateCommand())
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType = System.Data.CommandType.Text;
                            using (var reader = cmd.ExecuteReader())
                            {
                                var dt = new System.Data.DataTable();
                                dt.Load(reader);
                                result.Tables[table].Merge(dt);
                            }
                        }
                    }
                }

                string[] table2 = { "karyawan", "barang", "konsumen"};
                foreach (var table in table2)
                {
                    string sql = string.Format("select * from {0}", table);

                    using (var db = new Models.sim_penjualanContext())
                    {
                        db.Database.Connection.Open();
                        using (var cmd = db.Database.Connection.CreateCommand())
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType = System.Data.CommandType.Text;
                            using (var reader = cmd.ExecuteReader())
                            {
                                var dt = new System.Data.DataTable();
                                dt.Load(reader);
                                result.Tables[table].Merge(dt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }
    }
}
