using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroCursos : MaterialForm
    {
        string cursosFileName = "cursos.txt";
        bool isAlteracaoCurso = false;
        int indexSelecionadoCurso = 0;
        public FormCadastroCursos()
        {
            InitializeComponent();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void airForm1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Código do curso obrigatória!");
                txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome obrigatório!");
                txtNome.Focus();
                return false;
            }
            return true;
        }

        private void Salvar()
        {
            var line = $"{txtCodigo.Text};" +
                       $"{txtNome.Text};" +
                       $"{cboNivel.Text};" +
                       $"{cboDuracao.Text};" +
                       $"{cboPeriodo.Text};" +
                       $"{cboArea.Text};";

            if (!isAlteracaoCurso) //novo registro
            {
                var file = new StreamWriter(cursosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else //alteração
            {
                string[] alunos = File.ReadAllLines(cursosFileName);
                alunos[indexSelecionadoCurso] = line;
                File.WriteAllLines(cursosFileName, alunos);
            }
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            isAlteracaoCurso = false;
            foreach (var control in tabPageCadastroCurso.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            mlvCursos.Columns.Clear();
            mlvCursos.Items.Clear();
            mlvCursos.Columns.Add("Código");
            mlvCursos.Columns.Add("Nome");
            mlvCursos.Columns.Add("Nível");
            mlvCursos.Columns.Add("Duração sem.");
            mlvCursos.Columns.Add("Período");
            mlvCursos.Columns.Add("Área");

            string[] cursos = File.ReadAllLines(cursosFileName);

            foreach (string curso in cursos)
            {
                var campos = curso.Split(';');
                mlvCursos.Items.Add(new ListViewItem(campos));
            }
            mlvCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }

        private void Editar()
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                indexSelecionadoCurso = mlvCursos.SelectedItems[0].Index;
                isAlteracaoCurso = true;
                var item = mlvCursos.SelectedItems[0];
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
                cboNivel.Text = item.SubItems[2].Text;
                cboDuracao.Text = item.SubItems[3].Text;
                cboPeriodo.Text = item.SubItems[4].Text;
                cboArea.Text = item.SubItems[5].Text;
                TabControlCadastroCurso.SelectedIndex = 0;
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum Curso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mlvCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void mlvCursos_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Editar();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPageConsulta_Click(object sender, EventArgs e)
        {

        }

        private void cboDuracao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario()) //Faz a validação
            {
                Salvar(); //chama o método para salvar em arquivo
                TabControlCadastroCurso.SelectedIndex = 1; //muda para a página de consulta
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \r\n" + "Deseja cancelar?",
                "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastroCurso.SelectedIndex = 1;
            }
        }
        private void buttonNovo_Click_1(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastroCurso.SelectedIndex = 0;
            txtCodigo.Focus();
        }
        private void Excluir()
        {
            List<string> alunos = File.ReadAllLines(cursosFileName).ToList();
            alunos.RemoveAt(indexSelecionadoCurso);
            File.WriteAllLines(cursosFileName, alunos);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente deletar o curso selecionado?",
                    "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionadoCurso = mlvCursos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
