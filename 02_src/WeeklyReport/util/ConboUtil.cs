using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeklyReport.consts;

namespace WeeklyReport.util
{
    public static class ConboUtil
    {
        //インスタンス変数
        public static Form1 form;

        //分コンボボックス全体に値をセット
        public static void setTime(Form1 f)
        {
            form = f;

            set_TimeValue(form.StartMM1);
            set_TimeValue(form.StartMM2);
            set_TimeValue(form.StartMM3);
            set_TimeValue(form.StartMM4);
            set_TimeValue(form.StartMM5);
            set_TimeValue(form.StartMM6);
            set_TimeValue(form.StartMM7);

            set_TimeValue(form.EndMM1);
            set_TimeValue(form.EndMM2);
            set_TimeValue(form.EndMM3);
            set_TimeValue(form.EndMM4);
            set_TimeValue(form.EndMM5);
            set_TimeValue(form.EndMM6);
            set_TimeValue(form.EndMM7);

        }

        //setTimeでよばれたら動く
        private static void set_TimeValue(ComboBox c)
        {
            //form.Start(End)MMXにTimeConstの各値をセットしている
            c.Items.Add(TimeConst.mmconst00);
            c.Items.Add(TimeConst.mmconst15);
            c.Items.Add(TimeConst.mmconst30);
            c.Items.Add(TimeConst.mmconst45);

            //コンボボックスにテキスト入力させない設定
            c.DropDownStyle = ComboBoxStyle.DropDownList;

            //初期値(30分)入力設定
            c.SelectedIndex = 2;
        }

        //稼動コンボボックス全体に値をセット
        public static void setKadou(Form1 f)
        {
            form = f;

            set_KadouValue(form.Kadou1);
            set_KadouValue(form.Kadou2);
            set_KadouValue(form.Kadou3);
            set_KadouValue(form.Kadou4);
            set_KadouValue(form.Kadou5);
            set_KadouValue(form.Kadou6);
            set_KadouValue(form.Kadou7);

        }

        //setKadouでsetValueメソッドが呼ばれたら動く
        //ComboBox型のc変数にはsetKadouでsetValueが呼ばれたときに引数(form.KadouX)がはいってくる
        private static void set_KadouValue(ComboBox c)
        {
            //form.KadouXにKadouConstの各値をセットしている
            c.Items.Add(KadouConst.kadoumin);
            c.Items.Add(KadouConst.kadoumid);
            c.Items.Add(KadouConst.kadoumax);
            c.Items.Add(KadouConst.dayoff);
            c.Items.Add(KadouConst.specialholiday);
            c.Items.Add(KadouConst.sickday);

            //コンボボックスにテキスト入力させない設定
            c.DropDownStyle = ComboBoxStyle.DropDownList;

            //初期値入力設定
            if (c.Name == "Kadou1" || c.Name == "Kadou7")
            {
                // 土曜と日曜には初期値として「休日」を設定
                c.SelectedIndex = 3;
            }
            else
            {
                c.SelectedIndex = 0;
            }

        }

    }

}
