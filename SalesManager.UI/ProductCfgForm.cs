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
            productTypeTree.CollapseAll();
        }

        private void InitMenu()
        {
            productTypeMenu.AddItems(new BarItem[] { addTypeBarBtn, addSubTypeBarBtn, delBarBtn });
        }

        private ProductType GetCurrentType()
        {
            return (ProductType)productTypeTree.GetDataRecordByNode(productTypeTree.FocusedNode);
        }

        private void AddProductType()
        {
            ProductType currentType = GetCurrentType();
            if (currentType == null)
            {
                XtraMessageBox.Show("Please choose a product type first!");
                return;
            }
            string typeName = GetProductTypeName("Add Type");
            if (string.IsNullOrEmpty(typeName))
            {
                return;
            }
            if (!controller.AddProductType(typeName, currentType.ParentID))
            {
                XtraMessageBox.Show("Add product type failed.");
            }
            else
            {
                XtraMessageBox.Show("Add product type succeeded.");
            }
            productTypeTree.RefreshDataSource();
        }

        private void AddSubProductType()
        {
            ProductType currentType = GetCurrentType();
            if (currentType == null)
            {
                XtraMessageBox.Show("Please choose a product type first!");
                return;
            }
            string typeName = GetProductTypeName("Add Sub Type");
            if (string.IsNullOrEmpty(typeName))
            {
                return;
            }
            if (!controller.AddProductType(typeName, currentType.ID))
            {
                XtraMessageBox.Show("Add Sub product type failed.");
            }
            else
            {
                XtraMessageBox.Show("Add Sub product type succeeded.");
            }
            productTypeTree.RefreshDataSource();
        }

        private string GetProductTypeName(string formText)
        {
            TypeAddForm form = new TypeAddForm(productTypeList);
            form.Text = formText;
            form.ShowDialog();
            string result = form.TypeName;
            form.Dispose();
            return result;
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

        private void addSubTypeBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddSubProductType();
        }

        private void delBarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteProductType();
        }

        #endregion



        

    }
}