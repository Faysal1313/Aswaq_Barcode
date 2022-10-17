using Aswaq_Barcode.Properties;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aswaq_Barcode
{
    public partial class frm_main_barcode : DevExpress.XtraEditors.XtraForm
    {
        public frm_main_barcode()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon("Aswaq_Barcode.exe");

            compo_db();
        }

        private void btn_search_inv_Click(object sender, EventArgs e)
        {
            db.Open();
            all_comb.load_invoice_number_purchase(combo_invoice_no);
        }

        private void btn_show_inv_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_inv.Rows.Clear();
                DataTable dt = new DataTable();
                db.GetData_DGV("select cItCode, cItName, fTransQty, fTransUnitPrice from PInv_D where cInvoicNum='" + this.combo_invoice_no.Text + "'", dt);
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
                string str1 = dgv_inv.Rows[i].Cells["code"].Value.ToString().Trim();
                string str2 = dgv_inv.Rows[i].Cells["name"].Value.ToString().Trim();
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
                xtraReport.PrinterName = Settings.Default.printer_name_barcode;
                xtraReport.RollPaper = true;
                xtraReport.PrintAsync();

            }
        }
        private void btn_show_print_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if (dgv1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
               
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
        private void add_inv()
        {
            if (combo_code_items.Text == "") return;
            string str = db.GetData("select isnull(max(cVcode),0) from item where cCode='" + combo_code_items.Text + "'").Rows[0][0].ToString();
            if (str == "0")
                str = combo_code_items.Text;
            dgv_2.Rows.Add("", combo_code_items.Text, combo_name_items.Text, str, 1);

        }
        private void btn_search_items_Click(object sender, EventArgs e)
        {
            db.Open();
            all_comb.load_items_code(combo_code_items);
            //all_comb.load_items_code(combo_code_items);

            combo_name_items.Text = "";
            combo_code_items.Text = "";
        }

        private void combo_code_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                combo_name_items.Text = db.GetData("select (cName1) from item where cCode='" + combo_code_items.Text + "'").Rows[0][0].ToString().Trim();
            }
            catch (Exception)
            {
            }
        }

        private void combo_name_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                combo_code_items.Text = db.GetData("select (ccode) from item where cName1='" + combo_name_items.Text + "'").Rows[0][0].ToString().Trim();
            }
            catch (Exception)
            {
            }
        }

        private void combo_code_items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add_inv();
            }
        }
        private void btn_desgin_report_Click(object sender, EventArgs e)
        {
            Reportdesign f = new Reportdesign();
            f.Show();
        }
        public int row = 0;
        private void print_barcode(string code)
        {
            XtraReport xtraReport = XtraReport.FromFile("forms\\barcode_code.repx", true);
            xtraReport.Parameters["parameter1"].Value = code;
            xtraReport.Parameters["parameter1"].Visible = false;
            xtraReport.PrinterName = Settings.Default.printer_name_barcode;
            xtraReport.RollPaper = true;
            xtraReport.PrintAsync();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                progressBar1.Value = 0;
                return;
            }
            else
            {
                timer1.Start();
                progressBar1.Increment(1);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count < row)
            {
                row = 0;
                return;
            }
            else
            {
                if (dgv1.Rows.Count <= row)
                {
                    return;
                }
                if (progressBar1.Value == 100)
                {
                    progressBar1.Value = 0;
                    timer1.Enabled = false;
                    print_barcode(dgv1.Rows[row].Cells[1].Value + "");
                    timer1.Enabled = true;
                    row = row + 1;
                }
            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            combo_code_items.Text = "";
            combo_name_items.Text = "";
            dgv1.Rows.Clear();
            dgv_2.Rows.Clear();
        }
        //------------------------------------------------------------------------------------------------------------
        private void btn_save_con_Click(object sender, EventArgs e)
        {
            
                Settings.Default.server = this.txt_server.Text;
                Settings.Default.sql_name = this.txt_user_Sql.Text;
                Settings.Default.sql_pass = this.txt_pass_sql.Text;
                Settings.Default.db_base = this.combo_db.Text;
                Settings.Default.Save();

            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", new object[4]
      {
        (object) this.txt_server.Text,
        (object) this.combo_db.Text,
        (object) this.txt_user_Sql.Text,
        (object) this.txt_pass_sql.Text
      });
            try
            {
                if (new SqlHelper(connectionString).IsConnection)
                {
                    new AppSetting().SaveConnectionString("cn", connectionString);
                    int num = (int)MessageBox.Show("Your connection string has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                db.log_error(string.Concat((object)ex));
            }
            Application.Exit();
        }
        public void compo_db()
        {
            txt_server.Text = Settings.Default.server;
            txt_user_Sql.Text = Settings.Default.sql_name;
            txt_pass_sql.Text = Settings.Default.sql_pass;
            combo_db.Text = Settings.Default.db_base;
            combo_barcode.Text= Settings.Default.printer_name_barcode;
            load_printer_divec_barcode();

        }
        private void label7_Click(object sender, EventArgs e)
        {
            compo_db();

        }
        //------------------------------------------------------------------------------
        public static class myPrinters//install printer
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string Name);
        }
        private void load_printer_divec_barcode()//read printer_devies barcode
        {
            DataTable dt = new DataTable();
            foreach (var i in PrinterSettings.InstalledPrinters)
            {
                combo_barcode.Items.Add(i);
            }
        }
        private void btn_barcode_Click(object sender, EventArgs e)
        {
            string pname = combo_barcode.Text;
            myPrinters.SetDefaultPrinter(pname);
            Properties.Settings.Default.printer_name_barcode = pname;
            Properties.Settings.Default.Save();
        }


        
    }
}