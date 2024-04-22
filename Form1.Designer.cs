namespace CalculadoradoTiagoL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonMais = new System.Windows.Forms.Button();
            this.buttonTres = new System.Windows.Forms.Button();
            this.buttonDois = new System.Windows.Forms.Button();
            this.buttonUm = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonSeis = new System.Windows.Forms.Button();
            this.buttonCinco = new System.Windows.Forms.Button();
            this.buttonQuatro = new System.Windows.Forms.Button();
            this.buttonMultiple = new System.Windows.Forms.Button();
            this.buttonNove = new System.Windows.Forms.Button();
            this.buttonOito = new System.Windows.Forms.Button();
            this.buttonSete = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttomLimpar = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonVirgula = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 532);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDisplay.Font = new System.Drawing.Font("Bahnschrift SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(3, 3);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(372, 127);
            this.textBoxDisplay.TabIndex = 1;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonIgual, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonMais, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonTres, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonDois, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonUm, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonMenos, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonSeis, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonCinco, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonQuatro, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonMultiple, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonNove, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonOito, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSete, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonDiv, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCopiar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonApagar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttomLimpar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonZero, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonVirgula, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 136);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 393);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonIgual
            // 
            this.buttonIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIgual.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.Location = new System.Drawing.Point(282, 315);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(87, 75);
            this.buttonIgual.TabIndex = 21;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonMais
            // 
            this.buttonMais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMais.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMais.Location = new System.Drawing.Point(282, 237);
            this.buttonMais.Name = "buttonMais";
            this.buttonMais.Size = new System.Drawing.Size(87, 72);
            this.buttonMais.TabIndex = 17;
            this.buttonMais.Text = "+";
            this.buttonMais.UseVisualStyleBackColor = true;
            this.buttonMais.Click += new System.EventHandler(this.buttonMais_Click);
            // 
            // buttonTres
            // 
            this.buttonTres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTres.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTres.Location = new System.Drawing.Point(189, 237);
            this.buttonTres.Name = "buttonTres";
            this.buttonTres.Size = new System.Drawing.Size(87, 72);
            this.buttonTres.TabIndex = 16;
            this.buttonTres.Text = "3";
            this.buttonTres.UseVisualStyleBackColor = true;
            this.buttonTres.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonDois
            // 
            this.buttonDois.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDois.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDois.Location = new System.Drawing.Point(96, 237);
            this.buttonDois.Name = "buttonDois";
            this.buttonDois.Size = new System.Drawing.Size(87, 72);
            this.buttonDois.TabIndex = 15;
            this.buttonDois.Text = "2";
            this.buttonDois.UseVisualStyleBackColor = true;
            this.buttonDois.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonUm
            // 
            this.buttonUm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUm.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUm.Location = new System.Drawing.Point(3, 237);
            this.buttonUm.Name = "buttonUm";
            this.buttonUm.Size = new System.Drawing.Size(87, 72);
            this.buttonUm.TabIndex = 14;
            this.buttonUm.Text = "1";
            this.buttonUm.UseVisualStyleBackColor = true;
            this.buttonUm.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonMenos
            // 
            this.buttonMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMenos.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenos.Location = new System.Drawing.Point(282, 159);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(87, 72);
            this.buttonMenos.TabIndex = 13;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            this.buttonMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // buttonSeis
            // 
            this.buttonSeis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSeis.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeis.Location = new System.Drawing.Point(189, 159);
            this.buttonSeis.Name = "buttonSeis";
            this.buttonSeis.Size = new System.Drawing.Size(87, 72);
            this.buttonSeis.TabIndex = 12;
            this.buttonSeis.Text = "6";
            this.buttonSeis.UseVisualStyleBackColor = true;
            this.buttonSeis.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonCinco
            // 
            this.buttonCinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCinco.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinco.Location = new System.Drawing.Point(96, 159);
            this.buttonCinco.Name = "buttonCinco";
            this.buttonCinco.Size = new System.Drawing.Size(87, 72);
            this.buttonCinco.TabIndex = 11;
            this.buttonCinco.Text = "5";
            this.buttonCinco.UseVisualStyleBackColor = true;
            this.buttonCinco.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonQuatro
            // 
            this.buttonQuatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonQuatro.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuatro.Location = new System.Drawing.Point(3, 159);
            this.buttonQuatro.Name = "buttonQuatro";
            this.buttonQuatro.Size = new System.Drawing.Size(87, 72);
            this.buttonQuatro.TabIndex = 10;
            this.buttonQuatro.Text = "4";
            this.buttonQuatro.UseVisualStyleBackColor = true;
            this.buttonQuatro.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonMultiple
            // 
            this.buttonMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiple.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiple.Location = new System.Drawing.Point(282, 81);
            this.buttonMultiple.Name = "buttonMultiple";
            this.buttonMultiple.Size = new System.Drawing.Size(87, 72);
            this.buttonMultiple.TabIndex = 9;
            this.buttonMultiple.Text = "x";
            this.buttonMultiple.UseVisualStyleBackColor = true;
            this.buttonMultiple.Click += new System.EventHandler(this.buttonMultiple_Click);
            // 
            // buttonNove
            // 
            this.buttonNove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNove.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNove.Location = new System.Drawing.Point(189, 81);
            this.buttonNove.Name = "buttonNove";
            this.buttonNove.Size = new System.Drawing.Size(87, 72);
            this.buttonNove.TabIndex = 8;
            this.buttonNove.Text = "9";
            this.buttonNove.UseVisualStyleBackColor = true;
            this.buttonNove.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonOito
            // 
            this.buttonOito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOito.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOito.Location = new System.Drawing.Point(96, 81);
            this.buttonOito.Name = "buttonOito";
            this.buttonOito.Size = new System.Drawing.Size(87, 72);
            this.buttonOito.TabIndex = 7;
            this.buttonOito.Text = "8";
            this.buttonOito.UseVisualStyleBackColor = true;
            this.buttonOito.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonSete
            // 
            this.buttonSete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSete.Location = new System.Drawing.Point(3, 81);
            this.buttonSete.Name = "buttonSete";
            this.buttonSete.Size = new System.Drawing.Size(87, 72);
            this.buttonSete.TabIndex = 6;
            this.buttonSete.Text = "7";
            this.buttonSete.UseVisualStyleBackColor = true;
            this.buttonSete.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDiv.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(282, 3);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(87, 72);
            this.buttonDiv.TabIndex = 5;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCopiar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopiar.Location = new System.Drawing.Point(189, 3);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(87, 72);
            this.buttonCopiar.TabIndex = 4;
            this.buttonCopiar.Text = "Copiar";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonApagar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.Location = new System.Drawing.Point(96, 3);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(87, 72);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttomLimpar
            // 
            this.buttomLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttomLimpar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttomLimpar.Location = new System.Drawing.Point(3, 3);
            this.buttomLimpar.Name = "buttomLimpar";
            this.buttomLimpar.Size = new System.Drawing.Size(87, 72);
            this.buttomLimpar.TabIndex = 2;
            this.buttomLimpar.Text = "Limpar";
            this.buttomLimpar.UseVisualStyleBackColor = true;
            this.buttomLimpar.Click += new System.EventHandler(this.buttomLimpar_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonZero.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(96, 315);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(87, 75);
            this.buttonZero.TabIndex = 19;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonVirgula
            // 
            this.buttonVirgula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVirgula.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirgula.Location = new System.Drawing.Point(189, 315);
            this.buttonVirgula.Name = "buttonVirgula";
            this.buttonVirgula.Size = new System.Drawing.Size(87, 75);
            this.buttonVirgula.TabIndex = 20;
            this.buttonVirgula.Text = ",";
            this.buttonVirgula.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calculadora Do Tiago L";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttomLimpar;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonVirgula;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonMais;
        private System.Windows.Forms.Button buttonTres;
        private System.Windows.Forms.Button buttonDois;
        private System.Windows.Forms.Button buttonUm;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonSeis;
        private System.Windows.Forms.Button buttonCinco;
        private System.Windows.Forms.Button buttonQuatro;
        private System.Windows.Forms.Button buttonMultiple;
        private System.Windows.Forms.Button buttonNove;
        private System.Windows.Forms.Button buttonOito;
        private System.Windows.Forms.Button buttonSete;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button buttonApagar;
    }
}

