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

namespace SimpleProjectManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 启动MainForm时，启动navigation form
            var navForm = new NavigationForm();
            navForm.Show(this.dockPanel1, DockState.DockLeft);
        }

        private void taskListMenuItem_Click(object sender, EventArgs e)
        {
            var taskSingleForm = new TaskListForm();
            taskSingleForm.Show(this.dockPanel1);
        }
    }
}
