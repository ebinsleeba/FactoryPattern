namespace SDAssignment
{
    partial class ViewTimeTable
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
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lstbxTimeTable = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownHeight = 200;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.IntegralHeight = false;
            this.cmbCourse.Items.AddRange(new object[] {
            "----------ALL--------------",
            "Msc. Software Engineering",
            "Msc. Artificial Intelligence",
            "Msc. Cloud Computing"});
            this.cmbCourse.Location = new System.Drawing.Point(338, 54);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(170, 28);
            this.cmbCourse.TabIndex = 2;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCourse.Location = new System.Drawing.Point(122, 54);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(197, 29);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Select Course :";
            // 
            // lstbxTimeTable
            // 
            this.lstbxTimeTable.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbxTimeTable.FormattingEnabled = true;
            this.lstbxTimeTable.ItemHeight = 22;
            this.lstbxTimeTable.Location = new System.Drawing.Point(327, 115);
            this.lstbxTimeTable.Name = "lstbxTimeTable";
            this.lstbxTimeTable.Size = new System.Drawing.Size(549, 180);
            this.lstbxTimeTable.TabIndex = 5;
            // 
            // ViewTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 513);
            this.Controls.Add(this.lstbxTimeTable);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cmbCourse);
            this.Name = "ViewTimeTable";
            this.Text = "ViewTimeTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbCourse;
        private Label lblCourse;
        private ListBox lstbxTimeTable;
    }
}