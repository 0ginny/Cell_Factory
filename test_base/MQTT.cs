using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// M2Mqtt 패키지 다운로드
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
//Newtonsoft.Json 라이브러리 다운
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;


namespace test_base
{
    internal class MQTT
    {
        // uPLibrary.Networking.M2Mqtt 패키지에서 제공하는 MqttClient 클래스의 인스턴스
        private MqttClient client;

        // MQTT 브로커의 주소와 클라이언트 ID 설정
        string brokerAddress = "broker.hivemq.com"; // MQTT 브로커의 주소(Host / Port 미작성)
        string clientId = Guid.NewGuid().ToString(); // 고유한 클라이언트 ID 생성

        // 이벤트 핸들러에 전달될 MQTT 메시지 이벤트 아큐먼트 클래스
        public class MqttMessageEventArgs : EventArgs
        {
            public string Message { get; set; }
        }

        // 메시지 수신 시 외부로 알리기 위한 이벤트 정의
        public event EventHandler<MqttMessageEventArgs> MessageReceived;

        /// <summary>
        /// MQTT 클라이언트 생성자
        /// </summary>
        public MQTT()
        {
            // MQTT 클라이언트 인스턴스 생성
            client = new MqttClient(brokerAddress);

            // 메시지 수신 이벤트 핸들러 등록
            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;

            // MQTT 브로커에 연결
            client.Connect(clientId);
        }

        /// <summary>
        /// 주어진 주제에 메시지를 발행합니다.
        /// </summary>
        /// <param name="topic">발행할 주제</param>
        /// <param name="message">전송할 메시지</param>
        public void Publish(string topic, string message)
        {
            // MQTT 브로커에 메시지 발행
            client.Publish(topic, System.Text.Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }

        /// <summary>
        /// 주어진 주제를 구독합니다.
        /// </summary>
        /// <param name="topic">구독할 주제</param>
        public void SubscribeToTopic(string topic)
        {
            // 주어진 주제를 구독하고, QoS 수준을 AT_LEAST_ONCE으로 설정
            client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
        }

        /// <summary>
        /// 메시지 수신 이벤트 핸들러 메서드 정의
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            // 수신된 메시지를 외부로 전달하는 이벤트 발생
            OnMessageReceived(new MqttMessageEventArgs { Message = System.Text.Encoding.UTF8.GetString(e.Message) });
        }

        /// <summary>
        /// MessageReceived 이벤트 발생 메서드 정의
        /// </summary>
        /// <param name="e">전달할 이벤트 아큐먼트</param>
        protected virtual void OnMessageReceived(MqttMessageEventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        }

        /// <summary>
        /// JSON 문자열을 DataTable로 변환하는 메서드입니다.
        /// </summary>
        /// <param name="jsonString">변환할 JSON 문자열입니다.</param>
        /// <returns>변환된 DataTable 객체입니다.</returns>
        public DataTable ConvertJsonToDataTable(string jsonString)
        {
            // JSON 문자열을 JObject로 파싱
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(jsonString);

            DataTable dataTable = new DataTable();

            // JObject에서 Property들을 DataTable에 추가
            foreach (JProperty property in jsonObject.Properties())
            {
                // 각 Property를 DataTable의 열로 추가
                dataTable.Columns.Add(property.Name);

                // 각 Property의 값은 새로운 행을 생성하여 추가
                dataTable.Rows.Add(property.Value.ToString());
            }

            return dataTable;
        }


        /// <summary>
        /// JSON 형식의 메시지를 MqttObject로 파싱하고, UI를 업데이트합니다.
        /// </summary>
        /// <param name="jsonMessage">파싱할 JSON 형식의 메시지입니다.</param>
        public void UpdateMqttObject(string jsonMessage)
        {
            // mqtt_obj에 JSON 메시지를 저장하기 위한 작업
            MqttObject mqtt_obj = ParseJson(jsonMessage);
        }

        /// <summary>
        /// JSON 형식의 문자열을 MqttObject로 파싱합니다.
        /// </summary>
        /// <param name="json">파싱할 JSON 형식의 문자열입니다.</param>
        /// <returns>파싱된 MqttObject 객체 또는 오류 발생 시 null입니다.</returns>
        public MqttObject ParseJson(string json)
        {
            try
            {
                // JSON을 MqttObject로 파싱
                MqttObject mqtt_obj = JsonConvert.DeserializeObject<MqttObject>(json);
                return mqtt_obj;
            }
            catch (JsonException ex)
            {
                // JSON 파싱 오류 처리
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
                return null;
            }
        }
    }
}