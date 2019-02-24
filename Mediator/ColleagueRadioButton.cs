using System;

namespace Gushwell.DesignPatterns {
    // ���ԃI�u�W�F�N�g�̋�ۃN���X
    [Serializable]
    public class ColleagueRadioButton : System.Windows.Forms.RadioButton, IColleague {
        private IMediator mediator = null;
        public ColleagueRadioButton()
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

        protected override void OnCheckedChanged(EventArgs e) {
            base.OnCheckedChanged(e);
            if (mediator != null)
                // ����҂ɕύX�������Ƃ�m�点��
                // ��̓I�ɉ�����邩�́A����҂ɔC����
                mediator.ColleagueChanged();
        }
    }
}