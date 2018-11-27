namespace HorasPonto
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraSaida = new System.Windows.Forms.TextBox();
            this.txtMinutoSaida = new System.Windows.Forms.TextBox();
            this.btnCalcularSaida = new System.Windows.Forms.Button();
            this.cbHoraEntrada = new System.Windows.Forms.ComboBox();
            this.cbMinutoEntrada = new System.Windows.Forms.ComboBox();
            this.cbMinutoIntervaloSaida = new System.Windows.Forms.ComboBox();
            this.cbHoraIntervaloSaida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinutoIntervaloEntrada = new System.Windows.Forms.ComboBox();
            this.cbHoraIntervaloEntrada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 120);
            this.label4.TabIndex = 20;
            this.label4.Text = ":";
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraSaida.Location = new System.Drawing.Point(286, 22);
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.ReadOnly = true;
            this.txtHoraSaida.Size = new System.Drawing.Size(134, 129);
            this.txtHoraSaida.TabIndex = 19;
            // 
            // txtMinutoSaida
            // 
            this.txtMinutoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutoSaida.Location = new System.Drawing.Point(486, 22);
            this.txtMinutoSaida.Name = "txtMinutoSaida";
            this.txtMinutoSaida.ReadOnly = true;
            this.txtMinutoSaida.Size = new System.Drawing.Size(134, 129);
            this.txtMinutoSaida.TabIndex = 21;
            // 
            // btnCalcularSaida
            // 
            this.btnCalcularSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSaida.Location = new System.Drawing.Point(35, 173);
            this.btnCalcularSaida.Name = "btnCalcularSaida";
            this.btnCalcularSaida.Size = new System.Drawing.Size(585, 34);
            this.btnCalcularSaida.TabIndex = 7;
            this.btnCalcularSaida.Text = "Calcular saída";
            this.btnCalcularSaida.UseVisualStyleBackColor = true;
            this.btnCalcularSaida.Click += new System.EventHandler(this.btnCalcularSaida_Click);
            // 
            // cbHoraEntrada
            // 
            this.cbHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoraEntrada.FormattingEnabled = true;
            this.cbHoraEntrada.Location = new System.Drawing.Point(35, 22);
            this.cbHoraEntrada.Name = "cbHoraEntrada";
            this.cbHoraEntrada.Size = new System.Drawing.Size(100, 37);
            this.cbHoraEntrada.TabIndex = 1;
            // 
            // cbMinutoEntrada
            // 
            this.cbMinutoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinutoEntrada.FormattingEnabled = true;
            this.cbMinutoEntrada.Location = new System.Drawing.Point(153, 22);
            this.cbMinutoEntrada.Name = "cbMinutoEntrada";
            this.cbMinutoEntrada.Size = new System.Drawing.Size(100, 37);
            this.cbMinutoEntrada.TabIndex = 2;
            // 
            // cbMinutoIntervaloSaida
            // 
            this.cbMinutoIntervaloSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinutoIntervaloSaida.FormattingEnabled = true;
            this.cbMinutoIntervaloSaida.Location = new System.Drawing.Point(153, 68);
            this.cbMinutoIntervaloSaida.Name = "cbMinutoIntervaloSaida";
            this.cbMinutoIntervaloSaida.Size = new System.Drawing.Size(100, 37);
            this.cbMinutoIntervaloSaida.TabIndex = 4;
            // 
            // cbHoraIntervaloSaida
            // 
            this.cbHoraIntervaloSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoraIntervaloSaida.FormattingEnabled = true;
            this.cbHoraIntervaloSaida.Location = new System.Drawing.Point(35, 68);
            this.cbHoraIntervaloSaida.Name = "cbHoraIntervaloSaida";
            this.cbHoraIntervaloSaida.Size = new System.Drawing.Size(100, 37);
            this.cbHoraIntervaloSaida.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = ":";
            // 
            // cbMinutoIntervaloEntrada
            // 
            this.cbMinutoIntervaloEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinutoIntervaloEntrada.FormattingEnabled = true;
            this.cbMinutoIntervaloEntrada.Location = new System.Drawing.Point(153, 114);
            this.cbMinutoIntervaloEntrada.Name = "cbMinutoIntervaloEntrada";
            this.cbMinutoIntervaloEntrada.Size = new System.Drawing.Size(100, 37);
            this.cbMinutoIntervaloEntrada.TabIndex = 6;
            // 
            // cbHoraIntervaloEntrada
            // 
            this.cbHoraIntervaloEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoraIntervaloEntrada.FormattingEnabled = true;
            this.cbHoraIntervaloEntrada.Location = new System.Drawing.Point(35, 114);
            this.cbHoraIntervaloEntrada.Name = "cbHoraIntervaloEntrada";
            this.cbHoraIntervaloEntrada.Size = new System.Drawing.Size(100, 37);
            this.cbHoraIntervaloEntrada.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = ":";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 233);
            this.Controls.Add(this.cbMinutoIntervaloEntrada);
            this.Controls.Add(this.cbHoraIntervaloEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMinutoIntervaloSaida);
            this.Controls.Add(this.cbHoraIntervaloSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMinutoEntrada);
            this.Controls.Add(this.cbHoraEntrada);
            this.Controls.Add(this.btnCalcularSaida);
            this.Controls.Add(this.txtMinutoSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Resize += new System.EventHandler(this.FormPrincipal_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoraSaida;
        private System.Windows.Forms.TextBox txtMinutoSaida;
        private System.Windows.Forms.Button btnCalcularSaida;
        private System.Windows.Forms.ComboBox cbHoraEntrada;
        private System.Windows.Forms.ComboBox cbMinutoEntrada;
        private System.Windows.Forms.ComboBox cbMinutoIntervaloSaida;
        private System.Windows.Forms.ComboBox cbHoraIntervaloSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMinutoIntervaloEntrada;
        private System.Windows.Forms.ComboBox cbHoraIntervaloEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
    }
}

