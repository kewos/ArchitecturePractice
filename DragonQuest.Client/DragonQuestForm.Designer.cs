namespace DragonQuestWFA.Client
{
    partial class DragonQuestForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbScreen = new System.Windows.Forms.RichTextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnReveal = new System.Windows.Forms.Button();
            this.cmbCharactorNames = new System.Windows.Forms.ComboBox();
            this.btnInitial = new System.Windows.Forms.Button();
            this.btnExpedition = new System.Windows.Forms.Button();
            this.cmbMapNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbScreen
            // 
            this.rtbScreen.Location = new System.Drawing.Point(11, 11);
            this.rtbScreen.Margin = new System.Windows.Forms.Padding(2);
            this.rtbScreen.Name = "rtbScreen";
            this.rtbScreen.Size = new System.Drawing.Size(371, 211);
            this.rtbScreen.TabIndex = 0;
            this.rtbScreen.Text = "";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(277, 253);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(50, 29);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "攻擊";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(331, 252);
            this.btnReveal.Margin = new System.Windows.Forms.Padding(2);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(50, 29);
            this.btnReveal.TabIndex = 4;
            this.btnReveal.Text = "顯示";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // cmbCharactorNames
            // 
            this.cmbCharactorNames.FormattingEnabled = true;
            this.cmbCharactorNames.Location = new System.Drawing.Point(11, 226);
            this.cmbCharactorNames.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCharactorNames.Name = "cmbCharactorNames";
            this.cmbCharactorNames.Size = new System.Drawing.Size(193, 20);
            this.cmbCharactorNames.TabIndex = 5;
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(222, 254);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(50, 28);
            this.btnInitial.TabIndex = 6;
            this.btnInitial.Text = "初始";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // btnExpedition
            // 
            this.btnExpedition.Location = new System.Drawing.Point(12, 253);
            this.btnExpedition.Name = "btnExpedition";
            this.btnExpedition.Size = new System.Drawing.Size(75, 23);
            this.btnExpedition.TabIndex = 7;
            this.btnExpedition.Text = "遠征";
            this.btnExpedition.UseVisualStyleBackColor = true;
            this.btnExpedition.Click += new System.EventHandler(this.btnExpedition_Click);
            // 
            // cmbMapNames
            // 
            this.cmbMapNames.FormattingEnabled = true;
            this.cmbMapNames.Location = new System.Drawing.Point(209, 227);
            this.cmbMapNames.Name = "cmbMapNames";
            this.cmbMapNames.Size = new System.Drawing.Size(172, 20);
            this.cmbMapNames.TabIndex = 8;
            // 
            // DragonQuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 290);
            this.Controls.Add(this.cmbMapNames);
            this.Controls.Add(this.btnExpedition);
            this.Controls.Add(this.btnInitial);
            this.Controls.Add(this.cmbCharactorNames);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.rtbScreen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DragonQuestForm";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbScreen;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.ComboBox cmbCharactorNames;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Button btnExpedition;
        private System.Windows.Forms.ComboBox cmbMapNames;
    }
}

