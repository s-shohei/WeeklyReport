using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeeklyReport.consts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyReport.control
{
    class KadouCnbControl
    {
        //Form1の値を保持する変数を準備をする
        private Form1 form;


       //コンストラクタをつくる
        public KadouCnbControl(Form1 f)
        {
            //Form1の値を変数fに入れる
            //Fの値をForm1型のformに入れる
            form = f;
        }

        public void setKadou()
        {
            //setValueで値を入れたコンボボックスが取れてsetKadouになる
            setValue(form.Kadou1);
            setValue(form.Kadou2);
            setValue(form.Kadou3);
            setValue(form.Kadou4);
            setValue(form.Kadou5);
            setValue(form.Kadou6);
            setValue(form.Kadou7);

        }

        //setKadouでsetValueメソッドが呼ばれたら動く
        //ComboBox型のc変数にはsetKadouでsetValueが呼ばれたときに引数(form.KadouX)がはいってくる
        public void setValue(ComboBox c)
        {
            //form.KadouXにKadouConstの各値をセットしている
            c.Items.Add(KadouConst.kadoumin);
            c.Items.Add(KadouConst.kadoumid);
            c.Items.Add(KadouConst.kadoumax);
            c.Items.Add(KadouConst.dayoff);

            //コンボボックスにテキスト入力させない設定
            c.DropDownStyle = ComboBoxStyle.DropDownList;

            //初期値入力設定
            if (c.Name == "Kadou1" || c.Name == "Kadou7" ) 
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
