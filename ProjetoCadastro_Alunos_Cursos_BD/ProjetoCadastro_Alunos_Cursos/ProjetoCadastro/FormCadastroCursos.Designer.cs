namespace ProjetoCadastro
{
    partial class FormCadastroCursos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCursos));
            TabControlCadastroCurso = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastroCurso = new TabPage();
            buttonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            buttonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cboDuracao = new ReaLTaiizor.Controls.MaterialComboBox();
            cboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsultaCurso = new TabPage();
            buttonExcluir = new ReaLTaiizor.Controls.MaterialButton();
            buttonEditar = new ReaLTaiizor.Controls.MaterialButton();
            buttonNovo = new ReaLTaiizor.Controls.MaterialButton();
            mlvCursos = new ReaLTaiizor.Controls.MaterialListView();
            imageList1 = new ImageList(components);
            TabControlCadastroCurso.SuspendLayout();
            tabPageCadastroCurso.SuspendLayout();
            tabPageConsultaCurso.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastroCurso
            // 
            TabControlCadastroCurso.Controls.Add(tabPageCadastroCurso);
            TabControlCadastroCurso.Controls.Add(tabPageConsultaCurso);
            TabControlCadastroCurso.Depth = 0;
            TabControlCadastroCurso.Dock = DockStyle.Fill;
            TabControlCadastroCurso.ImageList = imageList1;
            TabControlCadastroCurso.Location = new Point(3, 64);
            TabControlCadastroCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastroCurso.Multiline = true;
            TabControlCadastroCurso.Name = "TabControlCadastroCurso";
            TabControlCadastroCurso.SelectedIndex = 0;
            TabControlCadastroCurso.Size = new Size(794, 383);
            TabControlCadastroCurso.TabIndex = 0;
            // 
            // tabPageCadastroCurso
            // 
            tabPageCadastroCurso.Controls.Add(buttonCancelar);
            tabPageCadastroCurso.Controls.Add(buttonSalvar);
            tabPageCadastroCurso.Controls.Add(cboArea);
            tabPageCadastroCurso.Controls.Add(cboPeriodo);
            tabPageCadastroCurso.Controls.Add(cboDuracao);
            tabPageCadastroCurso.Controls.Add(cboNivel);
            tabPageCadastroCurso.Controls.Add(txtNome);
            tabPageCadastroCurso.Controls.Add(txtCodigo);
            tabPageCadastroCurso.ImageKey = "form.png";
            tabPageCadastroCurso.Location = new Point(4, 31);
            tabPageCadastroCurso.Name = "tabPageCadastroCurso";
            tabPageCadastroCurso.Padding = new Padding(3);
            tabPageCadastroCurso.Size = new Size(786, 348);
            tabPageCadastroCurso.TabIndex = 0;
            tabPageCadastroCurso.Text = "Cadastro";
            tabPageCadastroCurso.UseVisualStyleBackColor = true;
            tabPageCadastroCurso.Click += tabPage1_Click_1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonCancelar.Depth = 0;
            buttonCancelar.HighEmphasis = true;
            buttonCancelar.Icon = null;
            buttonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonCancelar.Location = new Point(470, 322);
            buttonCancelar.Margin = new Padding(4, 6, 4, 6);
            buttonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.NoAccentTextColor = Color.Empty;
            buttonCancelar.Size = new Size(96, 36);
            buttonCancelar.TabIndex = 20;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonCancelar.UseAccentColor = false;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonSalvar.Depth = 0;
            buttonSalvar.HighEmphasis = true;
            buttonSalvar.Icon = null;
            buttonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonSalvar.Location = new Point(585, 322);
            buttonSalvar.Margin = new Padding(4, 6, 4, 6);
            buttonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.NoAccentTextColor = Color.Empty;
            buttonSalvar.Size = new Size(76, 36);
            buttonSalvar.TabIndex = 19;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonSalvar.UseAccentColor = false;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
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
            cboArea.Location = new Point(401, 256);
            cboArea.MaxDropDownItems = 4;
            cboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(260, 49);
            cboArea.StartIndex = 0;
            cboArea.TabIndex = 18;
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
            cboPeriodo.Hint = "Período do Curso";
            cboPeriodo.IntegralHeight = false;
            cboPeriodo.ItemHeight = 43;
            cboPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            cboPeriodo.Location = new Point(401, 163);
            cboPeriodo.MaxDropDownItems = 4;
            cboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPeriodo.Name = "cboPeriodo";
            cboPeriodo.Size = new Size(260, 49);
            cboPeriodo.StartIndex = 0;
            cboPeriodo.TabIndex = 17;
            // 
            // cboDuracao
            // 
            cboDuracao.AutoResize = false;
            cboDuracao.BackColor = Color.FromArgb(255, 255, 255);
            cboDuracao.Depth = 0;
            cboDuracao.DrawMode = DrawMode.OwnerDrawVariable;
            cboDuracao.DropDownHeight = 174;
            cboDuracao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDuracao.DropDownWidth = 121;
            cboDuracao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboDuracao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboDuracao.FormattingEnabled = true;
            cboDuracao.Hint = "Duração em semestres";
            cboDuracao.IntegralHeight = false;
            cboDuracao.ItemHeight = 43;
            cboDuracao.Items.AddRange(new object[] { "1 Semestre", "2 Semestres", "3 Semestres", "4 Semestres", "5 Semestres", "6 Semestres", "7 Semestres", "8 Semestres", "9 Semestres", "10 Semestres" });
            cboDuracao.Location = new Point(3, 256);
            cboDuracao.MaxDropDownItems = 4;
            cboDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboDuracao.Name = "cboDuracao";
            cboDuracao.Size = new Size(260, 49);
            cboDuracao.StartIndex = 0;
            cboDuracao.TabIndex = 16;
            cboDuracao.SelectedIndexChanged += cboDuracao_SelectedIndexChanged;
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
            cboNivel.ForeColor = Color.Black;
            cboNivel.FormattingEnabled = true;
            cboNivel.Hint = "Nível do Curso";
            cboNivel.IntegralHeight = false;
            cboNivel.ItemHeight = 43;
            cboNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            cboNivel.Location = new Point(3, 163);
            cboNivel.MaxDropDownItems = 4;
            cboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(260, 49);
            cboNivel.StartIndex = 0;
            cboNivel.TabIndex = 15;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(3, 88);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(658, 48);
            txtNome.TabIndex = 14;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Código do Curso";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(6, 22);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(446, 48);
            txtCodigo.TabIndex = 13;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // tabPageConsultaCurso
            // 
            tabPageConsultaCurso.Controls.Add(buttonExcluir);
            tabPageConsultaCurso.Controls.Add(buttonEditar);
            tabPageConsultaCurso.Controls.Add(buttonNovo);
            tabPageConsultaCurso.Controls.Add(mlvCursos);
            tabPageConsultaCurso.ImageKey = "search.png";
            tabPageConsultaCurso.Location = new Point(4, 31);
            tabPageConsultaCurso.Name = "tabPageConsultaCurso";
            tabPageConsultaCurso.Padding = new Padding(3);
            tabPageConsultaCurso.Size = new Size(786, 348);
            tabPageConsultaCurso.TabIndex = 1;
            tabPageConsultaCurso.Text = "Consulta";
            tabPageConsultaCurso.UseVisualStyleBackColor = true;
            tabPageConsultaCurso.Click += tabPageConsulta_Click;
            tabPageConsultaCurso.Enter += tabPageConsulta_Enter;
            // 
            // buttonExcluir
            // 
            buttonExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonExcluir.Depth = 0;
            buttonExcluir.HighEmphasis = true;
            buttonExcluir.Icon = null;
            buttonExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonExcluir.Location = new Point(577, 303);
            buttonExcluir.Margin = new Padding(4, 6, 4, 6);
            buttonExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.NoAccentTextColor = Color.Empty;
            buttonExcluir.Size = new Size(80, 36);
            buttonExcluir.TabIndex = 7;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonExcluir.UseAccentColor = false;
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEditar.Depth = 0;
            buttonEditar.HighEmphasis = true;
            buttonEditar.Icon = null;
            buttonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonEditar.Location = new Point(498, 303);
            buttonEditar.Margin = new Padding(4, 6, 4, 6);
            buttonEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonEditar.Name = "buttonEditar";
            buttonEditar.NoAccentTextColor = Color.Empty;
            buttonEditar.Size = new Size(71, 36);
            buttonEditar.TabIndex = 6;
            buttonEditar.Text = "Editar";
            buttonEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEditar.UseAccentColor = false;
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonNovo.Depth = 0;
            buttonNovo.HighEmphasis = true;
            buttonNovo.Icon = null;
            buttonNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonNovo.Location = new Point(426, 303);
            buttonNovo.Margin = new Padding(4, 6, 4, 6);
            buttonNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonNovo.Name = "buttonNovo";
            buttonNovo.NoAccentTextColor = Color.Empty;
            buttonNovo.Size = new Size(64, 36);
            buttonNovo.TabIndex = 5;
            buttonNovo.Text = "Novo";
            buttonNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonNovo.UseAccentColor = false;
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click_1;
            // 
            // mlvCursos
            // 
            mlvCursos.AutoSizeTable = false;
            mlvCursos.BackColor = Color.FromArgb(255, 255, 255);
            mlvCursos.BorderStyle = BorderStyle.None;
            mlvCursos.Depth = 0;
            mlvCursos.FullRowSelect = true;
            mlvCursos.Location = new Point(3, 3);
            mlvCursos.MinimumSize = new Size(200, 100);
            mlvCursos.MouseLocation = new Point(-1, -1);
            mlvCursos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mlvCursos.Name = "mlvCursos";
            mlvCursos.OwnerDraw = true;
            mlvCursos.Size = new Size(777, 291);
            mlvCursos.TabIndex = 2;
            mlvCursos.UseCompatibleStateImageBehavior = false;
            mlvCursos.View = View.Details;
            mlvCursos.SelectedIndexChanged += mlvCursos_SelectedIndexChanged;
            mlvCursos.MouseDoubleClick += mlvCursos_MouseDoubleClick_1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCadastroCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControlCadastroCurso);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = TabControlCadastroCurso;
            Name = "FormCadastroCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            TabControlCadastroCurso.ResumeLayout(false);
            tabPageCadastroCurso.ResumeLayout(false);
            tabPageCadastroCurso.PerformLayout();
            tabPageConsultaCurso.ResumeLayout(false);
            tabPageConsultaCurso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastroCurso;
        private TabPage tabPageCadastroCurso;
        private TabPage tabPageConsultaCurso;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton buttonCancelar;
        private ReaLTaiizor.Controls.MaterialButton buttonSalvar;
        private ReaLTaiizor.Controls.MaterialComboBox cboArea;
        private ReaLTaiizor.Controls.MaterialComboBox cboPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox cboDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox cboNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialListView mlvCursos;
        private ReaLTaiizor.Controls.MaterialButton buttonExcluir;
        private ReaLTaiizor.Controls.MaterialButton buttonEditar;
        private ReaLTaiizor.Controls.MaterialButton buttonNovo;
    }
}