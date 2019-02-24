using System.Collections.Generic;

namespace Gushwell.DesignPatterns.Game {

    // �I�u�W�F�N�g�̃X�i�b�v�V���b�g��ێ����Ă���
    public class Memento  {
        // �t���[�c
        private ICollection<string> fruits = new List<string>();

        // �������𓾂�(narrow interface)
        public int Money { get; }

        // �R���X�g���N�^(wide interface)
        public Memento(int money) {
            this.Money = money;
        }

        // �t���[�c��ǉ�����(wide interface)
        public void AddFruit(string fruit) {
            fruits.Add(fruit);
        }

        // �t���[�c�𓾂�(wide interface)
        public ICollection<string> GetFruits() {
            // �������ĕԂ��Ă���
            return new List<string>(fruits);
        }

    }
}