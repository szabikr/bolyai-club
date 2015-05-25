using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class ChooseTimePanel
    {

        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReserved = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.IsReserved});
            this.dataGridView1.Location = new System.Drawing.Point(520, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 300);
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // IsReserved
            // 
            this.IsReserved.HeaderText = "Is reserved";
            this.IsReserved.Name = "IsReserved";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(210, 120);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            //
            // ChooseTimePanel
            //
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
        }

        private void RefreshNextButtonPicture()
        {
            this.nextButton.BackgroundImage = global::BolyaiClubWindowsFormsApplication.Properties.Resources.DoneButton;
        }

        protected System.Windows.Forms.MonthCalendar monthCalendar1;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Time;
        protected System.Windows.Forms.DataGridViewButtonColumn IsReserved;

    }
}
