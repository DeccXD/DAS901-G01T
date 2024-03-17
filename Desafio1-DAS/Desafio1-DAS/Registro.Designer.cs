namespace Desafio1_DAS
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.txtContraU = new System.Windows.Forms.TextBox();
            this.txtContraConfirm = new System.Windows.Forms.TextBox();
            this.btnGuardarR = new System.Windows.Forms.Button();
            this.btnCancelarR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // txtNombreU
            // 
            this.txtNombreU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreU.Location = new System.Drawing.Point(277, 54);
            this.txtNombreU.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(129, 20);
            this.txtNombreU.TabIndex = 3;
            // 
            // txtContraU
            // 
            this.txtContraU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraU.Location = new System.Drawing.Point(277, 91);
            this.txtContraU.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraU.Name = "txtContraU";
            this.txtContraU.PasswordChar = '*';
            this.txtContraU.Size = new System.Drawing.Size(129, 20);
            this.txtContraU.TabIndex = 4;
            // 
            // txtContraConfirm
            // 
            this.txtContraConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraConfirm.Location = new System.Drawing.Point(277, 133);
            this.txtContraConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraConfirm.Name = "txtContraConfirm";
            this.txtContraConfirm.PasswordChar = '*';
            this.txtContraConfirm.Size = new System.Drawing.Size(129, 20);
            this.txtContraConfirm.TabIndex = 5;
            // 
            // btnGuardarR
            // 
            this.btnGuardarR.BackColor = System.Drawing.Color.Thistle;
            this.btnGuardarR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarR.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarR.Location = new System.Drawing.Point(165, 207);
            this.btnGuardarR.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarR.Name = "btnGuardarR";
            this.btnGuardarR.Size = new System.Drawing.Size(161, 52);
            this.btnGuardarR.TabIndex = 6;
            this.btnGuardarR.Text = "Aceptar";
            this.btnGuardarR.UseVisualStyleBackColor = false;
            this.btnGuardarR.Click += new System.EventHandler(this.btnGuardarR_Click);
            // 
            // btnCancelarR
            // 
            this.btnCancelarR.Location = new System.Drawing.Point(199, 321);
            this.btnCancelarR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarR.Name = "btnCancelarR";
            this.btnCancelarR.Size = new System.Drawing.Size(100, 49);
            this.btnCancelarR.TabIndex = 7;
            this.btnCancelarR.Text = "Cancelar";
            this.btnCancelarR.UseVisualStyleBackColor = true;
            this.btnCancelarR.Click += new System.EventHandler(this.btnCancelarR_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(485, 295);
            this.Controls.Add(this.btnCancelarR);
            this.Controls.Add(this.btnGuardarR);
            this.Controls.Add(this.txtContraConfirm);
            this.Controls.Add(this.txtContraU);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.TextBox txtContraU;
        private System.Windows.Forms.TextBox txtContraConfirm;
        private System.Windows.Forms.Button btnGuardarR;
        private System.Windows.Forms.Button btnCancelarR;
    }
}