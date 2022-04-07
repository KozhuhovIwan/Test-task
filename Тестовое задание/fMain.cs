using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Тестовое_задание
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void trainBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTrainsDataSet);

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBTrainsDataSet.TrainInStation". При необходимости она может быть перемещена или удалена.
            this.trainInStationTableAdapter.Fill(this.dBTrainsDataSet.TrainInStation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBTrainsDataSet.Station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.dBTrainsDataSet.Station);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBTrainsDataSet.TrainRoute". При необходимости она может быть перемещена или удалена.
            this.trainRouteTableAdapter.Fill(this.dBTrainsDataSet.TrainRoute);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBTrainsDataSet.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.dBTrainsDataSet.Train);
            LoadTrainNumber();
        }

        private void LoadTrainNumber()
        {
            trainBindingSource.MoveFirst();
            cbTrainNumber.Items.Clear();
            for (int i = 0; i < trainBindingSource.Count; i++)
            {
                DataRowView dr = (DataRowView)trainBindingSource.Current;
                cbTrainNumber.Items.Add(dr["TrainNumber"].ToString());
                trainBindingSource.MoveNext();
            }
            if (cbTrainNumber.Items.Count > 0)
                cbTrainNumber.SelectedIndex = 0;
            GetStation(cbTrainNumber.Text);
            carsInTraneTableAdapter.Fill(this.dBTrainsDataSet.CarsInTrane, int.Parse(cbTrainNumber.Text));
        }

        private void GetStation(string tn)
        {
            trainInStationBindingSource.Filter = $"TrainNumber={tn}";
            DataRowView dr = (DataRowView)trainInStationBindingSource.Current;
            int IDStation = Convert.ToInt32(dr["IDStation"]);
            lDate.Text = dr["WhenLastTrainOperation"].ToString();
            stationBindingSource.Filter = $"IDStation={IDStation}";
            dr = (DataRowView)stationBindingSource.Current;
            lStation.Text = dr["StationName"].ToString();
        }

        private void GetDate(string tn)
        {
            trainInStationBindingSource.Filter = $"TrainNumber={tn}";
            DataRowView dr = (DataRowView)trainInStationBindingSource.Current;
            int IDStation = Convert.ToInt32(dr["IDStation"]);
            stationBindingSource.Filter = $"IDStation={IDStation}";
            dr = (DataRowView)stationBindingSource.Current;
            lStation.Text = "Станция: " + dr["StationName"].ToString();
        }


        private void trainNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainBindingSource.Filter = $"TrainNumber='{cbTrainNumber.Text}'";
            DataRowView dr = (DataRowView)trainBindingSource.Current;
            string[] m = dr["TrainIndexCombined"].ToString().Split('-');
            lNumber.Text = m[1];
            GetStation(cbTrainNumber.Text);
            carsInTraneTableAdapter.Fill(this.dBTrainsDataSet.CarsInTrane, int.Parse(cbTrainNumber.Text));
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            string path = Application.StartupPath + "\\NL_Template.xlsx";
            if (File.Exists(path))
            {
                Excel.Workbook wb = excelApp.Workbooks.Open(path);
                Excel.Worksheet sheet = wb.ActiveSheet;
                sheet.Cells[3, 3] = cbTrainNumber.Text;
                sheet.Cells[4, 3] = lNumber.Text;
                sheet.Cells[3, 5] = lStation.Text;
                sheet.Cells[4, 5] = lDate.Text;
                int s = 0;
                for (int i = 0; i < dgvCars.Rows.Count; i++)
                {
                    sheet.Cells[i + 7, 1] = i + 1;
                    s += Convert.ToInt32(dgvCars.Rows[i].Cells[5].Value);
                    for (int j = 1; j < dgvCars.Columns.Count-1; j++)
                    {
                        sheet.Cells[i + 7, j + 1] = dgvCars.Rows[i].Cells[j].Value;
                    }
                    sheet.Cells[i + 7, 8] = " ";
                }

                Excel.Range range = sheet.get_Range("A7", "G"+(7+ dgvCars.Rows.Count).ToString());
                range.Borders.Weight = Excel.XlBorderWeight.xlThin;

                excelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Отсутствует файл шаблона");
            }

                
        }
    }
}
