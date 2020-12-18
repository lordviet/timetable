namespace timetable
{
    partial class AddEmployeeForm
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
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmployeeEgn = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeMidName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFamilyName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeOccupation = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeStartingDate = new System.Windows.Forms.TextBox();
            this.registerEmployeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.FlatAppearance.BorderSize = 0;
            this.closeFormBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.closeFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFormBtn.ForeColor = System.Drawing.Color.White;
            this.closeFormBtn.Location = new System.Drawing.Point(12, 12);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(29, 28);
            this.closeFormBtn.TabIndex = 5;
            this.closeFormBtn.Text = "X";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.closeFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "EGN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(156, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(157, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Family Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(157, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Occupation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(157, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Starting Date";
            // 
            // textBoxEmployeeEgn
            // 
            this.textBoxEmployeeEgn.Location = new System.Drawing.Point(364, 116);
            this.textBoxEmployeeEgn.Name = "textBoxEmployeeEgn";
            this.textBoxEmployeeEgn.Size = new System.Drawing.Size(138, 20);
            this.textBoxEmployeeEgn.TabIndex = 12;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(364, 154);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(138, 20);
            this.textBoxEmployeeName.TabIndex = 13;
            // 
            // textBoxEmployeeMidName
            // 
            this.textBoxEmployeeMidName.Location = new System.Drawing.Point(364, 197);
            this.textBoxEmployeeMidName.Name = "textBoxEmployeeMidName";
            this.textBoxEmployeeMidName.Size = new System.Drawing.Size(138, 20);
            this.textBoxEmployeeMidName.TabIndex = 14;
            // 
            // textBoxEmployeeFamilyName
            // 
            this.textBoxEmployeeFamilyName.Location = new System.Drawing.Point(364, 242);
            this.textBoxEmployeeFamilyName.Name = "textBoxEmployeeFamilyName";
            this.textBoxEmployeeFamilyName.Size = new System.Drawing.Size(138, 20);
            this.textBoxEmployeeFamilyName.TabIndex = 15;
            // 
            // textBoxEmployeeOccupation
            // 
            this.textBoxEmployeeOccupation.Location = new System.Drawing.Point(364, 287);
            this.textBoxEmployeeOccupation.Name = "textBoxEmployeeOccupation";
            this.textBoxEmployeeOccupation.Size = new System.Drawing.Size(138, 20);
            this.textBoxEmployeeOccupation.TabIndex = 16;
            // 
            // textBoxEmployeeStartingDate
            // 
            this.textBoxEmployeeStartingDate.Location = new System.Drawing.Point(364, 331);
            this.textBoxEmployeeStartingDate.Name = "textBoxEmployeeStartingDate";
            this.textBoxEmployeeStartingDate.Size = new System.Drawing.Size(138, 20);
            this.textBoxEmployeeStartingDate.TabIndex = 17;
            // 
            // registerEmployeeBtn
            // 
            this.registerEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(5)))));
            this.registerEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerEmployeeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.registerEmployeeBtn.Location = new System.Drawing.Point(427, 401);
            this.registerEmployeeBtn.Name = "registerEmployeeBtn";
            this.registerEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.registerEmployeeBtn.TabIndex = 18;
            this.registerEmployeeBtn.Text = "Register";
            this.registerEmployeeBtn.UseVisualStyleBackColor = true;
            this.registerEmployeeBtn.Click += new System.EventHandler(this.registerEmployeeBtn_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.registerEmployeeBtn);
            this.Controls.Add(this.textBoxEmployeeStartingDate);
            this.Controls.Add(this.textBoxEmployeeOccupation);
            this.Controls.Add(this.textBoxEmployeeFamilyName);
            this.Controls.Add(this.textBoxEmployeeMidName);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.textBoxEmployeeEgn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeFormBtn);
            this.Name = "AddEmployeeForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmployeeEgn;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeMidName;
        private System.Windows.Forms.TextBox textBoxEmployeeFamilyName;
        private System.Windows.Forms.TextBox textBoxEmployeeOccupation;
        private System.Windows.Forms.TextBox textBoxEmployeeStartingDate;
        private System.Windows.Forms.Button registerEmployeeBtn;
    }
}