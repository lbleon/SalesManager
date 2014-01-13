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
using SalesManager.Model;

namespace SalesManager.UI
{
    public partial class TypeAddForm : BaseForm
    {
        #region Properties

        public string TypeName { get; private set; }
        
        #endregion

        #region Members

        private ProductTypeList typeList;
        private PopupContainerControl popupControl;
        private TreeList treeList;
        private TreeListColumn treeListColumn;

        #endregion

        #region Constructor

        public TypeAddForm(ProductTypeList typeList)
        {
            InitializeComponent();
            this.typeList = typeList;
            InitComboBox();
        }

        #endregion

        #region Methods

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
            treeList.CollapseAll();
            
        }

        private void InitPopupContainerControl()
        {
            popupControl = new PopupContainerControl();
            Controls.Add(popupControl);
            popupControl.Controls.Add(treeList);
            parentTypeEdit.Properties.PopupControl = popupControl;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!GetTypeName())
            {
                XtraMessageBox.Show("Type name should not be null.");
                return;
            }
            Close();
        }

        private bool GetTypeName()
        {
            if (string.IsNullOrEmpty(typeTextEdit.Text))
            {
                return false;
            }
            TypeName = typeTextEdit.Text;
            return true;
        }

        #endregion

        #region Events

        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            int i = 0;
            
        }

        #endregion

        private void parentTypeEdit_Popup(object sender, EventArgs e)
        {
            treeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.TreeList_FocusedNodeChanged);
        }

        private void parentTypeEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            treeList.FocusedNodeChanged -= new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.TreeList_FocusedNodeChanged);
        }
    }
}