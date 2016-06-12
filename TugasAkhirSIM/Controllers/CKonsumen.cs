using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace TugasAkhirSIM.Controllers
{
    class CKonsumen
    {
        public static List<Models.konsumen> get_data()
        {
            using (var db = new Models.sim_penjualanContext())
            {
                return db.konsumen.ToList();
            }
        }

        public static Models.konsumen get_detail(string kode)
        {
            using (var db = new Models.sim_penjualanContext())
            {
                return db.konsumen.Where(t => t.kd_konsumen == kode).SingleOrDefault();
            }
        }

        public static string get_kode()
        {
            using (var db = new Models.sim_penjualanContext())
            {
                return db.Database.SqlQuery<string>("CALL penomoran('KSM','konsumen', 'kd_konsumen')").SingleOrDefault();
            }
        }

        public static List<Models.konsumen> search(string kolom, string param)
        {
            kolom = kolom.ToLower();
            using (var db = new Models.sim_penjualanContext())
            {
                if (kolom.Contains("kode"))
                {
                    return db.konsumen.Where(t => t.kd_konsumen.Contains(param)).ToList();
                }
                else if (kolom.Contains("nama"))
                {
                    return db.konsumen.Where(t => t.nama.Contains(param)).ToList();
                }                
                else if (kolom.Contains("alamat"))
                {
                    return db.konsumen.Where(t => t.alamat.ToString().Contains(param)).ToList();
                }
                else
                {
                    return db.konsumen.Where(t => t.email.Contains(param)).ToList();
                }
            }
        }

        public static bool insert(Models.konsumen data)
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

        public static bool update(Models.konsumen data)
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

        public static bool delete(Models.konsumen data)
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
            DataSet1 ds = new DataSet1();
            try
            {
                string sql = "select * from konsumen where ";
                if (column.Contains("kode"))
                {
                    sql += string.Format("kd_konsumen like '%{0}%'", param);
                }
                else if (column.Contains("nama"))
                {
                    sql += string.Format("nama like '%{0}%'", param);
                }
                else if (column.Contains("alamat"))
                {
                    sql += string.Format("alamat like '%{0}%'", param);
                }
                else
                {
                    sql += string.Format("email like '%{0}%'", param);
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
                            ds.Tables["konsumen"].Merge(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return ds;
        }
    }
}
