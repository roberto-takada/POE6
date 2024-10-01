using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;

namespace ProjetoCadastro
{
    public partial class FormCadastraCurso : MaterialForm
    {

        string cursosFileName = "cursos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCadastraCurso()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabCadastraCurso.Controls)
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

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtCodCurso.Text))
            {
                MessageBox.Show("Código do Curso inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCurso.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNomeCurso.Text))
            {
                MessageBox.Show("Nome do Curso inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeCurso.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboNivel.Text))
            {
                MessageBox.Show("Nível do Curso inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNivel.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboSemestres.Text))
            {
                MessageBox.Show("Semestre do Curso inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSemestres.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboPeriodo.Text))
            {
                MessageBox.Show("Periodo do Curso inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPeriodo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboArea.Text))
            {
                MessageBox.Show("Matricula inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboArea.Focus();
                return false;
            }

            return true;
        }

        private void Salvar()
        {
            var line = $"{txtCodCurso.Text};" + $"{txtNomeCurso.Text};" + $"{cboNivel.Text};" + $"{cboPeriodo.Text};" + $"{cboSemestres.Text};" + $"{cboArea.Text};";
            if (!isAlteracao)
            {
                var file = new StreamWriter(cursosFileName, true);
                file.WriteLine(line);
                file.Close();
                tabControlCursos.SelectedIndex = 1;
            }
            else
            {
                string[] alunos = File.ReadAllLines(cursosFileName);
                alunos[indexSelecionado] = line;
                File.WriteAllLines(cursosFileName, alunos);
                tabControlCursos.SelectedIndex = 1;
            }
        }

        private void FormCadastraCurso_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBoxEdit1_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmaCurso_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                tabControlCursos.SelectedIndex = 1;
            }
        }

        private void btnCancelaCurso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas. \r\n" + "Deseja cancelar ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCursos.SelectedIndex = 1;
            }
        }
    }
}
