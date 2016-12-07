namespace calculadora
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
            this.Operadores = new System.Windows.Forms.ComboBox();
            this.dato1 = new System.Windows.Forms.TextBox();
            this.dato2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operadores
            // 
            this.Operadores.FormattingEnabled = true;
            this.Operadores.Items.AddRange(new object[] {
            "SUMA",
            "RESTA",
            "DIVISION\t",
            "MULTIPLICACION"});
            this.Operadores.Location = new System.Drawing.Point(144, 28);
            this.Operadores.Name = "Operadores";
            this.Operadores.Size = new System.Drawing.Size(128, 21);
            this.Operadores.TabIndex = 0;
            this.Operadores.SelectedIndexChanged += new System.EventHandler(this.Operadores_SelectedIndexChanged);
            // 
            // dato1
            // 
            this.dato1.Location = new System.Drawing.Point(144, 73);
            this.dato1.Multiline = true;
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(128, 24);
            this.dato1.TabIndex = 1;
            // 
            // dato2
            // 
            this.dato2.Location = new System.Drawing.Point(144, 112);
            this.dato2.Multiline = true;
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(128, 24);
            this.dato2.TabIndex = 2;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(144, 154);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(128, 24);
            this.resultado.TabIndex = 3;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(13, 197);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(67, 27);
            this.calcular.TabIndex = 4;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(99, 198);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(76, 26);
            this.Borrar.TabIndex = 5;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(198, 198);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(77, 26);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite No. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digite No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.Operadores);
            this.Name = "Form1";
            this.Text = "Voyage 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Operadores;
        private System.Windows.Forms.TextBox dato1;
        private System.Windows.Forms.TextBox dato2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}

