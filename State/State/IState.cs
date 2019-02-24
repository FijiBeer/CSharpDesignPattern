using System;

namespace Gushwell.DesignPatterns {
    // ���̃A�v���ŏ�Ԃ����I�u�W�F�N�g�����ׂ��C���^�[�t�F�[�X
    public interface IState {
        void DoClock(IContext context, int hour); // �����ݒ�
        void DoUse(IContext context); // ���Ɏg�p
        void DoAlarm(IContext context); // ���x��
        void DoPhone(IContext context); // �ʏ�ʘb
    }
}