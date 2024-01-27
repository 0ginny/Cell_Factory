using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void picConMove(PictureBox pictureBox, string dir, int dist, double seconds, int inter)
        {
            int startX = pictureBox.Location.X;
            int startY = pictureBox.Location.Y;

            int endX = startX;
            int endY = startY;

            // 지정된 방향에 따라 끝 좌표 결정
            if (dir.ToLower() == "x")
            {
                endX += dist;
            }
            else if (dir.ToLower() == "y")
            {
                endY += dist;
            }
            else
            {
                // 잘못된 방향일 경우, 이에 대한 처리를 수행할 수 있습니다.
                return;
            }

            picMove(pictureBox, startX, startY, endX, endY, seconds, inter);
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
                // 최대 이동 거리를 적용 (최대값 272로 설정)
                endX = Math.Min(endX, startX + max_dist);
            }
            else if (dir.ToLower() == "y")
            {
                endY += dist;
                // 최대 이동 거리를 적용 (최대값 272로 설정)
                endY = Math.Min(endY, startY + max_dist);
            }
            else
            {
                // 잘못된 방향일 경우, 이에 대한 처리를 수행할 수 있습니다.
                return;
            }

            // 최대 이동 거리가 272보다 작거나 같을 때만 이동
            if (Math.Abs(endX - startX) <= max_dist || Math.Abs(endY - startY) <= max_dist)
            {
                picMove(pictureBox, startX, startY, endX, endY, seconds, inter);
            }

            // 최대 위치에 도달했을 때 visible 파라미터에 따라 PictureBox 숨김
            if (Math.Abs(endX - startX) >= max_dist || Math.Abs(endY - startY) >= max_dist)
            {
                pictureBox.Visible = visible;
            }
        }



        //public void picSpin(PictureBox pictureBox, int startAngle, int endAngle, double seconds, int inter, Point rotationCenter, int startX, int startY, int endX, int endY)
        //{
        //    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        //    timer.Interval = inter; // 타이머 간격 (20ms로 설정, 필요에 따라 변경 가능)

        //    DateTime startTime = DateTime.Now;

        //    timer.Tick += (sender, e) =>
        //    {
        //        TimeSpan elapsed = DateTime.Now - startTime;
        //        double progress = Math.Min(1.0, elapsed.TotalMilliseconds / (seconds * 1000));

        //        double currentAngle = Interpolate(startAngle, endAngle, progress);

        //        PictureBoxExtensions.RotatePictureBox(pictureBox, currentAngle, rotationCenter);

        //        int newX = Interpolate(startX, endX, progress);
        //        int newY = Interpolate(startY, endY, progress);

        //        pictureBox.Location = new Point(newX, newY);

        //        if (progress >= 1.0)
        //        {
        //            timer.Stop();
        //        }
        //    };

        //    timer.Start();
        //}

        //// PictureBox 확장 메서드
        //public static void RotatePictureBox(this PictureBox pictureBox, double angle, Point rotationCenter)
        //{
        //    Bitmap bmp = new Bitmap(pictureBox.Image);
        //    using (Graphics g = Graphics.FromImage(bmp))
        //    {
        //        g.TranslateTransform(rotationCenter.X, rotationCenter.Y); // 회전 중심으로 이동
        //        g.RotateTransform((float)angle); // 지정된 각도로 회전
        //        g.TranslateTransform(-rotationCenter.X, -rotationCenter.Y); // 다시 원래 위치로 이동
        //        g.DrawImage(pictureBox.Image, Point.Empty); // 이미지 그리기
        //    }
        //    pictureBox.Image = bmp;
        //}

        //// 지정된 각도로 Point를 회전하는 메서드
        //public static Point RotatePoint(Point point, double angle, Point rotationCenter)
        //{
        //    double radians = Math.PI * angle / 180.0;
        //    double cosTheta = Math.Cos(radians);
        //    double sinTheta = Math.Sin(radians);

        //    int x = (int)(cosTheta * (point.X - rotationCenter.X) - sinTheta * (point.Y - rotationCenter.Y) + rotationCenter.X);
        //    int y = (int)(sinTheta * (point.X - rotationCenter.X) + cosTheta * (point.Y - rotationCenter.Y) + rotationCenter.Y);

        //    return new Point(x, y);
        //}


    }

    public static class PictureBoxExtensions
    {
        // PictureBox 확장 메서드
        public static void RotatePictureBox(this PictureBox pictureBox, double angle, Point rotationCenter)
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TranslateTransform(rotationCenter.X, rotationCenter.Y); // 회전 중심으로 이동
                g.RotateTransform((float)angle); // 지정된 각도로 회전
                g.TranslateTransform(-rotationCenter.X, -rotationCenter.Y); // 다시 원래 위치로 이동
                g.DrawImage(pictureBox.Image, Point.Empty); // 이미지 그리기
            }
            pictureBox.Image = bmp;
        }
    }
}
