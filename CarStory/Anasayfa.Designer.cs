namespace CarStory
{
    partial class Anasayfa
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
            btnArabaStore = new Button();
            SuspendLayout();
            // 
            // btnArabaStore
            // 
            btnArabaStore.Location = new Point(64, 61);
            btnArabaStore.Name = "btnArabaStore";
            btnArabaStore.Size = new Size(164, 100);
            btnArabaStore.TabIndex = 0;
            btnArabaStore.Text = "Arabalar";
            btnArabaStore.UseVisualStyleBackColor = true;
            btnArabaStore.Click += btnArabaStore_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnArabaStore);
            Name = "Anasayfa";
            Text = "Anasayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button btnArabaStore;
    }
}