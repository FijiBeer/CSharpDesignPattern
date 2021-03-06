using System;

namespace Gushwell.Design.Patterns {

    public class Player {
        private string name;
        private IStrategy strategy;
        private int wincount;
        private int losecount;
        private int gamecount;

        // 名前と戦略を授けられる
        public Player(string name, IStrategy strategy) {
            this.name = name;
            this.strategy = strategy;
        }

        // 戦略におうかがいを立てる
        public Hand NextHand() {
            return strategy.NextHand();
        }

        // 勝った
        public void Win() {
            strategy.Study(true);
            wincount++;
            gamecount++;
        }

        // 負けた
        public void Lose() {
            strategy.Study(false);
            losecount++;
            gamecount++;
        }

        // 引き分け
        public void Even() {
            gamecount++;
        }

        public override string ToString() {
            return "[" + name + ":" + gamecount + " games, " + 
                        wincount + " win, " + 
                        losecount + " lose" + "]";
        }
    }
}