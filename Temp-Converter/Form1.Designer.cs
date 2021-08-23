
namespace OTFI1B_Parinas_TempConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CelsiusConv = new System.Windows.Forms.Button();
            this.FhnConv = new System.Windows.Forms.Button();
            this.kek = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Temperature";
            // 
            // txtIn
            // 
            this.txtIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(199, 72);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(175, 32);
            this.txtIn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "(May be either Celsius or Fahrenheit)";
            // 
            // CelsiusConv
            // 
            this.CelsiusConv.BackColor = System.Drawing.Color.LightGray;
            this.CelsiusConv.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusConv.Location = new System.Drawing.Point(18, 182);
            this.CelsiusConv.Name = "CelsiusConv";
            this.CelsiusConv.Size = new System.Drawing.Size(175, 23);
            this.CelsiusConv.TabIndex = 3;
            this.CelsiusConv.Text = "Convert to Fahrenheit";
            this.CelsiusConv.UseVisualStyleBackColor = false;
            this.CelsiusConv.Click += new System.EventHandler(this.CelsiusConv_Click);
            // 
            // FhnConv
            // 
            this.FhnConv.BackColor = System.Drawing.Color.LightGray;
            this.FhnConv.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FhnConv.Location = new System.Drawing.Point(199, 182);
            this.FhnConv.Name = "FhnConv";
            this.FhnConv.Size = new System.Drawing.Size(175, 23);
            this.FhnConv.TabIndex = 4;
            this.FhnConv.Text = "Convert to Celsius";
            this.FhnConv.UseVisualStyleBackColor = false;
            this.FhnConv.Click += new System.EventHandler(this.FhnConv_Click);
            // 
            // kek
            // 
            this.kek.AutoSize = true;
            this.kek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kek.Location = new System.Drawing.Point(14, 282);
            this.kek.Name = "kek";
            this.kek.Size = new System.Drawing.Size(164, 24);
            this.kek.TabIndex = 5;
            this.kek.Text = "Converted Temp.";
            // 
            // txtOut
            // 
            this.txtOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(199, 282);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(175, 32);
            this.txtOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.kek);
            this.Controls.Add(this.FhnConv);
            this.Controls.Add(this.CelsiusConv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CelsiusConv;
        private System.Windows.Forms.Button FhnConv;
        private System.Windows.Forms.Label kek;
        private System.Windows.Forms.TextBox txtOut;
    }
}

