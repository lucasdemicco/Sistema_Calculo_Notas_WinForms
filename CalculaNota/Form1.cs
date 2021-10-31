using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaNota
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Botão que insere as notas do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Cálculo da média
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal media = (nota1 + nota2 + nota3) / 3;

            media = decimal.Round(media, 2);

            //Adicionando dados no Grid
            dgvAlunos.Rows.Add();
            dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOME"].Value = txtNome.Text;
            dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTAUM"].Value = txtNota1.Text;
            dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTADOIS"].Value = txtNota2.Text;
            dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["NOTATRES"].Value = txtNota3.Text;
            dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Value = media;

            //Colorir as linhas de acordo com as notas
            if (media < 60)
            {
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.BackColor = Color.Red;
            }
            else
            {
                dgvAlunos.Rows[dgvAlunos.Rows.Count - 1].Cells["MEDIA"].Style.BackColor = Color.Green;
            }
        }
    }
}
