namespace Survey
{
    partial class Form4
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
            this.횟수0 = new System.Windows.Forms.CheckBox();
            this.횟수1 = new System.Windows.Forms.CheckBox();
            this.횟수2 = new System.Windows.Forms.CheckBox();
            this.횟수3 = new System.Windows.Forms.CheckBox();
            this.횟수모름 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.토핑 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.밥YES = new System.Windows.Forms.CheckBox();
            this.밥NO = new System.Windows.Forms.CheckBox();
            this.밥OR = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "일주일에 라면 먹는횟수는??";
            // 
            // 횟수0
            // 
            this.횟수0.AutoSize = true;
            this.횟수0.Location = new System.Drawing.Point(50, 121);
            this.횟수0.Name = "횟수0";
            this.횟수0.Size = new System.Drawing.Size(86, 22);
            this.횟수0.TabIndex = 1;
            this.횟수0.Text = "0~1번";
            this.횟수0.UseVisualStyleBackColor = true;
            this.횟수0.CheckedChanged += new System.EventHandler(this.횟수0_CheckedChanged);
            // 
            // 횟수1
            // 
            this.횟수1.AutoSize = true;
            this.횟수1.Location = new System.Drawing.Point(142, 121);
            this.횟수1.Name = "횟수1";
            this.횟수1.Size = new System.Drawing.Size(62, 22);
            this.횟수1.TabIndex = 2;
            this.횟수1.Text = "1번";
            this.횟수1.UseVisualStyleBackColor = true;
            this.횟수1.CheckedChanged += new System.EventHandler(this.횟수1_CheckedChanged);
            // 
            // 횟수2
            // 
            this.횟수2.AutoSize = true;
            this.횟수2.Location = new System.Drawing.Point(210, 121);
            this.횟수2.Name = "횟수2";
            this.횟수2.Size = new System.Drawing.Size(62, 22);
            this.횟수2.TabIndex = 3;
            this.횟수2.Text = "2번";
            this.횟수2.UseVisualStyleBackColor = true;
            this.횟수2.CheckedChanged += new System.EventHandler(this.횟수2_CheckedChanged);
            // 
            // 횟수3
            // 
            this.횟수3.AutoSize = true;
            this.횟수3.Location = new System.Drawing.Point(278, 121);
            this.횟수3.Name = "횟수3";
            this.횟수3.Size = new System.Drawing.Size(98, 22);
            this.횟수3.TabIndex = 4;
            this.횟수3.Text = "3번이상";
            this.횟수3.UseVisualStyleBackColor = true;
            this.횟수3.CheckedChanged += new System.EventHandler(this.횟수3_CheckedChanged);
            // 
            // 횟수모름
            // 
            this.횟수모름.AutoSize = true;
            this.횟수모름.Location = new System.Drawing.Point(382, 121);
            this.횟수모름.Name = "횟수모름";
            this.횟수모름.Size = new System.Drawing.Size(124, 22);
            this.횟수모름.TabIndex = 5;
            this.횟수모름.Text = "잘모르겠다";
            this.횟수모름.UseVisualStyleBackColor = true;
            this.횟수모름.CheckedChanged += new System.EventHandler(this.횟수모름_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "토핑을 어떤거를 넣어먹는습니까??";
            // 
            // 토핑
            // 
            this.토핑.FormattingEnabled = true;
            this.토핑.Items.AddRange(new object[] {
            "참치",
            "스팸",
            "계란",
            "파",
            "고추",
            "김치",
            "떡",
            "치즈",
            "양파",
            "않넣어먹는다"});
            this.토핑.Location = new System.Drawing.Point(50, 257);
            this.토핑.MultiColumn = true;
            this.토핑.Name = "토핑";
            this.토핑.Size = new System.Drawing.Size(405, 154);
            this.토핑.TabIndex = 7;
            this.토핑.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(45, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "밥을 말아먹습니까?";
            // 
            // 밥YES
            // 
            this.밥YES.AutoSize = true;
            this.밥YES.Location = new System.Drawing.Point(50, 559);
            this.밥YES.Name = "밥YES";
            this.밥YES.Size = new System.Drawing.Size(52, 22);
            this.밥YES.TabIndex = 9;
            this.밥YES.Text = "네";
            this.밥YES.UseVisualStyleBackColor = true;
            this.밥YES.CheckedChanged += new System.EventHandler(this.밥YES_CheckedChanged);
            // 
            // 밥NO
            // 
            this.밥NO.AutoSize = true;
            this.밥NO.Location = new System.Drawing.Point(142, 559);
            this.밥NO.Name = "밥NO";
            this.밥NO.Size = new System.Drawing.Size(88, 22);
            this.밥NO.TabIndex = 10;
            this.밥NO.Text = "아니요";
            this.밥NO.UseVisualStyleBackColor = true;
            this.밥NO.CheckedChanged += new System.EventHandler(this.밥NO_CheckedChanged);
            // 
            // 밥OR
            // 
            this.밥OR.AutoSize = true;
            this.밥OR.Location = new System.Drawing.Point(278, 559);
            this.밥OR.Name = "밥OR";
            this.밥OR.Size = new System.Drawing.Size(310, 22);
            this.밥OR.TabIndex = 11;
            this.밥OR.Text = "넣어먹을때도 안넣어먹을때도있다";
            this.밥OR.UseVisualStyleBackColor = true;
            this.밥OR.CheckedChanged += new System.EventHandler(this.밥OR_CheckedChanged);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Info;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Location = new System.Drawing.Point(859, 641);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(124, 69);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "다음";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1053, 755);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.밥OR);
            this.Controls.Add(this.밥NO);
            this.Controls.Add(this.밥YES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.토핑);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.횟수모름);
            this.Controls.Add(this.횟수3);
            this.Controls.Add(this.횟수2);
            this.Controls.Add(this.횟수1);
            this.Controls.Add(this.횟수0);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox 횟수0;
        private System.Windows.Forms.CheckBox 횟수1;
        private System.Windows.Forms.CheckBox 횟수2;
        private System.Windows.Forms.CheckBox 횟수3;
        private System.Windows.Forms.CheckBox 횟수모름;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox 토핑;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox 밥YES;
        private System.Windows.Forms.CheckBox 밥NO;
        private System.Windows.Forms.CheckBox 밥OR;
        private System.Windows.Forms.Button Button1;
    }
}