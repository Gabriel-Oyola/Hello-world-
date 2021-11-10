
namespace InvernaderoDigital
{
    partial class FrmSiembra
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoVer = new System.Windows.Forms.Label();
            this.cbVerdura = new System.Windows.Forms.ComboBox();
            this.cbFilaSembrar = new System.Windows.Forms.ComboBox();
            this.lblFIla1 = new System.Windows.Forms.Label();
            this.lblOpcFila = new System.Windows.Forms.Label();
            this.btSembrar = new System.Windows.Forms.Button();
            this.lblFila2 = new System.Windows.Forms.Label();
            this.lblFila3 = new System.Windows.Forms.Label();
            this.listFila1 = new System.Windows.Forms.ListBox();
            this.listfila2 = new System.Windows.Forms.ListBox();
            this.listFIla3 = new System.Windows.Forms.ListBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(342, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Siembra";
            // 
            // lblTipoVer
            // 
            this.lblTipoVer.AutoSize = true;
            this.lblTipoVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVer.Location = new System.Drawing.Point(343, 44);
            this.lblTipoVer.Name = "lblTipoVer";
            this.lblTipoVer.Size = new System.Drawing.Size(78, 20);
            this.lblTipoVer.TabIndex = 1;
            this.lblTipoVer.Text = "Verdura:";
            // 
            // cbVerdura
            // 
            this.cbVerdura.FormattingEnabled = true;
            this.cbVerdura.Location = new System.Drawing.Point(321, 67);
            this.cbVerdura.Name = "cbVerdura";
            this.cbVerdura.Size = new System.Drawing.Size(121, 21);
            this.cbVerdura.TabIndex = 2;
            this.cbVerdura.Text = "-";
            // 
            // cbFilaSembrar
            // 
            this.cbFilaSembrar.FormattingEnabled = true;
            this.cbFilaSembrar.Location = new System.Drawing.Point(321, 114);
            this.cbFilaSembrar.Name = "cbFilaSembrar";
            this.cbFilaSembrar.Size = new System.Drawing.Size(121, 21);
            this.cbFilaSembrar.TabIndex = 3;
            // 
            // lblFIla1
            // 
            this.lblFIla1.AutoSize = true;
            this.lblFIla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIla1.Location = new System.Drawing.Point(46, 187);
            this.lblFIla1.Name = "lblFIla1";
            this.lblFIla1.Size = new System.Drawing.Size(67, 24);
            this.lblFIla1.TabIndex = 5;
            this.lblFIla1.Text = "Fila 1:";
            // 
            // lblOpcFila
            // 
            this.lblOpcFila.AutoSize = true;
            this.lblOpcFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcFila.Location = new System.Drawing.Point(357, 91);
            this.lblOpcFila.Name = "lblOpcFila";
            this.lblOpcFila.Size = new System.Drawing.Size(43, 20);
            this.lblOpcFila.TabIndex = 9;
            this.lblOpcFila.Text = "Fila:";
            // 
            // btSembrar
            // 
            this.btSembrar.Location = new System.Drawing.Point(346, 141);
            this.btSembrar.Name = "btSembrar";
            this.btSembrar.Size = new System.Drawing.Size(75, 23);
            this.btSembrar.TabIndex = 10;
            this.btSembrar.Text = "Sembrar";
            this.btSembrar.UseVisualStyleBackColor = true;
            this.btSembrar.Click += new System.EventHandler(this.btSembrar_Click);
            // 
            // lblFila2
            // 
            this.lblFila2.AutoSize = true;
            this.lblFila2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFila2.Location = new System.Drawing.Point(366, 187);
            this.lblFila2.Name = "lblFila2";
            this.lblFila2.Size = new System.Drawing.Size(67, 24);
            this.lblFila2.TabIndex = 14;
            this.lblFila2.Text = "Fila 2:";
            // 
            // lblFila3
            // 
            this.lblFila3.AutoSize = true;
            this.lblFila3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFila3.Location = new System.Drawing.Point(673, 187);
            this.lblFila3.Name = "lblFila3";
            this.lblFila3.Size = new System.Drawing.Size(67, 24);
            this.lblFila3.TabIndex = 15;
            this.lblFila3.Text = "Fila 3:";
            // 
            // listFila1
            // 
            this.listFila1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listFila1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFila1.FormattingEnabled = true;
            this.listFila1.ItemHeight = 20;
            this.listFila1.Location = new System.Drawing.Point(22, 214);
            this.listFila1.Name = "listFila1";
            this.listFila1.Size = new System.Drawing.Size(120, 284);
            this.listFila1.TabIndex = 16;
            // 
            // listfila2
            // 
            this.listfila2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listfila2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listfila2.FormattingEnabled = true;
            this.listfila2.ItemHeight = 20;
            this.listfila2.Location = new System.Drawing.Point(341, 214);
            this.listfila2.Name = "listfila2";
            this.listfila2.Size = new System.Drawing.Size(120, 284);
            this.listfila2.TabIndex = 17;
            // 
            // listFIla3
            // 
            this.listFIla3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listFIla3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFIla3.FormattingEnabled = true;
            this.listFIla3.ItemHeight = 20;
            this.listFIla3.Location = new System.Drawing.Point(648, 214);
            this.listFIla3.Name = "listFIla3";
            this.listFIla3.Size = new System.Drawing.Size(120, 284);
            this.listFIla3.TabIndex = 18;
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(284, 537);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(221, 52);
            this.btVolver.TabIndex = 19;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // FrmSiembra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.listFIla3);
            this.Controls.Add(this.listfila2);
            this.Controls.Add(this.listFila1);
            this.Controls.Add(this.lblFila3);
            this.Controls.Add(this.lblFila2);
            this.Controls.Add(this.btSembrar);
            this.Controls.Add(this.lblOpcFila);
            this.Controls.Add(this.lblFIla1);
            this.Controls.Add(this.cbFilaSembrar);
            this.Controls.Add(this.cbVerdura);
            this.Controls.Add(this.lblTipoVer);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmSiembra";
            this.Text = "Siembra/Cosecha";
            this.Load += new System.EventHandler(this.FrmSiembra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoVer;
        private System.Windows.Forms.ComboBox cbVerdura;
        private System.Windows.Forms.ComboBox cbFilaSembrar;
        private System.Windows.Forms.Label lblFIla1;
        private System.Windows.Forms.Label lblOpcFila;
        private System.Windows.Forms.Button btSembrar;
        private System.Windows.Forms.Label lblFila2;
        private System.Windows.Forms.Label lblFila3;
        private System.Windows.Forms.ListBox listFila1;
        private System.Windows.Forms.ListBox listfila2;
        private System.Windows.Forms.ListBox listFIla3;
        private System.Windows.Forms.Button btVolver;
    }
}