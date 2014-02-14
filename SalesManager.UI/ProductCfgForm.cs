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
    public partial class ProductCfgForm : BaseForm
    {
        #region Members

        private ProductController controller = new ProductController();
        private BrandList brandList = null;
        private ProductTypeList productTypeList = null;
        private ProductList productList = null;

        #endregion

        #region Constructor

        public ProductCfgForm()
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
            productTypeTree.ExpandAll();
        }

        private void InitMenu()
        {
            productTypeMenu.AddItems(new BarItem[] { addTypeBarBtn, delBarBtn });
        }

        private ProductType GetCurrentType()
        {
            return (ProductType)productTypeTree.GetDataRecordByNode(productTypeTree.FocusedNode);
        }

        private void AddProductType()
        {
            TypeAddForm form = new TypeAddForm(controller);
            form.ShowDialog();
            productTypeTree.RefreshDataSource();
        }

        private void DeleteProductType()
        {
            ProductType currentType = GetCurrentType();
            if (currentType == null)
            {
                XtraMessageBox.Show("Please choose a product type first!");
                return;
            }
            controller.DeleteProductType(currentType);
            productTypeTree.RefreshDataSource();
        }
        
        #endregion

        #region Events

        private void FormProductCfg_Load(object sender, EventArgs e)
        {
            InitData();
            BindData();
            InitMenu();
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
            AddProductType();
        }

        private void delBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteProductType();
        }

        #endregion

        
        

    }
}