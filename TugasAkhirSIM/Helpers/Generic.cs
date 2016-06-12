using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;

namespace TugasAkhirSIM.Helpers
{
    class Generic
    {
        public static void ShowChild(RibbonForm parent, XtraForm child)
        {
            child.MdiParent = parent;
            child.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            child.Show();
        }
        public static void ShowAdd(XtraForm parent, XtraForm child)
        {
            child.Owner = parent;
            child.StartPosition = FormStartPosition.CenterScreen;
            child.Show();
        }

        public static void MsgInfo(string pesan)
        {
            XtraMessageBox.Show(pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult MsgQuestion(string pesan)
        {
            return XtraMessageBox.Show(pesan, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void MsgEx(string pesan)
        {
            XtraMessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgError(string pesan)
        {
            XtraMessageBox.Show(pesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
