namespace Survey
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.다음 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "좋아하는 라면을 3가지 이상 선택해주세요.";
            // 
            // 다음
            // 
            this.다음.BackColor = System.Drawing.SystemColors.Info;
            this.다음.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.다음.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.다음.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.다음.Location = new System.Drawing.Point(847, 608);
            this.다음.Name = "다음";
            this.다음.Size = new System.Drawing.Size(125, 46);
            this.다음.TabIndex = 19;
            this.다음.Text = "다음";
            this.다음.UseVisualStyleBackColor = false;
            this.다음.Click += new System.EventHandler(this.다음_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "신라면",
            "진라면",
            "너구리",
            "참깨라면",
            "꼬꼬면",
            "불닭볶음면",
            "안성탕면",
            "삼양라면",
            "짜파게티",
            "사리곰탕",
            "튀김우동"});
            this.checkedListBox1.Location = new System.Drawing.Point(26, 100);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(319, 304);
            this.checkedListBox1.TabIndex = 20;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1053, 755);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.다음);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 다음;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}