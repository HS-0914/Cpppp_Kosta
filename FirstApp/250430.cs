using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class _250430: Form
    {
        public _250430()
        {
            InitializeComponent();
        }

        private void _250430_Load(object sender, EventArgs e)
        {
            // 1
            result_1.Text = "";
            for (int i = 2; i < 10; i += 2)
            {
                for (int j = 1; j < 10; j++)
                {
                    result_1.Text += $"{i} x {j} = {i * j}\n";
                }
                result_1.Text += "\n";
            }

            // 3
            result_3.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                if (i%3==0)
                {
                    result_3.Text += "박수";
                }
                else
                {
                    result_3.Text += i;
                }
                result_3.Text += " ";
            }

            // 7
            GameBtn_7.Visible = false;
        }

        // 2
        private void AddBtn_2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(input_2.Text))
            {
                todo_2.Items.Add(input_2.Text);
            }
        }

        // 2
        private void DelBtn_2_Click(object sender, EventArgs e)
        {   
            if (todo_2.SelectedIndex != -1)
            {
                int index = todo_2.SelectedIndex;
                todo_2.Items.RemoveAt(index);
            }
        }

        // 4
        private void UseBtn_4_Click(object sender, EventArgs e)
        {
            int coupon = int.Parse(result_4.Text) - 1;
            if (coupon == 0)
            {
                result_4.Text = "모든 이용 쿠폰을\n소진하였습니다.";
            }
            else
            {
                result_4.Text = coupon.ToString();
            }
        }

        // 5
        int count_5 = 0;
        private void SumBtn_5_Click(object sender, EventArgs e)
        {
            bool ok = int.TryParse(input_5.Text, out int num);
            if (ok)
            {
                result_5_1.Text = $"1부터 {num}까지의 합 : {num * (num + 1) / 2}";
                result_5_2.Text = $"수행한 횟수 : {++count_5}번";
            } 
        }

        // 6
        private void SetBtn_6_Click(object sender, EventArgs e)
        {
            Result_6.Text = "";
            Timer_6.Interval = 5000;
            Timer_6.Start();
        }

        // 6
        private void RemoveBtn_6_Click(object sender, EventArgs e)
        {
            if (Timer_6.Enabled)
            {
                Timer_6.Stop();
                Result_6.Text = "갠신히 살았다";
            }
        }

        // 6
        private void Timer_6_Tick(object sender, EventArgs e)
        {
            Timer_6.Stop();
            Result_6.Text = "아 꽝이에요 다음 기회에...";
        }

        // 7
        int count_7 = 0;
        private void StartBtn_7_Click(object sender, EventArgs e)
        {
            RandomMove();
            Timer_7.Interval = 1000;
            Timer_7.Start();
            StartBtn_7.Visible = false;
            GameBtn_7.Visible = true;
        }
        
        private void GameBtn_7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("꽥!!","두더지", MessageBoxButtons.OK);
            count_7++;
            if(count_7 > 5)
            {
                MessageBox.Show("성공", "결과", MessageBoxButtons.OK);
                Timer_7.Stop();
            }
        }

        private void Timer_7_Tick(object sender, EventArgs e)
        {
            RandomMove();
        }

        private void RandomMove()
        {
            Random random = new Random();
            int maxX = groupBox7.Width - GameBtn_7.Width;
            int maxY = groupBox7.Height - GameBtn_7.Height;
            int x = random.Next(0, maxX);
            int y = random.Next(0, maxY);
            GameBtn_7.Location = new Point(x, y);
        }

        // 8
        int seconds = 0;
        private void TimerBtn_8_Click(object sender, EventArgs e)
        {
            if(!Timer_8.Enabled)
            {
                Timer_8.Interval = 1000;
                Timer_8.Start();
                time_8.Text = "00:00:00";
            }
            else
            {
                Timer_8.Stop();
            }
        }

        private void ResetBtn_8_Click(object sender, EventArgs e)
        {
            seconds = 0;
            time_8.Text = "00:00:00";
        }

        private void Timer_8_Tick(object sender, EventArgs e)
        {
            seconds++;
            ShowTime();
        }

        private void ShowTime()
        {
            int second = seconds % 60;
            int min_raw = seconds / 60;
            int min = min_raw % 60;
            int hour = min_raw / 60;
            time_8.Text = $"{DateForm(hour)}:{DateForm(min)}:{DateForm(second)}";
        }

        private string DateForm(int time)
        {
            if(time < 10)
            {
                return $"0{time}";
            }
            return $"{time}";
        }

        // 9
        private void DateTimePicker_9_ValueChanged(object sender, EventArgs e)
        {
            if(!Timer_9_2.Enabled)
            {
                Timer_9_1.Interval = 5000;
                Timer_9_1.Start();
                Timer_9_2.Interval = 1000;
                Timer_9_2.Start();
            }
        }

        private void Timer_9_1_Tick(object sender, EventArgs e)
        {
            Timer_9_1.Stop();
            SoundPlayer player = new SoundPlayer(Properties.Resources.alarm);
            player.Play();
        }

        private void Timer_9_2_Tick(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString();
            string setting = DateTimePicker_9.Value.ToString();
            if (now.Equals(setting))
            {
                Timer_9_2.Stop();
                SoundPlayer player = new SoundPlayer(Properties.Resources.alarm);
                player.Play();
            }
        }
    }
}
