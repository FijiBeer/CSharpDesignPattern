using System;
using System.Linq;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {
    // Visitor��ۃN���X
    public class ListVisitor : IVisitor {
        private string currentdir = ""; // ���ݒ��ڂ��Ă���f�B���N�g����

        // �t�@�C����K�₵���Ƃ��ɌĂ΂��
        public void Visit(File file) {
            Console.WriteLine(currentdir + "/" + file);
        }

        // �f�B���N�g����K�₵���Ƃ��ɌĂ΂��
        public void Visit(Directory directory) {
            Console.WriteLine(currentdir + "/" + directory);
            var savedir = currentdir;
            currentdir = currentdir + "/" + directory.Name;
            // Directory�́AIEnumerable<Entry>���������Ă���B
            // directory�z���̂��ׂĂ�Entry���󂯓����B
            directory.ForEach(e => e.Accept(this));
            currentdir = savedir;
        }
    }
}
