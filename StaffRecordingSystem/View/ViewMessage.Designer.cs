namespace StaffRecordingSystem
{
    partial class ViewMessage
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            pupilName = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            recordedOn = new TextBox();
            label3 = new Label();
            teacher = new TextBox();
            informationBox = new RichTextBox();
            panel1 = new Panel();
            btnMarkAsRead = new Button();
            btnClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Recorded on";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(informationBox, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8614607F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.13854F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(pupilName, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 49);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(908, 37);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(25, 8);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "Pupil name";
            // 
            // pupilName
            // 
            pupilName.BackColor = Color.White;
            pupilName.BorderStyle = BorderStyle.None;
            pupilName.Dock = DockStyle.Fill;
            pupilName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pupilName.Location = new Point(137, 4);
            pupilName.Margin = new Padding(3, 4, 3, 4);
            pupilName.Name = "pupilName";
            pupilName.ReadOnly = true;
            pupilName.Size = new Size(768, 27);
            pupilName.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1559639F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.84404F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 370F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(recordedOn, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(teacher, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(908, 37);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // recordedOn
            // 
            recordedOn.BackColor = Color.White;
            recordedOn.BorderStyle = BorderStyle.None;
            recordedOn.Dock = DockStyle.Fill;
            recordedOn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordedOn.Location = new Point(138, 4);
            recordedOn.Margin = new Padding(3, 4, 3, 4);
            recordedOn.Name = "recordedOn";
            recordedOn.ReadOnly = true;
            recordedOn.Size = new Size(356, 27);
            recordedOn.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(504, 8);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 2;
            label3.Text = "by";
            // 
            // teacher
            // 
            teacher.BackColor = Color.White;
            teacher.BorderStyle = BorderStyle.None;
            teacher.Dock = DockStyle.Fill;
            teacher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacher.Location = new Point(540, 4);
            teacher.Margin = new Padding(3, 4, 3, 4);
            teacher.Name = "teacher";
            teacher.ReadOnly = true;
            teacher.Size = new Size(365, 27);
            teacher.TabIndex = 3;
            // 
            // informationBox
            // 
            informationBox.BackColor = Color.White;
            informationBox.BorderStyle = BorderStyle.None;
            informationBox.Dock = DockStyle.Fill;
            informationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            informationBox.Location = new Point(3, 94);
            informationBox.Margin = new Padding(3, 4, 3, 4);
            informationBox.Name = "informationBox";
            informationBox.ReadOnly = true;
            informationBox.Size = new Size(908, 415);
            informationBox.TabIndex = 2;
            informationBox.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(btnMarkAsRead);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(272, 517);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 79);
            panel1.TabIndex = 3;
            // 
            // btnMarkAsRead
            // 
            btnMarkAsRead.Anchor = AnchorStyles.None;
            btnMarkAsRead.Location = new Point(83, 23);
            btnMarkAsRead.Margin = new Padding(3, 4, 3, 4);
            btnMarkAsRead.Name = "btnMarkAsRead";
            btnMarkAsRead.Size = new Size(106, 31);
            btnMarkAsRead.TabIndex = 5;
            btnMarkAsRead.Text = "Mark as Read";
            btnMarkAsRead.UseVisualStyleBackColor = true;
            btnMarkAsRead.Click += btnMarkAsRead_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.Location = new Point(197, 23);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 31);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ViewMessage
            // 
            AcceptButton = btnMarkAsRead;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Recording System :: View Message";
            Load += ViewMessage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox pupilName;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox recordedOn;
        private Label label3;
        private RichTextBox informationBox;
        private TextBox teacher;
        private Panel panel1;
        private Button btnMarkAsRead;
        private Button btnClose;
    }
}