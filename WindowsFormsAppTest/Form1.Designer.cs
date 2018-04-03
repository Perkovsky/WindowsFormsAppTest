namespace WindowsFormsAppTest
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.cbOrganization = new System.Windows.Forms.CheckBox();
            this.cbCity = new System.Windows.Forms.CheckBox();
            this.cbCountry = new System.Windows.Forms.CheckBox();
            this.cbManager = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, -1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(604, 334);
            this.dataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(17, 35);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(49, 17);
            this.cbDate.TabIndex = 2;
            this.cbDate.Text = "Date";
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // cbOrganization
            // 
            this.cbOrganization.AutoSize = true;
            this.cbOrganization.Location = new System.Drawing.Point(17, 59);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(85, 17);
            this.cbOrganization.TabIndex = 3;
            this.cbOrganization.Text = "Organization";
            this.cbOrganization.UseVisualStyleBackColor = true;
            // 
            // cbCity
            // 
            this.cbCity.AutoSize = true;
            this.cbCity.Location = new System.Drawing.Point(17, 83);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(43, 17);
            this.cbCity.TabIndex = 4;
            this.cbCity.Text = "City";
            this.cbCity.UseVisualStyleBackColor = true;
            // 
            // cbCountry
            // 
            this.cbCountry.AutoSize = true;
            this.cbCountry.Location = new System.Drawing.Point(17, 107);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(62, 17);
            this.cbCountry.TabIndex = 5;
            this.cbCountry.Text = "Country";
            this.cbCountry.UseVisualStyleBackColor = true;
            // 
            // cbManager
            // 
            this.cbManager.AutoSize = true;
            this.cbManager.Location = new System.Drawing.Point(17, 131);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(68, 17);
            this.cbManager.TabIndex = 6;
            this.cbManager.Text = "Manager";
            this.cbManager.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbManager);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbCountry);
            this.groupBox1.Controls.Add(this.cbOrganization);
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Controls.Add(this.cbDate);
            this.groupBox1.Location = new System.Drawing.Point(611, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 307);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check groups";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "If no group is checked, then the default query";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 331);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.CheckBox cbOrganization;
        private System.Windows.Forms.CheckBox cbCity;
        private System.Windows.Forms.CheckBox cbCountry;
        private System.Windows.Forms.CheckBox cbManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

