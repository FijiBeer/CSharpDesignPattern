using System;

namespace Gushwell.DesignPatterns {

    public class LimitSupport : Support {
        private int limit; // ���̔ԍ������Ȃ�����ł���

        public LimitSupport(string name, int limit)
            : base(name) {
            this.limit = limit;
        }

        // �����p���\�b�h
        protected override bool Resolve(Trouble trouble) {
            return trouble.Number < limit;
        }
    }
}
