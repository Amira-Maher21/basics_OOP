namespace AmeraProject
{
    partial class MainForm
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
            this.Class = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Subject = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.Teacher = new DevExpress.XtraEditors.SimpleButton();
            this.Student = new DevExpress.XtraEditors.SimpleButton();
            this.ClassFlag = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(48, 47);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(111, 51);
            this.Class.TabIndex = 0;
            this.Class.Text = "Classes";
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(228, 140);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(111, 51);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "studentsubjectidform";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(228, 47);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(111, 51);
            this.Subject.TabIndex = 2;
            this.Subject.Text = "Subject";
            this.Subject.Click += new System.EventHandler(this.Subject_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(403, 140);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(111, 51);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "teacherstudentclassesform";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Teacher
            // 
            this.Teacher.Location = new System.Drawing.Point(403, 47);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(111, 51);
            this.Teacher.TabIndex = 4;
            this.Teacher.Text = "Teacher";
            this.Teacher.Click += new System.EventHandler(this.Teacher_Click);
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(579, 47);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(111, 51);
            this.Student.TabIndex = 5;
            this.Student.Text = "Student";
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // ClassFlag
            // 
            this.ClassFlag.Location = new System.Drawing.Point(579, 140);
            this.ClassFlag.Name = "ClassFlag";
            this.ClassFlag.Size = new System.Drawing.Size(111, 51);
            this.ClassFlag.TabIndex = 6;
            this.ClassFlag.Text = "ClassFlags";
            this.ClassFlag.Click += new System.EventHandler(this.ClassFlag_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(48, 140);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(111, 51);
            this.simpleButton8.TabIndex = 7;
            this.simpleButton8.Text = "simpleButton8";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 380);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.ClassFlag);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.Class);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Class;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton Subject;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton Teacher;
        private DevExpress.XtraEditors.SimpleButton Student;
        private DevExpress.XtraEditors.SimpleButton ClassFlag;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
    }
}