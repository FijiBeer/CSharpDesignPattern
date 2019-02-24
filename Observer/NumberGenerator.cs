using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns {

    // ���s�҃N���X�́AIObservable<T>����������̂�C#��

    public abstract class NumberGenerator : IObservable<int> {

        private List<IObserver<int>> _observers = new List<IObserver<int>>();

        // �C�x���g�𔭍s����B�ʒm���鑊�肪�N���͔c�����Ă��Ȃ��B
        // ���ꂾ���ŁA�o�^����Ă��镡���̃I�u�W�F�N�g�ɒʒm�ł���B
        protected void OnStepped(int number) {
            foreach (var observer in _observers) {
                observer.OnNext(number);
            }
        }

        // ���𐶐�����
        public abstract void Execute();

        public IDisposable Subscribe(IObserver<int> observer) {
            _observers.Add(observer);
            return observer as IDisposable;
        }
    }
}