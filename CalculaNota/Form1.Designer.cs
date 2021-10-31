
namespace CalculaNota
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTAUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTADOIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTATRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToResizeColumns = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.NOTAUM,
            this.NOTADOIS,
            this.NOTATRES,
            this.MEDIA});
            this.dgvAlunos.Location = new System.Drawing.Point(12, 47);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.RowTemplate.Height = 25;
            this.dgvAlunos.Size = new System.Drawing.Size(742, 493);
            this.dgvAlunos.TabIndex = 0;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.FillWeight = 253.8071F;
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // NOTAUM
            // 
            this.NOTAUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOTAUM.FillWeight = 61.54816F;
            this.NOTAUM.HeaderText = "Nota 1";
            this.NOTAUM.Name = "NOTAUM";
            this.NOTAUM.ReadOnly = true;
            // 
            // NOTADOIS
            // 
            this.NOTADOIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOTADOIS.FillWeight = 61.54816F;
            this.NOTADOIS.HeaderText = "Nota 2";
            this.NOTADOIS.Name = "NOTADOIS";
            this.NOTADOIS.ReadOnly = true;
            // 
            // NOTATRES
            // 
            this.NOTATRES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOTATRES.FillWeight = 61.54816F;
            this.NOTATRES.HeaderText = "Nota 3";
            this.NOTATRES.Name = "NOTATRES";
            this.NOTATRES.ReadOnly = true;
            // 
            // MEDIA
            // 
            this.MEDIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MEDIA.FillWeight = 61.54816F;
            this.MEDIA.HeaderText = "Média";
            this.MEDIA.Name = "MEDIA";
            this.MEDIA.ReadOnly = true;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(301, 12);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.PlaceholderText = "1ª Nota";
            this.txtNota1.Size = new System.Drawing.Size(100, 23);
            this.txtNota1.TabIndex = 1;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(424, 12);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.PlaceholderText = "2ª Nota";
            this.txtNota2.Size = new System.Drawing.Size(100, 23);
            this.txtNota2.TabIndex = 2;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(541, 12);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.PlaceholderText = "3ª Nota";
            this.txtNota3.Size = new System.Drawing.Size(100, 23);
            this.txtNota3.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome do Aluno";
            this.txtNome.Size = new System.Drawing.Size(268, 23);
            this.txtNome.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(659, 11);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(95, 24);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(12, 551);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(118, 24);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Resultado Geral";
            this.btnResultado.UseVisualStyleBackColor = true;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(636, 551);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(118, 24);
            this.btnMedia.TabIndex = 7;
            this.btnMedia.Text = "Média dos Alunos";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 587);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.dgvAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Notas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTAUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTADOIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTATRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIA;
    }
}

