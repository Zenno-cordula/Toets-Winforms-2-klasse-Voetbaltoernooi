namespace _1._1
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
            lblPloeg = new Label();
            lblNaamPloeg = new Label();
            txtNaamPloeg = new TextBox();
            btnPloegAanmaken = new Button();
            lstPloegen = new ListBox();
            lstSpelers = new ListBox();
            btnSpelerToevoegen = new Button();
            txtNaamSpeler = new TextBox();
            lblNaamSpeler = new Label();
            lblSpeler = new Label();
            lblRugnummer = new Label();
            txtRugnummer = new TextBox();
            btnDoelpuntToevoegen = new Button();
            btnVerwijderSpeler = new Button();
            lblTotaalDoelpunten = new Label();
            lblTopSchutter = new Label();
            SuspendLayout();
            // 
            // lblPloeg
            // 
            lblPloeg.AutoSize = true;
            lblPloeg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPloeg.Location = new Point(33, 25);
            lblPloeg.Name = "lblPloeg";
            lblPloeg.Size = new Size(48, 20);
            lblPloeg.TabIndex = 0;
            lblPloeg.Text = "Ploeg";
            // 
            // lblNaamPloeg
            // 
            lblNaamPloeg.AutoSize = true;
            lblNaamPloeg.Location = new Point(33, 64);
            lblNaamPloeg.Name = "lblNaamPloeg";
            lblNaamPloeg.Size = new Size(95, 20);
            lblNaamPloeg.TabIndex = 1;
            lblNaamPloeg.Text = "Naam ploeg:";
            // 
            // txtNaamPloeg
            // 
            txtNaamPloeg.Location = new Point(166, 61);
            txtNaamPloeg.Name = "txtNaamPloeg";
            txtNaamPloeg.Size = new Size(125, 27);
            txtNaamPloeg.TabIndex = 2;
            // 
            // btnPloegAanmaken
            // 
            btnPloegAanmaken.Location = new Point(33, 156);
            btnPloegAanmaken.Name = "btnPloegAanmaken";
            btnPloegAanmaken.Size = new Size(258, 29);
            btnPloegAanmaken.TabIndex = 3;
            btnPloegAanmaken.Text = "Maak ploeg aan";
            btnPloegAanmaken.UseVisualStyleBackColor = true;
            btnPloegAanmaken.Click += btnPloegAanmaken_Click;
            // 
            // lstPloegen
            // 
            lstPloegen.FormattingEnabled = true;
            lstPloegen.Location = new Point(33, 202);
            lstPloegen.Name = "lstPloegen";
            lstPloegen.Size = new Size(258, 284);
            lstPloegen.TabIndex = 4;
            lstPloegen.SelectedIndexChanged += lstPloegen_SelectedIndexChanged;
            // 
            // lstSpelers
            // 
            lstSpelers.FormattingEnabled = true;
            lstSpelers.Location = new Point(440, 202);
            lstSpelers.Name = "lstSpelers";
            lstSpelers.Size = new Size(258, 284);
            lstSpelers.TabIndex = 9;
            // 
            // btnSpelerToevoegen
            // 
            btnSpelerToevoegen.Location = new Point(440, 156);
            btnSpelerToevoegen.Name = "btnSpelerToevoegen";
            btnSpelerToevoegen.Size = new Size(258, 29);
            btnSpelerToevoegen.TabIndex = 8;
            btnSpelerToevoegen.Text = "Voeg speler toe";
            btnSpelerToevoegen.UseVisualStyleBackColor = true;
            btnSpelerToevoegen.Click += btnSpelerToevoegen_Click;
            // 
            // txtNaamSpeler
            // 
            txtNaamSpeler.Location = new Point(573, 61);
            txtNaamSpeler.Name = "txtNaamSpeler";
            txtNaamSpeler.Size = new Size(125, 27);
            txtNaamSpeler.TabIndex = 7;
            // 
            // lblNaamSpeler
            // 
            lblNaamSpeler.AutoSize = true;
            lblNaamSpeler.Location = new Point(440, 64);
            lblNaamSpeler.Name = "lblNaamSpeler";
            lblNaamSpeler.Size = new Size(52, 20);
            lblNaamSpeler.TabIndex = 6;
            lblNaamSpeler.Text = "Naam:";
            // 
            // lblSpeler
            // 
            lblSpeler.AutoSize = true;
            lblSpeler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSpeler.Location = new Point(440, 25);
            lblSpeler.Name = "lblSpeler";
            lblSpeler.Size = new Size(52, 20);
            lblSpeler.TabIndex = 5;
            lblSpeler.Text = "Speler";
            // 
            // lblRugnummer
            // 
            lblRugnummer.AutoSize = true;
            lblRugnummer.Location = new Point(440, 112);
            lblRugnummer.Name = "lblRugnummer";
            lblRugnummer.Size = new Size(93, 20);
            lblRugnummer.TabIndex = 10;
            lblRugnummer.Text = "Rugnummer:";
            // 
            // txtRugnummer
            // 
            txtRugnummer.Location = new Point(573, 109);
            txtRugnummer.Name = "txtRugnummer";
            txtRugnummer.Size = new Size(125, 27);
            txtRugnummer.TabIndex = 11;
            // 
            // btnDoelpuntToevoegen
            // 
            btnDoelpuntToevoegen.Location = new Point(440, 501);
            btnDoelpuntToevoegen.Name = "btnDoelpuntToevoegen";
            btnDoelpuntToevoegen.Size = new Size(127, 29);
            btnDoelpuntToevoegen.TabIndex = 12;
            btnDoelpuntToevoegen.Text = "Doelpunt +1";
            btnDoelpuntToevoegen.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderSpeler
            // 
            btnVerwijderSpeler.Location = new Point(573, 501);
            btnVerwijderSpeler.Name = "btnVerwijderSpeler";
            btnVerwijderSpeler.Size = new Size(125, 29);
            btnVerwijderSpeler.TabIndex = 13;
            btnVerwijderSpeler.Text = "Verwijder speler";
            btnVerwijderSpeler.UseVisualStyleBackColor = true;
            // 
            // lblTotaalDoelpunten
            // 
            lblTotaalDoelpunten.AutoSize = true;
            lblTotaalDoelpunten.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotaalDoelpunten.Location = new Point(33, 553);
            lblTotaalDoelpunten.Name = "lblTotaalDoelpunten";
            lblTotaalDoelpunten.Size = new Size(0, 20);
            lblTotaalDoelpunten.TabIndex = 14;
            // 
            // lblTopSchutter
            // 
            lblTopSchutter.AutoSize = true;
            lblTopSchutter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTopSchutter.Location = new Point(33, 591);
            lblTopSchutter.Name = "lblTopSchutter";
            lblTopSchutter.Size = new Size(0, 20);
            lblTopSchutter.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 632);
            Controls.Add(lblTopSchutter);
            Controls.Add(lblTotaalDoelpunten);
            Controls.Add(btnVerwijderSpeler);
            Controls.Add(btnDoelpuntToevoegen);
            Controls.Add(txtRugnummer);
            Controls.Add(lblRugnummer);
            Controls.Add(lstSpelers);
            Controls.Add(btnSpelerToevoegen);
            Controls.Add(txtNaamSpeler);
            Controls.Add(lblNaamSpeler);
            Controls.Add(lblSpeler);
            Controls.Add(lstPloegen);
            Controls.Add(btnPloegAanmaken);
            Controls.Add(txtNaamPloeg);
            Controls.Add(lblNaamPloeg);
            Controls.Add(lblPloeg);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPloeg;
        private Label lblNaamPloeg;
        private TextBox txtNaamPloeg;
        private Button btnPloegAanmaken;
        private ListBox lstPloegen;
        private ListBox lstSpelers;
        private Button btnSpelerToevoegen;
        private TextBox txtNaamSpeler;
        private Label lblNaamSpeler;
        private Label lblSpeler;
        private Label lblRugnummer;
        private TextBox txtRugnummer;
        private Button btnDoelpuntToevoegen;
        private Button btnVerwijderSpeler;
        private Label lblTotaalDoelpunten;
        private Label lblTopSchutter;
    }
}
