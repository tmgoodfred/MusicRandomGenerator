namespace MusicRandomGenerator
{
    partial class Main
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
            keyTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bpmTxt = new TextBox();
            label3 = new Label();
            genreTxt = new TextBox();
            notesTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            chordTxt = new TextBox();
            progTxt = new TextBox();
            label6 = new Label();
            randomizeBtn = new Button();
            melodyTxt = new TextBox();
            makeMelodyBtn = new Button();
            vibeTxt = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // keyTxt
            // 
            keyTxt.Location = new Point(106, 46);
            keyTxt.Name = "keyTxt";
            keyTxt.Size = new Size(154, 23);
            keyTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 49);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 1;
            label1.Text = "Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 83);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "BPM";
            // 
            // bpmTxt
            // 
            bpmTxt.Location = new Point(106, 80);
            bpmTxt.Name = "bpmTxt";
            bpmTxt.Size = new Size(68, 23);
            bpmTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 118);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Genre";
            // 
            // genreTxt
            // 
            genreTxt.Location = new Point(106, 115);
            genreTxt.Name = "genreTxt";
            genreTxt.Size = new Size(244, 23);
            genreTxt.TabIndex = 5;
            // 
            // notesTxt
            // 
            notesTxt.Location = new Point(424, 41);
            notesTxt.Multiline = true;
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(310, 38);
            notesTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 46);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Notes in Key";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 118);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "Chords";
            // 
            // chordTxt
            // 
            chordTxt.Location = new Point(424, 115);
            chordTxt.Multiline = true;
            chordTxt.Name = "chordTxt";
            chordTxt.Size = new Size(310, 108);
            chordTxt.TabIndex = 9;
            // 
            // progTxt
            // 
            progTxt.Location = new Point(106, 173);
            progTxt.Name = "progTxt";
            progTxt.Size = new Size(244, 23);
            progTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 176);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 11;
            label6.Text = "Chord Prog";
            // 
            // randomizeBtn
            // 
            randomizeBtn.Location = new Point(343, 270);
            randomizeBtn.Name = "randomizeBtn";
            randomizeBtn.Size = new Size(75, 23);
            randomizeBtn.TabIndex = 12;
            randomizeBtn.Text = "Randomize";
            randomizeBtn.UseVisualStyleBackColor = true;
            randomizeBtn.Click += randomizeBtn_Click;
            // 
            // melodyTxt
            // 
            melodyTxt.Font = new Font("Consolas", 10F);
            melodyTxt.Location = new Point(118, 332);
            melodyTxt.Multiline = true;
            melodyTxt.Name = "melodyTxt";
            melodyTxt.Size = new Size(532, 123);
            melodyTxt.TabIndex = 13;
            // 
            // makeMelodyBtn
            // 
            makeMelodyBtn.Location = new Point(334, 303);
            makeMelodyBtn.Name = "makeMelodyBtn";
            makeMelodyBtn.Size = new Size(94, 23);
            makeMelodyBtn.TabIndex = 14;
            makeMelodyBtn.Text = "Make Melody";
            makeMelodyBtn.UseVisualStyleBackColor = true;
            makeMelodyBtn.Click += makeMelodyBtn_Click;
            // 
            // vibeTxt
            // 
            vibeTxt.Location = new Point(106, 144);
            vibeTxt.Name = "vibeTxt";
            vibeTxt.Size = new Size(244, 23);
            vibeTxt.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 147);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 16;
            label7.Text = "Vibe";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(label7);
            Controls.Add(vibeTxt);
            Controls.Add(makeMelodyBtn);
            Controls.Add(melodyTxt);
            Controls.Add(randomizeBtn);
            Controls.Add(label6);
            Controls.Add(progTxt);
            Controls.Add(chordTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(notesTxt);
            Controls.Add(genreTxt);
            Controls.Add(label3);
            Controls.Add(bpmTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(keyTxt);
            Name = "Main";
            Text = "Music Randomizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox keyTxt;
        private Label label1;
        private Label label2;
        private TextBox bpmTxt;
        private Label label3;
        private TextBox genreTxt;
        private TextBox notesTxt;
        private Label label4;
        private Label label5;
        private TextBox chordTxt;
        private TextBox progTxt;
        private Label label6;
        private Button randomizeBtn;
        private TextBox melodyTxt;
        private Button makeMelodyBtn;
        private TextBox vibeTxt;
        private Label label7;
    }
}
