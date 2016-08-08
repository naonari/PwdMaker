using System;
using System.Windows.Forms;
using NexFx.Controls;
using PwdMaker.Services;
using PwdMaker.Resources;

namespace PwdMaker.Presentations
{
    public partial class PwdMaker : ExForm
    {
        /// <summary>
        /// コンストラクタ定義。
        /// </summary>
        public PwdMaker()
        {
            // 初期設定を行います。
            InitializeComponent();
        }

        /// <summary>
        /// 画面読込時の処理を行います。
        /// </summary>
        private void PwdMaker_Load(object sender, EventArgs e)
        {
            // 各コントロールに初期値を設定します。
            this.PwdMaker_Initialize(true);
        }

        /// <summary>
        /// 画面の初期化を行います。
        /// </summary>
        /// <param name="forceInitialize">強制画面初期化値。</param>
        private void PwdMaker_Initialize(bool forceInitialize)
        {
            // 設定ファイルサービスを取得します。
            var css = ConfigSingletonService.GetInstance();

            // 各コントロールに初期化します。
            if (forceInitialize || css.GetCompleteInitialize(this.nudNumber.Key, true))
            {
                this.nudNumber.Value = css.GetDefaultValue(this.nudNumber.Key, PasswordSingletonService.DEFAULT_NUMBER_VALUE);
                if (css.GetSetFocus(this.nudNumber.Key, true)) this.nudNumber.Select();
            }

            if (forceInitialize || css.GetCompleteInitialize(this.nudLength.Key, true))
            {
                this.nudLength.Value = css.GetDefaultValue(this.nudLength.Key, PasswordSingletonService.DEFAULT_LENGTH_VALUE);
                if (css.GetSetFocus(this.nudLength.Key, false)) this.nudLength.Select();
            }

            if (forceInitialize || css.GetCompleteInitialize(this.cbUseNumric.Key, true))
            {
                this.cbUseNumric.Checked = css.GetDefaultValue(this.cbUseNumric.Key, PasswordSingletonService.DEFAULT_USE_NUMRIC_VALUE);
                if (css.GetSetFocus(this.cbUseNumric.Key, false)) this.cbUseNumric.Select();
            }

            if (forceInitialize || css.GetCompleteInitialize(this.cbUseUppercase.Key, true))
            {
                this.cbUseUppercase.Checked = css.GetDefaultValue(this.cbUseUppercase.Key, PasswordSingletonService.DEFAULT_USE_UPPERCASE_VALUE);
                if (css.GetSetFocus(this.cbUseUppercase.Key, false)) this.cbUseUppercase.Select();
            }

            if (forceInitialize || css.GetCompleteInitialize(this.cbUseLowercase.Key, true))
            {
                this.cbUseLowercase.Checked = css.GetDefaultValue(this.cbUseLowercase.Key, PasswordSingletonService.DEFAULT_USE_LOWERCASE_VALUE);
                if (css.GetSetFocus(this.cbUseLowercase.Key, false)) this.cbUseLowercase.Select();
            }

            if (forceInitialize || css.GetCompleteInitialize(this.cbUseSymbol.Key, true))
            {
                this.cbUseSymbol.Checked = css.GetDefaultValue(this.cbUseSymbol.Key, PasswordSingletonService.DEFAULT_USE_SYMBOL_VALUE);
                if (css.GetSetFocus(this.cbUseSymbol.Key, false)) this.cbUseSymbol.Select();
            }

            if (forceInitialize || css.GetCompleteInitialize(this.rbClipboard.Key, true))
            {
                this.rbClipboard.Checked = css.GetDefaultValue(this.rbClipboard.Key, PasswordSingletonService.DEFAULT_CLIPBOARD_VALUE);
                if (css.GetSetFocus(this.rbClipboard.Key, false)) this.rbClipboard.Select();
            }

            if (forceInitialize || css.GetCompleteInitialize(this.rbTextFile.Key, true))
            {
                this.rbTextFile.Checked = css.GetDefaultValue(this.rbTextFile.Key, PasswordSingletonService.DEFAULT_TEXT_FILE_VALUE);
                if (css.GetSetFocus(this.rbTextFile.Key, false)) this.rbTextFile.Select();
            }
        }

        // ファイル名のテンプレート。
        private static readonly string FILE_NAME_TMP = "Password_{0}.txt";

        /// <summary>
        /// 作成ボタン押下時の処理を行います。
        /// </summary>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            // 使用する文字種別の検証を行います。
            if (!this.cbUseNumric.Checked && !this.cbUseUppercase.Checked && !this.cbUseLowercase.Checked && !this.cbUseSymbol.Checked)
            {
                // エラーメッセージを表示します。
                MessageBox.Show(Messages.E0001, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // パスワードシングルトンのインスタンスを取得します。
            var pss = PasswordSingletonService.GetInstance();

            // パスワード作成処理を行います。
            var list = pss.MakePassword((int)this.nudNumber.Value,
                                        (int)this.nudLength.Value,
                                        this.cbUseNumric.Checked,
                                        this.cbUseUppercase.Checked,
                                        this.cbUseLowercase.Checked,
                                        this.cbUseSymbol.Checked);

            // パスワードの出力方法を判定します。
            if (this.rbClipboard.Checked)
            {
                // 作成したパスワードをクリップボードに設定します。
                if (list != null) pss.SetClipboard(list, Environment.NewLine);

                // 完了メッセージを表示します。
                MessageBox.Show(Messages.N0001, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // ファイル保存ダイアログをインスタン化します。
                using (var sfd = new SaveFileDialog())
                {
                    // タイムスタンプ文字列を取得します。。
                    var timestampStr = DateTime.Now.ToString("yyyyMMddHHmmssfff");

                    // ファイル保存ダイアログの初期設定を行います。
                    sfd.FileName = string.Format(FILE_NAME_TMP, timestampStr);
                    sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    sfd.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
                    sfd.FilterIndex = 1;
                    sfd.Title = "保存先のファイルを選択してください";

                    // ファイル保存ダイアログを開きます。
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // ファイルを出力します。
                        pss.Output(list, Environment.NewLine, sfd.FileName);

                        // 完了メッセージを表示します。
                        MessageBox.Show(Messages.N0002, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // 初期化せず処理を終了します。
                        return;
                    }
                }
            }

            // 画面の初期化処理を行います。
            this.PwdMaker_Initialize(false);
        }
    }
}
