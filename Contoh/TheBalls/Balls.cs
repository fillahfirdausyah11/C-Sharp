using System;

namespace TheBalls
{
    class Ball
    {
        private string color="";

        public void setColor(string color){
            this.color = color;
        }

        public string getColor(){
            return this.color;
        }
    }
}