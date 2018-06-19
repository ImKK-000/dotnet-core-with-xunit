using System;

namespace fizzbuzz.Service
{
    public class FizzBuzz
    {
        public String Says(int inputNumber) {
            if (isFizzBuzz(inputNumber)) {
                return "FizzBuzz";
            }
            if (isFizz(inputNumber)) {
                return "Fizz";
            }
            if (isBuzz(inputNumber)) {
                return "Buzz";
            }
            return inputNumber.ToString();
        }

        private bool isFizzBuzz(int inputNumber) {
            return (inputNumber % 15 == 0);
        }

        private bool isFizz(int inputNumber) {
            return (inputNumber % 3 == 0);
        }

        private bool isBuzz(int inputNumber) {
            return (inputNumber % 5 == 0);
        }
    }
}
