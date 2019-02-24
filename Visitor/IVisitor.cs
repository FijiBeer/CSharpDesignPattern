using System;

namespace Gushwell.DesignPatterns {
    // Visitor�C���^�[�t�F�[�X
    public interface IVisitor {
        void Visit(File file);
        void Visit(Directory directory);
    }
}