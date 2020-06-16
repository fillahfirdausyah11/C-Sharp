using System;
using System.Collections.Generic;
using System.Text;

namespace Suhu {

    class Thermometer {
        private Double celcius = 0;
        private Double fahrenheit = 0;
        private Double kelvin = 0;
        public void celciusToFahrenheit(Double celcius) {
            this.celcius = (celcius * 9 / 5) + 32;
        }
        public void fahrenheitToCelcius(Double fahrenheit) {
            this.fahrenheit = (fahrenheit - 32) * 5 / 9;
        }
        public void celciusToKelvin(Double kelvin) {
            this.kelvin = kelvin + 273.15;
        }

        public Tuple<Double, Double, Double> result() {
            return new Tuple<double, double, double>(this.celcius, this.fahrenheit, this.kelvin);
        }

    }
}