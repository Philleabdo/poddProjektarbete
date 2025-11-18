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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 2;
            label1.Text = "Ange källans url (RSS-adress):";
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(12, 27);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(261, 23);
            textBoxURL.TabIndex = 3;
            // 
            // buttonNyhetskalla
            // 
            buttonNyhetskalla.Location = new Point(12, 56);
            buttonNyhetskalla.Name = "buttonNyhetskalla";
            buttonNyhetskalla.Size = new Size(162, 23);
            buttonNyhetskalla.TabIndex = 4;
            buttonNyhetskalla.Text = "Hämta och visa nyhetskälla";
            buttonNyhetskalla.UseVisualStyleBackColor = true;
            // 
            // listBoxInformation
            // 
            listBoxInformation.FormattingEnabled = true;
            listBoxInformation.Location = new Point(12, 104);
            listBoxInformation.Name = "listBoxInformation";
            listBoxInformation.Size = new Size(303, 289);
            listBoxInformation.TabIndex = 5;
            // 
            // listBoxLankar
            // 
            listBoxLankar.FormattingEnabled = true;
            listBoxLankar.Location = new Point(349, 104);
            listBoxLankar.Name = "listBoxLankar";
            listBoxLankar.Size = new Size(313, 289);
            listBoxLankar.TabIndex = 6;
            // 
            // buttonSpara
            // 
            buttonSpara.Location = new Point(12, 406);
            buttonSpara.Name = "buttonSpara";
            buttonSpara.Size = new Size(162, 23);
            buttonSpara.TabIndex = 7;
            buttonSpara.Text = "Spara i nyhetsflödet";
            buttonSpara.UseVisualStyleBackColor = true;
            // 
            // buttonVisning
            // 
            buttonVisning.Location = new Point(224, 406);
            buttonVisning.Name = "buttonVisning";
            buttonVisning.Size = new Size(151, 23);
            buttonVisning.TabIndex = 8;
            buttonVisning.Text = "Ange visningsnamn";
            buttonVisning.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 441);
            Controls.Add(buttonVisning);
            Controls.Add(buttonSpara);
            Controls.Add(listBoxLankar);
            Controls.Add(listBoxInformation);
            Controls.Add(buttonNyhetskalla);
            Controls.Add(textBoxURL);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
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
