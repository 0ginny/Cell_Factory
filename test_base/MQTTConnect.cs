using System;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
//using MQTTnet.Client.Options;
using MQTTnet.Protocol;

class Program
{
    static async Task Main(string[] args)
    {
        await RunMqttClientAsync();
    }

    static async Task RunMqttClientAsync()
    {
        // MQTT 클라이언트 팩토리 생성
        var factory = new MqttFactory();
        // MQTT 클라이언트 생성
        var mqttClient = factory.CreateMqttClient();

        // MQTT 클라이언트 옵션 설정
        var options = new MqttClientOptionsBuilder()
            .WithClientId("@@@@") // 클라이언트 ID 설정
            .WithTcpServer("@@@@.com", 1883) // MQTT 브로커의 주소와 포트 설정
            .Build();

        // MQTT 클라이언트 이벤트 핸들러 설정
        //mqttClient.UseDisconnectedHandler(async e =>
        {
            Console.WriteLine("Disconnected from MQTT broker");
            await Task.Delay(TimeSpan.FromSeconds(5));

            try
            {
                // 재연결 시도
                await mqttClient.ConnectAsync(options);
            }
            catch
            {
                Console.WriteLine("Reconnect failed");
            }
        };

        //  MQTT 클라이언트가 메시지를 수신할 때 실행할 핸들러를 설정
        //mqttClient.UseApplicationMessageReceivedHandler(e =>
        {
            // 수신한 메시지의 내용을 출력
            //Console.WriteLine($"Received message: {e.ApplicationMessage.Payload}");
        };

        // MQTT 브로커에 연결
        await mqttClient.ConnectAsync(options);

        // 연결 성공 시
        Console.WriteLine("Connected to MQTT broker");

        // 메시지 발행 예시
        var message = new MqttApplicationMessageBuilder()
            .WithTopic("@@@@/topic")
            .WithPayload("Hello, MQTT!")
            .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.ExactlyOnce) // QoS 수준 설정
            .WithRetainFlag()
            .Build();

        await mqttClient.PublishAsync(message);

        // 메시지를 수신하려면 프로그램이 계속 실행 중이어야 합니다.
        Console.ReadLine();
    }
}
