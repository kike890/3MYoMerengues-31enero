namespace _3MYoMerengues_28enero
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
            this.but_limpiar = new System.Windows.Forms.Button();
            this.but_celcius = new System.Windows.Forms.Button();
            this.but_faren = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_celcius = new System.Windows.Forms.TextBox();
            this.Lb_fare = new System.Windows.Forms.TextBox();
            this.Lb_resul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_limpiar
            // 
            this.but_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but_limpiar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_limpiar.ForeColor = System.Drawing.Color.Maroon;
            this.but_limpiar.Location = new System.Drawing.Point(345, 338);
            this.but_limpiar.Name = "but_limpiar";
            this.but_limpiar.Size = new System.Drawing.Size(115, 67);
            this.but_limpiar.TabIndex = 0;
            this.but_limpiar.Text = "Limpiar";
            this.but_limpiar.UseVisualStyleBackColor = false;
            this.but_limpiar.Click += new System.EventHandler(this.but_limpiar_Click);
            // 
            // but_celcius
            // 
            this.but_celcius.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_celcius.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_celcius.Location = new System.Drawing.Point(131, 249);
            this.but_celcius.Name = "but_celcius";
            this.but_celcius.Size = new System.Drawing.Size(145, 81);
            this.but_celcius.TabIndex = 1;
            this.but_celcius.Text = "Celcius a Farenheit";
            this.but_celcius.UseVisualStyleBackColor = false;
            this.but_celcius.Click += new System.EventHandler(this.but_celcius_Click);
            // 
            // but_faren
            // 
            this.but_faren.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_faren.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_faren.Location = new System.Drawing.Point(543, 249);
            this.but_faren.Name = "but_faren";
            this.but_faren.Size = new System.Drawing.Size(169, 94);
            this.but_faren.TabIndex = 2;
            this.but_faren.Text = "Farenheit a Celcius";
            this.but_faren.UseVisualStyleBackColor = false;
            this.but_faren.Click += new System.EventHandler(this.but_faren_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Purple;
            this.textBox1.Location = new System.Drawing.Point(232, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "conversion de temperatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Farenheit";
            // 
            // LB_celcius
            // 
            this.LB_celcius.Location = new System.Drawing.Point(131, 162);
            this.LB_celcius.Name = "LB_celcius";
            this.LB_celcius.Size = new System.Drawing.Size(100, 22);
            this.LB_celcius.TabIndex = 6;
            // 
            // Lb_fare
            // 
            this.Lb_fare.Location = new System.Drawing.Point(560, 162);
            this.Lb_fare.Name = "Lb_fare";
            this.Lb_fare.Size = new System.Drawing.Size(100, 22);
            this.Lb_fare.TabIndex = 7;
            // 
            // Lb_resul
            // 
            this.Lb_resul.AutoSize = true;
            this.Lb_resul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Lb_resul.Location = new System.Drawing.Point(366, 162);
            this.Lb_resul.Name = "Lb_resul";
            this.Lb_resul.Size = new System.Drawing.Size(72, 16);
            this.Lb_resul.TabIndex = 8;
            this.Lb_resul.Text = "Resultado ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lb_resul);
            this.Controls.Add(this.Lb_fare);
            this.Controls.Add(this.LB_celcius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.but_faren);
            this.Controls.Add(this.but_celcius);
            this.Controls.Add(this.but_limpiar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_limpiar;
        private System.Windows.Forms.Button but_celcius;
        private System.Windows.Forms.Button but_faren;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LB_celcius;
        private System.Windows.Forms.TextBox Lb_fare;
        private System.Windows.Forms.Label Lb_resul;
    }
}

