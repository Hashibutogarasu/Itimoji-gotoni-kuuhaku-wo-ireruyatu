
namespace Itimoji_gotoni_kuuhaku_wo_ireruyatu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HenkansurumojiBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Title3Label = new System.Windows.Forms.Label();
            this.Title2Label = new System.Windows.Forms.Label();
            this.ItimojigotoniirerumojiBox = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountLine = new System.Windows.Forms.Label();
            this.CountLineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HenkansurumojiBox
            // 
            this.HenkansurumojiBox.Location = new System.Drawing.Point(13, 27);
            this.HenkansurumojiBox.Multiline = true;
            this.HenkansurumojiBox.Name = "HenkansurumojiBox";
            this.HenkansurumojiBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HenkansurumojiBox.Size = new System.Drawing.Size(344, 101);
            this.HenkansurumojiBox.TabIndex = 0;
            this.HenkansurumojiBox.TextChanged += new System.EventHandler(this.HenkansurumojiBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 193);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(345, 109);
            this.OutputBox.TabIndex = 3;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(86, 15);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "変換する文字：";
            // 
            // Title3Label
            // 
            this.Title3Label.AutoSize = true;
            this.Title3Label.Location = new System.Drawing.Point(12, 175);
            this.Title3Label.Name = "Title3Label";
            this.Title3Label.Size = new System.Drawing.Size(43, 15);
            this.Title3Label.TabIndex = 3;
            this.Title3Label.Text = "出力：";
            // 
            // Title2Label
            // 
            this.Title2Label.AutoSize = true;
            this.Title2Label.Location = new System.Drawing.Point(13, 131);
            this.Title2Label.Name = "Title2Label";
            this.Title2Label.Size = new System.Drawing.Size(137, 15);
            this.Title2Label.TabIndex = 5;
            this.Title2Label.Text = "一文字ごとに入れる文字：";
            // 
            // ItimojigotoniirerumojiBox
            // 
            this.ItimojigotoniirerumojiBox.Location = new System.Drawing.Point(12, 149);
            this.ItimojigotoniirerumojiBox.Name = "ItimojigotoniirerumojiBox";
            this.ItimojigotoniirerumojiBox.Size = new System.Drawing.Size(345, 23);
            this.ItimojigotoniirerumojiBox.TabIndex = 1;
            this.ItimojigotoniirerumojiBox.TextChanged += new System.EventHandler(this.ItimojigotoniirerumojiBox_TextChanged);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(107, 9);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(55, 15);
            this.Count.TabIndex = 6;
            this.Count.Text = "文字数：";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(158, 9);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(13, 15);
            this.CountLabel.TabIndex = 7;
            this.CountLabel.Text = "0";
            // 
            // CountLine
            // 
            this.CountLine.AutoSize = true;
            this.CountLine.Location = new System.Drawing.Point(177, 9);
            this.CountLine.Name = "CountLine";
            this.CountLine.Size = new System.Drawing.Size(43, 15);
            this.CountLine.TabIndex = 8;
            this.CountLine.Text = "行数：";
            // 
            // CountLineLabel
            // 
            this.CountLineLabel.AutoSize = true;
            this.CountLineLabel.Location = new System.Drawing.Point(216, 9);
            this.CountLineLabel.Name = "CountLineLabel";
            this.CountLineLabel.Size = new System.Drawing.Size(13, 15);
            this.CountLineLabel.TabIndex = 9;
            this.CountLineLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 314);
            this.Controls.Add(this.CountLineLabel);
            this.Controls.Add(this.CountLine);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.ItimojigotoniirerumojiBox);
            this.Controls.Add(this.Title2Label);
            this.Controls.Add(this.Title3Label);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.HenkansurumojiBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 353);
            this.MinimumSize = new System.Drawing.Size(385, 353);
            this.Name = "Form1";
            this.Text = "一文字ごとに文字を入れるツール";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HenkansurumojiBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Title3Label;
        private System.Windows.Forms.Label Title2Label;
        private System.Windows.Forms.TextBox ItimojigotoniirerumojiBox;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label CountLine;
        private System.Windows.Forms.Label CountLineLabel;
    }
}

