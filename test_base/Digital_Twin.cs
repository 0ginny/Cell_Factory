using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_base
{



    internal class Digital_Twin
    {

        MqttObject obj;


        public Digital_Twin(MqttObject mq_obj)
        {
            obj = mq_obj;
        }


        public void picMove(PictureBox pictureBox, int startX, int startY, int endX, int endY, double seconds, int inter)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); 
            timer.Interval = inter; // 타이머 간격 (20ms로 설정, 원하는 값으로 변경 가능)

            DateTime startTime = DateTime.Now;

            timer.Tick += (sender, e) =>
            {
                TimeSpan elapsed = DateTime.Now - startTime;
                double progress = Math.Min(1.0, elapsed.TotalMilliseconds / (seconds * 1000));

                int newX = Interpolate(startX, endX, progress);
                int newY = Interpolate(startY, endY, progress);

                pictureBox.Location = new Point(newX, newY);

                if (progress >= 1.0)
                {
                    timer.Stop();
                }
            };

            timer.Start();
        }

        public int Interpolate(int start, int end, double progress)
        {
            return (int)(start + (end - start) * progress);
        }

    }
}
