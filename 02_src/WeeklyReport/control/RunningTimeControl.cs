using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeklyReport.util;
using WeeklyReport.model;
namespace WeeklyReport.control
{
    public class RunningTimeControl
    {
        Form1 _form;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="form"></param>
        public RunningTimeControl(Form1 form)
        {
            // フォーム受取
            _form = form;
        }

        public void setRunnigTime()
        {
            doSetRunnigTime();
        }

        private void doSetRunnigTime()
        {
            try
            {
                DateTime startTimeSun = RunningTimeUtil.parseDatetime(_form.StartHH1.Text, _form.StartMM1.Text);
                DateTime endTimeSun = RunningTimeUtil.parseDatetime(_form.EndHH1.Text, _form.EndMM1.Text);
                _form.RunningTimeSun.Text = RunningTimeUtil.runningTimeCal(startTimeSun, endTimeSun);
                doSetKadouJyoukyou(1,_form.RunningTimeSun.Text);

                DateTime startTimeMon = RunningTimeUtil.parseDatetime(_form.StartHH2.Text, _form.StartMM2.Text);
                DateTime endTimeMon = RunningTimeUtil.parseDatetime(_form.EndHH2.Text, _form.EndMM2.Text);
                _form.RunningTimeMon.Text = RunningTimeUtil.runningTimeCal(startTimeMon, endTimeMon);
                doSetKadouJyoukyou(2,_form.RunningTimeMon.Text);

                DateTime startTimeTue = RunningTimeUtil.parseDatetime(_form.StartHH3.Text, _form.StartMM3.Text);
                DateTime endTimeTue = RunningTimeUtil.parseDatetime(_form.EndHH3.Text, _form.EndMM3.Text);
                _form.RunningTimeTue.Text = RunningTimeUtil.runningTimeCal(startTimeTue, endTimeTue);
                doSetKadouJyoukyou(3, _form.RunningTimeTue.Text);

                DateTime startTimeWed = RunningTimeUtil.parseDatetime(_form.StartHH4.Text, _form.StartMM4.Text);
                DateTime endTimeWed = RunningTimeUtil.parseDatetime(_form.EndHH4.Text, _form.EndMM4.Text);
                _form.RunningTimeWed.Text = RunningTimeUtil.runningTimeCal(startTimeWed, endTimeWed);
                doSetKadouJyoukyou(4, _form.RunningTimeWed.Text);

                DateTime startTimeThurs = RunningTimeUtil.parseDatetime(_form.StartHH5.Text, _form.StartMM5.Text);
                DateTime endTimeThurs = RunningTimeUtil.parseDatetime(_form.EndHH5.Text, _form.EndMM5.Text);
                _form.RunningTimeThurs.Text = RunningTimeUtil.runningTimeCal(startTimeThurs, endTimeThurs);
                doSetKadouJyoukyou(5, _form.RunningTimeThurs.Text);

                DateTime startTimeFri = RunningTimeUtil.parseDatetime(_form.StartHH6.Text, _form.StartMM6.Text);
                DateTime endTimeFri = RunningTimeUtil.parseDatetime(_form.EndHH6.Text, _form.EndMM6.Text);
                _form.RunningTimeFri.Text = RunningTimeUtil.runningTimeCal(startTimeFri, endTimeFri);
                doSetKadouJyoukyou(6, _form.RunningTimeFri.Text);

                DateTime startTimeSat = RunningTimeUtil.parseDatetime(_form.StartHH7.Text, _form.StartMM7.Text);
                DateTime endTimeSat = RunningTimeUtil.parseDatetime(_form.EndHH7.Text, _form.EndMM7.Text);
                _form.RunningTimeSat.Text = RunningTimeUtil.runningTimeCal(startTimeSat, endTimeSat);
                doSetKadouJyoukyou(7, _form.RunningTimeSat.Text);

            }
            catch (FormatException ex)
            {
                MessageBox.Show("時刻入力値が不正(｀･ω･´)ゞ");
            }
        }

        private void doSetKadouJyoukyou(int index, string runnningTime)
        {
            SettingTextModel model = XmlLoadUtil.settingXmlLoad();

            DateTime kadou_tei_value = RunningTimeUtil.parseDatetimeOfKadou(model.kadou_tei_value);
            DateTime kadou_chu_value = RunningTimeUtil.parseDatetimeOfKadou(model.kadou_chu_value);

            if (DateTime.Parse(runnningTime) <= kadou_tei_value)
            {
                // 低
                switch(index)
                {
                    case 1:
                        if (_form.Kadou1.SelectedIndex == 0 || _form.Kadou1.SelectedIndex == 1 || _form.Kadou1.SelectedIndex == 2)
                        {
                            _form.Kadou1.SelectedIndex = 0;
                        }
                        break;
                    case 2:
                        if (_form.Kadou2.SelectedIndex == 0 || _form.Kadou2.SelectedIndex == 1 || _form.Kadou2.SelectedIndex == 2)
                        {
                            _form.Kadou2.SelectedIndex = 0;
                        }
                        break;
                    case 3:
                        if (_form.Kadou3.SelectedIndex == 0 || _form.Kadou3.SelectedIndex == 1 || _form.Kadou3.SelectedIndex == 2)
                        {
                            _form.Kadou3.SelectedIndex = 0;
                        }
                        break;
                    case 4:
                        if (_form.Kadou4.SelectedIndex == 0 || _form.Kadou4.SelectedIndex == 1 || _form.Kadou4.SelectedIndex == 2)
                        {
                            _form.Kadou4.SelectedIndex = 0;
                        }
                        break;
                    case 5:
                        if (_form.Kadou5.SelectedIndex == 0 || _form.Kadou5.SelectedIndex == 1 || _form.Kadou5.SelectedIndex == 2)
                        {
                            _form.Kadou5.SelectedIndex = 0;
                        }
                        break;
                    case 6:
                        if (_form.Kadou6.SelectedIndex == 0 || _form.Kadou6.SelectedIndex == 1 || _form.Kadou6.SelectedIndex == 2)
                        {
                            _form.Kadou6.SelectedIndex = 0;
                        }
                        break;
                    case 7:
                        if (_form.Kadou7.SelectedIndex == 0 || _form.Kadou7.SelectedIndex == 1 || _form.Kadou7.SelectedIndex == 2)
                        {
                            _form.Kadou7.SelectedIndex = 0;
                        }
                        break;

                }
            }
            else if (kadou_tei_value < DateTime.Parse(runnningTime) && DateTime.Parse(runnningTime) <= kadou_chu_value)
            {
                // 中
                switch (index)
                {
                    case 1:
                        if (_form.Kadou1.SelectedIndex == 0 || _form.Kadou1.SelectedIndex == 1 || _form.Kadou1.SelectedIndex == 2)
                        {
                            _form.Kadou1.SelectedIndex = 1;
                        }
                        break;
                    case 2:
                        if (_form.Kadou2.SelectedIndex == 0 || _form.Kadou2.SelectedIndex == 1 || _form.Kadou2.SelectedIndex == 2)
                        {
                            _form.Kadou2.SelectedIndex = 1;
                        }
                        break;
                    case 3:
                        if (_form.Kadou3.SelectedIndex == 0 || _form.Kadou3.SelectedIndex == 1 || _form.Kadou3.SelectedIndex == 2)
                        {
                            _form.Kadou3.SelectedIndex = 1;
                        }
                        break;
                    case 4:
                        if (_form.Kadou4.SelectedIndex == 0 || _form.Kadou4.SelectedIndex == 1 || _form.Kadou4.SelectedIndex == 2)
                        {
                            _form.Kadou4.SelectedIndex = 1;
                        }
                        break;
                    case 5:
                        if (_form.Kadou5.SelectedIndex == 0 || _form.Kadou5.SelectedIndex == 1 || _form.Kadou5.SelectedIndex == 2)
                        {
                            _form.Kadou5.SelectedIndex = 1;
                        }
                        break;
                    case 6:
                        if (_form.Kadou6.SelectedIndex == 0 || _form.Kadou6.SelectedIndex == 1 || _form.Kadou6.SelectedIndex == 2)
                        {
                            _form.Kadou6.SelectedIndex = 1;
                        }
                        break;
                    case 7:
                        if (_form.Kadou7.SelectedIndex == 0 || _form.Kadou7.SelectedIndex == 1 || _form.Kadou7.SelectedIndex == 2)
                        {
                            _form.Kadou7.SelectedIndex = 1;
                        }
                        break;

                }

            }
            else
            {
                // 高
                switch (index)
                {
                    case 1:
                        if (_form.Kadou1.SelectedIndex == 0 || _form.Kadou1.SelectedIndex == 1 || _form.Kadou1.SelectedIndex == 2)
                        {
                            _form.Kadou1.SelectedIndex = 2;
                        }
                        break;
                    case 2:
                        if (_form.Kadou2.SelectedIndex == 0 || _form.Kadou2.SelectedIndex == 1 || _form.Kadou2.SelectedIndex == 2)
                        {
                            _form.Kadou2.SelectedIndex = 2;
                        }
                        break;
                    case 3:
                        if (_form.Kadou3.SelectedIndex == 0 || _form.Kadou3.SelectedIndex == 1 || _form.Kadou3.SelectedIndex == 2)
                        {
                            _form.Kadou3.SelectedIndex = 2;
                        }
                        break;
                    case 4:
                        if (_form.Kadou4.SelectedIndex == 0 || _form.Kadou4.SelectedIndex == 1 || _form.Kadou4.SelectedIndex == 2)
                        {
                            _form.Kadou4.SelectedIndex = 2;
                        }
                        break;
                    case 5:
                        if (_form.Kadou5.SelectedIndex == 0 || _form.Kadou5.SelectedIndex == 1 || _form.Kadou5.SelectedIndex == 2)
                        {
                            _form.Kadou5.SelectedIndex = 2;
                        }
                        break;
                    case 6:
                        if (_form.Kadou6.SelectedIndex == 0 || _form.Kadou6.SelectedIndex == 1 || _form.Kadou6.SelectedIndex == 2)
                        {
                            _form.Kadou6.SelectedIndex = 2;
                        }
                        break;
                    case 7:
                        if (_form.Kadou7.SelectedIndex == 0 || _form.Kadou7.SelectedIndex == 1 || _form.Kadou7.SelectedIndex == 2)
                        {
                            _form.Kadou7.SelectedIndex = 2;
                        }
                        break;

                }
            }
        }
    }
}
