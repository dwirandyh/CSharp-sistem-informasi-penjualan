using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TugasAkhirSIM.Controllers
{
    class CKaryawan
    {
        public static List<Models.karyawan> get_data()
        {
            using (var db = new Models.sim_penjualanContext())
            {
                return db.karyawans.ToList();
            }
        }

        public static Models.karyawan get_detail(string kode)
        {
            using (var db = new Models.sim_penjualanContext())
            {
                return db.karyawans.Where(t => t.kd_karyawan == kode).SingleOrDefault();
            }
        }

        public static Models.karyawan check_login(string username)
        {
            var result = new Models.karyawan();
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    result = db.karyawans.Where(t => t.username == username).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return result;
        }

        public static string get_kode()
        {
            using (var db = new Models.sim_penjualanContext())
            {
                return db.Database.SqlQuery<string>("CALL penomoran('KRY','karyawan', 'kd_karyawan')").SingleOrDefault();
            }
        }

        public static List<Models.karyawan> search(string kolom, string param)
        {
            kolom = kolom.ToLower();
            using (var db = new Models.sim_penjualanContext())
            {
                if (kolom.Contains("kode"))
                {
                    return db.karyawans.Where(t => t.kd_karyawan.Contains(param)).ToList();
                }
                else if (kolom.Contains("nama"))
                {
                    return db.karyawans.Where(t => t.nama.Contains(param)).ToList();
                }
                else if (kolom.Contains("alamat"))
                {
                    return db.karyawans.Where(t => t.alamat.Contains(param)).ToList();
                }
                else if (kolom.Contains("email"))
                {
                    return db.karyawans.Where(t => t.email.Contains(param)).ToList();
                }
                else if (kolom.Contains("username"))
                {
                    return db.karyawans.Where(t => t.username.Contains(param)).ToList();
                }
                else
                {
                    return db.karyawans.Where(t => t.hak_akses.Contains(param)).ToList();
                }
            }
        }

        public static bool insert(Models.karyawan data)
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

        public static bool update(Models.karyawan data)
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

        public static bool delete(Models.karyawan data)
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

        public static DataSet1 get_report(string kolom, string param)
        {
            DataSet1 result = new DataSet1();
            kolom = kolom.ToLower();
            string sql = "select * from karyawan where ";
            if (kolom.Contains("kode"))
            {
                sql += string.Format("kd_karyawan like '%{0}%'", param);
            }
            else if (kolom.Contains("nama"))
            {
                sql += string.Format("nama like '%{0}%'", param);
            }
            else if (kolom.Contains("alamat"))
            {
                sql += string.Format("alamat like '%{0}%'", param);
            }
            else if (kolom.Contains("email"))
            {
                sql += string.Format("email like '%{0}%'", param);
            }
            else if (kolom.Contains("akses"))
            {
                sql += string.Format("hak_akses like '%{0}%'", param);
            }
            try
            {
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
                            result.Tables["karyawan"].Merge(dt);
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
