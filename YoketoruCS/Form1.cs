using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        static int PlayerMax => 1;
        static int EnemyMax => 4;
        static int ItemMax => 4;

        static int PlayerIndex => 0;
        static int EnemyIndex => PlayerIndex + PlayerMax;
        static int ItemIndex => EnemyIndex + EnemyMax;
        static int LabelMax => ItemIndex + ItemMax;

        Label[] labels = new Label[LabelMax];

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear,
        }

        /// <summary>
        /// ���ɐ؂�ւ��������
        /// </summary>
        State nextState = State.Title;

        /// <summary>
        /// ���݂̏��
        /// </summary>
        State currentState = State.None;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < LabelMax; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Visible = false;
                Controls.Add(labels[i]);

                tempPlayer.Visible = false;
                tempEnemy.Visible = false;
                tempItem.Visible = false;

                // Text, Font, ForeColor���A��ނ��Ƃɐݒ肵����!!

                // �A�C�e���̂Ƃ�
                // i��???�̂Ƃ�
                if (i >= ItemIndex)
                {
                    labels[i].Font = tempItem.Font;
                    labels[i].ForeColor = tempItem.ForeColor;
                    labels[i].Text = tempItem.Text;
                }
                else if (i >= EnemyIndex)
                {
                    // �G�̂Ƃ�
                    // i��???�̂Ƃ�
                    labels[i].Font = tempEnemy.Font;
                    labels[i].ForeColor = tempEnemy.ForeColor;
                    labels[i].Text = tempEnemy.Text;
                }
                else
                {
                    // �v���C���[�̂Ƃ�
                    // i��???�̂Ƃ�
                    labels[i].Font = tempPlayer.Font;
                    labels[i].ForeColor = tempPlayer.ForeColor;
                    labels[i].Text = tempPlayer.Text;
                }

                if (i >= EnemyIndex)
                {
                    labels[i].Left = labels[i-1].Left + labels[i-1].Width;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitState();
            UpdateState();
        }

        void InitState()
        {
            if (nextState == State.None)
            {
                return;
            }
            currentState = nextState;
            nextState = State.None;

            // ����������
            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;

                    labelGameover.Visible = false;
                    buttonToTitle.Visible = false;
                    labelClear.Visible = false;
                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    for (int i=0;i<LabelMax;i++)
                    {
                        labels[i].Visible = true;
                    }
                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonToTitle.Visible = true;
                    break;

                case State.Clear:
                    labelClear.Visible = true;
                    buttonToTitle.Visible = true;
                    break;

            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }
            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;
            }

            // �v���C���[�̈ړ�
            var fpos = PointToClient(MousePosition);
            labels[PlayerIndex].Left = fpos.X;
            labels[PlayerIndex].Top = fpos.Y;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void buttonToTitle_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}