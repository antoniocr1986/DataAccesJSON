namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.button_Examinar = new System.Windows.Forms.Button();
            this.button_Abrir = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Examinar
            // 
            this.button_Examinar.Location = new System.Drawing.Point(31, 31);
            this.button_Examinar.Name = "button_Examinar";
            this.button_Examinar.Size = new System.Drawing.Size(75, 23);
            this.button_Examinar.TabIndex = 0;
            this.button_Examinar.Text = "Examinar";
            this.button_Examinar.UseVisualStyleBackColor = true;
            this.button_Examinar.Click += new System.EventHandler(this.button_Examinar_Click);
            // 
            // button_Abrir
            // 
            this.button_Abrir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_Abrir.Location = new System.Drawing.Point(31, 140);
            this.button_Abrir.Name = "button_Abrir";
            this.button_Abrir.Size = new System.Drawing.Size(75, 23);
            this.button_Abrir.TabIndex = 1;
            this.button_Abrir.Text = "Abrir";
            this.button_Abrir.UseVisualStyleBackColor = true;
            this.button_Abrir.Click += new System.EventHandler(this.button_Abrir_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(231, 172);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 2;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 45);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Abrir archivo seleccionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "y mostrar propiedades campos si es un .jsn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Abrir);
            this.Controls.Add(this.button_Examinar);
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimumSize = new System.Drawing.Size(330, 240);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRUEBA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Examinar;
        private System.Windows.Forms.Button button_Abrir;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

