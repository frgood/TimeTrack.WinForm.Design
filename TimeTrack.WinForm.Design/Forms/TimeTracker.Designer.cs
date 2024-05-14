namespace TimeTrack.WinForm.Design.Forms
{
    partial class TimeTracker
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
            Leftpanel = new Panel();
            pictureBox1 = new PictureBox();
            Toppanel = new Panel();
            Clocklabel = new Label();
            Exitbutton = new Button();
            StartTimerbutton = new Button();
            TaskDescriptor = new TextBox();
            StartTime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            TaskNotes = new RichTextBox();
            TaskTime = new TextBox();
            PauseTimerbutton = new Button();
            StopTimerbutton = new Button();
            TaskList = new ListBox();
            NewTaskbutton = new Button();
            Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Toppanel.SuspendLayout();
            SuspendLayout();
            // 
            // Leftpanel
            // 
            Leftpanel.BackColor = Color.FromArgb(0, 0, 64);
            Leftpanel.Controls.Add(NewTaskbutton);
            Leftpanel.Controls.Add(TaskList);
            Leftpanel.Controls.Add(pictureBox1);
            Leftpanel.Dock = DockStyle.Left;
            Leftpanel.Location = new Point(0, 0);
            Leftpanel.Name = "Leftpanel";
            Leftpanel.Size = new Size(96, 270);
            Leftpanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icononly_transparent_nobuffer;
            pictureBox1.Location = new Point(11, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Toppanel
            // 
            Toppanel.BackColor = Color.DarkRed;
            Toppanel.Controls.Add(Clocklabel);
            Toppanel.Dock = DockStyle.Top;
            Toppanel.Location = new Point(96, 0);
            Toppanel.Name = "Toppanel";
            Toppanel.Size = new Size(427, 33);
            Toppanel.TabIndex = 1;
            // 
            // Clocklabel
            // 
            Clocklabel.AutoSize = true;
            Clocklabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clocklabel.Location = new Point(202, 8);
            Clocklabel.Name = "Clocklabel";
            Clocklabel.Size = new Size(70, 17);
            Clocklabel.TabIndex = 4;
            Clocklabel.Text = "Date Label";
            // 
            // Exitbutton
            // 
            Exitbutton.Location = new Point(432, 227);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(79, 31);
            Exitbutton.TabIndex = 2;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = true;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // StartTimerbutton
            // 
            StartTimerbutton.BackColor = Color.FromArgb(0, 192, 0);
            StartTimerbutton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartTimerbutton.Location = new Point(140, 222);
            StartTimerbutton.Name = "StartTimerbutton";
            StartTimerbutton.Size = new Size(90, 39);
            StartTimerbutton.TabIndex = 3;
            StartTimerbutton.Text = "Start Timer";
            StartTimerbutton.UseVisualStyleBackColor = false;
            // 
            // TaskDescriptor
            // 
            TaskDescriptor.Location = new Point(140, 39);
            TaskDescriptor.Name = "TaskDescriptor";
            TaskDescriptor.Size = new Size(371, 23);
            TaskDescriptor.TabIndex = 5;
            TaskDescriptor.Text = "Task Descriptor";
            // 
            // StartTime
            // 
            StartTime.Location = new Point(140, 68);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(126, 23);
            StartTime.TabIndex = 6;
            StartTime.Text = "05/12/2024 12:12 PM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "Task:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 71);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 8;
            label2.Text = "Start:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 71);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 9;
            label3.Text = "End:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "05/12/2024 12:52 PM";
            // 
            // TaskNotes
            // 
            TaskNotes.Location = new Point(140, 109);
            TaskNotes.Name = "TaskNotes";
            TaskNotes.Size = new Size(371, 100);
            TaskNotes.TabIndex = 11;
            TaskNotes.Text = "";
            // 
            // TaskTime
            // 
            TaskTime.Location = new Point(475, 68);
            TaskTime.Name = "TaskTime";
            TaskTime.Size = new Size(36, 23);
            TaskTime.TabIndex = 12;
            TaskTime.Text = "00.00";
            // 
            // PauseTimerbutton
            // 
            PauseTimerbutton.BackColor = Color.Yellow;
            PauseTimerbutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PauseTimerbutton.Location = new Point(236, 227);
            PauseTimerbutton.Name = "PauseTimerbutton";
            PauseTimerbutton.Size = new Size(90, 31);
            PauseTimerbutton.TabIndex = 13;
            PauseTimerbutton.Text = "Pause";
            PauseTimerbutton.UseVisualStyleBackColor = false;
            // 
            // StopTimerbutton
            // 
            StopTimerbutton.BackColor = Color.Red;
            StopTimerbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopTimerbutton.Location = new Point(332, 227);
            StopTimerbutton.Name = "StopTimerbutton";
            StopTimerbutton.Size = new Size(90, 31);
            StopTimerbutton.TabIndex = 14;
            StopTimerbutton.Text = "Stop";
            StopTimerbutton.UseVisualStyleBackColor = false;
            // 
            // TaskList
            // 
            TaskList.FormattingEnabled = true;
            TaskList.ItemHeight = 15;
            TaskList.Location = new Point(6, 68);
            TaskList.Name = "TaskList";
            TaskList.Size = new Size(78, 139);
            TaskList.TabIndex = 1;
            // 
            // NewTaskbutton
            // 
            NewTaskbutton.BackColor = Color.DodgerBlue;
            NewTaskbutton.Location = new Point(6, 213);
            NewTaskbutton.Name = "NewTaskbutton";
            NewTaskbutton.Size = new Size(78, 23);
            NewTaskbutton.TabIndex = 2;
            NewTaskbutton.Text = "New +";
            NewTaskbutton.UseVisualStyleBackColor = false;
            // 
            // TimeTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 270);
            Controls.Add(StopTimerbutton);
            Controls.Add(PauseTimerbutton);
            Controls.Add(TaskTime);
            Controls.Add(TaskNotes);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartTime);
            Controls.Add(TaskDescriptor);
            Controls.Add(StartTimerbutton);
            Controls.Add(Exitbutton);
            Controls.Add(Toppanel);
            Controls.Add(Leftpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TimeTracker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimeTracker";
            Load += TimeTracker_Load;
            Leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Toppanel.ResumeLayout(false);
            Toppanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Leftpanel;
        private Panel Toppanel;
        private PictureBox pictureBox1;
        private Button Exitbutton;
        private Button StartTimerbutton;
        private Label Clocklabel;
        private TextBox TaskDescriptor;
        private TextBox StartTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox TaskNotes;
        private TextBox TaskTime;
        private Button PauseTimerbutton;
        private Button StopTimerbutton;
        private Button NewTaskbutton;
        private ListBox TaskList;
    }
}