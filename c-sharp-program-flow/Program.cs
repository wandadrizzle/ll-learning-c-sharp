//I wrote dotnet new console on the Shell to create this.
try {
  Console.WriteLine("Hello, World!\n\n");

  int myVal = 15;
  int[] nums = new int[] {3, 14, 15, 92, 6};
  string str = "The quick brown fox jumps over the lazy dog";

  Console.WriteLine("Using break and continue statements");
foreach (int num in nums){
  if(num>90){
    break;
  }
  if(num%2 == 0){
    continue;
  }
}

// count the number of o's in the string
var count = 0;
foreach (char c in str) {
    if (c == 'o') {
        count++;
    }
}
Console.WriteLine("\nCounted {0} o characters", count);
string inputStr = "";
// the do-while loop always executes at least one time
Console.WriteLine("\nThe  do-while() loop:");
do {
    inputStr = Console.ReadLine();

    Console.WriteLine("You entered: {0}", inputStr);
} while (inputStr != "exit");
Console.WriteLine();


    myVal = 30;
    if(myVal>36){
      throw new ArgumentOutOfRangeException("myVal", "myVal must be less than 36");
    }
    else {
        var result = myVal / 0;
        Console.WriteLine("The result is: {0}", result);
    }
  }
  catch (DivideByZeroException e){
    Console.WriteLine("You can't divide by zero!");
    Console.WriteLine(e.Message);
  }
  catch (ArgumentOutOfRangeException ex){
    Console.WriteLine("Sorry, 36 is the limit!");
    Console.WriteLine(ex.Message);
  }
  catch {
      Console.WriteLine("Whoops, something went wrong");
  }
  finally {
    Console.WriteLine("This code will always execute");
  }
  /*
  Topics covered:
  1. IF
  2. Switch
  3. Loops (for, while, do-while)
  4. Break and continue
  6. Exception Handling

  can use the switch with any data type
  */