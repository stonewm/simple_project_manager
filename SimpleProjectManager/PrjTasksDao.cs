using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using StoneUtils;

namespace SimpleProjectManager
{
    // Project tasks DAO (项目任务/课题管理)
    public class PrjTasksDao
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable tasksDataTable;

        // Constructor
        public PrjTasksDao()
        {
            connection = DbUtils.GetConnection();
            dataAdapter = DbUtils.GetDataAdapter("Select * from prj_tasks", connection);
            tasksDataTable = new DataTable("tasks");
        }

        public DataTable ListAll()
        {
            tasksDataTable.BeginLoadData();
            dataAdapter.Fill(tasksDataTable);
            tasksDataTable.EndLoadData();

            return tasksDataTable;
        }
    }
}
