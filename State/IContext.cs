using System;

namespace Gushwell.DesignPatterns {
    // �eState�I�u�W�F�N�g��Form�Ƃ�����ۃN���X�Ɉˑ����Ȃ��悤�ɃC���^�[�t�F�[�X���`����B
    // �eState�I�u�W�F�N�g�́A���̃��\�b�h�𗘗p���ď�Ԗ��̓��������
    public interface IContext {
        void SetClock(int hour);  // �����̐ݒ�
        void ChangeState(IState state); // ��ԕω�
        void CallSecurityCenter(string msg); // �x���Z���^�[�x�����Ăяo��
        void RecordLog(string msg); // �x���Z���^�[�L�^
    }
}