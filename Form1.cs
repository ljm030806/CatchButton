using System.Media;
namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
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
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 4. 위치할당(새로운Point 객체생성)
            runningman.Location = new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY}), 점수:{score}";
        }

        private void runningman_Click(object sender, EventArgs e)
        {
            score += 100;
            SystemSounds.Asterisk.Play();
            MessageBox.Show("축하합니다!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            runningman.Width = (int)(runningman.Width * 0.9);
            runningman.Height = (int)(runningman.Height * 0.9);
        }

        private void runningman_MouseLeave(object sender, EventArgs e)
        {
            score -= 10;
        }
    }
}
