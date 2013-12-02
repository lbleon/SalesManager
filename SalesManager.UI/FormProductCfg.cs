using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SalesManager.BLL;
using SalesManager.Model;

namespace SalesManager.UI
{
    public partial class FormProductCfg : BaseForm
    {
        #region Members

        private ProductController controller = new ProductController();
        private BrandList brandList = null;
        private ProductTypeList productTypeList = null;
        private ProductList productList = null;

        #endregion

        #region Constructor

        public FormProductCfg()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void InitData()
        {
            brandList = controller.GetBrands();
            productTypeList = controller.GetProductTypes();
            productList = controller.GetProducts();
        }

        private void BindData()
        {
            BindProductTypeTree();
            BindProductGridCtrl();
        }

        private void BindProductGridCtrl()
        {
            productGridCtrl.DataSource = productList.Products;
        }

        private void BindProductTypeTree()
        {
            productTypeTree.DataSource = productTypeList.Types;
            productTypeTree.CollapseAll();
        }

        #endregion

        #region Events

        private void FormProductCfg_Load(object sender, EventArgs e)
        {
            InitData();
            BindData();
            productTypeMenu.AddItems(new BarItem[] { addTypeBarBtn, addSubTypeBarBtn, delBarBtn });
        }

        private void productTypeTree_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                productTypeMenu.ShowPopup(Control.MousePosition);
            }

        }

        private void addTypeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void addSubTypeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void delBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        #endregion
    }
}