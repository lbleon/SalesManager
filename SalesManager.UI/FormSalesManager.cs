using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SalesManager
{
    public partial class FormSalesManager : BaseForm
    {
        public FormSalesManager()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void productCfgBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormProductCfg formProductCfg = new FormProductCfg();
            formProductCfg.MdiParent = this;
            formProductCfg.WindowState = FormWindowState.Maximized;
            formProductCfg.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formProductCfg.Show();
        }
    }
}