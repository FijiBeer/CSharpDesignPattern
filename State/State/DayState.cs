using System;

namespace Gushwell.DesignPatterns {
    // ���Ԃ̏�Ԃ�\��
    public sealed class DayState : IState {
        // �B��̃C���X�^���X�𓾂�
        public static IState Instance { get; } = new DayState();

        
        // �R���X�g���N�^��private
        private DayState() {
        }
        
        // �����ݒ�
        public void DoClock(IContext context, int hour) {
            if (hour < 9 || 17 <= hour) {
                context.ChangeState(NightState.Instance);
            }
        }
        
        // ���Ɏg�p
        public void DoUse(IContext context) {
            context.RecordLog("���Ɏg�p(����)");
        }
        
        // ���x��
        public void DoAlarm(IContext context) {
            context.CallSecurityCenter("���x��(����)");
        }
        
        // �ʏ�ʘb
        public void DoPhone(IContext context) {
            context.CallSecurityCenter("�ʏ�̒ʘb(����)");
        }

        // ������\��
        public override string ToString() {
            return "[����]";
        }
    }
}