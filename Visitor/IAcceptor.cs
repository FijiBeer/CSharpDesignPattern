using System;

namespace Gushwell.DesignPatterns {
    // Accepter�C���^�[�t�F�[�X
    public interface IAcceptor {
        void Accept(IVisitor v);
    }
}