using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyReport.model;
using System.Windows.Forms;

namespace WeeklyReport.control
{
    class InputValueContorol
    {
        //インスタンス変数
        private Form1 form1;

        //コンストラクタ
        public InputValueContorol(Form1 f1)
        {
            form1 = f1;
        }


        public FormTextModel getFormText()
        {
            //入力値を取得する

            FormTextModel model = new FormTextModel();

            //formから渡ってきた開始時間の値をモデルにセット
            //テキストボックスに入力されたTextの値をとりたいからTextになる
            model.startHH1 = form1.StartHH1.Text;
            model.startHH2 = form1.StartHH2.Text;
            model.startHH3 = form1.StartHH3.Text;
            model.startHH4 = form1.StartHH4.Text;
            model.startHH5 = form1.StartHH5.Text;
            model.startHH6 = form1.StartHH6.Text;
            model.startHH7 = form1.StartHH7.Text;

            //formから渡ってきた開始分の値をモデルにセット！
            //コンボボックスの値の中でさらに選択された値をもってきたいからSelectedItemになるって、その値をStringにしてあげる
            model.startMM1 = form1.StartMM1.SelectedItem.ToString();
            model.startMM2 = form1.StartMM2.SelectedItem.ToString();
            model.startMM3 = form1.StartMM3.SelectedItem.ToString();
            model.startMM4 = form1.StartMM4.SelectedItem.ToString();
            model.startMM5 = form1.StartMM5.SelectedItem.ToString();
            model.startMM6 = form1.StartMM6.SelectedItem.ToString();
            model.startMM7 = form1.StartMM7.SelectedItem.ToString();
            
            //formから渡ってきた終了時間の値をモデルにセット！
            model.endHH1 = form1.EndHH1.Text;
            model.endHH2 = form1.EndHH2.Text;
            model.endHH3 = form1.EndHH3.Text;
            model.endHH4 = form1.EndHH4.Text;
            model.endHH5 = form1.EndHH5.Text;
            model.endHH6 = form1.EndHH6.Text;
            model.endHH7 = form1.EndHH7.Text;

            //formから渡ってきた終了分の値をモデルにセット！
            model.endMM1 = form1.EndMM1.SelectedItem.ToString();
            model.endMM2 = form1.EndMM2.SelectedItem.ToString();
            model.endMM3 = form1.EndMM3.SelectedItem.ToString();
            model.endMM4 = form1.EndMM4.SelectedItem.ToString();
            model.endMM5 = form1.EndMM5.SelectedItem.ToString();
            model.endMM6 = form1.EndMM6.SelectedItem.ToString();
            model.endMM7 = form1.EndMM7.SelectedItem.ToString();

            //formから渡ってきた稼動状況の値をモデルにセット！
            model.kadou1 = form1.Kadou1.SelectedItem.ToString();
            model.kadou2 = form1.Kadou2.SelectedItem.ToString();
            model.kadou3 = form1.Kadou3.SelectedItem.ToString();
            model.kadou4 = form1.Kadou4.SelectedItem.ToString();
            model.kadou5 = form1.Kadou5.SelectedItem.ToString();
            model.kadou6 = form1.Kadou6.SelectedItem.ToString();
            model.kadou7 = form1.Kadou7.SelectedItem.ToString();
            
            //formから渡ってきた実施内容の値をモデルにセット;
            model.work1 = form1.work1.Text;
            model.work2 = form1.work2.Text;
            model.work3 = form1.work3.Text;
            model.work4 = form1.work4.Text;
            model.work5 = form1.work5.Text;
            model.work6 = form1.work6.Text;
            model.work7 = form1.work7.Text;

            //formから渡ってきた問題点・改善案の値をモデルにセット！
            model.mondaiKaizen = form1.MondaiKaizen.Text;

            //formから渡ってきたの改善案の実施結果をモデルにセット！
            model.result = form1.Result.Text;

            //formから渡ってきた話たいこと（業務）をモデルにセット！
            model.business = form1.business.Text;

            //formから渡ってきた話たいこと（業務外）をモデルにセット！
            model.play = form1.Play.Text;

            return model;

        }

    }
}
