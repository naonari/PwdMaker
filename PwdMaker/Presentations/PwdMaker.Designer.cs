﻿namespace PwdMaker.Presentations
{
    partial class PwdMaker : NexFx.Controls.ExForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwdMaker));
            this.pnlScreen = new NexFx.Controls.ExPanel();
            this.gbOutput = new NexFx.Controls.ExGroupBox();
            this.rbTextFile = new NexFx.Controls.ExRadioButton();
            this.rbClipboard = new NexFx.Controls.ExRadioButton();
            this.cbUseNumric = new NexFx.Controls.ExCheckBox();
            this.lblUseNumric = new System.Windows.Forms.Label();
            this.btnExecute = new NexFx.Controls.ExButton();
            this.cbUseSymbol = new NexFx.Controls.ExCheckBox();
            this.lblUseSymbol = new System.Windows.Forms.Label();
            this.cbUseLowercase = new NexFx.Controls.ExCheckBox();
            this.lblUseLowercase = new System.Windows.Forms.Label();
            this.cbUseUppercase = new NexFx.Controls.ExCheckBox();
            this.lblUseUppercase = new System.Windows.Forms.Label();
            this.nudLength = new NexFx.Controls.ExNumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.nudNumber = new NexFx.Controls.ExNumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pnlScreen.SuspendLayout();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreen.Controls.Add(this.gbOutput);
            this.pnlScreen.Controls.Add(this.cbUseNumric);
            this.pnlScreen.Controls.Add(this.lblUseNumric);
            this.pnlScreen.Controls.Add(this.btnExecute);
            this.pnlScreen.Controls.Add(this.cbUseSymbol);
            this.pnlScreen.Controls.Add(this.cbUseLowercase);
            this.pnlScreen.Controls.Add(this.cbUseUppercase);
            this.pnlScreen.Controls.Add(this.nudLength);
            this.pnlScreen.Controls.Add(this.nudNumber);
            this.pnlScreen.Controls.Add(this.lblUseSymbol);
            this.pnlScreen.Controls.Add(this.lblUseLowercase);
            this.pnlScreen.Controls.Add(this.lblUseUppercase);
            this.pnlScreen.Controls.Add(this.lblLength);
            this.pnlScreen.Controls.Add(this.lblNumber);
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(484, 312);
            this.pnlScreen.TabIndex = 0;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.rbTextFile);
            this.gbOutput.Controls.Add(this.rbClipboard);
            this.gbOutput.Location = new System.Drawing.Point(17, 207);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(266, 54);
            this.gbOutput.TabIndex = 12;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "出力方法";
            // 
            // rbTextFile
            // 
            this.rbTextFile.CaptionControl = null;
            this.rbTextFile.FocusedBackColor = System.Drawing.SystemColors.Control;
            this.rbTextFile.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.rbTextFile.Key = "TextFile";
            this.rbTextFile.Location = new System.Drawing.Point(150, 24);
            this.rbTextFile.Name = "rbTextFile";
            this.rbTextFile.Size = new System.Drawing.Size(102, 24);
            this.rbTextFile.TabIndex = 1;
            this.rbTextFile.TabStop = true;
            this.rbTextFile.Text = "テキストファイル";
            this.rbTextFile.UseVisualStyleBackColor = true;
            // 
            // rbClipboard
            // 
            this.rbClipboard.CaptionControl = null;
            this.rbClipboard.FocusedBackColor = System.Drawing.SystemColors.Control;
            this.rbClipboard.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.rbClipboard.Key = "Clipboard";
            this.rbClipboard.Location = new System.Drawing.Point(24, 24);
            this.rbClipboard.Name = "rbClipboard";
            this.rbClipboard.Size = new System.Drawing.Size(104, 24);
            this.rbClipboard.TabIndex = 0;
            this.rbClipboard.TabStop = true;
            this.rbClipboard.Text = "クリップボード";
            this.rbClipboard.UseVisualStyleBackColor = true;
            // 
            // cbUseNumric
            // 
            this.cbUseNumric.AutoSize = true;
            this.cbUseNumric.CaptionControl = this.lblUseNumric;
            this.cbUseNumric.FocusedBackColor = System.Drawing.SystemColors.Info;
            this.cbUseNumric.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.cbUseNumric.Key = "UseNumric";
            this.cbUseNumric.Location = new System.Drawing.Point(167, 79);
            this.cbUseNumric.Name = "cbUseNumric";
            this.cbUseNumric.Size = new System.Drawing.Size(15, 14);
            this.cbUseNumric.TabIndex = 5;
            this.cbUseNumric.UseVisualStyleBackColor = true;
            // 
            // lblUseNumric
            // 
            this.lblUseNumric.AutoSize = true;
            this.lblUseNumric.Location = new System.Drawing.Point(14, 78);
            this.lblUseNumric.Name = "lblUseNumric";
            this.lblUseNumric.Size = new System.Drawing.Size(114, 15);
            this.lblUseNumric.TabIndex = 4;
            this.lblUseNumric.Text = "数字を使用しますか？";
            // 
            // btnExecute
            // 
            this.btnExecute.CaptionControl = null;
            this.btnExecute.FocusedBackColor = System.Drawing.SystemColors.Info;
            this.btnExecute.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExecute.Location = new System.Drawing.Point(12, 267);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(459, 32);
            this.btnExecute.TabIndex = 13;
            this.btnExecute.Text = "作成";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cbUseSymbol
            // 
            this.cbUseSymbol.AutoSize = true;
            this.cbUseSymbol.CaptionControl = this.lblUseSymbol;
            this.cbUseSymbol.FocusedBackColor = System.Drawing.SystemColors.Info;
            this.cbUseSymbol.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.cbUseSymbol.Key = "UseSymbol";
            this.cbUseSymbol.Location = new System.Drawing.Point(167, 181);
            this.cbUseSymbol.Name = "cbUseSymbol";
            this.cbUseSymbol.Size = new System.Drawing.Size(15, 14);
            this.cbUseSymbol.TabIndex = 11;
            this.cbUseSymbol.UseVisualStyleBackColor = true;
            // 
            // lblUseSymbol
            // 
            this.lblUseSymbol.AutoSize = true;
            this.lblUseSymbol.Location = new System.Drawing.Point(14, 180);
            this.lblUseSymbol.Name = "lblUseSymbol";
            this.lblUseSymbol.Size = new System.Drawing.Size(114, 15);
            this.lblUseSymbol.TabIndex = 10;
            this.lblUseSymbol.Text = "記号を使用しますか？";
            // 
            // cbUseLowercase
            // 
            this.cbUseLowercase.AutoSize = true;
            this.cbUseLowercase.CaptionControl = this.lblUseLowercase;
            this.cbUseLowercase.FocusedBackColor = System.Drawing.SystemColors.Info;
            this.cbUseLowercase.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.cbUseLowercase.Key = "UseLowercase";
            this.cbUseLowercase.Location = new System.Drawing.Point(167, 147);
            this.cbUseLowercase.Name = "cbUseLowercase";
            this.cbUseLowercase.Size = new System.Drawing.Size(15, 14);
            this.cbUseLowercase.TabIndex = 9;
            this.cbUseLowercase.UseVisualStyleBackColor = true;
            // 
            // lblUseLowercase
            // 
            this.lblUseLowercase.AutoSize = true;
            this.lblUseLowercase.Location = new System.Drawing.Point(14, 146);
            this.lblUseLowercase.Name = "lblUseLowercase";
            this.lblUseLowercase.Size = new System.Drawing.Size(150, 15);
            this.lblUseLowercase.TabIndex = 8;
            this.lblUseLowercase.Text = "小文字英字を使用しますか？";
            // 
            // cbUseUppercase
            // 
            this.cbUseUppercase.AutoSize = true;
            this.cbUseUppercase.CaptionControl = this.lblUseUppercase;
            this.cbUseUppercase.FocusedBackColor = System.Drawing.SystemColors.Info;
            this.cbUseUppercase.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.cbUseUppercase.Key = "UseUppercase";
            this.cbUseUppercase.Location = new System.Drawing.Point(167, 113);
            this.cbUseUppercase.Name = "cbUseUppercase";
            this.cbUseUppercase.Size = new System.Drawing.Size(15, 14);
            this.cbUseUppercase.TabIndex = 7;
            this.cbUseUppercase.UseVisualStyleBackColor = true;
            // 
            // lblUseUppercase
            // 
            this.lblUseUppercase.AutoSize = true;
            this.lblUseUppercase.Location = new System.Drawing.Point(14, 112);
            this.lblUseUppercase.Name = "lblUseUppercase";
            this.lblUseUppercase.Size = new System.Drawing.Size(150, 15);
            this.lblUseUppercase.TabIndex = 6;
            this.lblUseUppercase.Text = "大文字英字を使用しますか？";
            // 
            // nudLength
            // 
            this.nudLength.CaptionControl = this.lblLength;
            this.nudLength.FocusedBackColor = System.Drawing.SystemColors.Info;
            this.nudLength.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.nudLength.Key = "Length";
            this.nudLength.Location = new System.Drawing.Point(167, 44);
            this.nudLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(178, 23);
            this.nudLength.TabIndex = 3;
            this.nudLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(14, 46);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(145, 15);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "パスワードを何桁にしますか？";
            // 
            // nudNumber
            // 
            this.nudNumber.CaptionControl = this.lblNumber;
            this.nudNumber.FocusedBackColor = System.Drawing.SystemColors.Info;
            this.nudNumber.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.nudNumber.Key = "Number";
            this.nudNumber.Location = new System.Drawing.Point(167, 10);
            this.nudNumber.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(178, 23);
            this.nudNumber.TabIndex = 1;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(14, 12);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(147, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "パスワードを何個作りますか？";
            // 
            // PwdMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.pnlScreen);
            this.DuplicateLastTimePosition = true;
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.GradationColor1 = System.Drawing.Color.MistyRose;
            this.GradationColor2 = System.Drawing.Color.Wheat;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PwdMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PwdMaker";
            this.Load += new System.EventHandler(this.PwdMaker_Load);
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal NexFx.Controls.ExPanel pnlScreen;
        internal NexFx.Controls.ExNumericUpDown nudNumber;
        internal System.Windows.Forms.Label lblNumber;
        internal NexFx.Controls.ExNumericUpDown nudLength;
        internal System.Windows.Forms.Label lblLength;
        internal NexFx.Controls.ExCheckBox cbUseNumric;
        internal System.Windows.Forms.Label lblUseNumric;
        internal NexFx.Controls.ExCheckBox cbUseUppercase;
        internal System.Windows.Forms.Label lblUseUppercase;
        internal NexFx.Controls.ExCheckBox cbUseLowercase;
        internal System.Windows.Forms.Label lblUseLowercase;
        internal NexFx.Controls.ExCheckBox cbUseSymbol;
        internal System.Windows.Forms.Label lblUseSymbol;
        internal NexFx.Controls.ExButton btnExecute;
        private NexFx.Controls.ExGroupBox gbOutput;
        private NexFx.Controls.ExRadioButton rbClipboard;
        private NexFx.Controls.ExRadioButton rbTextFile;
    }
}