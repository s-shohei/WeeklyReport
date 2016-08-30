using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeklyReport.consts;

namespace WeeklyReport.control
{
    class TimeCnbControl
    {
        //インスタンス変数
        private Form1 form;

        public TimeCnbControl(Form1 f)
        {
            form = f;

        }

        //分コンボボックス全体に値をセット
        public void setTime()
        {
            setValue(form.StartMM1);
            setValue(form.StartMM2);
            setValue(form.StartMM3);
            setValue(form.StartMM4);
            setValue(form.StartMM5);
            setValue(form.StartMM6);
            setValue(form.StartMM7);

            setValue(form.EndMM1);
            setValue(form.EndMM2);
            setValue(form.EndMM3);
            setValue(form.EndMM4);
            setValue(form.EndMM5);
            setValue(form.EndMM6);
            setValue(form.EndMM7);

         }

        //setKadouでsetValueメソッドが呼ばれたら動く
        public void setValue(ComboBox c)
        {
            //form.Start(End)MMXにTimeConstの各値をセットしている
            c.Items.Add(TimeConst.mmconst00);
            c.Items.Add(TimeConst.mmconst15);
            c.Items.Add(TimeConst.mmconst30);
            c.Items.Add(TimeConst.mmconst45);

            //コンボボックスにテキスト入力させない設定
            c.DropDownStyle = ComboBoxStyle.DropDownList;

            //初期値入力設定
            c.SelectedIndex = 2;
        }



    }
}
