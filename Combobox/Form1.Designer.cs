namespace Combobox
{
    partial class numero
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
            this.sair = new System.Windows.Forms.Button();
            this.buttonnumero = new System.Windows.Forms.Button();
            this.comboescolha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelresposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(472, 94);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 0;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = true;
            // 
            // buttonnumero
            // 
            this.buttonnumero.Location = new System.Drawing.Point(292, 22);
            this.buttonnumero.Name = "buttonnumero";
            this.buttonnumero.Size = new System.Drawing.Size(255, 23);
            this.buttonnumero.TabIndex = 1;
            this.buttonnumero.Text = "Escolha um numero e clique aqui!";
            this.buttonnumero.UseVisualStyleBackColor = true;
            this.buttonnumero.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // comboescolha
            // 
            this.comboescolha.FormattingEnabled = true;
            this.comboescolha.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboescolha.Location = new System.Drawing.Point(192, 22);
            this.comboescolha.Name = "comboescolha";
            this.comboescolha.Size = new System.Drawing.Size(80, 21);
            this.comboescolha.TabIndex = 2;
            this.comboescolha.SelectedIndexChanged += new System.EventHandler(this.comboescolha_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha um número e clique 1 a 12:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelresposta
            // 
            this.labelresposta.AutoSize = true;
            this.labelresposta.Location = new System.Drawing.Point(34, 56);
            this.labelresposta.Name = "labelresposta";
            this.labelresposta.Size = new System.Drawing.Size(0, 13);
            this.labelresposta.TabIndex = 4;
            // 
            // numero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(554, 129);
            this.Controls.Add(this.labelresposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboescolha);
            this.Controls.Add(this.buttonnumero);
            this.Controls.Add(this.sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "numero";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button buttonnumero;
        private System.Windows.Forms.ComboBox comboescolha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelresposta;
    }
}

