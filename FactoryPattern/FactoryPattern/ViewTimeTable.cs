using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAssignment
{
    public partial class ViewTimeTable : Form
    {
        public List<KeyValueDTO> lstTimeTables = new List<KeyValueDTO>();

        public ViewTimeTable()
        {
            InitializeComponent();
            this.LoadTimeTableFromJson();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxTimeTable.Items.Clear();

            var type = cmbCourse.Text;

            TimeTableFactory tbFactory = new TimeTableFactory();

            TimeTable objTimeTable = tbFactory.GetTimeTableObject(type, lstTimeTables);

            foreach (var timeTbl in objTimeTable.GetValues())
            {
                lstbxTimeTable.Items.Add(timeTbl.Value);
            }
        }

        private void LoadTimeTableFromJson()
        {
            string json = File.ReadAllText("timetable.json");
            this.lstTimeTables = JsonConvert.DeserializeObject<List<KeyValueDTO>>(json);
        }
    }
}
