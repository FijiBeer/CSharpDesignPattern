using System;

namespace Gushwell.DesignPatterns {
    public interface IContext {
        void SetClock(int hour);  // �����̐ݒ�
        void ChangeState(IState state); // ��ԕω�
        void CallSecurityCenter(string msg); // �x���Z���^�[�x�����Ăяo��
        void RecordLog(string msg); // �x���Z���^�[�L�^
    }
}