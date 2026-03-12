using System.Media; // 효과음 사용 설정
using static System.Net.Mime.MediaTypeNames;
namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0; // 기본점수 0점 설정
        int missCount = 0; // 기본 놓친횟수 0점 설정
        private void runningman_MouseEnter(object sender, EventArgs e)
        {

            SystemSounds.Hand.Play();
            // 1. 난수생성기준비
            Random rd = new Random();
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int maxX = this.ClientSize.Width - runningman.Width;
            int maxY = this.ClientSize.Height - runningman.Height;
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            // 4. 최대 좌표에서 버튼좌표만큼 빼서 form 안에 존재하게 설정
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 5. 위치할당(새로운Point 객체생성)
            runningman.Location = new Point(nextX, nextY);
            // 6. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY}), 점수:{score}";
        }

        private void runningman_Click(object sender, EventArgs e)
        {
            score += 100; //클릭 성공시 100점 추가
            SystemSounds.Asterisk.Play();
            MessageBox.Show("축하합니다!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);// 클릭 성공시 축하메세지 
            runningman.Width = (int)(runningman.Width * 0.9);
            runningman.Height = (int)(runningman.Height * 0.9);
            // 클릭 성공시 버튼의 가로 세로 크기를 10%씩 줄임
        }

        private void runningman_MouseLeave(object sender, EventArgs e)
        {
            score -= 10; // 버튼이 움직여 마우스가 밖으로 떠날시 10점 감점
            missCount++;// 놓친횟수 1회 추가
            if (missCount >= 20)
            {
                DialogResult result = MessageBox.Show(
    "Game Over!\n다시 시작하시겠습니까?",
    "게임 종료",
    MessageBoxButtons.YesNo
);
                if (result == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    runningman.Enabled = false;
                }
                // 놓친횟수가 20회 이상이 되면 게임오버 메시지 박스 표시
                // "다시 시작하시겠습니까?" 질문, Yes 선택 시 게임 초기화, No 선택 시 버튼 비활성화

                return;
            }
        }
        void ResetGame() // 게임 초기화 함수 추가
        {
            score = 0;
            missCount = 0;

            runningman.Width = 355;
            runningman.Height = 183;

            runningman.Enabled = true;

            this.Text = "점수: 0  놓친횟수: 0";

        }
    }
}
