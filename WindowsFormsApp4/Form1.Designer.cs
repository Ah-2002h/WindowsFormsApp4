namespace WindowsFormsApp4
{
    partial class Frm
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nb = new System.Windows.Forms.TextBox();
            this.txt_sun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt_na = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(224, 197);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 36);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "طرح";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(133, 197);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 36);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "ضرب";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(37, 197);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 36);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "قسمه";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter Number";
            // 
            // txt_nb
            // 
            this.txt_nb.Location = new System.Drawing.Point(147, 116);
            this.txt_nb.Name = "txt_nb";
            this.txt_nb.Size = new System.Drawing.Size(190, 20);
            this.txt_nb.TabIndex = 15;
            // 
            // txt_sun
            // 
            this.txt_sun.Location = new System.Drawing.Point(37, 156);
            this.txt_sun.Name = "txt_sun";
            this.txt_sun.Size = new System.Drawing.Size(362, 20);
            this.txt_sun.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Number";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(315, 197);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 36);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "جمع";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // txt_na
            // 
            this.txt_na.Location = new System.Drawing.Point(147, 90);
            this.txt_na.Name = "txt_na";
            this.txt_na.Size = new System.Drawing.Size(190, 20);
            this.txt_na.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 294);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nb);
            this.Controls.Add(this.txt_sun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt_na);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nb;
        private System.Windows.Forms.TextBox txt_sun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt_na;
    }
}

