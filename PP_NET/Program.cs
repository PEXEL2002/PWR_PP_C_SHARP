using System.Security.Cryptography;

namespace PP_NET{
    class FizzBuzz{
        private int _number;
        public FizzBuzz() => this._number = 15;
        public FizzBuzz(int number) => this._number = number;
        public void GetFizzBuzz(){
            for (int i = 1; i <= _number; i++){
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0){
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0){
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }
        }
    }
    internal class Program{
        static void Main(string[] args){
            int number
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.GetFizzBuzz();
        }
    }
}
