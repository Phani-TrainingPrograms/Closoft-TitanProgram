namespace SampleUIApp
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
            if(disposing && (components != null))
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdDept = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(307, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(398, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Windows Programming";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter the MobileNo:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(344, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(395, 34);
            this.txtName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtName, "Name please!");
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(344, 196);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(395, 34);
            this.txtAddress.TabIndex = 3;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(344, 258);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(395, 34);
            this.txtMobile.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(374, 378);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(167, 60);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.toolTip1.SetToolTip(this.btnOk, "Click after U Enter all data");
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(344, 81);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(395, 34);
            this.txtId.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtId, "Name please!");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select Dept:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Enter the ID:";
            // 
            // cmdDept
            // 
            this.cmdDept.FormattingEnabled = true;
            this.cmdDept.Location = new System.Drawing.Point(344, 319);
            this.cmdDept.Name = "cmdDept";
            this.cmdDept.Size = new System.Drawing.Size(395, 37);
            this.cmdDept.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(965, 517);
            this.Controls.Add(this.cmdDept);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmdDept;
    }
}

