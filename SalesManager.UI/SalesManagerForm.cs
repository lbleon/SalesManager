using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SalesManager.UI
{
    public partial class SalesManagerForm : BaseForm
    {
        public SalesManagerForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void productCfgBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductCfgForm formProductCfg = new ProductCfgForm();
            formProductCfg.MdiParent = this;
            formProductCfg.WindowState = FormWindowState.Maximized;
            formProductCfg.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formProductCfg.Show();
        }
    }
}