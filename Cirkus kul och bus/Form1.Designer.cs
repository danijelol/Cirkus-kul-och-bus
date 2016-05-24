namespace Cirkus_kul_och_bus
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
            this.listboxPersoner = new System.Windows.Forms.ListBox();
            this.btnHämta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxPersoner
            // 
            this.listboxPersoner.FormattingEnabled = true;
            this.listboxPersoner.Location = new System.Drawing.Point(84, 61);
            this.listboxPersoner.Name = "listboxPersoner";
            this.listboxPersoner.Size = new System.Drawing.Size(120, 95);
            this.listboxPersoner.TabIndex = 0;
            // 
            // btnHämta
            // 
            this.btnHämta.Location = new System.Drawing.Point(242, 61);
            this.btnHämta.Name = "btnHämta";
            this.btnHämta.Size = new System.Drawing.Size(75, 23);
            this.btnHämta.TabIndex = 1;
            this.btnHämta.Text = "Hämta";
            this.btnHämta.UseVisualStyleBackColor = true;
            this.btnHämta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 389);
            this.Controls.Add(this.btnHämta);
            this.Controls.Add(this.listboxPersoner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxPersoner;
        private System.Windows.Forms.Button btnHämta;
    }
}

