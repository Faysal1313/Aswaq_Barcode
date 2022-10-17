// Decompiled with JetBrains decompiler
// Type: f1.Classes.SqlHelper
// Assembly: f1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8176C681-E52F-4362-9348-6544A7AEFF71
// Assembly location: D:\Reverse Engineer\Lighthoues erp system - Copy\f1.exe
// Compiler-generated code is shown

using System.Data;
using System.Data.SqlClient;

namespace Aswaq_Barcode
{
    internal class SqlHelper
    {
        private SqlConnection cn;

        public bool IsConnection
        {
            get
            {
                if (this.cn.State == ConnectionState.Closed)
                    this.cn.Open();
                return true;
            }
        }

        public SqlHelper(string connectionString)
        {
           
            this.cn = new SqlConnection(connectionString);
        }
    }
}
