using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      Console.WriteLine("Введите пятизначное число: ");
      int numb = int.Parse(Console.ReadLine());
      
      if (numb < 10000 || numb >99999)
      {
        Console.WriteLine("Число не пятизначное");
        Console.WriteLine("False");
      }
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}