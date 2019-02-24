using System;
using System.Threading;

namespace Gushwell.DesignPatterns {

    // �w�ǎ҃N���X�́AIObserver<T>����������̂�C#��

    public class DigitObserver : IObserver<int> {
        public void OnCompleted() {
 
        }

        public void OnError(Exception error) {

        }

        public void OnNext(int value) {
            Console.WriteLine("DigitObserver:" + value);
            Thread.Sleep(100);
        }

    }
}
