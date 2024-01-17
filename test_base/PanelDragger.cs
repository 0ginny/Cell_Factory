using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace test_base
{
    internal class PanelDragger
    {
        private bool isDragging = false;
        private Point lastMousePosition;
        private Panel draggablePanel;
        private Form parentForm;

        public PanelDragger(Panel panel, Form form)
        {
            if (panel == null || form == null)
                throw new ArgumentNullException("Panel and Form cannot be null.");

            // 패널의 마우스 다운 이벤트 핸들러 등록
            panel.MouseDown += Panel_MouseDown;

            // 패널 및 윈도우 창을 드래그할 대상으로 설정
            draggablePanel = panel;
            parentForm = form;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;

                // 마우스 움직임 및 마우스 버튼 놓을 때 이벤트 핸들러 등록
                draggablePanel.MouseMove += Panel_MouseMove;
                draggablePanel.MouseUp += Panel_MouseUp;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = parentForm.PointToScreen(e.Location);
                parentForm.Location = new Point(p.X - lastMousePosition.X, p.Y - lastMousePosition.Y);
                lastMousePosition = parentForm.PointToClient(p);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;

                // 마우스 이동 및 마우스 버튼 놓을 때 이벤트 핸들러 제거
                draggablePanel.MouseMove -= Panel_MouseMove;
                draggablePanel.MouseUp -= Panel_MouseUp;
            }
        }
    }

}
