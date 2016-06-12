using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasAkhirSIM.Controllers
{
    class CPenjualan
    {
        public static string get_faktur()
        {
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    return db.Database.SqlQuery<string>("call penomoran_transaksi('TRJ','penjualan','no_faktur')").SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                Helpers.Generic.MsgError(ex.Message);
            }
            return "";
        }

        public static bool insert(Models.penjualan data)
        {
            bool result = false;
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    db.Entry(data).State = System.Data.Entity.EntityState.Added;
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

        public static DataSet1 get_report(DateTime tgl1, DateTime tgl2)
        {
            DataSet1 result = new DataSet1();
            try
            {
                using (var db = new Models.sim_penjualanContext())
                {
                    db.Database.Connection.Open();
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = string.Format("select * from penjualan where date(tgl) between '{0}' and '{1}' order by kd_konsumen asc",tgl1.ToString("yyyy-MM-dd"), tgl2.ToString("yyyy-MM-dd"));
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            result.Tables["penjualan"].Merge(dt);
                        }
                    }

                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = "select * from konsumen";
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new System.Data.DataTable();
                            dt.Load(reader);
                            result.Tables["konsumen"].Merge(dt);
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
