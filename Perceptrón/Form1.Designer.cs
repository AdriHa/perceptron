namespace Perceptrón
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBEntrada1 = new System.Windows.Forms.TextBox();
            this.TBEntrada2 = new System.Windows.Forms.TextBox();
            this.TBBias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Li1 = new System.Windows.Forms.Label();
            this.Li2 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.LCompuerta = new System.Windows.Forms.Label();
            this.BInicio = new System.Windows.Forms.Button();
            this.BOR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.TBBiasFinal = new System.Windows.Forms.TextBox();
            this.TBW2Final = new System.Windows.Forms.TextBox();
            this.TBW1Final = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBEntrada1
            // 
            this.TBEntrada1.Location = new System.Drawing.Point(12, 85);
            this.TBEntrada1.Name = "TBEntrada1";
            this.TBEntrada1.ReadOnly = true;
            this.TBEntrada1.Size = new System.Drawing.Size(100, 20);
            this.TBEntrada1.TabIndex = 0;
            this.TBEntrada1.TextChanged += new System.EventHandler(this.TBEntrada1_TextChanged);
            // 
            // TBEntrada2
            // 
            this.TBEntrada2.Location = new System.Drawing.Point(12, 146);
            this.TBEntrada2.Name = "TBEntrada2";
            this.TBEntrada2.ReadOnly = true;
            this.TBEntrada2.Size = new System.Drawing.Size(100, 20);
            this.TBEntrada2.TabIndex = 1;
            // 
            // TBBias
            // 
            this.TBBias.Location = new System.Drawing.Point(12, 208);
            this.TBBias.Name = "TBBias";
            this.TBBias.ReadOnly = true;
            this.TBBias.Size = new System.Drawing.Size(100, 20);
            this.TBBias.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "W1 Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "W2 Inicial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bias Inicial";
            // 
            // Li1
            // 
            this.Li1.AutoSize = true;
            this.Li1.Location = new System.Drawing.Point(231, 9);
            this.Li1.Name = "Li1";
            this.Li1.Size = new System.Drawing.Size(15, 13);
            this.Li1.TabIndex = 10;
            this.Li1.Text = "i1";
            // 
            // Li2
            // 
            this.Li2.AutoSize = true;
            this.Li2.Location = new System.Drawing.Point(302, 9);
            this.Li2.Name = "Li2";
            this.Li2.Size = new System.Drawing.Size(15, 13);
            this.Li2.TabIndex = 12;
            this.Li2.Text = "i2";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(367, 9);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(14, 13);
            this.T.TabIndex = 14;
            this.T.Text = "T";
            // 
            // LCompuerta
            // 
            this.LCompuerta.AutoSize = true;
            this.LCompuerta.Location = new System.Drawing.Point(9, 11);
            this.LCompuerta.Name = "LCompuerta";
            this.LCompuerta.Size = new System.Drawing.Size(58, 13);
            this.LCompuerta.TabIndex = 17;
            this.LCompuerta.Text = "Compuerta";
            // 
            // BInicio
            // 
            this.BInicio.Location = new System.Drawing.Point(12, 27);
            this.BInicio.Name = "BInicio";
            this.BInicio.Size = new System.Drawing.Size(75, 23);
            this.BInicio.TabIndex = 19;
            this.BInicio.Text = "AND";
            this.BInicio.UseVisualStyleBackColor = true;
            this.BInicio.Click += new System.EventHandler(this.BInicio_Click);
            // 
            // BOR
            // 
            this.BOR.Location = new System.Drawing.Point(93, 27);
            this.BOR.Name = "BOR";
            this.BOR.Size = new System.Drawing.Size(75, 23);
            this.BOR.TabIndex = 21;
            this.BOR.Text = "OR";
            this.BOR.UseVisualStyleBackColor = true;
            this.BOR.Click += new System.EventHandler(this.BOR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "###";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "###";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "###";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "###";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "###";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "###";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "###";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "###";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "###";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(379, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "###";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "###";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "###";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(463, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "###";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(463, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "###";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(463, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "###";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(463, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "###";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(463, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "FP";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(534, 143);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "Bias Final";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(534, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "W2 Final";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(534, 11);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 42;
            this.label24.Text = "W1 Final";
            // 
            // TBBiasFinal
            // 
            this.TBBiasFinal.Location = new System.Drawing.Point(537, 159);
            this.TBBiasFinal.Name = "TBBiasFinal";
            this.TBBiasFinal.ReadOnly = true;
            this.TBBiasFinal.Size = new System.Drawing.Size(100, 20);
            this.TBBiasFinal.TabIndex = 41;
            // 
            // TBW2Final
            // 
            this.TBW2Final.Location = new System.Drawing.Point(537, 97);
            this.TBW2Final.Name = "TBW2Final";
            this.TBW2Final.ReadOnly = true;
            this.TBW2Final.Size = new System.Drawing.Size(100, 20);
            this.TBW2Final.TabIndex = 40;
            // 
            // TBW1Final
            // 
            this.TBW1Final.Location = new System.Drawing.Point(537, 36);
            this.TBW1Final.Name = "TBW1Final";
            this.TBW1Final.ReadOnly = true;
            this.TBW1Final.Size = new System.Drawing.Size(100, 20);
            this.TBW1Final.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 267);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.TBBiasFinal);
            this.Controls.Add(this.TBW2Final);
            this.Controls.Add(this.TBW1Final);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BOR);
            this.Controls.Add(this.BInicio);
            this.Controls.Add(this.LCompuerta);
            this.Controls.Add(this.T);
            this.Controls.Add(this.Li2);
            this.Controls.Add(this.Li1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBBias);
            this.Controls.Add(this.TBEntrada2);
            this.Controls.Add(this.TBEntrada1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBEntrada1;
        private System.Windows.Forms.TextBox TBEntrada2;
        private System.Windows.Forms.TextBox TBBias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Li1;
        private System.Windows.Forms.Label Li2;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label LCompuerta;
        private System.Windows.Forms.Button BInicio;
        private System.Windows.Forms.Button BOR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TBBiasFinal;
        private System.Windows.Forms.TextBox TBW2Final;
        private System.Windows.Forms.TextBox TBW1Final;
    }
}

