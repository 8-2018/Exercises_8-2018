using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_8_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection DConnection = new SqlConnection())
            {
                List<ExerciseResult> listEX = new List<ExerciseResult>();

                string connString = "Integrated Security=true;Initial Catalog=FacultyDB;Data Source = (localdb)\\MSSQLLocalDB";

                DConnection.ConnectionString = connString;
                DConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = DConnection;
                sqlCommand.CommandText = "SELECT * FROM ExerciseResults";

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while(dataReader.Read())
                {
                    ExerciseResult exResult = new ExerciseResult();

                    exResult.Id = dataReader.GetInt32(0);
                    exResult.StudentName = dataReader.GetString(1);
                    exResult.StudentIndex = dataReader.GetString(2);
                    exResult.Points = dataReader.GetInt32(3);

                    listEX.Add(exResult);
                }

                foreach(ExerciseResult z in listEX)
                {
                    listBoxExerciseResults.Items.Add(z);
                }

            }
        }
    }
}
