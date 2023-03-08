namespace Teste001
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
            textBoxTermo = new TextBox();
            progressBar1 = new ProgressBar();
            listBox1 = new ListBox();
            bgWorker = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Termo";
            label1.Click += label1_Click;
            // 
            // textBoxTermo
            // 
            textBoxTermo.Location = new Point(24, 47);
            textBoxTermo.Name = "textBoxTermo";
            textBoxTermo.Size = new Size(429, 23);
            textBoxTermo.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 85);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(514, 21);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(514, 289);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(459, 45);
            button1.Name = "button1";
            button1.Size = new Size(79, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(progressBar1);
            Controls.Add(textBoxTermo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTermo;
        private ProgressBar progressBar1;
        private ListBox listBox1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private Button button1;
    }
}