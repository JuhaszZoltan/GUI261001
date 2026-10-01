namespace GUI261001
{
    partial class FrmMain
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
            lblText = new Label();
            btnBlueFG = new Button();
            btnWhiteBG = new Button();
            btnDelete = new Button();
            btnMiddleLeft = new Button();
            btnMiddleCenter = new Button();
            btnMiddleRight = new Button();
            btnUpperCase = new Button();
            btnFontPlus = new Button();
            btnFontMinus = new Button();
            btnReset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.BackColor = Color.LightGray;
            lblText.Font = new Font("Segoe UI", 20F);
            lblText.Location = new Point(12, 21);
            lblText.Name = "lblText";
            lblText.Size = new Size(525, 194);
            lblText.TabIndex = 0;
            lblText.Text = "Hello, World!";
            // 
            // btnBlueFG
            // 
            btnBlueFG.BackColor = Color.LightGray;
            btnBlueFG.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBlueFG.Location = new Point(12, 232);
            btnBlueFG.Name = "btnBlueFG";
            btnBlueFG.Size = new Size(151, 52);
            btnBlueFG.TabIndex = 1;
            btnBlueFG.Text = "blue text";
            btnBlueFG.UseVisualStyleBackColor = false;
            // 
            // btnWhiteBG
            // 
            btnWhiteBG.BackColor = Color.LightGray;
            btnWhiteBG.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnWhiteBG.Location = new Point(199, 232);
            btnWhiteBG.Name = "btnWhiteBG";
            btnWhiteBG.Size = new Size(151, 52);
            btnWhiteBG.TabIndex = 1;
            btnWhiteBG.Text = "white bg";
            btnWhiteBG.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightGray;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(386, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 52);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnMiddleLeft
            // 
            btnMiddleLeft.AccessibleRole = AccessibleRole.None;
            btnMiddleLeft.BackColor = Color.LightGray;
            btnMiddleLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMiddleLeft.Location = new Point(12, 323);
            btnMiddleLeft.Name = "btnMiddleLeft";
            btnMiddleLeft.Size = new Size(151, 52);
            btnMiddleLeft.TabIndex = 1;
            btnMiddleLeft.Text = "middle-left";
            btnMiddleLeft.UseVisualStyleBackColor = false;
            // 
            // btnMiddleCenter
            // 
            btnMiddleCenter.BackColor = Color.LightGray;
            btnMiddleCenter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMiddleCenter.Location = new Point(199, 323);
            btnMiddleCenter.Name = "btnMiddleCenter";
            btnMiddleCenter.Size = new Size(151, 52);
            btnMiddleCenter.TabIndex = 1;
            btnMiddleCenter.Text = "middle-center";
            btnMiddleCenter.UseVisualStyleBackColor = false;
            // 
            // btnMiddleRight
            // 
            btnMiddleRight.BackColor = Color.LightGray;
            btnMiddleRight.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMiddleRight.Location = new Point(386, 323);
            btnMiddleRight.Name = "btnMiddleRight";
            btnMiddleRight.Size = new Size(151, 52);
            btnMiddleRight.TabIndex = 1;
            btnMiddleRight.Text = "middle-right";
            btnMiddleRight.UseVisualStyleBackColor = false;
            // 
            // btnUpperCase
            // 
            btnUpperCase.BackColor = Color.LightGray;
            btnUpperCase.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpperCase.Location = new Point(12, 414);
            btnUpperCase.Name = "btnUpperCase";
            btnUpperCase.Size = new Size(151, 52);
            btnUpperCase.TabIndex = 1;
            btnUpperCase.Text = "uppercase";
            btnUpperCase.UseVisualStyleBackColor = false;
            // 
            // btnFontPlus
            // 
            btnFontPlus.BackColor = Color.LightGray;
            btnFontPlus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFontPlus.Location = new Point(199, 414);
            btnFontPlus.Name = "btnFontPlus";
            btnFontPlus.Size = new Size(151, 52);
            btnFontPlus.TabIndex = 1;
            btnFontPlus.Text = "font size +";
            btnFontPlus.UseVisualStyleBackColor = false;
            // 
            // btnFontMinus
            // 
            btnFontMinus.BackColor = Color.LightGray;
            btnFontMinus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFontMinus.Location = new Point(386, 414);
            btnFontMinus.Name = "btnFontMinus";
            btnFontMinus.Size = new Size(151, 52);
            btnFontMinus.TabIndex = 1;
            btnFontMinus.Text = "font size -";
            btnFontMinus.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightGray;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReset.Location = new Point(12, 506);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(151, 52);
            btnReset.TabIndex = 1;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightGray;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(386, 505);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(151, 52);
            btnExit.TabIndex = 1;
            btnExit.Text = "exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(549, 571);
            Controls.Add(btnExit);
            Controls.Add(btnFontMinus);
            Controls.Add(btnMiddleRight);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(btnFontPlus);
            Controls.Add(btnUpperCase);
            Controls.Add(btnMiddleCenter);
            Controls.Add(btnMiddleLeft);
            Controls.Add(btnWhiteBG);
            Controls.Add(btnBlueFG);
            Controls.Add(lblText);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "text formatting";
            ResumeLayout(false);
        }

        #endregion

        private Label lblText;
        private Button btnBlueFG;
        private Button btnWhiteBG;
        private Button btnDelete;
        private Button btnMiddleLeft;
        private Button btnMiddleCenter;
        private Button btnMiddleRight;
        private Button btnUpperCase;
        private Button btnFontPlus;
        private Button btnFontMinus;
        private Button btnReset;
        private Button btnExit;
    }
}
