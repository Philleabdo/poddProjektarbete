namespace poddProjektGrupp22
{
    partial class RegisterForm
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
            buttonKallor = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            buttonTom = new Button();
            SuspendLayout();
            // 
            // buttonKallor
            // 
            buttonKallor.Location = new Point(12, 12);
            buttonKallor.Name = "buttonKallor";
            buttonKallor.Size = new Size(75, 23);
            buttonKallor.TabIndex = 0;
            buttonKallor.Text = "Visa källor";
            buttonKallor.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(161, 319);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(207, 41);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(244, 319);
            listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(482, 41);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(231, 319);
            listBox3.TabIndex = 3;
            // 
            // buttonTom
            // 
            buttonTom.Location = new Point(569, 366);
            buttonTom.Name = "buttonTom";
            buttonTom.Size = new Size(144, 23);
            buttonTom.TabIndex = 4;
            buttonTom.Text = "Töm hela registret";
            buttonTom.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTom);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(buttonKallor);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKallor;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button buttonTom;
    }
}