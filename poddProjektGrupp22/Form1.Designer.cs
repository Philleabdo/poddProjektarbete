namespace poddProjektGrupp22
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
            label1 = new Label();
            textBoxURL = new TextBox();
            buttonNyhetskalla = new Button();
            listBoxInformation = new ListBox();
            listBoxLankar = new ListBox();
            buttonSpara = new Button();
            buttonVisning = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 2;
            label1.Text = "Ange källans url (RSS-adress):";
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(17, 45);
            textBoxURL.Margin = new Padding(4, 5, 4, 5);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(371, 31);
            textBoxURL.TabIndex = 3;
            textBoxURL.TextChanged += textBoxURL_TextChanged;
            // 
            // buttonNyhetskalla
            // 
            buttonNyhetskalla.Location = new Point(17, 93);
            buttonNyhetskalla.Margin = new Padding(4, 5, 4, 5);
            buttonNyhetskalla.Name = "buttonNyhetskalla";
            buttonNyhetskalla.Size = new Size(231, 38);
            buttonNyhetskalla.TabIndex = 4;
            buttonNyhetskalla.Text = "Hämta och visa nyhetskälla";
            buttonNyhetskalla.UseVisualStyleBackColor = true;
            buttonNyhetskalla.Click += buttonNyhetskalla_Click;
            // 
            // listBoxInformation
            // 
            listBoxInformation.FormattingEnabled = true;
            listBoxInformation.Location = new Point(17, 173);
            listBoxInformation.Margin = new Padding(4, 5, 4, 5);
            listBoxInformation.Name = "listBoxInformation";
            listBoxInformation.Size = new Size(431, 479);
            listBoxInformation.TabIndex = 5;
            listBoxInformation.SelectedIndexChanged += listBoxInformation_SelectedIndexChanged;
            // 
            // listBoxLankar
            // 
            listBoxLankar.FormattingEnabled = true;
            listBoxLankar.Location = new Point(499, 173);
            listBoxLankar.Margin = new Padding(4, 5, 4, 5);
            listBoxLankar.Name = "listBoxLankar";
            listBoxLankar.Size = new Size(445, 479);
            listBoxLankar.TabIndex = 6;
            listBoxLankar.SelectedIndexChanged += listBoxLankar_SelectedIndexChanged;
            // 
            // buttonSpara
            // 
            buttonSpara.Location = new Point(17, 677);
            buttonSpara.Margin = new Padding(4, 5, 4, 5);
            buttonSpara.Name = "buttonSpara";
            buttonSpara.Size = new Size(231, 38);
            buttonSpara.TabIndex = 7;
            buttonSpara.Text = "Spara i nyhetsflödet";
            buttonSpara.UseVisualStyleBackColor = true;
            buttonSpara.Click += buttonSpara_Click;
            // 
            // buttonVisning
            // 
            buttonVisning.Location = new Point(320, 677);
            buttonVisning.Margin = new Padding(4, 5, 4, 5);
            buttonVisning.Name = "buttonVisning";
            buttonVisning.Size = new Size(216, 38);
            buttonVisning.TabIndex = 8;
            buttonVisning.Text = "Ange visningsnamn";
            buttonVisning.UseVisualStyleBackColor = true;
            buttonVisning.Click += buttonVisning_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 735);
            Controls.Add(buttonVisning);
            Controls.Add(buttonSpara);
            Controls.Add(listBoxLankar);
            Controls.Add(listBoxInformation);
            Controls.Add(buttonNyhetskalla);
            Controls.Add(textBoxURL);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBoxURL;
        private Button buttonNyhetskalla;
        private ListBox listBoxInformation;
        private ListBox listBoxLankar;
        private Button buttonSpara;
        private Button buttonVisning;
    }
}
