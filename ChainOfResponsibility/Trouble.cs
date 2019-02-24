using System;

namespace Gushwell.DesignPatterns {

    public class Trouble {
        // �g���u���ԍ��𓾂�
        virtual public int Number { get; private set; }

        // �g���u���̐���
        public Trouble(int number) {
            Number = number;
        }

        // �g���u���̕�����\��
        public override string ToString() {
            return "[Trouble " + Number + "]";
        }
    }
}