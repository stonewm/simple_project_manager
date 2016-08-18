using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SimpleProjectManager.Forms;

namespace SimpleProjectManager
{
    public partial class TaskListForm : BaseListForm
    {
        private DataTable tasksDataTable;
        private PrjTasksDao dao;

        public TaskListForm()
        {
            InitializeComponent();

            // 初始化dao和data table
            dao = new PrjTasksDao();
            tasksDataTable = dao.ListAll();
        }

        private void TaskSingleForm_Load(object sender, EventArgs e)
        {
            this.Text = "课题清单";

            //LoadData();
            //SetDataGridView();
        }

        protected override void SetDataBinding()
        {            
            this.mainBindingSource.DataSource = tasksDataTable;
            base.SetDataBinding();
        }

        // 加载数据，用data table
        //private void LoadData()
        //{
        //    mainDataGrid.DataSource = tasksDataTable;
        //}

        // 设置datagridview的标题、列宽等
        //private void SetDataGridView()
        //{
        //    mainDataGrid.Columns[0].HeaderText = "ID";
        //    mainDataGrid.Columns[1].HeaderText = "项目名称";

        //    mainDataGrid.Columns[0].Width = 100;
        //    mainDataGrid.Columns[1].Width = 200;
        //    mainDataGrid.Columns[2].Width = 400;
        //}
    }
}
