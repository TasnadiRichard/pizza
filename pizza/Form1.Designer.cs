namespace pizza
{
    partial class Form1_pizzarendelés
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_pizzarendelés));
            label_forrasfajlneve = new Label();
            textBox_forrasfajlneve = new TextBox();
            button_betoltes = new Button();
            listBox_pizzak = new ListBox();
            button_pizzakatlagara = new Button();
            checkBox_keszpenzesfizetes = new CheckBox();
            checkBox_bankkartyasfizetes = new CheckBox();
            label_szamlaigenyles = new Label();
            checkBox_szamlaigen = new CheckBox();
            checkBox_szamlanem = new CheckBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label_darabszam = new Label();
            textBox_darabszam = new TextBox();
            label_rendelesiadatok = new Label();
            textBox3 = new TextBox();
            button_kiiras = new Button();
            SuspendLayout();
            // 
            // label_forrasfajlneve
            // 
            label_forrasfajlneve.AutoSize = true;
            label_forrasfajlneve.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_forrasfajlneve.ForeColor = SystemColors.HotTrack;
            label_forrasfajlneve.Location = new Point(69, 30);
            label_forrasfajlneve.Name = "label_forrasfajlneve";
            label_forrasfajlneve.Size = new Size(115, 21);
            label_forrasfajlneve.TabIndex = 0;
            label_forrasfajlneve.Text = "Forrásfájl neve:";
            // 
            // textBox_forrasfajlneve
            // 
            textBox_forrasfajlneve.Location = new Point(69, 54);
            textBox_forrasfajlneve.Name = "textBox_forrasfajlneve";
            textBox_forrasfajlneve.Size = new Size(147, 23);
            textBox_forrasfajlneve.TabIndex = 1;
            // 
            // button_betoltes
            // 
            button_betoltes.BackColor = Color.DarkOrange;
            button_betoltes.ForeColor = SystemColors.HotTrack;
            button_betoltes.Location = new Point(69, 89);
            button_betoltes.Name = "button_betoltes";
            button_betoltes.Size = new Size(147, 23);
            button_betoltes.TabIndex = 2;
            button_betoltes.Text = "Betöltés";
            button_betoltes.UseVisualStyleBackColor = false;
            // 
            // listBox_pizzak
            // 
            listBox_pizzak.FormattingEnabled = true;
            listBox_pizzak.ItemHeight = 15;
            listBox_pizzak.Location = new Point(71, 127);
            listBox_pizzak.Name = "listBox_pizzak";
            listBox_pizzak.Size = new Size(145, 184);
            listBox_pizzak.TabIndex = 3;
            // 
            // button_pizzakatlagara
            // 
            button_pizzakatlagara.BackColor = Color.DarkOrange;
            button_pizzakatlagara.ForeColor = SystemColors.HotTrack;
            button_pizzakatlagara.Location = new Point(70, 331);
            button_pizzakatlagara.Name = "button_pizzakatlagara";
            button_pizzakatlagara.Size = new Size(146, 33);
            button_pizzakatlagara.TabIndex = 4;
            button_pizzakatlagara.Text = "Pizzák átlagára";
            button_pizzakatlagara.UseVisualStyleBackColor = false;
            // 
            // checkBox_keszpenzesfizetes
            // 
            checkBox_keszpenzesfizetes.AutoSize = true;
            checkBox_keszpenzesfizetes.ForeColor = SystemColors.HotTrack;
            checkBox_keszpenzesfizetes.Location = new Point(271, 54);
            checkBox_keszpenzesfizetes.Name = "checkBox_keszpenzesfizetes";
            checkBox_keszpenzesfizetes.Size = new Size(121, 19);
            checkBox_keszpenzesfizetes.TabIndex = 5;
            checkBox_keszpenzesfizetes.Text = "Készpénzes fizetés";
            checkBox_keszpenzesfizetes.UseVisualStyleBackColor = true;
            // 
            // checkBox_bankkartyasfizetes
            // 
            checkBox_bankkartyasfizetes.AutoSize = true;
            checkBox_bankkartyasfizetes.Location = new Point(271, 79);
            checkBox_bankkartyasfizetes.Name = "checkBox_bankkartyasfizetes";
            checkBox_bankkartyasfizetes.Size = new Size(125, 19);
            checkBox_bankkartyasfizetes.TabIndex = 6;
            checkBox_bankkartyasfizetes.Text = "Bankkártyás fizetés";
            checkBox_bankkartyasfizetes.UseVisualStyleBackColor = true;
            // 
            // label_szamlaigenyles
            // 
            label_szamlaigenyles.AutoSize = true;
            label_szamlaigenyles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_szamlaigenyles.Location = new Point(272, 111);
            label_szamlaigenyles.Name = "label_szamlaigenyles";
            label_szamlaigenyles.Size = new Size(124, 21);
            label_szamlaigenyles.TabIndex = 7;
            label_szamlaigenyles.Text = "Igényel számlát?";
            // 
            // checkBox_szamlaigen
            // 
            checkBox_szamlaigen.AutoSize = true;
            checkBox_szamlaigen.Location = new Point(269, 140);
            checkBox_szamlaigen.Name = "checkBox_szamlaigen";
            checkBox_szamlaigen.Size = new Size(49, 19);
            checkBox_szamlaigen.TabIndex = 8;
            checkBox_szamlaigen.Text = "Igen";
            checkBox_szamlaigen.UseVisualStyleBackColor = true;
            // 
            // checkBox_szamlanem
            // 
            checkBox_szamlanem.AutoSize = true;
            checkBox_szamlanem.Location = new Point(269, 165);
            checkBox_szamlanem.Name = "checkBox_szamlanem";
            checkBox_szamlanem.Size = new Size(52, 19);
            checkBox_szamlanem.TabIndex = 8;
            checkBox_szamlanem.Text = "Nem";
            checkBox_szamlanem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(272, 204);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 9;
            label1.Text = "Pizza neve:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 23);
            textBox2.TabIndex = 10;
            // 
            // label_darabszam
            // 
            label_darabszam.AutoSize = true;
            label_darabszam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_darabszam.Location = new Point(269, 264);
            label_darabszam.Name = "label_darabszam";
            label_darabszam.Size = new Size(99, 21);
            label_darabszam.TabIndex = 11;
            label_darabszam.Text = "Darabszáma:";
            // 
            // textBox_darabszam
            // 
            textBox_darabszam.Location = new Point(269, 288);
            textBox_darabszam.Name = "textBox_darabszam";
            textBox_darabszam.Size = new Size(123, 23);
            textBox_darabszam.TabIndex = 12;
            // 
            // label_rendelesiadatok
            // 
            label_rendelesiadatok.AutoSize = true;
            label_rendelesiadatok.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_rendelesiadatok.Location = new Point(261, 324);
            label_rendelesiadatok.Name = "label_rendelesiadatok";
            label_rendelesiadatok.Size = new Size(131, 21);
            label_rendelesiadatok.TabIndex = 13;
            label_rendelesiadatok.Text = "Rendelési adatok:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(268, 348);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 14;
            // 
            // button_kiiras
            // 
            button_kiiras.BackColor = Color.DarkOrange;
            button_kiiras.ForeColor = SystemColors.HotTrack;
            button_kiiras.Location = new Point(268, 377);
            button_kiiras.Name = "button_kiiras";
            button_kiiras.Size = new Size(124, 23);
            button_kiiras.TabIndex = 2;
            button_kiiras.Text = "Kiírás";
            button_kiiras.UseVisualStyleBackColor = false;
            // 
            // Form1_pizzarendelés
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label_rendelesiadatok);
            Controls.Add(textBox_darabszam);
            Controls.Add(label_darabszam);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(checkBox_szamlanem);
            Controls.Add(checkBox_szamlaigen);
            Controls.Add(label_szamlaigenyles);
            Controls.Add(checkBox_bankkartyasfizetes);
            Controls.Add(checkBox_keszpenzesfizetes);
            Controls.Add(button_pizzakatlagara);
            Controls.Add(listBox_pizzak);
            Controls.Add(button_kiiras);
            Controls.Add(button_betoltes);
            Controls.Add(textBox_forrasfajlneve);
            Controls.Add(label_forrasfajlneve);
            ForeColor = SystemColors.HotTrack;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1_pizzarendelés";
            Text = "Pizza Rendelés";
            Load += Form1_pizzarendelés_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_forrasfajlneve;
        private TextBox textBox_forrasfajlneve;
        private Button button_betoltes;
        private ListBox listBox_pizzak;
        private Button button_pizzakatlagara;
        private CheckBox checkBox_keszpenzesfizetes;
        private CheckBox checkBox_bankkartyasfizetes;
        private Label label_szamlaigenyles;
        private CheckBox checkBox_szamlaigen;
        private CheckBox checkBox_szamlanem;
        private Label label1;
        private TextBox textBox2;
        private Label label_darabszam;
        private TextBox textBox_darabszam;
        private Label label_rendelesiadatok;
        private TextBox textBox3;
        private Button button_kiiras;
    }
}