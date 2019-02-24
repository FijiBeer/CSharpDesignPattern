using System;

namespace Gushwell.DesignPatterns {

    public abstract class Support {
        private string name; // ���̃g���u�������҂̖��O
        private Support next; // ���炢�񂵂̐�

        // �g���u�������҂̐���
        public Support(string name) {
            this.name = name;
        }

        // ���炢�񂵂̐��ݒ�
        public virtual Support SetNext(Support next) {
            this.next = next;
            return next;
        }

        // �g���u�������̎菇
        public void DoSupport(Trouble trouble) {
            if (Resolve(trouble)) {
                Done(trouble);
            } else if (next != null) {
                next.DoSupport(trouble);
            } else {
                Fail(trouble);
            }
        }
        // ������\��
        public override string ToString() {
            return "[" + name + "]";
        }

        // �����p���\�b�h
        protected abstract bool Resolve(Trouble trouble);

        // ����
        protected virtual void Done(Trouble trouble) {
            Console.WriteLine(trouble + " is resolved by " + this + ".");
        }

        // ������
        protected virtual void Fail(Trouble trouble) {
            Console.WriteLine(trouble + " cannot be resolved.");
        }
    }
}