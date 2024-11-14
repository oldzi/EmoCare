namespace EmoCare
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtNastroj = new System.Windows.Forms.TextBox();
            this.btnAnalizuj = new System.Windows.Forms.Button();
            this.btnCytat = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.lblCytat = new System.Windows.Forms.Label();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.chartNastroj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnWczytajWykres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartNastroj)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNastroj
            // 
            this.txtNastroj.Location = new System.Drawing.Point(306, 72);
            this.txtNastroj.Name = "txtNastroj";
            this.txtNastroj.Size = new System.Drawing.Size(143, 22);
            this.txtNastroj.TabIndex = 0;
            // 
            // btnAnalizuj
            // 
            this.btnAnalizuj.Location = new System.Drawing.Point(267, 124);
            this.btnAnalizuj.Name = "btnAnalizuj";
            this.btnAnalizuj.Size = new System.Drawing.Size(247, 23);
            this.btnAnalizuj.TabIndex = 1;
            this.btnAnalizuj.Text = "Analizuj moje uczucia";
            this.btnAnalizuj.UseVisualStyleBackColor = true;
            this.btnAnalizuj.Click += new System.EventHandler(this.btnAnalizuj_Click);
            // 
            // btnCytat
            // 
            this.btnCytat.Location = new System.Drawing.Point(267, 221);
            this.btnCytat.Name = "btnCytat";
            this.btnCytat.Size = new System.Drawing.Size(232, 34);
            this.btnCytat.TabIndex = 2;
            this.btnCytat.Text = "Przycisk do generowania cytatów";
            this.btnCytat.UseVisualStyleBackColor = true;
            this.btnCytat.Click += new System.EventHandler(this.btnCytat_Click);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(290, 170);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(190, 16);
            this.lblWynik.TabIndex = 3;
            this.lblWynik.Text = "Etykieta, która wyświetla wyniki";
            // 
            // lblCytat
            // 
            this.lblCytat.AutoSize = true;
            this.lblCytat.Location = new System.Drawing.Point(280, 284);
            this.lblCytat.Name = "lblCytat";
            this.lblCytat.Size = new System.Drawing.Size(200, 16);
            this.lblCytat.TabIndex = 4;
            this.lblCytat.Text = "Etykieta do wyświetlania cytatów";
            // 
            // btnHistoria
            // 
            this.btnHistoria.Location = new System.Drawing.Point(267, 352);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(247, 23);
            this.btnHistoria.TabIndex = 5;
            this.btnHistoria.Text = "Historia";
            this.btnHistoria.UseVisualStyleBackColor = true;
            this.btnHistoria.Click += new System.EventHandler(this.btnHistoria_Click);
            // 
            // chartNastroj
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNastroj.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNastroj.Legends.Add(legend1);
            this.chartNastroj.Location = new System.Drawing.Point(574, 101);
            this.chartNastroj.Name = "chartNastroj";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Nastroje";
            this.chartNastroj.Series.Add(series1);
            this.chartNastroj.Size = new System.Drawing.Size(458, 313);
            this.chartNastroj.TabIndex = 6;
            this.chartNastroj.Text = "chart1";
            // 
            // btnWczytajWykres
            // 
            this.btnWczytajWykres.Location = new System.Drawing.Point(609, 52);
            this.btnWczytajWykres.Name = "btnWczytajWykres";
            this.btnWczytajWykres.Size = new System.Drawing.Size(160, 23);
            this.btnWczytajWykres.TabIndex = 7;
            this.btnWczytajWykres.Text = "Wczytaj wykres";
            this.btnWczytajWykres.UseVisualStyleBackColor = true;
            this.btnWczytajWykres.Click += new System.EventHandler(this.btnWczytajWykres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 516);
            this.Controls.Add(this.btnWczytajWykres);
            this.Controls.Add(this.chartNastroj);
            this.Controls.Add(this.btnHistoria);
            this.Controls.Add(this.lblCytat);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btnCytat);
            this.Controls.Add(this.btnAnalizuj);
            this.Controls.Add(this.txtNastroj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartNastroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNastroj;
        private System.Windows.Forms.Button btnAnalizuj;
        private System.Windows.Forms.Button btnCytat;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Label lblCytat;
        private System.Windows.Forms.Button btnHistoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNastroj;
        private System.Windows.Forms.Button btnWczytajWykres;
    }
}

