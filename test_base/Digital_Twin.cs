using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace test_base
{

    internal class Digital_Twin
    {

        MqttObject obj;

        private System.Windows.Forms.Timer conTimer = new System.Windows.Forms.Timer();

        public Digital_Twin(MqttObject mq_obj)
        {
            obj = mq_obj;
        }


        public void picMove(PictureBox pictureBox, int startX, int startY, int endX, int endY, double seconds, int inter)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = inter; // 타이머 간격 (20ms로 설정, 원하는 값으로 변경 가능)

            int currentX = startX;
            int currentY = startY;

            DateTime startTime = DateTime.Now;

            // 초기 위치로 이동
            //pictureBox.Location = new Point(currentX, currentY);

            timer.Tick += (sender, e) =>
            {
                TimeSpan elapsed = DateTime.Now - startTime;
                double progress = Math.Min(1.0, elapsed.TotalMilliseconds / (seconds * 1000));

                int newX = Interpolate(startX, endX, progress);
                int newY = Interpolate(startY, endY, progress);

                // 현재 위치가 시작 위치와 다를 때만 이동 처리
                if (newX != currentX || newY != currentY)
                {
                    pictureBox.Location = new Point(newX, newY);
                    currentX = newX;
                    currentY = newY;
                }

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


        public void picConMove(PictureBox pictureBox, string dir, int dist, double seconds, int inter, int max_dist, bool visible =true)
        {
            int startX = pictureBox.Location.X;
            int startY = pictureBox.Location.Y;

            int endX = startX;
            int endY = startY;

            // 지정된 방향에 따라 끝 좌표 결정
            if (dir.ToLower() == "x")
            {
                endX += dist;
                if (dist > 0 )
                {
                    if (max_dist <= endX) { 
                        endX = max_dist; 
                        pictureBox.Visible = visible;
                    }
                } else
                {
                    if (max_dist >= endX)
                    {
                        endX = max_dist;
                        pictureBox.Visible = visible;
                    }
                }
            }
            else if (dir.ToLower() == "y")
            {
                endY += dist;
                if (dist > 0)
                {
                    if (max_dist <= endY)
                    {
                        endY = max_dist;
                        pictureBox.Visible = visible;

                    }
                }
                else
                {
                    if (max_dist >= endY)
                    {
                        endY = max_dist;
                        pictureBox.Visible = visible;

                    }
                }
            }
            else
            {
                // 잘못된 방향일 경우, 이에 대한 처리를 수행할 수 있습니다.
                return;
            }
            picMove(pictureBox, startX, startY, endX, endY, seconds, inter);
        }

        public void change_stack_pic(PictureBox pbox1, PictureBox pbox2, PictureBox pbox3, int idx)
        {

            switch (idx)
            {
                case 0:
                    pbox1.Image = Properties.Resources.A_cell_stacking;
                    pbox2.Image = Properties.Resources.A_cell_stacking;
                    pbox3.Image = Properties.Resources.A_cell_stacking;
                    break;
                case 1:
                    pbox1.Image = Properties.Resources.B_cell_stacking;
                    pbox2.Image = Properties.Resources.B_cell_stacking;
                    pbox3.Image = Properties.Resources.B_cell_stacking;

                    break;
                case 2:
                    pbox1.Image = Properties.Resources.C_cell_stacking;
                    pbox2.Image = Properties.Resources.C_cell_stacking;
                    pbox3.Image = Properties.Resources.C_cell_stacking;
                    break;
                default:
                    break;
            }
        }

        public void anime_stacking(PictureBox pbox1, PictureBox pbox2, PictureBox pbox3, int floar)
        {
            if (floar == 1){
                pbox1.Visible = false;
                pbox2.Visible = false;
                pbox3.Visible = false;
            } else if (floar == 2)
            {
                pbox1.Visible = true;
                pbox2.Visible = false;
                pbox3.Visible = false;
            } else if (floar == 3)
            {
                pbox1.Visible = true;
                pbox2.Visible = true;
                pbox3.Visible = false;
            } else if (floar == 4)
            {
                pbox1.Visible = true;
                pbox2.Visible = true;
                pbox3.Visible = true;
            } else if (floar == 5)
            {
                pbox1.Visible = !pbox1.Visible;
                pbox2.Visible = !pbox2.Visible;
                pbox3.Visible = !pbox3.Visible;
            }
        }


    }

}
