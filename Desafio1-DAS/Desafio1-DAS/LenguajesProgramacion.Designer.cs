namespace Desafio1_DAS
{
    partial class LenguajesProgramacion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 47D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 38D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPython = new System.Windows.Forms.TextBox();
            this.lstPython = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstJava = new System.Windows.Forms.ListBox();
            this.txtJava = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtJavascript = new System.Windows.Forms.TextBox();
            this.lstJavascript = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lenguajes de Programación";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 381);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPython);
            this.tabPage1.Controls.Add(this.lstPython);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PYTHON";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPython
            // 
            this.txtPython.Enabled = false;
            this.txtPython.Location = new System.Drawing.Point(235, 14);
            this.txtPython.Multiline = true;
            this.txtPython.Name = "txtPython";
            this.txtPython.Size = new System.Drawing.Size(515, 321);
            this.txtPython.TabIndex = 1;
            // 
            // lstPython
            // 
            this.lstPython.FormattingEnabled = true;
            this.lstPython.ItemHeight = 23;
            this.lstPython.Location = new System.Drawing.Point(17, 12);
            this.lstPython.Name = "lstPython";
            this.lstPython.Size = new System.Drawing.Size(201, 303);
            this.lstPython.TabIndex = 0;
            this.lstPython.SelectedIndexChanged += new System.EventHandler(this.lstPython_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstJava);
            this.tabPage2.Controls.Add(this.txtJava);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "JAVA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstJava
            // 
            this.lstJava.FormattingEnabled = true;
            this.lstJava.ItemHeight = 23;
            this.lstJava.Location = new System.Drawing.Point(13, 12);
            this.lstJava.Name = "lstJava";
            this.lstJava.Size = new System.Drawing.Size(226, 303);
            this.lstJava.TabIndex = 1;
            this.lstJava.SelectedIndexChanged += new System.EventHandler(this.lstJava_SelectedIndexChanged);
            // 
            // txtJava
            // 
            this.txtJava.Enabled = false;
            this.txtJava.Location = new System.Drawing.Point(256, 12);
            this.txtJava.Multiline = true;
            this.txtJava.Name = "txtJava";
            this.txtJava.Size = new System.Drawing.Size(491, 324);
            this.txtJava.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtJavascript);
            this.tabPage3.Controls.Add(this.lstJavascript);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(773, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "JAVASCRIPT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtJavascript
            // 
            this.txtJavascript.Enabled = false;
            this.txtJavascript.Location = new System.Drawing.Point(248, 11);
            this.txtJavascript.Multiline = true;
            this.txtJavascript.Name = "txtJavascript";
            this.txtJavascript.Size = new System.Drawing.Size(511, 324);
            this.txtJavascript.TabIndex = 1;
            // 
            // lstJavascript
            // 
            this.lstJavascript.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJavascript.FormattingEnabled = true;
            this.lstJavascript.ItemHeight = 32;
            this.lstJavascript.Location = new System.Drawing.Point(12, 11);
            this.lstJavascript.Name = "lstJavascript";
            this.lstJavascript.Size = new System.Drawing.Size(230, 292);
            this.lstJavascript.TabIndex = 0;
            this.lstJavascript.SelectedIndexChanged += new System.EventHandler(this.lstJavascript_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(773, 345);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Estadisticas";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.Location = new System.Drawing.Point(583, 12);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(180, 48);
            this.btnCerrarSesión.TabIndex = 2;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(17, 26);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            dataPoint7.Label = "Python";
            dataPoint8.Label = "JAVA";
            dataPoint9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataPoint9.IsValueShownAsLabel = false;
            dataPoint9.IsVisibleInLegend = true;
            dataPoint9.Label = "JavaScript";
            dataPoint9.LabelAngle = -30;
            dataPoint9.MarkerBorderColor = System.Drawing.Color.Yellow;
            series3.Points.Add(dataPoint7);
            series3.Points.Add(dataPoint8);
            series3.Points.Add(dataPoint9);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(733, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // LenguajesProgramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LenguajesProgramacion";
            this.Text = "LenguajesProgramacion";
            this.Load += new System.EventHandler(this.LenguajesProgramacion_Load);
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
        private System.Windows.Forms.TextBox txtPython;
        private System.Windows.Forms.ListBox lstPython;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstJava;
        private System.Windows.Forms.TextBox txtJava;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtJavascript;
        private System.Windows.Forms.ListBox lstJavascript;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}