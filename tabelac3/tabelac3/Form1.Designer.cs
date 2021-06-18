
namespace tabelac3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.txtboxnome = new System.Windows.Forms.TextBox();
            this.txtboxpreco = new System.Windows.Forms.TextBox();
            this.txtboxobs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridtotal = new System.Windows.Forms.DataGridView();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtnome_pesquisar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridtotal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxid
            // 
            this.txtboxid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtboxid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxid.Location = new System.Drawing.Point(107, 28);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(138, 22);
            this.txtboxid.TabIndex = 0;
            // 
            // txtboxnome
            // 
            this.txtboxnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtboxnome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxnome.Location = new System.Drawing.Point(303, 28);
            this.txtboxnome.Name = "txtboxnome";
            this.txtboxnome.Size = new System.Drawing.Size(132, 22);
            this.txtboxnome.TabIndex = 1;
            // 
            // txtboxpreco
            // 
            this.txtboxpreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtboxpreco.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxpreco.Location = new System.Drawing.Point(488, 28);
            this.txtboxpreco.Name = "txtboxpreco";
            this.txtboxpreco.Size = new System.Drawing.Size(138, 22);
            this.txtboxpreco.TabIndex = 2;
            // 
            // txtboxobs
            // 
            this.txtboxobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtboxobs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxobs.Location = new System.Drawing.Point(668, 28);
            this.txtboxobs.Name = "txtboxobs";
            this.txtboxobs.Size = new System.Drawing.Size(134, 22);
            this.txtboxobs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID DO PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(303, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOME DO PRODUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(488, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "PREÇO DO PRODUTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(689, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "OBSERVAÇÕES";
            // 
            // gridtotal
            // 
            this.gridtotal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.gridtotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtotal.Location = new System.Drawing.Point(40, 169);
            this.gridtotal.Name = "gridtotal";
            this.gridtotal.RowTemplate.Height = 25;
            this.gridtotal.Size = new System.Drawing.Size(721, 324);
            this.gridtotal.TabIndex = 9;
            this.gridtotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridtotal_CellContentClick_1);
            this.gridtotal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridtotal_CellDoubleClick);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnsalvar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsalvar.Location = new System.Drawing.Point(379, 68);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(86, 23);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "ADICIONAR";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnpesquisar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnpesquisar.Location = new System.Drawing.Point(470, 140);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(88, 23);
            this.btnpesquisar.TabIndex = 12;
            this.btnpesquisar.Text = "PESQUISAR";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtnome_pesquisar
            // 
            this.txtnome_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txtnome_pesquisar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnome_pesquisar.Location = new System.Drawing.Point(248, 141);
            this.txtnome_pesquisar.Name = "txtnome_pesquisar";
            this.txtnome_pesquisar.Size = new System.Drawing.Size(216, 22);
            this.txtnome_pesquisar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(248, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "DIGITE O NOME DO PRODUTO EM QUE PROCURA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnsalvar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtboxobs);
            this.panel1.Controls.Add(this.txtboxpreco);
            this.panel1.Controls.Add(this.txtboxnome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtboxid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-14, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 100);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tabelac3.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point(26, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(11)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnome_pesquisar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.gridtotal);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(11)))), ((int)(((byte)(19)))));
            this.Name = "Form1";
            this.Text = "Admin / E-Commerce";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtotal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.TextBox txtboxnome;
        private System.Windows.Forms.TextBox txtboxpreco;
        private System.Windows.Forms.TextBox txtboxobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridtotal;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtnome_pesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

