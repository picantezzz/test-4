namespace test_4
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNaamKlant = new TextBox();
            txtKlantnummer = new TextBox();
            txtProduct = new TextBox();
            txtAantal = new TextBox();
            txtPrijs = new TextBox();
            btnmaakfactuuraan = new Button();
            listBox1 = new ListBox();
            label6 = new Label();
            textBox6 = new TextBox();
            btnpasaantalaan = new Button();
            labelover = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "naam klant:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 82);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "klant nummer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 140);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "product:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 205);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "aantal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 273);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 4;
            label5.Text = "prijs:";
            // 
            // txtNaamKlant
            // 
            txtNaamKlant.Location = new Point(137, 27);
            txtNaamKlant.Name = "txtNaamKlant";
            txtNaamKlant.Size = new Size(125, 27);
            txtNaamKlant.TabIndex = 5;
            // 
            // txtKlantnummer
            // 
            txtKlantnummer.Location = new Point(137, 82);
            txtKlantnummer.Name = "txtKlantnummer";
            txtKlantnummer.Size = new Size(125, 27);
            txtKlantnummer.TabIndex = 6;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(137, 140);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(125, 27);
            txtProduct.TabIndex = 7;
            // 
            // txtAantal
            // 
            txtAantal.Location = new Point(137, 205);
            txtAantal.Name = "txtAantal";
            txtAantal.Size = new Size(125, 27);
            txtAantal.TabIndex = 8;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(137, 270);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(125, 27);
            txtPrijs.TabIndex = 9;
            // 
            // btnmaakfactuuraan
            // 
            btnmaakfactuuraan.Location = new Point(50, 354);
            btnmaakfactuuraan.Name = "btnmaakfactuuraan";
            btnmaakfactuuraan.Size = new Size(155, 29);
            btnmaakfactuuraan.TabIndex = 10;
            btnmaakfactuuraan.Text = "maak factuur aan";
            btnmaakfactuuraan.UseVisualStyleBackColor = true;
            btnmaakfactuuraan.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(50, 435);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(221, 164);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 422);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 12;
            label6.Text = "nieuwe aantal:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(522, 419);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 13;
            // 
            // btnpasaantalaan
            // 
            btnpasaantalaan.Location = new Point(431, 497);
            btnpasaantalaan.Name = "btnpasaantalaan";
            btnpasaantalaan.Size = new Size(155, 29);
            btnpasaantalaan.TabIndex = 14;
            btnpasaantalaan.Text = "pas aantal aan";
            btnpasaantalaan.UseVisualStyleBackColor = true;
            btnpasaantalaan.Click += btnpasaantalaan_Click;
            // 
            // labelover
            // 
            labelover.AutoSize = true;
            labelover.Location = new Point(395, 277);
            labelover.Name = "labelover";
            labelover.Size = new Size(0, 20);
            labelover.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 354);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 16;
            label7.Text = "factuur";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 621);
            Controls.Add(label7);
            Controls.Add(labelover);
            Controls.Add(btnpasaantalaan);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(btnmaakfactuuraan);
            Controls.Add(txtPrijs);
            Controls.Add(txtAantal);
            Controls.Add(txtProduct);
            Controls.Add(txtKlantnummer);
            Controls.Add(txtNaamKlant);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNaamKlant;
        private TextBox txtKlantnummer;
        private TextBox txtProduct;
        private TextBox txtAantal;
        private TextBox txtPrijs;
        private Button btnmaakfactuuraan;
        private ListBox listBox1;
        private Label label6;
        private TextBox textBox6;
        private Button btnpasaantalaan;
        private Label labelover;
        private Label label7;
    }
}
