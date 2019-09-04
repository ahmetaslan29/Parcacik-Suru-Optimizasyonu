namespace PSO_ödev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grup_chart = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_run = new System.Windows.Forms.Button();
            this.gb_Params = new System.Windows.Forms.GroupBox();
            this.nud_pbest = new System.Windows.Forms.NumericUpDown();
            this.nud_gbest = new System.Windows.Forms.NumericUpDown();
            this.lb_pbest = new System.Windows.Forms.Label();
            this.lb_gbest = new System.Windows.Forms.Label();
            this.nud_jenerasyon = new System.Windows.Forms.NumericUpDown();
            this.lb_generation = new System.Windows.Forms.Label();
            this.lb_swarm = new System.Windows.Forms.Label();
            this.nud_parcacık = new System.Windows.Forms.NumericUpDown();
            this.grup_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gb_Params.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pbest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gbest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_jenerasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_parcacık)).BeginInit();
            this.SuspendLayout();
            // 
            // grup_chart
            // 
            this.grup_chart.Controls.Add(this.chart1);
            this.grup_chart.Location = new System.Drawing.Point(369, 13);
            this.grup_chart.Margin = new System.Windows.Forms.Padding(4);
            this.grup_chart.Name = "grup_chart";
            this.grup_chart.Padding = new System.Windows.Forms.Padding(4);
            this.grup_chart.Size = new System.Drawing.Size(743, 448);
            this.grup_chart.TabIndex = 5;
            this.grup_chart.TabStop = false;
            this.grup_chart.Text = "Grafik";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(34, 31);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(702, 404);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.Color.Teal;
            this.btn_run.Location = new System.Drawing.Point(29, 386);
            this.btn_run.Margin = new System.Windows.Forms.Padding(4);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(318, 75);
            this.btn_run.TabIndex = 4;
            this.btn_run.Text = "Hesapla";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // gb_Params
            // 
            this.gb_Params.Controls.Add(this.nud_pbest);
            this.gb_Params.Controls.Add(this.nud_gbest);
            this.gb_Params.Controls.Add(this.lb_pbest);
            this.gb_Params.Controls.Add(this.lb_gbest);
            this.gb_Params.Controls.Add(this.nud_jenerasyon);
            this.gb_Params.Controls.Add(this.lb_generation);
            this.gb_Params.Controls.Add(this.lb_swarm);
            this.gb_Params.Controls.Add(this.nud_parcacık);
            this.gb_Params.Location = new System.Drawing.Point(16, 44);
            this.gb_Params.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Params.Name = "gb_Params";
            this.gb_Params.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Params.Size = new System.Drawing.Size(345, 230);
            this.gb_Params.TabIndex = 3;
            this.gb_Params.TabStop = false;
            this.gb_Params.Text = "Parametreler";
            // 
            // nud_pbest
            // 
            this.nud_pbest.Location = new System.Drawing.Point(172, 136);
            this.nud_pbest.Margin = new System.Windows.Forms.Padding(4);
            this.nud_pbest.Name = "nud_pbest";
            this.nud_pbest.Size = new System.Drawing.Size(159, 22);
            this.nud_pbest.TabIndex = 10;
            this.nud_pbest.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_gbest
            // 
            this.nud_gbest.Location = new System.Drawing.Point(172, 108);
            this.nud_gbest.Margin = new System.Windows.Forms.Padding(4);
            this.nud_gbest.Name = "nud_gbest";
            this.nud_gbest.Size = new System.Drawing.Size(159, 22);
            this.nud_gbest.TabIndex = 9;
            this.nud_gbest.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lb_pbest
            // 
            this.lb_pbest.AutoSize = true;
            this.lb_pbest.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_pbest.ForeColor = System.Drawing.Color.Black;
            this.lb_pbest.Location = new System.Drawing.Point(15, 137);
            this.lb_pbest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pbest.Name = "lb_pbest";
            this.lb_pbest.Size = new System.Drawing.Size(149, 17);
            this.lb_pbest.TabIndex = 6;
            this.lb_pbest.Text = "pbest İçin Fakt. (C2):";
            // 
            // lb_gbest
            // 
            this.lb_gbest.AutoSize = true;
            this.lb_gbest.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_gbest.ForeColor = System.Drawing.Color.Black;
            this.lb_gbest.Location = new System.Drawing.Point(15, 109);
            this.lb_gbest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gbest.Name = "lb_gbest";
            this.lb_gbest.Size = new System.Drawing.Size(149, 17);
            this.lb_gbest.TabIndex = 5;
            this.lb_gbest.Text = "gbest İçin Fakt. (C1):";
            // 
            // nud_jenerasyon
            // 
            this.nud_jenerasyon.Location = new System.Drawing.Point(172, 79);
            this.nud_jenerasyon.Margin = new System.Windows.Forms.Padding(4);
            this.nud_jenerasyon.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_jenerasyon.Name = "nud_jenerasyon";
            this.nud_jenerasyon.Size = new System.Drawing.Size(159, 22);
            this.nud_jenerasyon.TabIndex = 4;
            this.nud_jenerasyon.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lb_generation
            // 
            this.lb_generation.AutoSize = true;
            this.lb_generation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_generation.ForeColor = System.Drawing.Color.Black;
            this.lb_generation.Location = new System.Drawing.Point(10, 80);
            this.lb_generation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_generation.Name = "lb_generation";
            this.lb_generation.Size = new System.Drawing.Size(154, 17);
            this.lb_generation.TabIndex = 3;
            this.lb_generation.Text = "Jenerasyon Sayısı (G):";
            // 
            // lb_swarm
            // 
            this.lb_swarm.AutoSize = true;
            this.lb_swarm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_swarm.ForeColor = System.Drawing.Color.Black;
            this.lb_swarm.Location = new System.Drawing.Point(29, 51);
            this.lb_swarm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_swarm.Name = "lb_swarm";
            this.lb_swarm.Size = new System.Drawing.Size(135, 17);
            this.lb_swarm.TabIndex = 2;
            this.lb_swarm.Text = "Parçacık Sayısı (N):";
            // 
            // nud_parcacık
            // 
            this.nud_parcacık.Location = new System.Drawing.Point(172, 50);
            this.nud_parcacık.Margin = new System.Windows.Forms.Padding(4);
            this.nud_parcacık.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_parcacık.Name = "nud_parcacık";
            this.nud_parcacık.Size = new System.Drawing.Size(159, 22);
            this.nud_parcacık.TabIndex = 1;
            this.nud_parcacık.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1125, 529);
            this.Controls.Add(this.grup_chart);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.gb_Params);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grup_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gb_Params.ResumeLayout(false);
            this.gb_Params.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pbest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gbest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_jenerasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_parcacık)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grup_chart;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.GroupBox gb_Params;
        private System.Windows.Forms.NumericUpDown nud_pbest;
        private System.Windows.Forms.NumericUpDown nud_gbest;
        private System.Windows.Forms.Label lb_pbest;
        private System.Windows.Forms.Label lb_gbest;
        private System.Windows.Forms.NumericUpDown nud_jenerasyon;
        private System.Windows.Forms.Label lb_generation;
        private System.Windows.Forms.Label lb_swarm;
        private System.Windows.Forms.NumericUpDown nud_parcacık;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

