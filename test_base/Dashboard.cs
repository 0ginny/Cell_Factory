using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;
using static test_base.MQTT;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace test_base
{
    public partial class Dashboard : Form
    {
        // 클래스 전역 선언
        DashBord_Class dash;
        CSS css;
        MQTT mqtt;
        MqttObject obj;

        string publish_topic = "publish_chn3";
        string subscribe_topic = "subscribe_chn3";

        public Dashboard()
        {
            InitializeComponent();
            Load += Dashboard_Load;
            
            // 클래스 객체 생성
            dash = new DashBord_Class();
            css = new CSS();
            mqtt = new MQTT();

            //mqtt 구독 시작
            //mqtt.SubscribeToTopic(subscribe_topic);
            // MQTT 수신 이벤트 핸들러 등록, 미 등록시 수신 이벤트 미 처리 : textbox에 메세지가 출력되지 않음
            mqtt.MessageReceived += Mqtt_MessageReceived;

            //standard gauge
            solidGauge1.From = 0;
            solidGauge1.To = 100;
            solidGauge1.Value = 50;
            
            // 설비운전 라벨 설정
            label13.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // 이미지를 프로젝트 리소스에서 가져와서 PictureBox의 이미지로 설정

            //pictureBox1.Image = Properties.Resources.실시간모니터링_그림;




            pictureBox2.Image = Properties.Resources.녹색_1단;


            pictureBox2.Image = Properties.Resources.녹색_1단;

            // 이미 생성된 패널1에 둥근 테두리, 테두리 색상, 테두리 굵기 설정
            css.ApplyRoundedBorder(panel1, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel2, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel3, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel4, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel5, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel6, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능

            // 금일 발생 에러 리스트 표시
            dash.today_error_list(dataGridView1);
            // 금일 착수 예정 리스트 표시
            dash.plan_order_list(dataGridView2);

            InitializeSolidGauge();
        }

        private void InitializeSolidGauge()
        {
            // SolidGauge의 폰트 색상을 변경합니다.
            solidGauge1.ForeColor = ColorTranslator.FromHtml("#3C4E71");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            label13.Visible = true;
            parrotCircleProgressBar1.IsAnimated = true;
            // 버튼 클릭 시 Label13의 텍스트를 "가동중"으로 변경
            label13.Text = " 가동중";


            mqtt.Publish(publish_topic, "start");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            label13.Visible = true;
            parrotCircleProgressBar1.IsAnimated = false;
            // 버튼 클릭 시 Label13의 텍스트를 "정지"로 변경
            label13.Text = "  정지";

            mqtt.Publish(publish_topic, "stop");
        }



        // MQTT 수신 이벤트 핸들러
        private void Mqtt_MessageReceived(object sender, MqttMessageEventArgs e)
        {
            // mqtt_obj에 JSON 메시지를 저장하기 위한 작업
            MqttObject obj = mqtt.ParseJson(e.Message);

            // UI 업데이트
            label9.Invoke(new Action(() =>
            {
                // label1에 OrdId 속성의 값을 할당
                label9.Text = obj?.ord_id;
            }));

            label10.Invoke(new Action(() =>
            {
                // label2에 Company 속성의 값을 할당
                label10.Text = obj?.company;
            }));
            label11.Invoke(new Action(() =>
            {
                // label2에 Company 속성의 값을 할당
                label11.Text = obj?.prod_name;
            }));
            label12.Invoke(new Action(() =>
            {
                // label2에 Company 속성의 값을 할당
                label12.Text =  obj?.ord_num.ToString();
            }));

            // 나머지 레이블들에 대해서도 유사하게 추가할 수 있습니다.
        }
    }
}
