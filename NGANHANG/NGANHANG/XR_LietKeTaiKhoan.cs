using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG
{
    public partial class XR_LietKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public XR_LietKeTaiKhoan()
        {
            
        }

        public XR_LietKeTaiKhoan(string tungay, string denngay, int all)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tungay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denngay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = all;
            this.sqlDataSource1.Fill();
        }

    }
}
