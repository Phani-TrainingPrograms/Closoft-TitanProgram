namespace SampleUIApp
{
    partial class DisplayAll
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEmpNames = new System.Windows.Forms.ListBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Master Window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of Employees";
            // 
            // lstEmpNames
            // 
            this.lstEmpNames.FormattingEnabled = true;
            this.lstEmpNames.ItemHeight = 24;
            this.lstEmpNames.Location = new System.Drawing.Point(46, 155);
            this.lstEmpNames.Name = "lstEmpNames";
            this.lstEmpNames.Size = new System.Drawing.Size(300, 484);
            this.lstEmpNames.TabIndex = 2;
            this.lstEmpNames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.button1);
            this.grpDetails.Controls.Add(this.txtDeptId);
            this.grpDetails.Controls.Add(this.txtMobile);
            this.grpDetails.Controls.Add(this.txtAddress);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.txtId);
            this.grpDetails.Location = new System.Drawing.Point(448, 118);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(898, 510);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Employee Details";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(89, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(504, 29);
            this.txtId.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtId, "ID of the Employee");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(504, 29);
            this.txtName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtName, "Name of the Employee");
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(89, 198);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(504, 29);
            this.txtAddress.TabIndex = 2;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(89, 268);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(504, 29);
            this.txtMobile.TabIndex = 3;
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(89, 336);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(504, 29);
            this.txtDeptId.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DisplayAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1373, 651);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lstEmpNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DisplayAll";
            this.Text = "All Employees";
            this.Load += new System.EventHandler(this.DisplayAll_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEmpNames;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}