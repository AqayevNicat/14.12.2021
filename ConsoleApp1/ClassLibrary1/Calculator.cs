namespace ClassLibrary1
{
    public class Calculator
    {
        public void Toplama(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }
        public void Cixma(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public void Vurma(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        public void Bolme(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}