
namespace Aswaq_Barcode
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_code_items = new DevExpress.XtraEditors.SimpleButton();
            this.btn_show_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_direct_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_show_barcode_items = new DevExpress.XtraEditors.SimpleButton();
            this.btn_show_inv = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search_items = new DevExpress.XtraEditors.SimpleButton();
            this.combo_code_items = new System.Windows.Forms.ComboBox();
            this.combo_name_items = new System.Windows.Forms.ComboBox();
            this.btn_search_inv = new DevExpress.XtraEditors.SimpleButton();
            this.combo_invoice_no = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_show_barcode_inv = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.no1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_inv = new System.Windows.Forms.DataGridView();
            this.no_inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_2 = new System.Windows.Forms.DataGridView();
            this.no2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.ImageOptions.Image")));
            this.btn_new.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(413, 280);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(22, 25);
            this.btn_new.TabIndex = 214;
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_del.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.ImageOptions.Image")));
            this.btn_del.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_del.Location = new System.Drawing.Point(407, 279);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(22, 25);
            this.btn_del.TabIndex = 213;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(231, 265);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 212;
            // 
            // btn_code_items
            // 
            this.btn_code_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_code_items.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_code_items.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_code_items.ImageOptions.Image")));
            this.btn_code_items.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_code_items.Location = new System.Drawing.Point(413, 253);
            this.btn_code_items.Name = "btn_code_items";
            this.btn_code_items.Size = new System.Drawing.Size(22, 25);
            this.btn_code_items.TabIndex = 211;
            // 
            // btn_show_print
            // 
            this.btn_show_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_show_print.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_show_print.Appearance.Options.UseFont = true;
            this.btn_show_print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_show_print.ImageOptions.SvgImage")));
            this.btn_show_print.Location = new System.Drawing.Point(266, 454);
            this.btn_show_print.Name = "btn_show_print";
            this.btn_show_print.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_show_print.Size = new System.Drawing.Size(153, 36);
            this.btn_show_print.TabIndex = 210;
            this.btn_show_print.Text = "طباعة دقيقة";
            // 
            // btn_direct_print
            // 
            this.btn_direct_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_direct_print.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_direct_print.Appearance.Options.UseFont = true;
            this.btn_direct_print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_direct_print.ImageOptions.SvgImage")));
            this.btn_direct_print.Location = new System.Drawing.Point(516, 454);
            this.btn_direct_print.Name = "btn_direct_print";
            this.btn_direct_print.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_direct_print.Size = new System.Drawing.Size(153, 36);
            this.btn_direct_print.TabIndex = 209;
            this.btn_direct_print.Text = "طباعة الباركود مباشر";
            this.btn_direct_print.Click += new System.EventHandler(this.btn_direct_print_Click);
            // 
            // btn_show_barcode_items
            // 
            this.btn_show_barcode_items.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_show_barcode_items.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_show_barcode_items.Appearance.Options.UseFont = true;
            this.btn_show_barcode_items.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_show_barcode_items.ImageOptions.SvgImage")));
            this.btn_show_barcode_items.Location = new System.Drawing.Point(733, 454);
            this.btn_show_barcode_items.Name = "btn_show_barcode_items";
            this.btn_show_barcode_items.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_show_barcode_items.Size = new System.Drawing.Size(153, 36);
            this.btn_show_barcode_items.TabIndex = 208;
            this.btn_show_barcode_items.Text = "عرض الباركود للصنف";
            // 
            // btn_show_inv
            // 
            this.btn_show_inv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_show_inv.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_show_inv.Appearance.Options.UseFont = true;
            this.btn_show_inv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_show_inv.ImageOptions.Image")));
            this.btn_show_inv.Location = new System.Drawing.Point(427, 26);
            this.btn_show_inv.Name = "btn_show_inv";
            this.btn_show_inv.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_show_inv.Size = new System.Drawing.Size(115, 36);
            this.btn_show_inv.TabIndex = 206;
            this.btn_show_inv.Text = "عرض الفاتورة";
            this.btn_show_inv.Click += new System.EventHandler(this.btn_show_inv_Click);
            // 
            // btn_search_items
            // 
            this.btn_search_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_items.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search_items.ImageOptions.Image")));
            this.btn_search_items.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_search_items.Location = new System.Drawing.Point(764, 261);
            this.btn_search_items.Name = "btn_search_items";
            this.btn_search_items.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_search_items.Size = new System.Drawing.Size(22, 25);
            this.btn_search_items.TabIndex = 205;
            this.btn_search_items.ToolTip = "بحث رقم الوردية";
            // 
            // combo_code_items
            // 
            this.combo_code_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_code_items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_code_items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_code_items.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo_code_items.FormattingEnabled = true;
            this.combo_code_items.Location = new System.Drawing.Point(441, 251);
            this.combo_code_items.Name = "combo_code_items";
            this.combo_code_items.Size = new System.Drawing.Size(317, 21);
            this.combo_code_items.TabIndex = 204;
            // 
            // combo_name_items
            // 
            this.combo_name_items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_name_items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_name_items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_name_items.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo_name_items.FormattingEnabled = true;
            this.combo_name_items.Location = new System.Drawing.Point(441, 278);
            this.combo_name_items.Name = "combo_name_items";
            this.combo_name_items.Size = new System.Drawing.Size(317, 21);
            this.combo_name_items.TabIndex = 203;
            // 
            // btn_search_inv
            // 
            this.btn_search_inv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_inv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search_inv.ImageOptions.Image")));
            this.btn_search_inv.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_search_inv.Location = new System.Drawing.Point(753, 35);
            this.btn_search_inv.Name = "btn_search_inv";
            this.btn_search_inv.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_search_inv.Size = new System.Drawing.Size(22, 25);
            this.btn_search_inv.TabIndex = 202;
            this.btn_search_inv.ToolTip = "بحث رقم الوردية";
            this.btn_search_inv.Click += new System.EventHandler(this.btn_search_inv_Click);
            // 
            // combo_invoice_no
            // 
            this.combo_invoice_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_invoice_no.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_invoice_no.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_invoice_no.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo_invoice_no.FormattingEnabled = true;
            this.combo_invoice_no.Location = new System.Drawing.Point(571, 38);
            this.combo_invoice_no.Name = "combo_invoice_no";
            this.combo_invoice_no.Size = new System.Drawing.Size(176, 21);
            this.combo_invoice_no.TabIndex = 201;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(804, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 200;
            this.label3.Text = "كود الصنف";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            // 
            // btn_show_barcode_inv
            // 
            this.btn_show_barcode_inv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_show_barcode_inv.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn_show_barcode_inv.Appearance.Options.UseFont = true;
            this.btn_show_barcode_inv.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_show_barcode_inv.ImageOptions.SvgImage")));
            this.btn_show_barcode_inv.Location = new System.Drawing.Point(256, 26);
            this.btn_show_barcode_inv.Name = "btn_show_barcode_inv";
            this.btn_show_barcode_inv.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_show_barcode_inv.Size = new System.Drawing.Size(153, 36);
            this.btn_show_barcode_inv.TabIndex = 207;
            this.btn_show_barcode_inv.Text = "عرض الباركود للفاتورة";
            this.btn_show_barcode_inv.Click += new System.EventHandler(this.btn_show_barcode_inv_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(804, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 199;
            this.label2.Text = "اسم الصنف";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv1.Location = new System.Drawing.Point(2, 23);
            this.dgv1.Name = "dgv1";
            this.dgv1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.Size = new System.Drawing.Size(240, 470);
            this.dgv1.TabIndex = 195;
            this.dgv1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv1_RowsAdded);
            this.dgv1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv1_RowsRemoved);
            // 
            // no1
            // 
            this.no1.FillWeight = 45.68528F;
            this.no1.HeaderText = "م";
            this.no1.Name = "no1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 127.1574F;
            this.Column2.HeaderText = "كود الصنف";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 127.1574F;
            this.Column3.HeaderText = "باركود";
            this.Column3.Name = "Column3";
            // 
            // dgv_inv
            // 
            this.dgv_inv.AllowUserToAddRows = false;
            this.dgv_inv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_inv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_inv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_inv,
            this.code,
            this.name,
            this.qty,
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_inv.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_inv.Location = new System.Drawing.Point(256, 65);
            this.dgv_inv.Name = "dgv_inv";
            this.dgv_inv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_inv.Size = new System.Drawing.Size(633, 162);
            this.dgv_inv.TabIndex = 196;
            this.dgv_inv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_inv_RowsAdded);
            this.dgv_inv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_inv_RowsRemoved);
            // 
            // no_inv
            // 
            this.no_inv.FillWeight = 45.68528F;
            this.no_inv.HeaderText = "م";
            this.no_inv.Name = "no_inv";
            // 
            // code
            // 
            this.code.DataPropertyName = "cItCode";
            this.code.FillWeight = 127.1574F;
            this.code.HeaderText = "كود الصنف";
            this.code.Name = "code";
            // 
            // name
            // 
            this.name.DataPropertyName = "cItName";
            this.name.HeaderText = "اسم الصنف";
            this.name.Name = "name";
            // 
            // qty
            // 
            this.qty.DataPropertyName = "fTransQty";
            this.qty.FillWeight = 127.1574F;
            this.qty.HeaderText = "الكمية";
            this.qty.Name = "qty";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fTransUnitPrice";
            this.Column4.HeaderText = "سعر الشراء";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(772, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 198;
            this.label1.Text = "فاتورة مشتريات";
            // 
            // dgv_2
            // 
            this.dgv_2.AllowUserToAddRows = false;
            this.dgv_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no2,
            this.dataGridViewTextBoxColumn5,
            this.Column7,
            this.dataGridViewTextBoxColumn6,
            this.Column6});
            this.dgv_2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_2.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_2.Location = new System.Drawing.Point(248, 335);
            this.dgv_2.Name = "dgv_2";
            this.dgv_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_2.Size = new System.Drawing.Size(683, 113);
            this.dgv_2.TabIndex = 197;
            this.dgv_2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_2_RowsAdded);
            this.dgv_2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_2_RowsRemoved);
            // 
            // no2
            // 
            this.no2.FillWeight = 45.68528F;
            this.no2.HeaderText = "م";
            this.no2.Name = "no2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 127.1574F;
            this.dataGridViewTextBoxColumn5.HeaderText = "كود الصنف";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "اسم الصنف";
            this.Column7.Name = "Column7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 127.1574F;
            this.dataGridViewTextBoxColumn6.HeaderText = "باركود";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "العدد";
            this.Column6.Name = "Column6";
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(307, 248);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(100, 20);
            this.txt_db.TabIndex = 215;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(289, 243);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(22, 25);
            this.simpleButton1.TabIndex = 216;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv1);
            this.groupControl1.Controls.Add(this.btn_show_print);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btn_direct_print);
            this.groupControl1.Controls.Add(this.btn_show_barcode_inv);
            this.groupControl1.Controls.Add(this.btn_show_barcode_items);
            this.groupControl1.Controls.Add(this.txt_db);
            this.groupControl1.Controls.Add(this.dgv_2);
            this.groupControl1.Controls.Add(this.btn_del);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.progressBar1);
            this.groupControl1.Controls.Add(this.btn_new);
            this.groupControl1.Controls.Add(this.combo_invoice_no);
            this.groupControl1.Controls.Add(this.btn_search_inv);
            this.groupControl1.Controls.Add(this.btn_show_inv);
            this.groupControl1.Controls.Add(this.btn_code_items);
            this.groupControl1.Controls.Add(this.dgv_inv);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.combo_code_items);
            this.groupControl1.Controls.Add(this.btn_search_items);
            this.groupControl1.Controls.Add(this.combo_name_items);
            this.groupControl1.Location = new System.Drawing.Point(12, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(889, 495);
            this.groupControl1.TabIndex = 217;
            this.groupControl1.Text = "groupControl1";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 503);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraEditors.SimpleButton btn_code_items;
        private DevExpress.XtraEditors.SimpleButton btn_show_print;
        private DevExpress.XtraEditors.SimpleButton btn_direct_print;
        private DevExpress.XtraEditors.SimpleButton btn_show_barcode_items;
        private DevExpress.XtraEditors.SimpleButton btn_show_inv;
        private DevExpress.XtraEditors.SimpleButton btn_search_items;
        private System.Windows.Forms.ComboBox combo_code_items;
        private System.Windows.Forms.ComboBox combo_name_items;
        private DevExpress.XtraEditors.SimpleButton btn_search_inv;
        private System.Windows.Forms.ComboBox combo_invoice_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btn_show_barcode_inv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dgv_inv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn no2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_db;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}