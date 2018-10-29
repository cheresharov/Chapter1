namespace _5_WinFormCalc
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
            this.btnFun = new System.Windows.Forms.Button();
            this.boxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFun
            // 
            this.btnFun.Location = new System.Drawing.Point(261, 66);
            this.btnFun.Name = "btnFun";
            this.btnFun.Size = new System.Drawing.Size(202, 83);
            this.btnFun.TabIndex = 0;
            this.btnFun.Text = "Click";
            this.btnFun.UseVisualStyleBackColor = true;
            this.btnFun.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // boxMessage
            // 
            this.boxMessage.Location = new System.Drawing.Point(261, 217);
            this.boxMessage.Multiline = true;
            this.boxMessage.Name = "boxMessage";
            this.boxMessage.Size = new System.Drawing.Size(382, 188);
            this.boxMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is my message";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(542, 94);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxMessage);
            this.Controls.Add(this.btnFun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFun;
        private System.Windows.Forms.TextBox boxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
    }
}

