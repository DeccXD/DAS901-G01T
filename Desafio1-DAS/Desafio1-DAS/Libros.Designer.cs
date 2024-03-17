namespace Desafio1_DAS
{
    partial class Libros
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 44D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 26D);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtHarry = new System.Windows.Forms.TextBox();
            this.lstHarry = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtGoos = new System.Windows.Forms.TextBox();
            this.lstGoos = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPerry = new System.Windows.Forms.TextBox();
            this.lstPerry = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libros";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(18, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 436);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtHarry);
            this.tabPage1.Controls.Add(this.lstHarry);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Harry Potter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtHarry
            // 
            this.txtHarry.Location = new System.Drawing.Point(267, 11);
            this.txtHarry.Multiline = true;
            this.txtHarry.Name = "txtHarry";
            this.txtHarry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHarry.Size = new System.Drawing.Size(514, 372);
            this.txtHarry.TabIndex = 1;
            // 
            // lstHarry
            // 
            this.lstHarry.FormattingEnabled = true;
            this.lstHarry.ItemHeight = 31;
            this.lstHarry.Location = new System.Drawing.Point(13, 11);
            this.lstHarry.Name = "lstHarry";
            this.lstHarry.Size = new System.Drawing.Size(215, 345);
            this.lstHarry.TabIndex = 0;
            this.lstHarry.SelectedIndexChanged += new System.EventHandler(this.lstHarry_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtGoos);
            this.tabPage2.Controls.Add(this.lstGoos);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Goosebumps";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGoos
            // 
            this.txtGoos.Enabled = false;
            this.txtGoos.Location = new System.Drawing.Point(265, 17);
            this.txtGoos.Multiline = true;
            this.txtGoos.Name = "txtGoos";
            this.txtGoos.Size = new System.Drawing.Size(521, 372);
            this.txtGoos.TabIndex = 2;
            // 
            // lstGoos
            // 
            this.lstGoos.FormattingEnabled = true;
            this.lstGoos.ItemHeight = 31;
            this.lstGoos.Location = new System.Drawing.Point(15, 17);
            this.lstGoos.Name = "lstGoos";
            this.lstGoos.Size = new System.Drawing.Size(215, 345);
            this.lstGoos.TabIndex = 1;
            this.lstGoos.SelectedIndexChanged += new System.EventHandler(this.lstGoos_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPerry);
            this.tabPage3.Controls.Add(this.lstPerry);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(806, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Perry Mason";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtPerry
            // 
            this.txtPerry.Enabled = false;
            this.txtPerry.Location = new System.Drawing.Point(267, 17);
            this.txtPerry.Multiline = true;
            this.txtPerry.Name = "txtPerry";
            this.txtPerry.Size = new System.Drawing.Size(522, 372);
            this.txtPerry.TabIndex = 2;
            // 
            // lstPerry
            // 
            this.lstPerry.FormattingEnabled = true;
            this.lstPerry.ItemHeight = 31;
            this.lstPerry.Location = new System.Drawing.Point(16, 17);
            this.lstPerry.Name = "lstPerry";
            this.lstPerry.Size = new System.Drawing.Size(215, 345);
            this.lstPerry.TabIndex = 1;
            this.lstPerry.SelectedIndexChanged += new System.EventHandler(this.lstPerry_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(806, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Estadisticas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(587, 43);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(216, 42);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(37, 53);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            dataPoint10.Label = "Harry Potter";
            dataPoint11.Label = "Goosbumps";
            dataPoint12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataPoint12.IsValueShownAsLabel = false;
            dataPoint12.IsVisibleInLegend = true;
            dataPoint12.Label = "Perry Mason";
            dataPoint12.LabelAngle = -30;
            dataPoint12.MarkerBorderColor = System.Drawing.Color.Yellow;
            series4.Points.Add(dataPoint10);
            series4.Points.Add(dataPoint11);
            series4.Points.Add(dataPoint12);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(733, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(838, 537);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Libros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtHarry;
        private System.Windows.Forms.ListBox lstHarry;
        private System.Windows.Forms.TextBox txtGoos;
        private System.Windows.Forms.ListBox lstGoos;
        private System.Windows.Forms.TextBox txtPerry;
        private System.Windows.Forms.ListBox lstPerry;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}