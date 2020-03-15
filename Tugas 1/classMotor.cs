using System;
using System.Collections.Generic;
using System.Text;

namespace MotorClasic {
        class motor {
           public string color = "green";
            int transmissionState = 0;
            Double speedMax = 250;
            public Double currentSpeed = 0;

            public void go() {
                currentSpeed += 10;
            }

            public void turnLeft() {
                currentSpeed -= 2;
            }
        }
}