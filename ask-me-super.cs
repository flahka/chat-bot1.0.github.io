namespace MyFirstConsoleApp 

{ 

class Program 

{ 

static void Main(string[] args) 

{ 

Console.WriteLine("Hello World!"); 

Console.WriteLine("I am Zulkifl. This is my first Console App!"); 

 
 

Console.WriteLine("Can you please tell me your name?"); 

var name = Console.ReadLine(); 

Console.WriteLine($"There are {name.Length} letters in your name."); 

 
 

Console.WriteLine($"That's a really cool name, {name}. I can also help you in Maths."); 

Console.WriteLine("I will help you with multiplication. Write a number."); 

var firstNumber = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Write another number."); 

var secondNumber = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"The answer {firstNumber} times {secondNumber} is {firstNumber * secondNumber}"); 

 
 

Console.WriteLine("What is your favourite colour?"); 

var colour = Console.ReadLine(); 

Console.WriteLine($"I like {colour} too! Actually I like all colours, though blue is my favourite."); 

 
 

} 

} 

} 
