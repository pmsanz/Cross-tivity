namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tSumar = new System.Windows.Forms.Button();
            this.tRestar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dRestar = new System.Windows.Forms.Button();
            this.dSumar = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 632);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiempo: ";
            // 
            // lblMostrar
            // 
            this.lblMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(85, 632);
            this.lblMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(87, 20);
            this.lblMostrar.TabIndex = 4;
            this.lblMostrar.Text = "00 : 00 : 00";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(28, 38);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // tSumar
            // 
            this.tSumar.Location = new System.Drawing.Point(188, 38);
            this.tSumar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tSumar.Name = "tSumar";
            this.tSumar.Size = new System.Drawing.Size(30, 31);
            this.tSumar.TabIndex = 6;
            this.tSumar.Text = "+";
            this.tSumar.UseVisualStyleBackColor = true;
            this.tSumar.Click += new System.EventHandler(this.tSumar_Click);
            // 
            // tRestar
            // 
            this.tRestar.Location = new System.Drawing.Point(226, 38);
            this.tRestar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tRestar.Name = "tRestar";
            this.tRestar.Size = new System.Drawing.Size(30, 31);
            this.tRestar.TabIndex = 7;
            this.tRestar.Text = "-";
            this.tRestar.UseVisualStyleBackColor = true;
            this.tRestar.Click += new System.EventHandler(this.tRestar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trabajo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descanso:";
            // 
            // dRestar
            // 
            this.dRestar.Location = new System.Drawing.Point(226, 102);
            this.dRestar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dRestar.Name = "dRestar";
            this.dRestar.Size = new System.Drawing.Size(30, 31);
            this.dRestar.TabIndex = 11;
            this.dRestar.Text = "-";
            this.dRestar.UseVisualStyleBackColor = true;
            this.dRestar.Click += new System.EventHandler(this.dRestar_Click);
            // 
            // dSumar
            // 
            this.dSumar.Location = new System.Drawing.Point(188, 102);
            this.dSumar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dSumar.Name = "dSumar";
            this.dSumar.Size = new System.Drawing.Size(30, 31);
            this.dSumar.TabIndex = 10;
            this.dSumar.Text = "+";
            this.dSumar.UseVisualStyleBackColor = true;
            this.dSumar.Click += new System.EventHandler(this.dSumar_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(28, 102);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dRestar);
            this.Controls.Add(this.dSumar);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tRestar);
            this.Controls.Add(this.tSumar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button tSumar;
        private System.Windows.Forms.Button tRestar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dRestar;
        private System.Windows.Forms.Button dSumar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}

