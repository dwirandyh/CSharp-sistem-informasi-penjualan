using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TugasAkhirSIM.Controllers
{
    class CBarang
    {
        public static List<Models.barang> get_data()
        {
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    return db.barangs.ToList();
                }   
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new List<Models.barang>();
        }

        public static List<satuanbarang> get_satuan()
        {
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    return db.Database.SqlQuery<satuanbarang>("select distinct satuan from barang order by satuan desc").ToList();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new List<satuanbarang>();
        }

        public static List<jenisbarang> get_jenis()
        {
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    return db.Database.SqlQuery<jenisbarang>("select distinct jenis from barang order by satuan desc").ToList();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return new List<jenisbarang>();
        }

        public static Models.barang get_detail(string kode)
        {
            using (var db = new Models.sim_penjualanContext())
            {
                return db.barangs.Where(t => t.kd_barang == kode).SingleOrDefault();
            }
        }

        public static string get_kode()
        {
            using (var db = new Models.sim_penjualanContext())
            {
                return db.Database.SqlQuery<string>("CALL penomoran('BRG','barang', 'kd_barang')").SingleOrDefault();
            }
        }

        public static List<Models.barang> search(string kolom, string param)
        {
            kolom = kolom.ToLower();
            using (var db = new Models.sim_penjualanContext())
            {
                if (kolom.Contains("kode"))
                {
                    return db.barangs.Where(t => t.kd_barang.Contains(param)).ToList();
                }
                else if (kolom.Contains("nama"))
                {
                    return db.barangs.Where(t => t.nama.Contains(param)).ToList();
                }
                else if (kolom.Contains("harga"))
                {
                    return db.barangs.Where(t => t.harga.ToString().Contains(param)).ToList();
                }
                else if (kolom.Contains("satuan"))
                {
                    return db.barangs.Where(t => t.satuan.Contains(param)).ToList();
                }
                else if (kolom.Contains("jenis"))
                {
                    return db.barangs.Where(t => t.jenis.Contains(param)).ToList();
                }
                else
                {
                    return db.barangs.Where(t => t.stok.ToString().Contains(param)).ToList();
                }
            }
        }

        public static bool insert(Models.barang data)
        {
            bool result = false;
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    db.Entry(data).State = EntityState.Added;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static bool update(Models.barang data)
        {
            bool result = false;
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    db.Entry(data).State = EntityState.Modified;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static bool delete(Models.barang data)
        {
            bool result = false;
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    db.Entry(data).State = EntityState.Deleted;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static DataSet1 get_report(string column, string param)
        {
            DataSet1 result = new DataSet1();
            try
            {
                string sql = "select * from barang";
                column = column.ToLower();
                if (column.Contains("kode"))
                {
                    sql += string.Format(" where kd_barang like '%{0}%'", param);
                }
                else if (column.Contains("nama"))
                {
                    sql += string.Format(" where nama like '%{0}%'", param);
                }
                else if (column.Contains("harga"))
                {
                    sql += string.Format(" where harga like '%{0}%'", param);
                }
                else if (column.Contains("satuan"))
                {
                    sql += string.Format(" where satuan like '%{0}%'", param);
                }
                else if (column.Contains("jenis"))
                {
                    sql += string.Format(" where jenis like '%{0}%'", param);
                }
                else if (column.Contains("stok"))
                {
                    sql += string.Format(" where stok like '%{0}%'", param);
                }

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
                            result.Tables["barang"].Merge(dt);
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

        public static DataSet1 get_report_per_satuan(string param)
        {
            DataSet1 result = new DataSet1();
            try
            {
                string sql = string.Format("select * from barang where satuan in({0})", "'"+ param.Replace(", ", "','") + "'");

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
                            result.Tables["barang"].Merge(dt);
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

        public static DataSet1 get_report_per_jenis(string param)
        {
            DataSet1 result = new DataSet1();
            try
            {
                string sql = string.Format("select * from barang where jenis in ({0})", "'" + param.Replace(", ", "','") + "'");

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
                            result.Tables["barang"].Merge(dt);
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

    public class satuanbarang
    {
        public string satuan { get; set; }
    }

    public class jenisbarang
    {
        public string jenis { get; set; }
    }
}
