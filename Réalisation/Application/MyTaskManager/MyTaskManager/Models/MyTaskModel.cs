using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager.Controllers;
using MySql.Data.MySqlClient;

namespace MyTaskManager.Models
{
    public class MyTaskModel
    {
        public MyTaskController Controller { get; set; }

        private readonly MySqlConnection _databaseConnection = new MySqlConnection(
            "server=localhost; database=db_mytaskmanager; user id=root; password=root");

        public MyTaskModel()
        {

        }
    }
}
