using System;

namespace Gushwell.DesignPatterns {

    public class NoSupport : Support {
        public NoSupport(string name)
            : base(name) {
        }

        // �����p���\�b�h
        protected override bool Resolve(Trouble trouble) {
            return false; // �����͉����������Ȃ�
        }
    }
}