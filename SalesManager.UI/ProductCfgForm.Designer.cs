namespace SalesManager.UI
{
    partial class ProductCfgForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.productTypeTree = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.exportBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.productGridCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.brandColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remarkColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productTypeMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.productTypeBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.addTypeBarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addSubTypeBarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.delBarBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.productTypeTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(170, 322);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Product Type";
            // 
            // productTypeTree
            // 
            this.productTypeTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.productTypeTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTypeTree.Location = new System.Drawing.Point(2, 23);
            this.productTypeTree.Name = "productTypeTree";
            this.productTypeTree.OptionsBehavior.Editable = false;
            this.productTypeTree.OptionsView.ShowColumns = false;
            this.productTypeTree.OptionsView.ShowHorzLines = false;
            this.productTypeTree.OptionsView.ShowIndicator = false;
            this.productTypeTree.OptionsView.ShowVertLines = false;
            this.productTypeTree.Size = new System.Drawing.Size(166, 297);
            this.productTypeTree.TabIndex = 0;
            this.productTypeTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.productTypeTree_MouseUp);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Types";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.OptionsColumn.AllowMove = false;
            this.treeListColumn1.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.exportBtn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(170, 290);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(454, 32);
            this.panelControl2.TabIndex = 2;
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBtn.Location = new System.Drawing.Point(374, 5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 0;
            this.exportBtn.Text = "Export";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(170, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(454, 290);
            this.panelControl1.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.productGridCtrl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(450, 286);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Product List";
            // 
            // productGridCtrl
            // 
            this.productGridCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridCtrl.Location = new System.Drawing.Point(2, 23);
            this.productGridCtrl.MainView = this.gridView1;
            this.productGridCtrl.Name = "productGridCtrl";
            this.productGridCtrl.Size = new System.Drawing.Size(446, 261);
            this.productGridCtrl.TabIndex = 0;
            this.productGridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.brandColumn,
            this.nameColumn,
            this.remarkColumn});
            this.gridView1.GridControl = this.productGridCtrl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // brandColumn
            // 
            this.brandColumn.Caption = "Brand";
            this.brandColumn.FieldName = "Brand.Name";
            this.brandColumn.Name = "brandColumn";
            this.brandColumn.Visible = true;
            this.brandColumn.VisibleIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "Name";
            this.nameColumn.FieldName = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 1;
            // 
            // remarkColumn
            // 
            this.remarkColumn.Caption = "Remark";
            this.remarkColumn.FieldName = "Remark";
            this.remarkColumn.Name = "remarkColumn";
            this.remarkColumn.Visible = true;
            this.remarkColumn.VisibleIndex = 2;
            // 
            // productTypeMenu
            // 
            this.productTypeMenu.Manager = this.productTypeBarManager;
            this.productTypeMenu.Name = "productTypeMenu";
            // 
            // productTypeBarManager
            // 
            this.productTypeBarManager.DockControls.Add(this.barDockControlTop);
            this.productTypeBarManager.DockControls.Add(this.barDockControlBottom);
            this.productTypeBarManager.DockControls.Add(this.barDockControlLeft);
            this.productTypeBarManager.DockControls.Add(this.barDockControlRight);
            this.productTypeBarManager.Form = this;
            this.productTypeBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addTypeBarBtn,
            this.addSubTypeBarBtn,
            this.delBarBtn});
            this.productTypeBarManager.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(624, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 322);
            this.barDockControlBottom.Size = new System.Drawing.Size(624, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 322);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(624, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 322);
            // 
            // addTypeBarBtn
            // 
            this.addTypeBarBtn.Caption = "Add Type";
            this.addTypeBarBtn.Id = 0;
            this.addTypeBarBtn.Name = "addTypeBarBtn";
            this.addTypeBarBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addTypeBarBtn_ItemClick);
            // 
            // addSubTypeBarBtn
            // 
            this.addSubTypeBarBtn.Caption = "Add Sub Type";
            this.addSubTypeBarBtn.Id = 1;
            this.addSubTypeBarBtn.Name = "addSubTypeBarBtn";
            this.addSubTypeBarBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addSubTypeBarBtn_ItemClick);
            // 
            // delBarBtn
            // 
            this.delBarBtn.Caption = "Delete Type";
            this.delBarBtn.Id = 2;
            this.delBarBtn.Name = "delBarBtn";
            this.delBarBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.delBarBtn_ItemClick);
            // 
            // ProductCfgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 322);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ProductCfgForm";
            this.Text = "Product Configuration";
            this.Load += new System.EventHandler(this.FormProductCfg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTypeTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBarManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton exportBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl productGridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTreeList.TreeList productTypeTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn brandColumn;
        private DevExpress.XtraGrid.Columns.GridColumn remarkColumn;
        private DevExpress.XtraBars.PopupMenu productTypeMenu;
        private DevExpress.XtraBars.BarManager productTypeBarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addTypeBarBtn;
        private DevExpress.XtraBars.BarButtonItem addSubTypeBarBtn;
        private DevExpress.XtraBars.BarButtonItem delBarBtn;
    }
}