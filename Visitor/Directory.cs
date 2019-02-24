using System;
using System.Collections.Generic;
using System.Linq;

namespace Gushwell.DesignPatterns {
    // Acceptor��ۃN���X
    public class Directory : Entry, IEnumerable<Entry> {

        // �ċA���g��Tree�\����\���Ă���
        private List<Entry> dir = new List<Entry>(); // �f�B���N�g���G���g���̏W��

        // �R���X�g���N�^
        public Directory(string name) : base(name){
        }


        // �T�C�Y�𓾂�
        public override int Size {
            get {
                //int size = 0;
                //foreach (Entry entry in dir)
                //    size += entry.Size;
                //return size;
                //��L������Aggregate���g���ď����Ă݂��B
                return dir.Aggregate(0, (a, entry) => a + entry.Size);
            }

        }

        // �G���g���̒ǉ�
        public override Entry Add(Entry entry) {
            dir.Add(entry);
            return this;
        }

        // �K��҂̎󂯓���
        // �󂯓��ꂽ�Ƃ��ɉ������邩�́AVisitor���m���Ă���B
        public override void Accept(IVisitor v) {
            v.Visit(this);
        }

        public IEnumerator<Entry> GetEnumerator() {
            return dir.GetEnumerator();
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }
    }
}