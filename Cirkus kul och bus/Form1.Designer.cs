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
            this.tbx_fornamn = new System.Windows.Forms.TextBox();
            this.tbx_efternamn = new System.Windows.Forms.TextBox();
            this.tbx_personNr = new System.Windows.Forms.TextBox();
            this.tbx_postNr = new System.Windows.Forms.TextBox();
            this.tbx_adress = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_teleNr = new System.Windows.Forms.TextBox();
            this.tbx_kon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxJa = new System.Windows.Forms.CheckBox();
            this.btn_läggTillPers = new System.Windows.Forms.Button();
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
            // tbx_fornamn
            // 
            this.tbx_fornamn.Location = new System.Drawing.Point(417, 158);
            this.tbx_fornamn.Name = "tbx_fornamn";
            this.tbx_fornamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_fornamn.TabIndex = 2;
            // 
            // tbx_efternamn
            // 
            this.tbx_efternamn.Location = new System.Drawing.Point(419, 202);
            this.tbx_efternamn.Name = "tbx_efternamn";
            this.tbx_efternamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_efternamn.TabIndex = 3;
            // 
            // tbx_personNr
            // 
            this.tbx_personNr.Location = new System.Drawing.Point(417, 254);
            this.tbx_personNr.Name = "tbx_personNr";
            this.tbx_personNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_personNr.TabIndex = 4;
            // 
            // tbx_postNr
            // 
            this.tbx_postNr.Location = new System.Drawing.Point(419, 307);
            this.tbx_postNr.Name = "tbx_postNr";
            this.tbx_postNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_postNr.TabIndex = 5;
            // 
            // tbx_adress
            // 
            this.tbx_adress.Location = new System.Drawing.Point(417, 352);
            this.tbx_adress.Name = "tbx_adress";
            this.tbx_adress.Size = new System.Drawing.Size(100, 20);
            this.tbx_adress.TabIndex = 6;
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(414, 443);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(100, 20);
            this.tbx_email.TabIndex = 7;
            // 
            // tbx_teleNr
            // 
            this.tbx_teleNr.Location = new System.Drawing.Point(417, 400);
            this.tbx_teleNr.Name = "tbx_teleNr";
            this.tbx_teleNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_teleNr.TabIndex = 8;
            // 
            // tbx_kon
            // 
            this.tbx_kon.Location = new System.Drawing.Point(417, 482);
            this.tbx_kon.Name = "tbx_kon";
            this.tbx_kon.Size = new System.Drawing.Size(100, 20);
            this.tbx_kon.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Förnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kön:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Postnummer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Personnummer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Efternamn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(655, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Foto tilllåtet:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefonnummer:";
            // 
            // cBoxJa
            // 
            this.cBoxJa.AutoSize = true;
            this.cBoxJa.Location = new System.Drawing.Point(658, 215);
            this.cBoxJa.Name = "cBoxJa";
            this.cBoxJa.Size = new System.Drawing.Size(38, 17);
            this.cBoxJa.TabIndex = 19;
            this.cBoxJa.Text = "JA";
            this.cBoxJa.UseVisualStyleBackColor = true;
            // 
            // btn_läggTillPers
            // 
            this.btn_läggTillPers.Location = new System.Drawing.Point(634, 336);
            this.btn_läggTillPers.Name = "btn_läggTillPers";
            this.btn_läggTillPers.Size = new System.Drawing.Size(75, 23);
            this.btn_läggTillPers.TabIndex = 20;
            this.btn_läggTillPers.Text = "Lägg Till";
            this.btn_läggTillPers.UseVisualStyleBackColor = true;
            this.btn_läggTillPers.Click += new System.EventHandler(this.btn_läggTillPers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 668);
            this.Controls.Add(this.btn_läggTillPers);
            this.Controls.Add(this.cBoxJa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_kon);
            this.Controls.Add(this.tbx_teleNr);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.tbx_adress);
            this.Controls.Add(this.tbx_postNr);
            this.Controls.Add(this.tbx_personNr);
            this.Controls.Add(this.tbx_efternamn);
            this.Controls.Add(this.tbx_fornamn);
            this.Controls.Add(this.btnHämta);
            this.Controls.Add(this.listboxPersoner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxPersoner;
        private System.Windows.Forms.Button btnHämta;
        private System.Windows.Forms.TextBox tbx_fornamn;
        private System.Windows.Forms.TextBox tbx_efternamn;
        private System.Windows.Forms.TextBox tbx_personNr;
        private System.Windows.Forms.TextBox tbx_postNr;
        private System.Windows.Forms.TextBox tbx_adress;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_teleNr;
        private System.Windows.Forms.TextBox tbx_kon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cBoxJa;
        private System.Windows.Forms.Button btn_läggTillPers;
    }
}

