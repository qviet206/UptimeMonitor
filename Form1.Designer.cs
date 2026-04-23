namespace GUI_UPTIME_MONITOR
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnStart = new Button();
            btnStop = new Button();
            label1 = new Label();
            txtUrl = new TextBox();
            txtLog = new TextBox();
            dgvMonitor = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMonitor).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(634, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(70, 99);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(193, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(549, 99);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(179, 29);
            btnStop.TabIndex = 2;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "ADD URL:";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(134, 27);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(453, 27);
            txtUrl.TabIndex = 5;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(70, 393);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(658, 27);
            txtLog.TabIndex = 6;
            // 
            // dgvMonitor
            // 
            dgvMonitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonitor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonitor.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvMonitor.Location = new Point(70, 151);
            dgvMonitor.Name = "dgvMonitor";
            dgvMonitor.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvMonitor.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMonitor.Size = new Size(658, 188);
            dgvMonitor.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "URL";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "STATUS";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "RESPONCE TIME";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "LAST TIME";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMonitor);
            Controls.Add(txtLog);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "UPTIME MONITOR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMonitor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnStart;
        private Button btnStop;
        private Label label1;
        private TextBox txtUrl;
        private TextBox txtLog;
        private DataGridView dgvMonitor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
