﻿
namespace Q4__inheretence_
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorBox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(436, 366);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(150, 27);
            this.colorBox.TabIndex = 3;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(462, 421);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(94, 29);
            this.result.TabIndex = 4;
            this.result.Text = "קבל מידע";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "אורך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "גובה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "רוחב";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "צבע";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.screen.Location = new System.Drawing.Point(88, 210);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(229, 123);
            this.screen.TabIndex = 9;
            // 
            // Length
            // 
            this.Length.DecimalPlaces = 1;
            this.Length.Location = new System.Drawing.Point(436, 129);
            this.Length.Name = "Length";
            this.Length.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Length.Size = new System.Drawing.Size(150, 27);
            this.Length.TabIndex = 10;
            // 
            // height
            // 
            this.height.DecimalPlaces = 1;
            this.height.Location = new System.Drawing.Point(436, 192);
            this.height.Name = "height";
            this.height.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.height.Size = new System.Drawing.Size(150, 27);
            this.height.TabIndex = 11;
            // 
            // width
            // 
            this.width.DecimalPlaces = 1;
            this.width.Location = new System.Drawing.Point(436, 256);
            this.width.Name = "width";
            this.width.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.width.Size = new System.Drawing.Size(150, 27);
            this.width.TabIndex = 12;
            // 
            // weight
            // 
            this.weight.DecimalPlaces = 1;
            this.weight.Location = new System.Drawing.Point(436, 313);
            this.weight.Name = "weight";
            this.weight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.weight.Size = new System.Drawing.Size(150, 27);
            this.weight.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "משקל";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(257, 27);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(273, 47);
            this.label5.TabIndex = 15;
            this.label5.Text = "מחשבון לקופסה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "תוצאה  ";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(825, 515);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.width);
            this.Controls.Add(this.height);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.colorBox);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.NumericUpDown Length;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

