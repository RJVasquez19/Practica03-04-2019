namespace Practica02_04_2019
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
            this.components = new System.ComponentModel.Container();
            this.progBar1 = new System.Windows.Forms.ProgressBar();
            this.btnButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.btn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progBar1
            // 
            this.progBar1.Location = new System.Drawing.Point(13, 155);
            this.progBar1.Name = "progBar1";
            this.progBar1.Size = new System.Drawing.Size(386, 23);
            this.progBar1.TabIndex = 0;
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(13, 198);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 23);
            this.btnButton.TabIndex = 1;
            this.btnButton.Text = "Button1";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(100, 22);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 23);
            this.btnRojo.TabIndex = 2;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.Location = new System.Drawing.Point(100, 51);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(75, 23);
            this.btnAmarillo.TabIndex = 3;
            this.btnAmarillo.Text = "Amarillo";
            this.btnAmarillo.UseVisualStyleBackColor = true;
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(100, 85);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 23);
            this.btnVerde.TabIndex = 4;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 5000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(158, 198);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "Button5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.progBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progBar1;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Timer timer4;
    }
}

