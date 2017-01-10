namespace HallgatoFelvetel
{
    partial class IdopontFelvetele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hallgatoSelector = new System.Windows.Forms.ComboBox();
            this.studentEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentCourseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentEntityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // appointmentDataGridViewTextBoxColumn
            // 
            this.appointmentDataGridViewTextBoxColumn.DataPropertyName = "Appointment";
            this.appointmentDataGridViewTextBoxColumn.HeaderText = "Appointment";
            this.appointmentDataGridViewTextBoxColumn.Name = "appointmentDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentCourseDataGridViewTextBoxColumn
            // 
            this.studentCourseDataGridViewTextBoxColumn.DataPropertyName = "StudentCourse";
            this.studentCourseDataGridViewTextBoxColumn.HeaderText = "StudentCourse";
            this.studentCourseDataGridViewTextBoxColumn.Name = "studentCourseDataGridViewTextBoxColumn";
            // 
            // appointmentEntityBindingSource
            // 
            this.appointmentEntityBindingSource.DataSource = typeof(HallgatoFelvetel.AppointmentEntity);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 392);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Időpont: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hallgató: ";
            // 
            // hallgatoSelector
            // 
            this.hallgatoSelector.DataSource = this.studentEntityBindingSource;
            this.hallgatoSelector.DisplayMember = "Name";
            this.hallgatoSelector.FormattingEnabled = true;
            this.hallgatoSelector.Location = new System.Drawing.Point(381, 389);
            this.hallgatoSelector.Name = "hallgatoSelector";
            this.hallgatoSelector.Size = new System.Drawing.Size(174, 21);
            this.hallgatoSelector.TabIndex = 4;
            // 
            // studentEntityBindingSource
            // 
            this.studentEntityBindingSource.DataSource = typeof(HallgatoFelvetel.StudentEntity);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Foglalás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdopontFelvetele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hallgatoSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IdopontFelvetele";
            this.Text = "IdopontFelvetele";
            this.Load += new System.EventHandler(this.IdopontFelvetele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentEntityBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hallgatoSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource studentEntityBindingSource;
    }
}