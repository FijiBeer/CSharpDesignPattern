using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns {
    // Entry�́AIAcceptor�C���^�[�t�F�[�X������
    // ���̃N���X����AFIle, Directory��h��������B
    public abstract class Entry : IAcceptor { 
        public string Name { get; }
        public abstract int Size { get; }

        public Entry(string name) {
            this.Name = name;
        }

        // �G���g����ǉ�����
        public virtual Entry Add(Entry entry) {
            throw new FileTreatmentException();
        }

        // ������\��
        public override string ToString() {
            return Name + " (" + Size + ")";
        }
        
        // IAcceptor�C���^�[�t�F�[�X�̃��\�b�h
        public abstract void Accept(IVisitor param1);

    }
}