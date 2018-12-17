using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_A_Fire.Forms
{
    public partial class ReportView : Form
    {
        List<Paymount_Select_Result> paylist;


        public ReportView(List<Paymount_Select_Result> datasourse)
        {
            InitializeComponent();
            paylist = datasourse;
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            Paymount_Select_ResultBindingSource.DataSource = paylist;
            this.rptPrint.RefreshReport();
        }
    }
}
