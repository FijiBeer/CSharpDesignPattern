using System;

namespace Gushwell.DesignPatterns {
    // ���ԃI�u�W�F�N�g�̋�ۃN���X
    [Serializable]
    public class ColleagueButton : System.Windows.Forms.Button, IColleague {
        private IMediator mediator;
        public ColleagueButton()
            : base() {
        }

        // Mediator��ێ�
        virtual public void SetMediator(IMediator value) {
            this.mediator = value;
        }

        // Mediator����L��/�������w�������
        virtual public void SetColleagueEnabled(bool value) {
            Enabled = value;
        }
    }
}