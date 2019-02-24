using System;

namespace Gushwell.DesignPatterns {
    // ��Ԃ̏�Ԃ�\��
    public sealed class NightState : IState {
        // �B��̃C���X�^���X�𓾂�
        public static IState Instance { get; } = new NightState();


        // �R���X�g���N�^��private
        private NightState() {
        }

        // �����ݒ�
        public void DoClock(IContext context, int hour) {
            if (9 <= hour && hour < 17) {
                context.ChangeState(DayState.Instance);
            }
        }

        // ���Ɏg�p
        public void DoUse(IContext context) {
            context.CallSecurityCenter("���F��Ԃ̋��Ɏg�p�I");
        }

        // ���x��
        public void DoAlarm(IContext context) {
            context.CallSecurityCenter("���x��(���)");
        }

        // �ʏ�ʘb
        public void DoPhone(IContext context) {
            context.RecordLog("��Ԃ̒ʘb�^��");
        }
        
        // ������\��
        public override string ToString() {
            return "[���]";
        }
    }
}