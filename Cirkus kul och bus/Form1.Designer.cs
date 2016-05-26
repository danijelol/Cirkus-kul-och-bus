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
            this.btn_läggTillPers = new System.Windows.Forms.Button();
            this.btn_tabort = new System.Windows.Forms.Button();
            this.btn_ändraPerson = new System.Windows.Forms.Button();
            this.rbtn_träningsgrupp = new System.Windows.Forms.RadioButton();
            this.rbtn_träning = new System.Windows.Forms.RadioButton();
            this.rbtn_Person = new System.Windows.Forms.RadioButton();
            this.rbt_styrelse = new System.Windows.Forms.RadioButton();
            this.rbt_ledareansvarig = new System.Windows.Forms.RadioButton();
            this.rbt_uppdrag = new System.Windows.Forms.RadioButton();
            this.rbt_ledare = new System.Windows.Forms.RadioButton();
            this.rbt_cirkusvan = new System.Windows.Forms.RadioButton();
            this.rbt_provapa = new System.Windows.Forms.RadioButton();
            this.rbt_medlem = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_kontaktperson = new System.Windows.Forms.TextBox();
            this.tbx_kontakpersonnr = new System.Windows.Forms.TextBox();
            this.cBoxJa = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_kon = new System.Windows.Forms.TextBox();
            this.tbx_teleNr = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_adress = new System.Windows.Forms.TextBox();
            this.tbx_postNr = new System.Windows.Forms.TextBox();
            this.tbx_personNr = new System.Windows.Forms.TextBox();
            this.tbx_efternamn = new System.Windows.Forms.TextBox();
            this.tbx_fornamn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_sok = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbx_datum = new System.Windows.Forms.TextBox();
            this.tbx_plats = new System.Windows.Forms.TextBox();
            this.tbx_starttid = new System.Windows.Forms.TextBox();
            this.tbx_sluttid = new System.Windows.Forms.TextBox();
            this.tbx_sammanfattning = new System.Windows.Forms.TextBox();
            this.tbx_träningsgruppsid = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_träningstillfälle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxPersoner
            // 
            this.listboxPersoner.FormattingEnabled = true;
            this.listboxPersoner.Location = new System.Drawing.Point(555, 34);
            this.listboxPersoner.Name = "listboxPersoner";
            this.listboxPersoner.Size = new System.Drawing.Size(797, 342);
            this.listboxPersoner.TabIndex = 0;
            this.listboxPersoner.SelectedIndexChanged += new System.EventHandler(this.listboxPersoner_SelectedIndexChanged);
            // 
            // btnHämta
            // 
            this.btnHämta.Location = new System.Drawing.Point(20, 89);
            this.btnHämta.Name = "btnHämta";
            this.btnHämta.Size = new System.Drawing.Size(75, 23);
            this.btnHämta.TabIndex = 1;
            this.btnHämta.Text = "Hämta";
            this.btnHämta.UseVisualStyleBackColor = true;
            this.btnHämta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_läggTillPers
            // 
            this.btn_läggTillPers.Location = new System.Drawing.Point(21, 500);
            this.btn_läggTillPers.Name = "btn_läggTillPers";
            this.btn_läggTillPers.Size = new System.Drawing.Size(75, 23);
            this.btn_läggTillPers.TabIndex = 20;
            this.btn_läggTillPers.Text = "Lägg Till";
            this.btn_läggTillPers.UseVisualStyleBackColor = true;
            this.btn_läggTillPers.Click += new System.EventHandler(this.btn_läggTillPers_Click);
            // 
            // btn_tabort
            // 
            this.btn_tabort.Location = new System.Drawing.Point(21, 529);
            this.btn_tabort.Name = "btn_tabort";
            this.btn_tabort.Size = new System.Drawing.Size(75, 23);
            this.btn_tabort.TabIndex = 21;
            this.btn_tabort.Text = "Ta bort";
            this.btn_tabort.UseVisualStyleBackColor = true;
            this.btn_tabort.Click += new System.EventHandler(this.btn_tabort_Click);
            // 
            // btn_ändraPerson
            // 
            this.btn_ändraPerson.Location = new System.Drawing.Point(21, 558);
            this.btn_ändraPerson.Name = "btn_ändraPerson";
            this.btn_ändraPerson.Size = new System.Drawing.Size(75, 23);
            this.btn_ändraPerson.TabIndex = 22;
            this.btn_ändraPerson.Text = "Ändra";
            this.btn_ändraPerson.UseVisualStyleBackColor = true;
            this.btn_ändraPerson.Click += new System.EventHandler(this.btn_ändraPerson_Click);
            // 
            // rbtn_träningsgrupp
            // 
            this.rbtn_träningsgrupp.AutoSize = true;
            this.rbtn_träningsgrupp.Location = new System.Drawing.Point(228, 44);
            this.rbtn_träningsgrupp.Name = "rbtn_träningsgrupp";
            this.rbtn_träningsgrupp.Size = new System.Drawing.Size(93, 17);
            this.rbtn_träningsgrupp.TabIndex = 2;
            this.rbtn_träningsgrupp.TabStop = true;
            this.rbtn_träningsgrupp.Text = "Träningsgrupp";
            this.rbtn_träningsgrupp.UseVisualStyleBackColor = true;
            // 
            // rbtn_träning
            // 
            this.rbtn_träning.AutoSize = true;
            this.rbtn_träning.Location = new System.Drawing.Point(125, 44);
            this.rbtn_träning.Name = "rbtn_träning";
            this.rbtn_träning.Size = new System.Drawing.Size(89, 17);
            this.rbtn_träning.TabIndex = 1;
            this.rbtn_träning.TabStop = true;
            this.rbtn_träning.Text = "Träningtillfälle";
            this.rbtn_träning.UseVisualStyleBackColor = true;
            // 
            // rbtn_Person
            // 
            this.rbtn_Person.AutoSize = true;
            this.rbtn_Person.Location = new System.Drawing.Point(20, 44);
            this.rbtn_Person.Name = "rbtn_Person";
            this.rbtn_Person.Size = new System.Drawing.Size(99, 17);
            this.rbtn_Person.TabIndex = 0;
            this.rbtn_Person.TabStop = true;
            this.rbtn_Person.Text = "Personuppgifter";
            this.rbtn_Person.UseVisualStyleBackColor = true;
            // 
            // rbt_styrelse
            // 
            this.rbt_styrelse.AutoSize = true;
            this.rbt_styrelse.Location = new System.Drawing.Point(19, 237);
            this.rbt_styrelse.Name = "rbt_styrelse";
            this.rbt_styrelse.Size = new System.Drawing.Size(99, 17);
            this.rbt_styrelse.TabIndex = 6;
            this.rbt_styrelse.TabStop = true;
            this.rbt_styrelse.Text = "Styrelseledamot";
            this.rbt_styrelse.UseVisualStyleBackColor = true;
            // 
            // rbt_ledareansvarig
            // 
            this.rbt_ledareansvarig.AutoSize = true;
            this.rbt_ledareansvarig.Location = new System.Drawing.Point(19, 204);
            this.rbt_ledareansvarig.Name = "rbt_ledareansvarig";
            this.rbt_ledareansvarig.Size = new System.Drawing.Size(101, 17);
            this.rbt_ledareansvarig.TabIndex = 5;
            this.rbt_ledareansvarig.TabStop = true;
            this.rbt_ledareansvarig.Text = "Ledare ansvarig";
            this.rbt_ledareansvarig.UseVisualStyleBackColor = true;
            // 
            // rbt_uppdrag
            // 
            this.rbt_uppdrag.AutoSize = true;
            this.rbt_uppdrag.Location = new System.Drawing.Point(19, 171);
            this.rbt_uppdrag.Name = "rbt_uppdrag";
            this.rbt_uppdrag.Size = new System.Drawing.Size(114, 17);
            this.rbt_uppdrag.TabIndex = 4;
            this.rbt_uppdrag.TabStop = true;
            this.rbt_uppdrag.Text = "Uppdrags ansvarig";
            this.rbt_uppdrag.UseVisualStyleBackColor = true;
            // 
            // rbt_ledare
            // 
            this.rbt_ledare.AutoSize = true;
            this.rbt_ledare.Location = new System.Drawing.Point(19, 138);
            this.rbt_ledare.Name = "rbt_ledare";
            this.rbt_ledare.Size = new System.Drawing.Size(58, 17);
            this.rbt_ledare.TabIndex = 3;
            this.rbt_ledare.TabStop = true;
            this.rbt_ledare.Text = "Ledare";
            this.rbt_ledare.UseVisualStyleBackColor = true;
            // 
            // rbt_cirkusvan
            // 
            this.rbt_cirkusvan.AutoSize = true;
            this.rbt_cirkusvan.Location = new System.Drawing.Point(19, 105);
            this.rbt_cirkusvan.Name = "rbt_cirkusvan";
            this.rbt_cirkusvan.Size = new System.Drawing.Size(81, 17);
            this.rbt_cirkusvan.TabIndex = 2;
            this.rbt_cirkusvan.TabStop = true;
            this.rbt_cirkusvan.Text = "Cirkus vänn";
            this.rbt_cirkusvan.UseVisualStyleBackColor = true;
            // 
            // rbt_provapa
            // 
            this.rbt_provapa.AutoSize = true;
            this.rbt_provapa.Location = new System.Drawing.Point(19, 72);
            this.rbt_provapa.Name = "rbt_provapa";
            this.rbt_provapa.Size = new System.Drawing.Size(68, 17);
            this.rbt_provapa.TabIndex = 1;
            this.rbt_provapa.TabStop = true;
            this.rbt_provapa.Text = "Prova på";
            this.rbt_provapa.UseVisualStyleBackColor = true;
            // 
            // rbt_medlem
            // 
            this.rbt_medlem.AutoSize = true;
            this.rbt_medlem.Location = new System.Drawing.Point(19, 39);
            this.rbt_medlem.Name = "rbt_medlem";
            this.rbt_medlem.Size = new System.Drawing.Size(62, 17);
            this.rbt_medlem.TabIndex = 0;
            this.rbt_medlem.TabStop = true;
            this.rbt_medlem.Text = "Medlem";
            this.rbt_medlem.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 618);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btn_ändraPerson);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btn_tabort);
            this.tabPage1.Controls.Add(this.tbx_kontaktperson);
            this.tabPage1.Controls.Add(this.btn_läggTillPers);
            this.tabPage1.Controls.Add(this.tbx_kontakpersonnr);
            this.tabPage1.Controls.Add(this.cBoxJa);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbx_kon);
            this.tabPage1.Controls.Add(this.tbx_teleNr);
            this.tabPage1.Controls.Add(this.tbx_email);
            this.tabPage1.Controls.Add(this.tbx_adress);
            this.tabPage1.Controls.Add(this.tbx_postNr);
            this.tabPage1.Controls.Add(this.tbx_personNr);
            this.tabPage1.Controls.Add(this.tbx_efternamn);
            this.tabPage1.Controls.Add(this.tbx_fornamn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Skapa medlem";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hämta uppgifter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Telefonnummer kontaktperson:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Kontaktperson:";
            // 
            // tbx_kontaktperson
            // 
            this.tbx_kontaktperson.Location = new System.Drawing.Point(15, 416);
            this.tbx_kontaktperson.Name = "tbx_kontaktperson";
            this.tbx_kontaktperson.Size = new System.Drawing.Size(100, 20);
            this.tbx_kontaktperson.TabIndex = 48;
            // 
            // tbx_kontakpersonnr
            // 
            this.tbx_kontakpersonnr.Location = new System.Drawing.Point(15, 458);
            this.tbx_kontakpersonnr.Name = "tbx_kontakpersonnr";
            this.tbx_kontakpersonnr.Size = new System.Drawing.Size(160, 20);
            this.tbx_kontakpersonnr.TabIndex = 47;
            // 
            // cBoxJa
            // 
            this.cBoxJa.AutoSize = true;
            this.cBoxJa.Location = new System.Drawing.Point(140, 349);
            this.cBoxJa.Name = "cBoxJa";
            this.cBoxJa.Size = new System.Drawing.Size(38, 17);
            this.cBoxJa.TabIndex = 46;
            this.cBoxJa.Text = "JA";
            this.cBoxJa.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Telefonnummer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Foto tilllåtet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Efternamn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Personnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Postnummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kön:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Adress:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Förnamn:";
            // 
            // tbx_kon
            // 
            this.tbx_kon.Location = new System.Drawing.Point(19, 352);
            this.tbx_kon.Name = "tbx_kon";
            this.tbx_kon.Size = new System.Drawing.Size(100, 20);
            this.tbx_kon.TabIndex = 36;
            // 
            // tbx_teleNr
            // 
            this.tbx_teleNr.Location = new System.Drawing.Point(19, 270);
            this.tbx_teleNr.Name = "tbx_teleNr";
            this.tbx_teleNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_teleNr.TabIndex = 35;
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(16, 313);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(100, 20);
            this.tbx_email.TabIndex = 34;
            // 
            // tbx_adress
            // 
            this.tbx_adress.Location = new System.Drawing.Point(19, 222);
            this.tbx_adress.Name = "tbx_adress";
            this.tbx_adress.Size = new System.Drawing.Size(100, 20);
            this.tbx_adress.TabIndex = 33;
            // 
            // tbx_postNr
            // 
            this.tbx_postNr.Location = new System.Drawing.Point(21, 177);
            this.tbx_postNr.Name = "tbx_postNr";
            this.tbx_postNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_postNr.TabIndex = 32;
            // 
            // tbx_personNr
            // 
            this.tbx_personNr.Location = new System.Drawing.Point(19, 124);
            this.tbx_personNr.Name = "tbx_personNr";
            this.tbx_personNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_personNr.TabIndex = 31;
            // 
            // tbx_efternamn
            // 
            this.tbx_efternamn.Location = new System.Drawing.Point(21, 72);
            this.tbx_efternamn.Name = "tbx_efternamn";
            this.tbx_efternamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_efternamn.TabIndex = 30;
            // 
            // tbx_fornamn
            // 
            this.tbx_fornamn.Location = new System.Drawing.Point(19, 28);
            this.tbx_fornamn.Name = "tbx_fornamn";
            this.tbx_fornamn.Size = new System.Drawing.Size(100, 20);
            this.tbx_fornamn.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_sok);
            this.groupBox1.Controls.Add(this.rbtn_träning);
            this.groupBox1.Controls.Add(this.btnHämta);
            this.groupBox1.Controls.Add(this.rbtn_träningsgrupp);
            this.groupBox1.Controls.Add(this.rbtn_Person);
            this.groupBox1.Location = new System.Drawing.Point(42, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tbx_sok
            // 
            this.tbx_sok.Location = new System.Drawing.Point(31, 20);
            this.tbx_sok.Name = "tbx_sok";
            this.tbx_sok.Size = new System.Drawing.Size(100, 20);
            this.tbx_sok.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox5);
            this.tabPage3.Controls.Add(this.checkBox4);
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(529, 592);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Närvaro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(223, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(223, 161);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(223, 218);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(223, 267);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(223, 321);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_uppdrag);
            this.groupBox2.Controls.Add(this.rbt_ledare);
            this.groupBox2.Controls.Add(this.rbt_cirkusvan);
            this.groupBox2.Controls.Add(this.rbt_ledareansvarig);
            this.groupBox2.Controls.Add(this.rbt_provapa);
            this.groupBox2.Controls.Add(this.rbt_medlem);
            this.groupBox2.Controls.Add(this.rbt_styrelse);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 286);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Typ av medlem:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_träningstillfälle);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.Datum);
            this.tabPage4.Controls.Add(this.tbx_träningsgruppsid);
            this.tabPage4.Controls.Add(this.tbx_sammanfattning);
            this.tabPage4.Controls.Add(this.tbx_sluttid);
            this.tabPage4.Controls.Add(this.tbx_starttid);
            this.tabPage4.Controls.Add(this.tbx_plats);
            this.tabPage4.Controls.Add(this.tbx_datum);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(529, 592);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Skapa träningstillfälle";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbx_datum
            // 
            this.tbx_datum.Location = new System.Drawing.Point(27, 74);
            this.tbx_datum.Name = "tbx_datum";
            this.tbx_datum.Size = new System.Drawing.Size(100, 20);
            this.tbx_datum.TabIndex = 0;
            // 
            // tbx_plats
            // 
            this.tbx_plats.Location = new System.Drawing.Point(27, 117);
            this.tbx_plats.Name = "tbx_plats";
            this.tbx_plats.Size = new System.Drawing.Size(100, 20);
            this.tbx_plats.TabIndex = 1;
            // 
            // tbx_starttid
            // 
            this.tbx_starttid.Location = new System.Drawing.Point(27, 160);
            this.tbx_starttid.Name = "tbx_starttid";
            this.tbx_starttid.Size = new System.Drawing.Size(100, 20);
            this.tbx_starttid.TabIndex = 2;
            // 
            // tbx_sluttid
            // 
            this.tbx_sluttid.Location = new System.Drawing.Point(27, 203);
            this.tbx_sluttid.Name = "tbx_sluttid";
            this.tbx_sluttid.Size = new System.Drawing.Size(100, 20);
            this.tbx_sluttid.TabIndex = 3;
            // 
            // tbx_sammanfattning
            // 
            this.tbx_sammanfattning.Location = new System.Drawing.Point(27, 246);
            this.tbx_sammanfattning.Name = "tbx_sammanfattning";
            this.tbx_sammanfattning.Size = new System.Drawing.Size(100, 20);
            this.tbx_sammanfattning.TabIndex = 4;
            // 
            // tbx_träningsgruppsid
            // 
            this.tbx_träningsgruppsid.Location = new System.Drawing.Point(27, 289);
            this.tbx_träningsgruppsid.Name = "tbx_träningsgruppsid";
            this.tbx_träningsgruppsid.Size = new System.Drawing.Size(100, 20);
            this.tbx_träningsgruppsid.TabIndex = 5;
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(24, 58);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 6;
            this.Datum.Text = "Datum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Sammanfattning";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Sluttid";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Träningsgrupp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Plats";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Starttid";
            // 
            // btn_träningstillfälle
            // 
            this.btn_träningstillfälle.Location = new System.Drawing.Point(25, 330);
            this.btn_träningstillfälle.Name = "btn_träningstillfälle";
            this.btn_träningstillfälle.Size = new System.Drawing.Size(131, 23);
            this.btn_träningstillfälle.TabIndex = 12;
            this.btn_träningstillfälle.Text = "Lägg till träningstillfälle";
            this.btn_träningstillfälle.UseVisualStyleBackColor = true;
            this.btn_träningstillfälle.Click += new System.EventHandler(this.btn_träningstillfälle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1445, 973);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listboxPersoner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxPersoner;
        private System.Windows.Forms.Button btnHämta;
        private System.Windows.Forms.Button btn_läggTillPers;
        private System.Windows.Forms.Button btn_tabort;
        private System.Windows.Forms.Button btn_ändraPerson;
        private System.Windows.Forms.RadioButton rbtn_träningsgrupp;
        private System.Windows.Forms.RadioButton rbtn_träning;
        private System.Windows.Forms.RadioButton rbtn_Person;
        private System.Windows.Forms.RadioButton rbt_styrelse;
        private System.Windows.Forms.RadioButton rbt_ledareansvarig;
        private System.Windows.Forms.RadioButton rbt_uppdrag;
        private System.Windows.Forms.RadioButton rbt_ledare;
        private System.Windows.Forms.RadioButton rbt_cirkusvan;
        private System.Windows.Forms.RadioButton rbt_provapa;
        private System.Windows.Forms.RadioButton rbt_medlem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_kontaktperson;
        private System.Windows.Forms.TextBox tbx_kontakpersonnr;
        private System.Windows.Forms.CheckBox cBoxJa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_kon;
        private System.Windows.Forms.TextBox tbx_teleNr;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_adress;
        private System.Windows.Forms.TextBox tbx_postNr;
        private System.Windows.Forms.TextBox tbx_personNr;
        private System.Windows.Forms.TextBox tbx_efternamn;
        private System.Windows.Forms.TextBox tbx_fornamn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_sok;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbx_datum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.TextBox tbx_träningsgruppsid;
        private System.Windows.Forms.TextBox tbx_sammanfattning;
        private System.Windows.Forms.TextBox tbx_sluttid;
        private System.Windows.Forms.TextBox tbx_starttid;
        private System.Windows.Forms.TextBox tbx_plats;
        private System.Windows.Forms.Button btn_träningstillfälle;
    }
}

