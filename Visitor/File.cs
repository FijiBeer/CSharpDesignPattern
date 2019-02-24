using System;

namespace Gushwell.DesignPatterns {
    // Acceptor��ۃN���X

    public class File : Entry {
        private readonly int size;

        public File(string name, int size) : base(name) {
            this.size = size;
        }


        public override int Size {
            get { return size; }

        }

        // �K��҂̎󂯓���
        // �󂯓��ꂽ�Ƃ��ɉ������邩�́AVisitor���m���Ă���B
        public override void Accept(IVisitor v) {
            v.Visit(this);
        }
    }
}