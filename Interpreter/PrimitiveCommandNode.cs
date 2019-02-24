using System;
using System.Drawing;

namespace InterpreterSample {
    // <primitive command> ::= go | right | left
    public class PrimitiveCommandNode : INode {
        private string name;

        public void Parse(Context context) {
            name = context.CurrentToken();
            context.SkipToken(name);
            if (!name.Equals("go") && !name.Equals("right") && !name.Equals("left")) {
                throw new ParseException(name + " is undefined");
            }
        }

        public override string ToString() {
            return name;
        }

        public void Print() {
            Console.WriteLine("do:" + name);
        }

        // Run���\�b�h�́A��ʕ`��̂��߂ɓƎ��ɒǉ�
        public void Run(Turtle turtle) {
            turtle.Run(name);
        }
    }
}