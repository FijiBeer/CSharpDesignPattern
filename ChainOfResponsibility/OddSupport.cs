using System;

namespace Gushwell.DesignPatterns {

    public class OddSupport : Support {
        public OddSupport(string name)
            : base(name) {
        }

        // �����p���\�b�h
        protected override bool Resolve(Trouble trouble) {
            return (trouble.Number % 2 == 1);
        }
    }
}