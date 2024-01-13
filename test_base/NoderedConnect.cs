using System;
using System.Windows.Forms;

using System.Net.Http;
using System.Threading.Tasks;


namespace test_base
{
    public partial class NoderedConnect
    {
        // Node-RED 서버의 엔드포인트 주소
        private const string NodeRedEndpoint = "http://your-node-red-server:1880/your-api-endpoint";

        public NoderedConnect()
        {
            
        }

        private async void buttonSendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    // Node-RED API로 GET 요청 보내기
                    HttpResponseMessage response = await httpClient.GetAsync(NodeRedEndpoint);

                    // 응답을 문자열로 변환
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // 여기서 responseBody를 사용하여 적절한 처리 수행
                    // 예: MessageBox.Show(responseBody);
                }
            }
            catch (Exception ex)
            {
                // 오류 발생 시 메시지 박스로 표시
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}