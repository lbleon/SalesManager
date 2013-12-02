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
    public partial class FormTypeAdd : BaseForm
    {
        #region Properties

        public string TypeName { get; private set; }

        #endregion

        #region Constructor

        public FormTypeAdd()
        {
            InitializeComponent();
            TypeName = null;
        }

        #endregion
    }
}