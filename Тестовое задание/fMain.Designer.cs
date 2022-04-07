
namespace Тестовое_задание
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label trainNumberLabel;
            this.cbTrainNumber = new System.Windows.Forms.ComboBox();
            this.lSostav = new System.Windows.Forms.Label();
            this.lStation = new System.Windows.Forms.Label();
            this.lTitleDate = new System.Windows.Forms.Label();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTrainsDataSet = new Тестовое_задание.DBTrainsDataSet();
            this.trainTableAdapter = new Тестовое_задание.DBTrainsDataSetTableAdapters.TrainTableAdapter();
            this.tableAdapterManager = new Тестовое_задание.DBTrainsDataSetTableAdapters.TableAdapterManager();
            this.trainRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainRouteTableAdapter = new Тестовое_задание.DBTrainsDataSetTableAdapters.TrainRouteTableAdapter();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter = new Тестовое_задание.DBTrainsDataSetTableAdapters.StationTableAdapter();
            this.trainInStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainInStationTableAdapter = new Тестовое_задание.DBTrainsDataSetTableAdapters.TrainInStationTableAdapter();
            this.carsInTraneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsInTraneTableAdapter = new Тестовое_задание.DBTrainsDataSetTableAdapters.CarsInTraneTableAdapter();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.PositionInTraine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bExport = new System.Windows.Forms.Button();
            this.lNumber = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lTitleStation = new System.Windows.Forms.Label();
            trainNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTrainsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainInStationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsInTraneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // trainNumberLabel
            // 
            trainNumberLabel.AutoSize = true;
            trainNumberLabel.Location = new System.Drawing.Point(19, 15);
            trainNumberLabel.Name = "trainNumberLabel";
            trainNumberLabel.Size = new System.Drawing.Size(83, 13);
            trainNumberLabel.TabIndex = 1;
            trainNumberLabel.Text = "Номер поезда:";
            // 
            // cbTrainNumber
            // 
            this.cbTrainNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainNumber.FormattingEnabled = true;
            this.cbTrainNumber.Location = new System.Drawing.Point(103, 12);
            this.cbTrainNumber.Name = "cbTrainNumber";
            this.cbTrainNumber.Size = new System.Drawing.Size(99, 21);
            this.cbTrainNumber.TabIndex = 2;
            this.cbTrainNumber.SelectedIndexChanged += new System.EventHandler(this.trainNumberComboBox_SelectedIndexChanged);
            // 
            // lSostav
            // 
            this.lSostav.AutoSize = true;
            this.lSostav.Location = new System.Drawing.Point(19, 51);
            this.lSostav.Name = "lSostav";
            this.lSostav.Size = new System.Drawing.Size(88, 13);
            this.lSostav.TabIndex = 3;
            this.lSostav.Text = "Номер состава:";
            // 
            // lStation
            // 
            this.lStation.AutoSize = true;
            this.lStation.Location = new System.Drawing.Point(358, 15);
            this.lStation.Name = "lStation";
            this.lStation.Size = new System.Drawing.Size(52, 13);
            this.lStation.TabIndex = 4;
            this.lStation.Text = "Станция:";
            // 
            // lTitleDate
            // 
            this.lTitleDate.AutoSize = true;
            this.lTitleDate.Location = new System.Drawing.Point(300, 51);
            this.lTitleDate.Name = "lTitleDate";
            this.lTitleDate.Size = new System.Drawing.Size(39, 13);
            this.lTitleDate.TabIndex = 5;
            this.lTitleDate.Text = "Дата: ";
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            this.trainBindingSource.DataSource = this.dBTrainsDataSet;
            // 
            // dBTrainsDataSet
            // 
            this.dBTrainsDataSet.DataSetName = "DBTrainsDataSet";
            this.dBTrainsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.FreightTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.OperationTableAdapter = null;
            this.tableAdapterManager.OperationToCarTableAdapter = null;
            this.tableAdapterManager.StationTableAdapter = null;
            this.tableAdapterManager.TrainInStationTableAdapter = null;
            this.tableAdapterManager.TrainRouteTableAdapter = null;
            this.tableAdapterManager.TrainTableAdapter = this.trainTableAdapter;
            this.tableAdapterManager.UpdateOrder = Тестовое_задание.DBTrainsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trainRouteBindingSource
            // 
            this.trainRouteBindingSource.DataMember = "TrainRoute";
            this.trainRouteBindingSource.DataSource = this.dBTrainsDataSet;
            // 
            // trainRouteTableAdapter
            // 
            this.trainRouteTableAdapter.ClearBeforeFill = true;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "Station";
            this.stationBindingSource.DataSource = this.dBTrainsDataSet;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // trainInStationBindingSource
            // 
            this.trainInStationBindingSource.DataMember = "TrainInStation";
            this.trainInStationBindingSource.DataSource = this.dBTrainsDataSet;
            // 
            // trainInStationTableAdapter
            // 
            this.trainInStationTableAdapter.ClearBeforeFill = true;
            // 
            // carsInTraneBindingSource
            // 
            this.carsInTraneBindingSource.DataMember = "CarsInTrane";
            this.carsInTraneBindingSource.DataSource = this.dBTrainsDataSet;
            // 
            // carsInTraneTableAdapter
            // 
            this.carsInTraneTableAdapter.ClearBeforeFill = true;
            // 
            // dgvCars
            // 
            this.dgvCars.AutoGenerateColumns = false;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionInTraine,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvCars.DataSource = this.carsInTraneBindingSource;
            this.dgvCars.Location = new System.Drawing.Point(12, 76);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(1038, 421);
            this.dgvCars.TabIndex = 6;
            // 
            // PositionInTraine
            // 
            this.PositionInTraine.DataPropertyName = "PositionInTraine";
            this.PositionInTraine.HeaderText = "Позиция вагона";
            this.PositionInTraine.Name = "PositionInTraine";
            this.PositionInTraine.ReadOnly = true;
            this.PositionInTraine.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CarNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер вагона";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InvoiceNum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Накладная";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WhenLastCarOperation";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FreightName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Груз";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 220;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FreightTotalWeight";
            this.dataGridViewTextBoxColumn5.HeaderText = "Вес";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LastOperatinName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Последняя операция";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 350;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TrainNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "TrainNumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(824, 528);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(146, 23);
            this.bExport.TabIndex = 7;
            this.bExport.Text = "Экспорт в Excel";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(113, 51);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(41, 13);
            this.lNumber.TabIndex = 8;
            this.lNumber.Text = "Номер";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(345, 51);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(39, 13);
            this.lDate.TabIndex = 9;
            this.lDate.Text = "Дата: ";
            // 
            // lTitleStation
            // 
            this.lTitleStation.AutoSize = true;
            this.lTitleStation.Location = new System.Drawing.Point(300, 15);
            this.lTitleStation.Name = "lTitleStation";
            this.lTitleStation.Size = new System.Drawing.Size(52, 13);
            this.lTitleStation.TabIndex = 10;
            this.lTitleStation.Text = "Станция:";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 606);
            this.Controls.Add(this.lTitleStation);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lNumber);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.lTitleDate);
            this.Controls.Add(this.lStation);
            this.Controls.Add(this.lSostav);
            this.Controls.Add(this.cbTrainNumber);
            this.Controls.Add(trainNumberLabel);
            this.Name = "fMain";
            this.Text = "Тестовое задание";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTrainsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainInStationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsInTraneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBTrainsDataSet dBTrainsDataSet;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private DBTrainsDataSetTableAdapters.TrainTableAdapter trainTableAdapter;
        private DBTrainsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbTrainNumber;
        private System.Windows.Forms.Label lSostav;
        private System.Windows.Forms.Label lStation;
        private System.Windows.Forms.BindingSource trainRouteBindingSource;
        private DBTrainsDataSetTableAdapters.TrainRouteTableAdapter trainRouteTableAdapter;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private DBTrainsDataSetTableAdapters.StationTableAdapter stationTableAdapter;
        private System.Windows.Forms.BindingSource trainInStationBindingSource;
        private DBTrainsDataSetTableAdapters.TrainInStationTableAdapter trainInStationTableAdapter;
        private System.Windows.Forms.Label lTitleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource carsInTraneBindingSource;
        private DBTrainsDataSetTableAdapters.CarsInTraneTableAdapter carsInTraneTableAdapter;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionInTraine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lTitleStation;
    }
}

