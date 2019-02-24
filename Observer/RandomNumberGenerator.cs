using System;
using System.Collections.Generic;
using System.Linq;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {
    public class RandomNumberGenerator : NumberGenerator {

        public override void Execute() {
            RandomMaker.Random(51).Take(20)
                .ForEach(n => OnStepped(n));
        }
    }

    // LINQ �̋@�\���g���Ă݂܂����B
    public static class RandomMaker {
        // 0 - maxValue-1 �̊Ԃŗ����𖳌��ɔ���������B
        public static IEnumerable<int> Random(int maxValue) {
            var random = new Random();
            while (true) {
                yield return random.Next(maxValue);
            }
        }
    }
}
