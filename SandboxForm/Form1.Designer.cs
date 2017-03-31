namespace SandboxForm
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
            this.btnMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_FirstName = new System.Windows.Forms.TextBox();
            this.btnGetTextBoxData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxAge = new System.Windows.Forms.TextBox();
            this.pb_HJ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HJ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(180, 230);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(100, 30);
            this.btnMessage.TabIndex = 10;
            this.btnMessage.Text = "MESSAGE";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txbx_FirstName
            // 
            this.txbx_FirstName.Location = new System.Drawing.Point(99, 16);
            this.txbx_FirstName.Name = "txbx_FirstName";
            this.txbx_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txbx_FirstName.TabIndex = 0;
            // 
            // btnGetTextBoxData
            // 
            this.btnGetTextBoxData.Location = new System.Drawing.Point(205, 110);
            this.btnGetTextBoxData.Name = "btnGetTextBoxData";
            this.btnGetTextBoxData.Size = new System.Drawing.Size(75, 23);
            this.btnGetTextBoxData.TabIndex = 9;
            this.btnGetTextBoxData.Text = "Person Info";
            this.btnGetTextBoxData.UseVisualStyleBackColor = true;
            this.btnGetTextBoxData.Click += new System.EventHandler(this.btnGetTextBoxData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // txbx_LastName
            // 
            this.txbx_LastName.Location = new System.Drawing.Point(99, 51);
            this.txbx_LastName.Name = "txbx_LastName";
            this.txbx_LastName.Size = new System.Drawing.Size(100, 20);
            this.txbx_LastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // txbxAge
            // 
            this.txbxAge.Location = new System.Drawing.Point(99, 84);
            this.txbxAge.Name = "txbxAge";
            this.txbxAge.Size = new System.Drawing.Size(100, 20);
            this.txbxAge.TabIndex = 2;
            // 
            // pb_HJ
            // 
            this.pb_HJ.Location = new System.Drawing.Point(12, 110);
            this.pb_HJ.Name = "pb_HJ";
            this.pb_HJ.Size = new System.Drawing.Size(162, 150);
            this.pb_HJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_HJ.TabIndex = 11;
            this.pb_HJ.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.pb_HJ);
            this.Controls.Add(this.txbxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetTextBoxData);
            this.Controls.Add(this.txbx_FirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_HJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_FirstName;
        private System.Windows.Forms.Button btnGetTextBoxData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxAge;
        private System.Windows.Forms.PictureBox pb_HJ;
    }
}

