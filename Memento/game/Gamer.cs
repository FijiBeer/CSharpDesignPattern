using System;
using System.Collections.Generic;
using System.Linq;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns.Game {
    // Memento�N���X���g���A�C���X�^���X�̕ۑ��A�����̋@�\���������Ă���B
    // Originator�ɊY������N���X
    public class Gamer {


        // �t���[�c
        private ICollection<string> fruits = new List<string>();

        // ����������
        private Random random = new Random();

        private static string[] fruitsname = new string[] { "�����S", "�Ԃǂ�", "�o�i�i", "�݂���" };

        // �R���X�g���N�^
        public Gamer(int money) {
            this.Money = money;
        }

        // ���݂̏�����
        public int Money { get; private set; }

        public void Bet() {
            // �q����c�Q�[���̐i�s
            // �T�C�R����U��
            var dice = random.Next(6) + 1; 
            if (dice == 1) {
                // 1�̖ځc��������������
                Money += 100;
                Console.WriteLine("�������������܂����B");
            } else if (dice == 2) {
                // 2�̖ځc�������������ɂȂ�
                Money /= 2;
                Console.WriteLine("�������������ɂȂ�܂����B");
            } else if (dice == 6) {
                // 6�̖ځc�t���[�c�����炤
                var f = GetFruit();
                Console.WriteLine("�t���[�c({0})�����炢�܂����B",f);
                fruits.Add(f);
            } else {
                // ����ȊO�c�����N���Ȃ�
                Console.WriteLine("�����N����܂���ł����B");
            }
        }

        // �X�i�b�v�V���b�g���Ƃ�
        public Memento CreateMemento() {
            var m = new Memento(Money);
            // �t���[�c�͂����������̂����ۑ�
            fruits.Where(f => f.StartsWith("��������"))
                  .ForEach(f => m.AddFruit(f));
            return m;
        }

        // �A���h�D���s��
        public void RestoreMemento(Memento memento) {
            this.Money = memento.Money;
            this.fruits = memento.GetFruits();
        }

        // ������\��
        public override string ToString() {
            var s = string.Join(", ", fruits.ToArray());
            return string.Format("[money = {0}, fruits = [{1}]]", Money, s);
        }

        // �t���[�c��1����
        private string GetFruit() {
            var prefix = "";
            if (random.Next(0, 2) == 0) {
                prefix = "��������";
            }
            return prefix + fruitsname[random.Next(fruitsname.Length)];
        }
    }
}