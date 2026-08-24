namespace Scheduler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            BirthdayColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            Name1 = new DataGridViewTextBoxColumn();
            Ages = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, BirthdayColumn });
            dataGridView1.Location = new Point(389, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(370, 453);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 150;
            // 
            // BirthdayColumn
            // 
            BirthdayColumn.HeaderText = "Birthday";
            BirthdayColumn.Name = "BirthdayColumn";
            BirthdayColumn.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(873, 276);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            label1.Click += label1_Click_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(805, 274);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "StartTime";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(805, 310);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "EndTime";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(873, 314);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            label2.Click += label2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(805, 354);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(808, 447);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(804, 162);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            label3.Click += label3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Name1, Ages });
            dataGridView2.Location = new Point(833, 525);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(483, 255);
            dataGridView2.TabIndex = 10;
            // 
            // Name1
            // 
            Name1.HeaderText = "Name";
            Name1.Name = "Name1";
            // 
            // Ages
            // 
            Ages.HeaderText = "Age";
            Ages.Name = "Ages";
            // 
            // button2
            // 
            button2.Location = new Point(889, 448);
            button2.Name = "button2";
            button2.Size = new Size(70, 22);
            button2.TabIndex = 11;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Location = new Point(1101, 553);
            label5.Name = "label5";
            label5.Size = new Size(156, 27);
            label5.TabIndex = 12;
            label5.Text = " ";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 792);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();



        }







        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn BirthdayColumn;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView2;
        private Button button2;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Ages;
        private Label label5;
    }
}
