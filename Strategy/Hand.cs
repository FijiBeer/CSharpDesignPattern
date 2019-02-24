using System;
using System.Collections.Generic;

namespace Gushwell.Design.Patterns {

    // ���̃N���X�̓I���W�i���Ƃ͑傫���ύX
    public struct Hand {
        public static readonly int GUU = 0; // �O�[��\���l
        public static readonly int CHO = 1; // �`���L��\���l
        public static readonly int PAA = 2; // �p�[��\���l
        private static readonly string[] name = new string[] { "�O�[", "�`���L", "�p�[" };

        // �R���X�g���N�^ (GUU, CHO, PAA�������ɓn��)
        public Hand(int handvalue) {
            if (handvalue < 0 || 2 < handvalue)
                throw new ArgumentException();
            this.Value = handvalue;
        }

        // handValue��Ԃ�
        public int Value { get; }

        // �O�[�A�`���L�A�p�[��Ԃ�
        public string GetName() {
            return name[Value];
        }

        // ����Hnad�ɏ��� Hand�𓾂�
        public Hand StrongHand() {
            return (Hand)((Value + 2) % 3);
        }

        // �l����C���X�^���X�𓾂�
        public static Hand GetHand(int handvalue) {
            return new Hand(handvalue);
        }

        // Hand����@int�ւ̌^�ϊ�
        public static implicit operator Int32(Hand hand) {
            return hand.Value;
        }

        // int����Hnad�ւ̌^�ϊ�
        public static implicit operator Hand(int value) {
            return new Hand(value);
        }

        // Hand��񋓂��邽�߂̃��\�b�h�i�z�j
        public Hand NextHand() {
            var value = Value + 1;
            if (value >= 3)
                value = 0;
            return new Hand(value);
        }

        // Hand���
        public static IEnumerable<Hand> GetValues() {
            yield return new Hand(GUU);
            yield return new Hand(CHO);
            yield return new Hand(PAA);
        }

        // this��h��苭���Ƃ�true
        public bool IsStrongerThan(Hand h) {
            return Fight(h) == 1;
        }

        // this��h���ア�Ƃ�true
        public bool IsWeakerThan(Hand h) {
            return Fight(h) == -1;
        }

        // ����������0, this�̏����Ȃ�1, h�̏����Ȃ�-1
        private int Fight(Hand h) {
            if (this.Equals(h)) {
                return 0;
            } else if (this.Equals(h.StrongHand())) {
                return 1;
            } else {
                return -1;
            }
        }

        // ������\���֕ϊ�
        public override string ToString() {
            return this.GetName();
        }


        public override bool Equals(object obj) {
            if (obj is Hand)
                return this.Value == ((Hand)obj).Value;
            return false;
        }

        public override int GetHashCode() {
            return this.Value.GetHashCode();
        }
    }
}