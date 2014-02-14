using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using SalesManager.BLL;
using SalesManager.Model;

namespace SalesManager.UI
{
    public partial class TypeAddForm : BaseForm
    {
        #region Properties

        public string TypeName { get; private set; }
        
        #endregion

        #region Members

        private ProductController controller;
        private ProductTypeList typeList;
        private PopupContainerControl popupControl;
        private TreeList treeList;
        private TreeListColumn treeListColumn;

        #endregion

        #region Constructor

        public TypeAddForm(ProductController controller)
        {
            InitializeComponent();
            this.controller = controller;
            InitTypeList();
            InitComboBox();
        }

        #endregion

        #region Methods

        private void InitTypeList()
        {
            typeList = (ProductTypeList)controller.GetProductTypes().Clone();
            typeList.AddType(new ProductType(0, "All Product Types", -1));
        }

        private void InitComboBox()
        {
            InitTreeListColumn();
            InitTreeList();
            InitPopupContainerControl();
        }

        private void InitTreeListColumn()
        {
            treeListColumn = new TreeListColumn();
            treeListColumn.Caption = "Types";
            treeListColumn.FieldName = "Name";
            treeListColumn.Name = "treeListColumn";
            treeListColumn.Visible = true;
            treeListColumn.VisibleIndex = 0;
        }

        private void InitTreeList()
        {
            treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsView.ShowColumns = false;
            treeList.OptionsView.ShowHorzLines = false;
            treeList.OptionsView.ShowIndicator = false;
            treeList.OptionsView.ShowVertLines = false;
            treeList.OptionsSelection.MultiSelect = false;
            treeList.Columns.AddRange(new TreeListColumn[] { treeListColumn });
            treeList.DataSource = typeList.Types;
        }

        private void InitPopupContainerControl()
        {
            popupControl = new PopupContainerControl();
            Controls.Add(popupControl);
            popupControl.Controls.Add(treeList);
            parentTypeEdit.Properties.PopupControl = popupControl;
            parentTypeEdit.Text = "All Product Types";
            treeList.CollapseAll();
            treeList.Width = parentTypeEdit.Width;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string typeName = GetTypeName();
            if (string.IsNullOrEmpty(typeName))
            {
                XtraMessageBox.Show("Type name should not be null.");
                return;
            }
            int parentID = GetParentID();
            if (parentID == -1)
            {
                XtraMessageBox.Show("Parent type name is incorrect, please check.");
                return;
            }
            if (!AddType(typeName, parentID))
            {
                XtraMessageBox.Show("Add product type failed.");
            }
            else
            {
                XtraMessageBox.Show("Add product type succeeded.");
            }
            treeList.RefreshDataSource();
            Close();
        }

        private string GetTypeName()
        {
            if (string.IsNullOrEmpty(typeTextEdit.Text))
            {
                return null;
            }
            return typeTextEdit.Text;
        }

        private int GetParentID()
        {
            string parentTypeName = parentTypeEdit.Text;
            if (string.IsNullOrEmpty(parentTypeName))
            {
                return 0;
            }
            ProductType parentType = typeList.GetType(parentTypeName);
            if (parentType == null)
            {
                return -1;
            }
            return parentType.ID;
        }

        private bool AddType(string typeName, int parentID)
        {
            return controller.AddProductType(typeName, parentID);
        }

        #endregion

        #region Events

        private void productTypeTree_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            int currentID = (int)treeList.FocusedNode.GetValue("ID");
            parentTypeEdit.Text = typeList.GetType(currentID).Name;
            parentTypeEdit.ClosePopup();
        }

        private void parentTypeEdit_Popup(object sender, EventArgs e)
        {
            this.treeList.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.productTypeTree_AfterFocusNode);
        }

        private void parentTypeEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            treeList.AfterFocusNode -= new DevExpress.XtraTreeList.NodeEventHandler(this.productTypeTree_AfterFocusNode);

        }

        #endregion
    }
}