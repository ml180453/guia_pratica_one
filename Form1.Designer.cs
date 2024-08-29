namespace guia_pratica_one
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
            panel = new Panel();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(396, 567);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
            panel.MouseClick += panel_MouseClick;
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox.ForeColor = Color.DarkTurquoise;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Items.AddRange(new object[] { "Círculo", "Rectángulo" });
            listBox.Location = new Point(414, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(178, 64);
            listBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 581);
            Controls.Add(listBox);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Dibujos";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private ListBox listBox;
    }
}
