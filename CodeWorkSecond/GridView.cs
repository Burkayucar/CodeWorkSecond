using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWorkSecond
{
    public partial class GridView : Form
    {
        CodeWorkDal CodeWorkDal = new CodeWorkDal();
        private List<CodeWork> Datas = new List<CodeWork>();
        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            LoadData();
            Datas=CodeWorkDal.GetAll();
        }

        private void LoadData()
        {
            dgwWorkers.DataSource = CodeWorkDal.GetFemale();
            dgwWorker2.DataSource = CodeWorkDal.GetMale();
        }

        public void UpdateTime()
        {
            foreach (var data in Datas)
            {
                CodeWork codeWork = new CodeWork
                {
                    Id = data.Id,
                    Name = data.Name,
                    Surname = data.Surname,
                    Gender = data.Gender,
                    Salary = data.Salary,
                    Time = Convert.ToDateTime(tbxUpdateTime.Text)
                };
                CodeWorkDal.UpdateTime(codeWork);

            }
            MessageBox.Show("Updated!");
            LoadData();
        }

        private void btnUpdateTime_Click(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
