using System;
using System.Linq;
using System.Windows.Forms;
using PwdMaker.Services;

namespace PwdMaker
{
    static class Program
    {
        // コマンドライン引数のインデックス。
        private static readonly int COMMAND_INDEX = 1;
        private static readonly string BATCH_COMMAND_LOWER_VALUE = "batch";
        private static readonly int NUMBER_INDEX = 2;
        private static readonly int LENGTH_INDEX = 3;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // コマンドライン引数用の変数。
            int numberValue, lengthValue;

            // コマンドライン引数の判定します。
            if (Environment.GetCommandLineArgs().Count() == 4 &&
                BATCH_COMMAND_LOWER_VALUE.Equals(Environment.GetCommandLineArgs()[COMMAND_INDEX].ToLower()) &&
                int.TryParse(Environment.GetCommandLineArgs()[NUMBER_INDEX], out numberValue) &&
                int.TryParse(Environment.GetCommandLineArgs()[LENGTH_INDEX], out lengthValue))
            {
                // パスワードシングルトンのインスタンスを取得します。
                var pss = PasswordSingletonService.GetInstance();

                // バッチ起動をします。
                var list = pss.MakePasswordByBatchProcess(numberValue, lengthValue);

                // 作成したパスワードをクリップボードに設定します。
                if (list != null) pss.SetClipboard(list, Environment.NewLine);
            }
            else
            {
                // 画面起動をします。
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Presentations.PwdMaker());
            }
        }
    }
}
