namespace ProjetoCadastro
{
    partial class FormCadastraCurso
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
            tabControlCursos = new ReaLTaiizor.Controls.MaterialTabControl();
            tabCadastraCurso = new TabPage();
            btnConfirmaCurso = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelaCurso = new ReaLTaiizor.Controls.MaterialButton();
            cboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            cboSemestres = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNomeCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabConsultaCurso = new TabPage();
            tabControlCursos.SuspendLayout();
            tabCadastraCurso.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCursos
            // 
            tabControlCursos.Controls.Add(tabCadastraCurso);
            tabControlCursos.Controls.Add(tabConsultaCurso);
            tabControlCursos.Depth = 0;
            tabControlCursos.Dock = DockStyle.Fill;
            tabControlCursos.Location = new Point(3, 64);
            tabControlCursos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCursos.Multiline = true;
            tabControlCursos.Name = "tabControlCursos";
            tabControlCursos.SelectedIndex = 0;
            tabControlCursos.Size = new Size(922, 616);
            tabControlCursos.TabIndex = 0;
            // 
            // tabCadastraCurso
            // 
            tabCadastraCurso.Controls.Add(btnConfirmaCurso);
            tabCadastraCurso.Controls.Add(btnCancelaCurso);
            tabCadastraCurso.Controls.Add(cboArea);
            tabCadastraCurso.Controls.Add(cboSemestres);
            tabCadastraCurso.Controls.Add(cboPeriodo);
            tabCadastraCurso.Controls.Add(cboNivel);
            tabCadastraCurso.Controls.Add(txtNomeCurso);
            tabCadastraCurso.Controls.Add(txtCodCurso);
            tabCadastraCurso.Location = new Point(4, 29);
            tabCadastraCurso.Name = "tabCadastraCurso";
            tabCadastraCurso.Padding = new Padding(3);
            tabCadastraCurso.Size = new Size(914, 583);
            tabCadastraCurso.TabIndex = 0;
            tabCadastraCurso.Text = "Cadastrar";
            tabCadastraCurso.UseVisualStyleBackColor = true;
            // 
            // btnConfirmaCurso
            // 
            btnConfirmaCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmaCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmaCurso.Depth = 0;
            btnConfirmaCurso.HighEmphasis = true;
            btnConfirmaCurso.Icon = null;
            btnConfirmaCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnConfirmaCurso.Location = new Point(543, 499);
            btnConfirmaCurso.Margin = new Padding(4, 6, 4, 6);
            btnConfirmaCurso.MinimumSize = new Size(150, 60);
            btnConfirmaCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConfirmaCurso.Name = "btnConfirmaCurso";
            btnConfirmaCurso.NoAccentTextColor = Color.Empty;
            btnConfirmaCurso.Size = new Size(150, 60);
            btnConfirmaCurso.TabIndex = 7;
            btnConfirmaCurso.Text = "Confirma";
            btnConfirmaCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmaCurso.UseAccentColor = false;
            btnConfirmaCurso.UseVisualStyleBackColor = true;
            btnConfirmaCurso.Click += btnConfirmaCurso_Click;
            // 
            // btnCancelaCurso
            // 
            btnCancelaCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelaCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelaCurso.Depth = 0;
            btnCancelaCurso.HighEmphasis = true;
            btnCancelaCurso.Icon = null;
            btnCancelaCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelaCurso.Location = new Point(222, 499);
            btnCancelaCurso.Margin = new Padding(4, 6, 4, 6);
            btnCancelaCurso.MinimumSize = new Size(150, 60);
            btnCancelaCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelaCurso.Name = "btnCancelaCurso";
            btnCancelaCurso.NoAccentTextColor = Color.Empty;
            btnCancelaCurso.Size = new Size(150, 60);
            btnCancelaCurso.TabIndex = 6;
            btnCancelaCurso.Text = "Cancela";
            btnCancelaCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelaCurso.UseAccentColor = false;
            btnCancelaCurso.UseVisualStyleBackColor = true;
            btnCancelaCurso.Click += btnCancelaCurso_Click;
            // 
            // cboArea
            // 
            cboArea.AutoResize = false;
            cboArea.BackColor = Color.FromArgb(255, 255, 255);
            cboArea.Depth = 0;
            cboArea.DrawMode = DrawMode.OwnerDrawVariable;
            cboArea.DropDownHeight = 174;
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.DropDownWidth = 121;
            cboArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboArea.FormattingEnabled = true;
            cboArea.Hint = "Área do Curso";
            cboArea.IntegralHeight = false;
            cboArea.ItemHeight = 43;
            cboArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Industria", "Administração" });
            cboArea.Location = new Point(222, 397);
            cboArea.MaxDropDownItems = 4;
            cboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(471, 49);
            cboArea.StartIndex = 0;
            cboArea.TabIndex = 5;
            // 
            // cboSemestres
            // 
            cboSemestres.AutoResize = false;
            cboSemestres.BackColor = Color.FromArgb(255, 255, 255);
            cboSemestres.Depth = 0;
            cboSemestres.DrawMode = DrawMode.OwnerDrawVariable;
            cboSemestres.DropDownHeight = 174;
            cboSemestres.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemestres.DropDownWidth = 121;
            cboSemestres.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSemestres.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSemestres.FormattingEnabled = true;
            cboSemestres.Hint = "Duração em Semestres";
            cboSemestres.IntegralHeight = false;
            cboSemestres.ItemHeight = 43;
            cboSemestres.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cboSemestres.Location = new Point(222, 253);
            cboSemestres.MaxDropDownItems = 4;
            cboSemestres.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSemestres.Name = "cboSemestres";
            cboSemestres.Size = new Size(471, 49);
            cboSemestres.StartIndex = 0;
            cboSemestres.TabIndex = 4;
            // 
            // cboPeriodo
            // 
            cboPeriodo.AutoResize = false;
            cboPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            cboPeriodo.Depth = 0;
            cboPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            cboPeriodo.DropDownHeight = 174;
            cboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeriodo.DropDownWidth = 121;
            cboPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPeriodo.FormattingEnabled = true;
            cboPeriodo.Hint = "Periodo";
            cboPeriodo.IntegralHeight = false;
            cboPeriodo.ItemHeight = 43;
            cboPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            cboPeriodo.Location = new Point(222, 323);
            cboPeriodo.MaxDropDownItems = 4;
            cboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPeriodo.Name = "cboPeriodo";
            cboPeriodo.Size = new Size(471, 49);
            cboPeriodo.StartIndex = 0;
            cboPeriodo.TabIndex = 3;
            cboPeriodo.SelectedIndexChanged += materialComboBox2_SelectedIndexChanged;
            // 
            // cboNivel
            // 
            cboNivel.AutoResize = false;
            cboNivel.BackColor = Color.FromArgb(255, 255, 255);
            cboNivel.Depth = 0;
            cboNivel.DrawMode = DrawMode.OwnerDrawVariable;
            cboNivel.DropDownHeight = 174;
            cboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNivel.DropDownWidth = 121;
            cboNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNivel.FormattingEnabled = true;
            cboNivel.Hint = "Nível do Curso";
            cboNivel.IntegralHeight = false;
            cboNivel.ItemHeight = 43;
            cboNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            cboNivel.Location = new Point(222, 181);
            cboNivel.MaxDropDownItems = 4;
            cboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(471, 49);
            cboNivel.StartIndex = 0;
            cboNivel.TabIndex = 2;
            // 
            // txtNomeCurso
            // 
            txtNomeCurso.AnimateReadOnly = false;
            txtNomeCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeCurso.BackgroundImageLayout = ImageLayout.None;
            txtNomeCurso.CharacterCasing = CharacterCasing.Normal;
            txtNomeCurso.Depth = 0;
            txtNomeCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCurso.HideSelection = true;
            txtNomeCurso.Hint = "Nome do Curso";
            txtNomeCurso.LeadingIcon = null;
            txtNomeCurso.Location = new Point(222, 110);
            txtNomeCurso.MaxLength = 32767;
            txtNomeCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeCurso.Name = "txtNomeCurso";
            txtNomeCurso.PasswordChar = '\0';
            txtNomeCurso.PrefixSuffixText = null;
            txtNomeCurso.ReadOnly = false;
            txtNomeCurso.RightToLeft = RightToLeft.No;
            txtNomeCurso.SelectedText = "";
            txtNomeCurso.SelectionLength = 0;
            txtNomeCurso.SelectionStart = 0;
            txtNomeCurso.ShortcutsEnabled = true;
            txtNomeCurso.Size = new Size(471, 48);
            txtNomeCurso.TabIndex = 1;
            txtNomeCurso.TabStop = false;
            txtNomeCurso.TextAlign = HorizontalAlignment.Left;
            txtNomeCurso.TrailingIcon = null;
            txtNomeCurso.UseSystemPasswordChar = false;
            // 
            // txtCodCurso
            // 
            txtCodCurso.AnimateReadOnly = false;
            txtCodCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtCodCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtCodCurso.BackgroundImageLayout = ImageLayout.None;
            txtCodCurso.CharacterCasing = CharacterCasing.Normal;
            txtCodCurso.Depth = 0;
            txtCodCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodCurso.HideSelection = true;
            txtCodCurso.Hint = "Código do Curso";
            txtCodCurso.LeadingIcon = null;
            txtCodCurso.Location = new Point(222, 37);
            txtCodCurso.MaxLength = 32767;
            txtCodCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodCurso.Name = "txtCodCurso";
            txtCodCurso.PasswordChar = '\0';
            txtCodCurso.PrefixSuffixText = null;
            txtCodCurso.ReadOnly = false;
            txtCodCurso.RightToLeft = RightToLeft.No;
            txtCodCurso.SelectedText = "";
            txtCodCurso.SelectionLength = 0;
            txtCodCurso.SelectionStart = 0;
            txtCodCurso.ShortcutsEnabled = true;
            txtCodCurso.Size = new Size(471, 48);
            txtCodCurso.TabIndex = 0;
            txtCodCurso.TabStop = false;
            txtCodCurso.TextAlign = HorizontalAlignment.Left;
            txtCodCurso.TrailingIcon = null;
            txtCodCurso.UseSystemPasswordChar = false;
            txtCodCurso.Click += materialTextBoxEdit1_Click;
            // 
            // tabConsultaCurso
            // 
            tabConsultaCurso.Location = new Point(4, 29);
            tabConsultaCurso.Name = "tabConsultaCurso";
            tabConsultaCurso.Padding = new Padding(3);
            tabConsultaCurso.Size = new Size(914, 583);
            tabConsultaCurso.TabIndex = 1;
            tabConsultaCurso.Text = "Consulta";
            tabConsultaCurso.UseVisualStyleBackColor = true;
            // 
            // FormCadastraCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 683);
            Controls.Add(tabControlCursos);
            DrawerTabControl = tabControlCursos;
            Name = "FormCadastraCurso";
            Text = "Cadastro de Cursos";
            Load += FormCadastraCurso_Load;
            tabControlCursos.ResumeLayout(false);
            tabCadastraCurso.ResumeLayout(false);
            tabCadastraCurso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCursos;
        private TabPage tabCadastraCurso;
        private TabPage tabConsultaCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodCurso;
        private ReaLTaiizor.Controls.MaterialComboBox cboPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox cboNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCurso;
        private ReaLTaiizor.Controls.MaterialComboBox cboSemestres;
        private ReaLTaiizor.Controls.MaterialComboBox cboArea;
        private ReaLTaiizor.Controls.MaterialButton btnConfirmaCurso;
        private ReaLTaiizor.Controls.MaterialButton btnCancelaCurso;
    }
}