using System;
using System.Collections.Generic; 

namespace TheBalls
{
    class Bucket
    {
        private List<Ball> balls = new List<Ball>();

        public void addBall(Ball ball){
            this.balls.Add(ball);
        }

        public int countTheBalls(){
            return this.balls.Count;
        }
        
    }
}