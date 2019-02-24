using System;
using System.Windows.Forms;

// �C�x���g�Ƃ����@�\������̂ŁA���̂悤��WindowsForms�A�v����
// Mediatopr�p�^�[�����g�����Ƃ͂���̂��ȁH ������Ƃ킩��Ȃ��ł��B
// ColleagueButton�Ƃ�ColleagueTextField�Ƃ��͕��ʂ͍��Ȃ��Ǝv���܂��B
// �܂��A�����܂ł�Mediator�p�^�[���̃T���v���Ƃ������ƂŁB
namespace Gushwell.DesignPatterns {

    // ����҃I�u�W�F�N�g
    public partial class LoginForm : Form, IMediator {
        public LoginForm() {
            InitializeComponent();
            CreateColleagues();
            ColleagueChanged();
        }

        // ���O�����Ԃƈ�v���Ȃ��Ȃ������A�I���W�i���̖��O�̂܂܂Ƃ���B
        public virtual void CreateColleagues() {
            // ��Form���A���ꂼ��̃R���g���[���̒��َ҂ɂȂ�
            radioGuest.SetMediator(this);
            radioLogin.SetMediator(this);
            textUser.SetMediator(this);
            textPass.SetMediator(this);
            buttonOk.SetMediator(this);
            buttonCancel.SetMediator(this);
        }

        // Colleage(����)����̒ʒm�ŊeColleage�̗L��/�����𔻒肷��B
        public virtual void ColleagueChanged() {
            if (radioGuest.Checked) {
                // Guest mode
                textUser.SetColleagueEnabled(false);
                textPass.SetColleagueEnabled(false);
                buttonOk.SetColleagueEnabled(true);
            } else {
                // Login mode
                textUser.SetColleagueEnabled(true);
                UserPassChanged();
            }
        }

        // textUser�܂���textPass�̕ύX���������B
        // �eColleage(����)�̗L��/�����𔻒肷��B
        private void UserPassChanged() {
            if (textUser.Text.Length > 0) {
                textPass.SetColleagueEnabled(true);
                if (textPass.Text.Length > 0) {
                    buttonOk.SetColleagueEnabled(true);
                } else {
                    buttonOk.SetColleagueEnabled(false);
                }
            } else {
                textPass.SetColleagueEnabled(false);
                buttonOk.SetColleagueEnabled(false);
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e) {
            Console.WriteLine(sender + " : " + e.ToString());
            Close();
        }
    }
}