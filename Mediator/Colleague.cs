using System;

namespace Gushwell.DesignPatterns {
    // �����A����
    public interface IColleague {
        // ����҂�ݒ肷��
        void SetMediator(IMediator mediator);

        // Colleague���{�����U�镑��
        void SetColleagueEnabled(bool enabled);
    }
}