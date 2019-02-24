using System;

namespace Gushwell.DesignPatterns {
    // ���ԃI�u�W�F�N�g�̋�ۃN���X
    [Serializable]
    public class ColleagueTextField : System.Windows.Forms.TextBox, IColleague {
        private IMediator mediator = null;
        public ColleagueTextField()
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

        // �����񂪕ω�������Mediator�ɒʒm
        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);
            if (mediator != null)
                // ����҂ɕύX�������Ƃ�m�点��
                // ��̓I�ɉ�����邩�́A����҂ɔC����
                mediator.ColleagueChanged();
        }
    }
}