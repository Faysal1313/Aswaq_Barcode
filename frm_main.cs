using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;


namespace Aswaq_Barcode
{
    public partial class frm_main : DevExpress.XtraEditors.XtraForm
    {
        public frm_main()
        {
            InitializeComponent();
            db.Open();
        }
        public static string database = "";
        private void btn_search_inv_Click(object sender, EventArgs e)
        {
            all_comb.load_invoice_number_purchase(combo_invoice_no);

            //combo_invoice_no.Text = Properties.Settings.Default.db_name;
        }

        private void btn_show_inv_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_inv.Rows.Clear();
                DataTable dt = new DataTable();
                db.GetData_DGV("select cItCode, cItName, fTransQty, fTransUnitPrice from PInv_D where cInvoicNum='" + this.combo_invoice_no.Text + "'", dt);
                // this.dgv_inv.DataSource =dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_inv.Rows.Add("", dt.Rows[i][0] + "", dt.Rows[i][1] + "", dt.Rows[i][2] + "", dt.Rows[i][3] + "");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_show_barcode_inv_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_inv.Rows.Count; ++i)
            {
                double num = Convert.ToDouble(dgv_inv.Rows[i].Cells["qty"].Value);
                string str1 = dgv_inv.Rows[i].Cells["code"].Value.ToString();
                string str2 = dgv_inv.Rows[i].Cells["name"].Value.ToString();
                for (int ii = 0; ii < num; ++ii)
                    dgv_2.Rows.Add("0", str1, str2, 0, 1);
            }
            try
            {
                for (int i = 0; i < dgv_2.Rows.Count; ++i)
                {
                    int num = Convert.ToInt32(dgv_2.Rows[i].Cells[4].Value);
                    for (int ii = 0; ii < num; ++ii)
                    {
                        string str = db.GetData("select isnull(max(cVcode),0) from item where cCode='" + dgv_2.Rows[i].Cells[1].Value + "'").Rows[0][0].ToString();
                        if (str == "0")
                            str = string.Concat(dgv_2.Rows[i].Cells[1].Value);
                        dgv1.Rows.Add("", dgv_2.Rows[i].Cells[1].Value, str);
                    }
                }
            }
            catch (Exception ex)
            {
                db.log_error(string.Concat((object)ex));
            }
        }

        private void btn_direct_print_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count < 0)
                return;
            for (int i = 0; i < dgv1.Rows.Count; ++i)
            {

                XtraReport xtraReport = XtraReport.FromFile("forms\\barcode_code.repx", true);
                xtraReport.Parameters["parameter1"].Value = dgv1.Rows[i].Cells[1].Value;
                xtraReport.Parameters["parameter1"].Visible = false;
                xtraReport.PrinterName = "Xprinter XP-370B";//Settings.Default.printer_name_barcode;
                xtraReport.RollPaper = true;
                xtraReport.PrintAsync();

            }
        }

        private void dgv_inv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            db.LoadSerial(dgv_inv, "no_inv");
        }

        private void dgv_inv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            db.LoadSerial(dgv_inv, "no_inv");
        }

        private void dgv1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            db.LoadSerial(dgv1, "no1");
        }
        private void dgv1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            db.LoadSerial(dgv1, "no1");
        }

        private void dgv_2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            db.LoadSerial(dgv_2, "no2");

        }

        private void dgv_2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            db.LoadSerial(dgv_2, "no2");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           //Properties.Settings.Default.db_name= txt_db.Text;

           // Properties.Settings.Default.Save();
            db.Open();
        }
    }
}