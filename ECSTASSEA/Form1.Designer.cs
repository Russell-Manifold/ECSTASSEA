
namespace ECSTASSEA
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
            this.BtnTest = new System.Windows.Forms.Button();
            this.txtDataPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(123, 164);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(450, 43);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "Test SDK Connection (To test your SDK Authentication and Data Path)";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // txtDataPath
            // 
            this.txtDataPath.Location = new System.Drawing.Point(265, 76);
            this.txtDataPath.Name = "txtDataPath";
            this.txtDataPath.Size = new System.Drawing.Size(370, 20);
            this.txtDataPath.TabIndex = 1;
            this.txtDataPath.Text = "C:\\Pastel19\\_Demo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pastel Data Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SDK Serial No";
            // 
            // txtSerNum
            // 
            this.txtSerNum.Location = new System.Drawing.Point(265, 102);
            this.txtSerNum.Name = "txtSerNum";
            this.txtSerNum.Size = new System.Drawing.Size(119, 20);
            this.txtSerNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SDK Auth Code";
            // 
            // txtAuthCode
            // 
            this.txtAuthCode.Location = new System.Drawing.Point(265, 128);
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.Size = new System.Drawing.Size(119, 20);
            this.txtAuthCode.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Code behind this button will show how to import a document";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Usually something like C:\\Pastel19\\\"data file\" )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAuthCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataPath);
            this.Controls.Add(this.BtnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.TextBox txtDataPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

