using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SimpleProjectManager.Forms
{
    public partial class BaseListForm : DockContent
    {
        public BaseListForm()
        {
            InitializeComponent();
        }

        private void BaseListForm_Load(object sender, EventArgs e)
        {
            SetDataBinding();
        }

        protected virtual void SetDataBinding()
        {
            mainDataGrid.DataSource = mainBindingSource;
            mainBindingNavigator.BindingSource = mainBindingSource;
        }
    }
}
