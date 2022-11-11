
namespace Pr5SimHomoCrypt
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
            this.label3 = new System.Windows.Forms.Label();
            this.decryptedTextTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptedTextTBX = new System.Windows.Forms.TextBox();
            this.decryptB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enterTextTBX = new System.Windows.Forms.TextBox();
            this.encryptB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Расшифрованный текст";
            // 
            // decryptedTextTBX
            // 
            this.decryptedTextTBX.Location = new System.Drawing.Point(323, 280);
            this.decryptedTextTBX.Name = "decryptedTextTBX";
            this.decryptedTextTBX.ReadOnly = true;
            this.decryptedTextTBX.Size = new System.Drawing.Size(223, 20);
            this.decryptedTextTBX.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Зашифрованный текст";
            // 
            // encryptedTextTBX
            // 
            this.encryptedTextTBX.Location = new System.Drawing.Point(323, 186);
            this.encryptedTextTBX.Name = "encryptedTextTBX";
            this.encryptedTextTBX.ReadOnly = true;
            this.encryptedTextTBX.Size = new System.Drawing.Size(223, 20);
            this.encryptedTextTBX.TabIndex = 12;

            // 
            // decryptB
            // 
            this.decryptB.Location = new System.Drawing.Point(379, 233);
            this.decryptB.Name = "decryptB";
            this.decryptB.Size = new System.Drawing.Size(97, 23);
            this.decryptB.TabIndex = 11;
            this.decryptB.Text = "Расшифровать";
            this.decryptB.UseVisualStyleBackColor = true;
            this.decryptB.Click += new System.EventHandler(this.decryptB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Исходный текст";
            // 
            // enterTextTBX
            // 
            this.enterTextTBX.Location = new System.Drawing.Point(323, 91);
            this.enterTextTBX.Name = "enterTextTBX";
            this.enterTextTBX.Size = new System.Drawing.Size(223, 20);
            this.enterTextTBX.TabIndex = 9;
            this.enterTextTBX.TextChanged += new System.EventHandler(this.enterTextTBX_TextChanged);
            // 
            // encryptB
            // 
            this.encryptB.Location = new System.Drawing.Point(379, 138);
            this.encryptB.Name = "encryptB";
            this.encryptB.Size = new System.Drawing.Size(97, 23);
            this.encryptB.TabIndex = 8;
            this.encryptB.Text = "Зашифровать";
            this.encryptB.UseVisualStyleBackColor = true;
            this.encryptB.Click += new System.EventHandler(this.encryptB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptedTextTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptedTextTBX);
            this.Controls.Add(this.decryptB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterTextTBX);
            this.Controls.Add(this.encryptB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decryptedTextTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptedTextTBX;
        private System.Windows.Forms.Button decryptB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterTextTBX;
        private System.Windows.Forms.Button encryptB;
    }
}

