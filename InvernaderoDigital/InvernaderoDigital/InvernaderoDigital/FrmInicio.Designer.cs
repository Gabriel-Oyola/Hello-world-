
namespace InvernaderoDigital
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.ImgInv1 = new System.Windows.Forms.PictureBox();
            this.btConfigInv1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgSiembra = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSyC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgInv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSiembra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(173, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(211, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Invernadero Digital";
            // 
            // ImgLogo
            // 
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.Location = new System.Drawing.Point(103, 12);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(100, 50);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 1;
            this.ImgLogo.TabStop = false;
            // 
            // ImgInv1
            // 
            this.ImgInv1.Image = ((System.Drawing.Image)(resources.GetObject("ImgInv1.Image")));
            this.ImgInv1.Location = new System.Drawing.Point(41, 98);
            this.ImgInv1.Name = "ImgInv1";
            this.ImgInv1.Size = new System.Drawing.Size(197, 119);
            this.ImgInv1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgInv1.TabIndex = 2;
            this.ImgInv1.TabStop = false;
            // 
            // btConfigInv1
            // 
            this.btConfigInv1.Location = new System.Drawing.Point(52, 223);
            this.btConfigInv1.Name = "btConfigInv1";
            this.btConfigInv1.Size = new System.Drawing.Size(177, 35);
            this.btConfigInv1.TabIndex = 3;
            this.btConfigInv1.Text = "Configurar";
            this.btConfigInv1.UseVisualStyleBackColor = true;
            this.btConfigInv1.Click += new System.EventHandler(this.btConfigInv1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Invernadero";
            // 
            // ImgSiembra
            // 
            this.ImgSiembra.Image = ((System.Drawing.Image)(resources.GetObject("ImgSiembra.Image")));
            this.ImgSiembra.Location = new System.Drawing.Point(298, 98);
            this.ImgSiembra.Name = "ImgSiembra";
            this.ImgSiembra.Size = new System.Drawing.Size(197, 119);
            this.ImgSiembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgSiembra.TabIndex = 5;
            this.ImgSiembra.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Siembra";
            // 
            // btSyC
            // 
            this.btSyC.Location = new System.Drawing.Point(309, 223);
            this.btSyC.Name = "btSyC";
            this.btSyC.Size = new System.Drawing.Size(177, 35);
            this.btSyC.TabIndex = 7;
            this.btSyC.Text = "Configurar";
            this.btSyC.UseVisualStyleBackColor = true;
            this.btSyC.Click += new System.EventHandler(this.btSyC_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(522, 320);
            this.Controls.Add(this.btSyC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImgSiembra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConfigInv1);
            this.Controls.Add(this.ImgInv1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ImgLogo);
            this.Name = "FrmInicio";
            this.Text = "Invernadero Digital";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgInv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSiembra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.PictureBox ImgInv1;
        private System.Windows.Forms.Button btConfigInv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImgSiembra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSyC;
    }
}

