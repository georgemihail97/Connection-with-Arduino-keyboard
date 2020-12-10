namespace tastatura_arduino
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
            this.components = new System.ComponentModel.Container();
            this.afisareTxt = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // afisareTxt
            // 
            this.afisareTxt.Location = new System.Drawing.Point(29, 47);
            this.afisareTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.afisareTxt.Multiline = true;
            this.afisareTxt.Name = "afisareTxt";
            this.afisareTxt.Size = new System.Drawing.Size(499, 29);
            this.afisareTxt.TabIndex = 0;
            this.afisareTxt.TextChanged += new System.EventHandler(this.afisareTxt_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.afisareTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Laborator 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox afisareTxt;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

