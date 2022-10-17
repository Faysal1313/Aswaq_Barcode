// Decompiled with JetBrains decompiler
// Type: f1.all_comb
// Assembly: f1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C526F6F-AC8B-4D70-88CB-4955DEB97EDA
// Assembly location: D:\Reverse Engineer\POS - Copy\f1.exe
// Compiler-generated code is shown

using System;
using System.Data;
using System.Windows.Forms;

namespace Aswaq_Barcode
{
    internal class all_comb
    {
        public all_comb()
        {
           
        }

        public static void load_invoice_number_purchase(ComboBox combo)
        {
            DataTable tb = new DataTable();
            db.GetData_DGV("select distinct cInvoicNum from PInv_D", tb);
            combo.DisplayMember = "cInvoicNum";
            combo.DataSource = tb;
        }
        public static void load_items_code(ComboBox combo_code_items)
        {
            DataTable tb = new DataTable();
            db.GetData_DGV("select distinct cCode from item", tb);
            combo_code_items.DisplayMember = "cCode".Trim();
            combo_code_items.DataSource = tb;
        }


    }
}
