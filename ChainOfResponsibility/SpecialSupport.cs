using System;

namespace Gushwell.DesignPatterns {

    public class SpecialSupport : Support {
        private int number; // ���̔ԍ����������ł���

        public SpecialSupport(string name, int number)
            : base(name) {
            this.number = number;
        }

        // �����p���\�b�h
        protected override bool Resolve(Trouble trouble) {
            return (trouble.Number == number);
        }
    }
}