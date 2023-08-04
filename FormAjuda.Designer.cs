namespace EditorTXT
{
    partial class FormAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjuda));
            webBrowser = new WebBrowser();
            SuspendLayout();
            // 
            // webBrowser
            // 
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Location = new Point(0, 0);
            webBrowser.Name = "webBrowser";
            webBrowser.Size = new Size(803, 455);
            webBrowser.TabIndex = 0;
            // 
            // FormAjuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 455);
            Controls.Add(webBrowser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAjuda";
            Text = "Ajuda do Editor TXT";
            ResumeLayout(false);
        }

        #endregion

        private WebBrowser webBrowser;
    }
}