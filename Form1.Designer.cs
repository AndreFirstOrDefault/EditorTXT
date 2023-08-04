namespace EditorTXT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuBar = new MenuStrip();
            mArquivo = new ToolStripMenuItem();
            mArquivoNovo = new ToolStripMenuItem();
            mArquivoNovaJanela = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mArquivoAbrir = new ToolStripMenuItem();
            mArquivoSalvar = new ToolStripMenuItem();
            mArquivoSalvarComo = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mArquivoSair = new ToolStripMenuItem();
            mEditar = new ToolStripMenuItem();
            mEditarDesfazer = new ToolStripMenuItem();
            mEditarRefazer = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mEditarRecortar = new ToolStripMenuItem();
            mEditarCopiar = new ToolStripMenuItem();
            mEditarColar = new ToolStripMenuItem();
            mEditarExcluir = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mEditarDataHora = new ToolStripMenuItem();
            mFormatar = new ToolStripMenuItem();
            mFormatarQuebra = new ToolStripMenuItem();
            mFormatarFonte = new ToolStripMenuItem();
            mExibir = new ToolStripMenuItem();
            mExibirZoom = new ToolStripMenuItem();
            mZoomAmpliar = new ToolStripMenuItem();
            mZoomReduzir = new ToolStripMenuItem();
            mZoomRestaurar = new ToolStripMenuItem();
            mExibirBarraStatus = new ToolStripMenuItem();
            mAjuda = new ToolStripMenuItem();
            mAjudarExibirAjuda = new ToolStripMenuItem();
            mAjudarSobre = new ToolStripMenuItem();
            statusBar = new StatusStrip();
            statusBarLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButtonNovo = new ToolStripButton();
            toolStripButtonAbrir = new ToolStripButton();
            toolStripButtonSalvar = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtonFormatar = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButtonZoom = new ToolStripButton();
            toolStripButtonZoomMais = new ToolStripButton();
            toolStripButtonZoomMenos = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButtonAjuda = new ToolStripButton();
            txtConteudo = new RichTextBox();
            menuBar.SuspendLayout();
            statusBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuBar.Items.AddRange(new ToolStripItem[] { mArquivo, mEditar, mFormatar, mExibir, mAjuda });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(784, 29);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            mArquivo.DropDownItems.AddRange(new ToolStripItem[] { mArquivoNovo, mArquivoNovaJanela, toolStripSeparator1, mArquivoAbrir, mArquivoSalvar, mArquivoSalvarComo, toolStripSeparator2, mArquivoSair });
            mArquivo.Name = "mArquivo";
            mArquivo.Size = new Size(80, 25);
            mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            mArquivoNovo.Image = Properties.Resources.novo;
            mArquivoNovo.Name = "mArquivoNovo";
            mArquivoNovo.ShortcutKeyDisplayString = "";
            mArquivoNovo.ShortcutKeys = Keys.Control | Keys.N;
            mArquivoNovo.Size = new Size(272, 26);
            mArquivoNovo.Text = "Novo";
            mArquivoNovo.Click += mArquivoNovo_Click;
            // 
            // mArquivoNovaJanela
            // 
            mArquivoNovaJanela.Image = (Image)resources.GetObject("mArquivoNovaJanela.Image");
            mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            mArquivoNovaJanela.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            mArquivoNovaJanela.Size = new Size(272, 26);
            mArquivoNovaJanela.Text = "Nova Janela";
            mArquivoNovaJanela.Click += mArquivoNovaJanela_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(269, 6);
            // 
            // mArquivoAbrir
            // 
            mArquivoAbrir.Image = Properties.Resources._62917openfilefolder_109270;
            mArquivoAbrir.Name = "mArquivoAbrir";
            mArquivoAbrir.ShortcutKeys = Keys.Control | Keys.O;
            mArquivoAbrir.Size = new Size(272, 26);
            mArquivoAbrir.Text = "Abrir";
            mArquivoAbrir.Click += mArquivoAbrir_Click;
            // 
            // mArquivoSalvar
            // 
            mArquivoSalvar.Image = (Image)resources.GetObject("mArquivoSalvar.Image");
            mArquivoSalvar.Name = "mArquivoSalvar";
            mArquivoSalvar.ShortcutKeys = Keys.Control | Keys.S;
            mArquivoSalvar.Size = new Size(272, 26);
            mArquivoSalvar.Text = "Salvar";
            mArquivoSalvar.Click += mArquivoSalvar_Click;
            // 
            // mArquivoSalvarComo
            // 
            mArquivoSalvarComo.Image = (Image)resources.GetObject("mArquivoSalvarComo.Image");
            mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            mArquivoSalvarComo.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            mArquivoSalvarComo.Size = new Size(272, 26);
            mArquivoSalvarComo.Text = "Salvar Como";
            mArquivoSalvarComo.Click += mArquivoSalvarComo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(269, 6);
            // 
            // mArquivoSair
            // 
            mArquivoSair.Image = (Image)resources.GetObject("mArquivoSair.Image");
            mArquivoSair.Name = "mArquivoSair";
            mArquivoSair.ShortcutKeys = Keys.Alt | Keys.F4;
            mArquivoSair.Size = new Size(272, 26);
            mArquivoSair.Text = "Sair";
            mArquivoSair.Click += mArquivoSair_Click;
            // 
            // mEditar
            // 
            mEditar.DropDownItems.AddRange(new ToolStripItem[] { mEditarDesfazer, mEditarRefazer, toolStripSeparator3, mEditarRecortar, mEditarCopiar, mEditarColar, mEditarExcluir, toolStripSeparator4, mEditarDataHora });
            mEditar.Name = "mEditar";
            mEditar.Size = new Size(64, 25);
            mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            mEditarDesfazer.Image = (Image)resources.GetObject("mEditarDesfazer.Image");
            mEditarDesfazer.Name = "mEditarDesfazer";
            mEditarDesfazer.ShortcutKeys = Keys.Control | Keys.Z;
            mEditarDesfazer.Size = new Size(236, 26);
            mEditarDesfazer.Text = "Desfazer";
            mEditarDesfazer.Click += mEditarDesfazer_Click;
            // 
            // mEditarRefazer
            // 
            mEditarRefazer.Image = (Image)resources.GetObject("mEditarRefazer.Image");
            mEditarRefazer.Name = "mEditarRefazer";
            mEditarRefazer.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            mEditarRefazer.Size = new Size(236, 26);
            mEditarRefazer.Text = "Refazer";
            mEditarRefazer.Click += mEditarRefazer_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(233, 6);
            // 
            // mEditarRecortar
            // 
            mEditarRecortar.Image = Properties.Resources.cuttingscissors_corte_1578;
            mEditarRecortar.Name = "mEditarRecortar";
            mEditarRecortar.ShortcutKeys = Keys.Control | Keys.X;
            mEditarRecortar.Size = new Size(236, 26);
            mEditarRecortar.Text = "Recortar";
            mEditarRecortar.Click += mEditarRecortar_Click;
            // 
            // mEditarCopiar
            // 
            mEditarCopiar.Image = Properties.Resources.copy_paste_document_theuser_1579;
            mEditarCopiar.Name = "mEditarCopiar";
            mEditarCopiar.ShortcutKeys = Keys.Control | Keys.C;
            mEditarCopiar.Size = new Size(236, 26);
            mEditarCopiar.Text = "Copiar";
            mEditarCopiar.Click += mEditarCopiar_Click;
            // 
            // mEditarColar
            // 
            mEditarColar.Image = Properties.Resources.Glue512_44194;
            mEditarColar.Name = "mEditarColar";
            mEditarColar.ShortcutKeys = Keys.Control | Keys.V;
            mEditarColar.Size = new Size(236, 26);
            mEditarColar.Text = "Colar";
            mEditarColar.Click += mEditarColar_Click;
            // 
            // mEditarExcluir
            // 
            mEditarExcluir.Image = Properties.Resources.file_delete_114438;
            mEditarExcluir.Name = "mEditarExcluir";
            mEditarExcluir.ShortcutKeyDisplayString = "Delete";
            mEditarExcluir.Size = new Size(236, 26);
            mEditarExcluir.Text = "Excluir";
            mEditarExcluir.Click += mEditarExcluir_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(233, 6);
            // 
            // mEditarDataHora
            // 
            mEditarDataHora.Image = Properties.Resources.time_date_may_19653;
            mEditarDataHora.Name = "mEditarDataHora";
            mEditarDataHora.ShortcutKeys = Keys.F5;
            mEditarDataHora.Size = new Size(236, 26);
            mEditarDataHora.Text = "Data e Hora";
            mEditarDataHora.Click += mEditarDataHora_Click;
            // 
            // mFormatar
            // 
            mFormatar.DropDownItems.AddRange(new ToolStripItem[] { mFormatarQuebra, mFormatarFonte });
            mFormatar.Name = "mFormatar";
            mFormatar.Size = new Size(88, 25);
            mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebra
            // 
            mFormatarQuebra.CheckOnClick = true;
            mFormatarQuebra.Name = "mFormatarQuebra";
            mFormatarQuebra.Size = new Size(280, 26);
            mFormatarQuebra.Text = "Quebra automática de linha";
            mFormatarQuebra.Click += mFormatarQuebra_Click;
            // 
            // mFormatarFonte
            // 
            mFormatarFonte.Name = "mFormatarFonte";
            mFormatarFonte.Size = new Size(280, 26);
            mFormatarFonte.Text = "Fonte";
            mFormatarFonte.Click += mFormatarFonte_Click;
            // 
            // mExibir
            // 
            mExibir.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoom, mExibirBarraStatus });
            mExibir.Name = "mExibir";
            mExibir.Size = new Size(62, 25);
            mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            mExibirZoom.DropDownItems.AddRange(new ToolStripItem[] { mZoomAmpliar, mZoomReduzir, mZoomRestaurar });
            mExibirZoom.Image = Properties.Resources.searchzoomflat_106031;
            mExibirZoom.Name = "mExibirZoom";
            mExibirZoom.Size = new Size(188, 26);
            mExibirZoom.Text = "Zoom";
            // 
            // mZoomAmpliar
            // 
            mZoomAmpliar.Image = Properties.Resources.zoom_zoom_in_zoomin_2368;
            mZoomAmpliar.Name = "mZoomAmpliar";
            mZoomAmpliar.ShortcutKeyDisplayString = "Ctrl ++";
            mZoomAmpliar.ShortcutKeys = Keys.Control | Keys.Oemplus;
            mZoomAmpliar.Size = new Size(205, 26);
            mZoomAmpliar.Text = "Ampliar";
            mZoomAmpliar.Click += mZoomAmpliar_Click;
            // 
            // mZoomReduzir
            // 
            mZoomReduzir.Image = Properties.Resources.zoom_zoomout_zoom_2369;
            mZoomReduzir.Name = "mZoomReduzir";
            mZoomReduzir.ShortcutKeyDisplayString = "Ctrl --";
            mZoomReduzir.ShortcutKeys = Keys.Control | Keys.OemMinus;
            mZoomReduzir.Size = new Size(205, 26);
            mZoomReduzir.Text = "Reduzir";
            mZoomReduzir.Click += mZoomReduzir_Click;
            // 
            // mZoomRestaurar
            // 
            mZoomRestaurar.Image = Properties.Resources.ic_restore_128_28737;
            mZoomRestaurar.Name = "mZoomRestaurar";
            mZoomRestaurar.ShortcutKeys = Keys.Control | Keys.D0;
            mZoomRestaurar.Size = new Size(205, 26);
            mZoomRestaurar.Text = "Restaurar";
            mZoomRestaurar.Click += mZoomRestaurar_Click;
            // 
            // mExibirBarraStatus
            // 
            mExibirBarraStatus.Checked = true;
            mExibirBarraStatus.CheckOnClick = true;
            mExibirBarraStatus.CheckState = CheckState.Checked;
            mExibirBarraStatus.Name = "mExibirBarraStatus";
            mExibirBarraStatus.Size = new Size(188, 26);
            mExibirBarraStatus.Text = "Barra de status";
            mExibirBarraStatus.Click += mExibirBarraStatus_Click;
            // 
            // mAjuda
            // 
            mAjuda.DropDownItems.AddRange(new ToolStripItem[] { mAjudarExibirAjuda, mAjudarSobre });
            mAjuda.Name = "mAjuda";
            mAjuda.Size = new Size(64, 25);
            mAjuda.Text = "Ajuda";
            // 
            // mAjudarExibirAjuda
            // 
            mAjudarExibirAjuda.Image = Properties.Resources.help_support_22593;
            mAjudarExibirAjuda.Name = "mAjudarExibirAjuda";
            mAjudarExibirAjuda.ShortcutKeys = Keys.F1;
            mAjudarExibirAjuda.Size = new Size(218, 26);
            mAjudarExibirAjuda.Text = "Exibir Ajuda";
            mAjudarExibirAjuda.Click += mAjudarExibirAjuda_Click;
            // 
            // mAjudarSobre
            // 
            mAjudarSobre.Image = Properties.Resources.gui_about_icon_157266;
            mAjudarSobre.Name = "mAjudarSobre";
            mAjudarSobre.Size = new Size(218, 26);
            mAjudarSobre.Text = "Sobre o Editor TXT";
            mAjudarSobre.Click += mAjudarSobre_Click;
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarLabel });
            statusBar.Location = new Point(0, 539);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(784, 22);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            statusBarLabel.Name = "statusBarLabel";
            statusBarLabel.Size = new Size(38, 17);
            statusBarLabel.Text = "100 %";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNovo, toolStripButtonAbrir, toolStripButtonSalvar, toolStripSeparator5, toolStripButtonFormatar, toolStripSeparator6, toolStripButtonZoom, toolStripButtonZoomMais, toolStripButtonZoomMenos, toolStripSeparator7, toolStripButtonAjuda });
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNovo
            // 
            toolStripButtonNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNovo.Image = Properties.Resources.novo;
            toolStripButtonNovo.ImageTransparentColor = Color.Magenta;
            toolStripButtonNovo.Name = "toolStripButtonNovo";
            toolStripButtonNovo.Size = new Size(23, 24);
            toolStripButtonNovo.Text = "toolStripButton1";
            toolStripButtonNovo.ToolTipText = "Novo";
            toolStripButtonNovo.Click += toolStripButtonNovo_Click;
            // 
            // toolStripButtonAbrir
            // 
            toolStripButtonAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAbrir.Image = Properties.Resources._62917openfilefolder_109270;
            toolStripButtonAbrir.ImageTransparentColor = Color.Magenta;
            toolStripButtonAbrir.Name = "toolStripButtonAbrir";
            toolStripButtonAbrir.Size = new Size(23, 24);
            toolStripButtonAbrir.Text = "toolStripButton2";
            toolStripButtonAbrir.ToolTipText = "Abrir";
            toolStripButtonAbrir.Click += mArquivoAbrir_Click;
            // 
            // toolStripButtonSalvar
            // 
            toolStripButtonSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSalvar.Image = (Image)resources.GetObject("toolStripButtonSalvar.Image");
            toolStripButtonSalvar.ImageTransparentColor = Color.Magenta;
            toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            toolStripButtonSalvar.Size = new Size(23, 24);
            toolStripButtonSalvar.ToolTipText = "Salvar";
            toolStripButtonSalvar.Click += mArquivoSalvar_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // toolStripButtonFormatar
            // 
            toolStripButtonFormatar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonFormatar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            toolStripButtonFormatar.Image = Properties.Resources.Font_Folder_22338;
            toolStripButtonFormatar.ImageTransparentColor = Color.Magenta;
            toolStripButtonFormatar.Name = "toolStripButtonFormatar";
            toolStripButtonFormatar.Size = new Size(33, 24);
            toolStripButtonFormatar.Text = "Aa";
            toolStripButtonFormatar.ToolTipText = "Fonte";
            toolStripButtonFormatar.Click += mFormatarFonte_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // toolStripButtonZoom
            // 
            toolStripButtonZoom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonZoom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            toolStripButtonZoom.Image = Properties.Resources.zoom_zoom_in_zoomin_2368;
            toolStripButtonZoom.ImageTransparentColor = Color.Magenta;
            toolStripButtonZoom.Name = "toolStripButtonZoom";
            toolStripButtonZoom.Size = new Size(44, 24);
            toolStripButtonZoom.Text = "100%";
            toolStripButtonZoom.ToolTipText = "Restaurar Zoom";
            toolStripButtonZoom.Click += mZoomRestaurar_Click;
            // 
            // toolStripButtonZoomMais
            // 
            toolStripButtonZoomMais.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonZoomMais.Image = Properties.Resources.zoom_zoom_in_zoomin_23681;
            toolStripButtonZoomMais.ImageTransparentColor = Color.Magenta;
            toolStripButtonZoomMais.Name = "toolStripButtonZoomMais";
            toolStripButtonZoomMais.Size = new Size(23, 24);
            toolStripButtonZoomMais.Text = "toolStripButton7";
            toolStripButtonZoomMais.ToolTipText = "Zoom +";
            toolStripButtonZoomMais.Click += mZoomAmpliar_Click;
            // 
            // toolStripButtonZoomMenos
            // 
            toolStripButtonZoomMenos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonZoomMenos.Image = Properties.Resources.zoom_zoomout_zoom_23691;
            toolStripButtonZoomMenos.ImageTransparentColor = Color.Magenta;
            toolStripButtonZoomMenos.Name = "toolStripButtonZoomMenos";
            toolStripButtonZoomMenos.Size = new Size(23, 24);
            toolStripButtonZoomMenos.Text = "toolStripButton8";
            toolStripButtonZoomMenos.ToolTipText = "Zoom -";
            toolStripButtonZoomMenos.Click += mZoomReduzir_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 27);
            // 
            // toolStripButtonAjuda
            // 
            toolStripButtonAjuda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAjuda.Image = Properties.Resources.help_support_22593;
            toolStripButtonAjuda.ImageTransparentColor = Color.Magenta;
            toolStripButtonAjuda.Name = "toolStripButtonAjuda";
            toolStripButtonAjuda.Size = new Size(23, 24);
            toolStripButtonAjuda.ToolTipText = "Ajuda";
            toolStripButtonAjuda.Click += mAjudarExibirAjuda_Click;
            // 
            // txtConteudo
            // 
            txtConteudo.Dock = DockStyle.Fill;
            txtConteudo.Location = new Point(0, 56);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new Size(784, 483);
            txtConteudo.TabIndex = 4;
            txtConteudo.Text = "";
            txtConteudo.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(txtConteudo);
            Controls.Add(toolStrip1);
            Controls.Add(statusBar);
            Controls.Add(menuBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuBar;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor TXT";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem mArquivo;
        private ToolStripMenuItem mEditar;
        private ToolStripMenuItem mFormatar;
        private ToolStripMenuItem mExibir;
        private ToolStripMenuItem mAjuda;
        private ToolStripMenuItem mArquivoNovo;
        private ToolStripMenuItem mArquivoNovaJanela;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mArquivoAbrir;
        private ToolStripMenuItem mArquivoSalvar;
        private ToolStripMenuItem mArquivoSalvarComo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mArquivoSair;
        private ToolStripMenuItem mEditarDesfazer;
        private ToolStripMenuItem mEditarRefazer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditarRecortar;
        private ToolStripMenuItem mEditarCopiar;
        private ToolStripMenuItem mEditarColar;
        private ToolStripMenuItem mEditarExcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mEditarDataHora;
        private ToolStripMenuItem mFormatarQuebra;
        private ToolStripMenuItem mFormatarFonte;
        private ToolStripMenuItem mExibirZoom;
        private ToolStripMenuItem mZoomAmpliar;
        private ToolStripMenuItem mZoomReduzir;
        private ToolStripMenuItem mZoomRestaurar;
        private ToolStripMenuItem mExibirBarraStatus;
        private ToolStripMenuItem mAjudarExibirAjuda;
        private ToolStripMenuItem mAjudarSobre;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusBarLabel;
        private ToolStrip toolStrip1;
        private RichTextBox txtConteudo;
        private ToolStripButton toolStripButtonNovo;
        private ToolStripButton toolStripButtonAbrir;
        private ToolStripButton toolStripButtonSalvar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonFormatar;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButtonZoom;
        private ToolStripButton toolStripButtonZoomMais;
        private ToolStripButton toolStripButtonZoomMenos;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButtonAjuda;
    }
}