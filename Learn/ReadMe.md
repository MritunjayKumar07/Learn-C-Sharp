# Learn C#
## Beginner Level
1. What is C#?:
    - A modern, Object-oriented programming language developed by Microsoft.
    - It's a Part of the .NET framework Or C# run on .NET Framework.
    - C# has roots from the C family, and the language close popular languages like C++ and Java.
    - The 1th version was released in year 2002.
    - C# used for Mobile applications, Desktop applications, Web applications, Web services, Web sites, Games, VR, Database applications, And much, much more!

2. Basic Syntax and Structure:
    - Example of 'Hello World' program.
        ```C#
        using System;
        class HelloWorld
        {
            static void Main()
            {
                Console.WriteLine("Hello World!");
            }
        }
        ```

3. Basic Data Types:
    - `int` (4 bytes) and (-2<spu>31</sup> to 2<sup>31</sup> -1 Range).
    - `long` (8 bytes) and (-2<spu>63</sup> to 2<sup>63</sup> -1 Range).
    - `float` (4 bytes) and (-3.4 x 10<spu>38</sup> to 3.4 x 10<sup>38</sup> -1 Range).
    - `double` (8 bytes) and (-1.7 x 10<spu>308</sup> to 1.7 x 10<sup>308</sup> -1 Range).
    - `char` (2 bytes).
    - `string` (2 bytes per character).
    - `bool` (1 bytes).

4. Variable and Constants:
    - `int number = 10;`
    - `const double PI = 3.14;`
    - `int x = 5, y = 6, z = 50;`
    - ```C#
            int x,y,z;
            x=y=z=50;           
        ```
    - 

5. Comments:
    - Single-line (`//`).
    - Multi-line (`/*...*/`).

6. Type Casting:
    - One data type to another called Type Casting.
    - Two types of type casting.
        1. Implicit Casting (Automatic)
        - Performed automatically by the C# compiler when there is no risk of data loss.
        - Example:
            ```C#
                int num = 123;
                long bigNum = num;
        
                float smallNum = 12.34F;
                double largeNum = smallNum;
            ```
        2. Explicit Casting (Manual)
        - convert one data type to another by manually.
        - Example:
            ```C#
            //Double to int:
                double num = 123.45;
                int intNum = (int)num;
        
            //Long to int:
                long bigNum = 123456789;
                int smallNum  = (int)bigNum;
        
            //String to int:
                string str = "123";
                Convert.ToInt32(str);
        
            //String to double:
                string str = "123.45";
                Convert.ToDouble(str);
        
            //Int to string:
                int myInt = 10;
                Convert.ToString(myInt);
        
            ```
        - This are the all conversion methods:- 
            - `Convert.ToBoolean()`, 
            - `Convert.ToDouble()`, 
            - `Convert.ToString()`, 
            - `Convert.ToInt32()`, 
            - `(int)`,
            - `Convert.ToInt64()`:
    
7. User Input:
    - By using `Console.ReadLine()` to get user Input.
    - Example:
        ```C#
            using System;
            class HelloWorld
            {
                static void Main()
                {
                    string userName;
                    userName = Console.ReadLine();
                    Console.WriteLine("Hello "+ userName+"!");
                }
            }
        ```

8. Operators:
    - Arithmetic Operators: (`+`, `-`, `*`, `/`, `%`, `++`, `--`);
    - Assignment Operators: (`=`, `+=`, `-=`, `*=`, `/=`, `%=`, `&=`, `&=`, `|=`, `^=`, `>>=`, `<<=`);
    - Comparison Operators: (`==`, `!=`, `>`, `<`,`>=`, `<=`);
    - Logical Operators: (`&&`, `||`, `!`);
    Example of `&=`, `|=`, `^=`, `>>=` and `<<=`:
    1. `&=` (Bitwise AND Assignment):
        - AND operators mins if both are true then true(1) another wize false(0).
        ```C#
            int a = 6;  // binary of 6 is   : 0110
            int b = 3;  // binary of 3 is   : 0011
            a &= b;     // binary result is : 0010 which is 2 binary
            Console.WriteLine(a);  //Output : 2
        ```
    2. `|=` (Bitwise OR Assignmenr):
        - OR operators mins if any one are true(1) then true another wize false(0).
        ```C#
            int a = 6;  // binary of 6 is   : 0110
            int b = 3;  // binary of 3 is   : 0011
            a |= b;     // binary result is : 0111 which is 7 binary
            Console.WriteLine(a);  //Output : 7    
        ```
    3. `^=` (Bitwise XOR Assignment):
        - XOR operators mins if both are opposit then true(1) another wize false(0).
        ```C#
            int a = 6;  // binary of 6 is   : 0110
            int b = 3;  // binary of 3 is   : 0011
            a ^= b;     // binary result is : 0101 which is 5 binary
            Console.WriteLine(a);  //Output : 5  
        ```
    4. `>>=` (Right Shift Assignment):
        - First convert into binary, Then remove certain number of digits from right side and add the same number of zero(0) in left side.
        ```C#
            int a = 16;  // 16 in binary:00010000
            a >>= 2;     // Shift right by 2 positions: 00000100
            Console.WriteLine(a);  //Output : 4
        ```
    5. `<<=` (Left Shift Assignment):
        - First convert into binary, Then remove certain number of digits from left side and add the same number of zero(0) in right side.
        ```C#
            int a = 4;  // 16 in binary:00000100
            a <<= 2;     // Shift right by 2 positions: 00010000
            Console.WriteLine(a);  //Output : 16
        ```
        ```C#
            int a = 4;  // 16 in binary:00000100
            a <<= 3;     // Shift right by 2 positions: 00000000
            Console.WriteLine(a);  //Output : 0
        ```
        
9. Math:
    - `Math.Max(5, 10); //Out: 10` Use to find highest value bitween 2 value.
    - `Math.Min(5, 10); //Out: 5` Use to find lowest value bitween 2 value.
    - `Math.Sqrt(64); //Out: 8` Use to find square root of value.
    - `Math.Abs(-4.7); //Out: 4.7` Use to return absolute value.
    - `Math.Round(9.99); //Out: 10` Use to rounds the nearest whole number.

10. Strings:
    - String are used for storing text.
    - String contain collection of characters which is surrounded by doubele quotes.
    - Example:`string greeting = "Hello Mritunjay Kumar!";`.
    - Find length of string: `Console.WriteLine(greeting.Length);`.
    - Methods: 
        1. ToUpper(): `Console.WriteLine(greeting.ToUpper());`.
        2. ToLower(): `Console.WriteLine(greeting.ToLower());`.
    - Concatenation:
        1. Using Operator (`+`):
            ```C#
                string firstName = "Mritunjay";
                string lastName = " Kumar";
                Console.WriteLine(firstName+lastName);
            ```
        2. Using `string.Concat()`:
            ```C#
                string firstName = "Mritunjay";
                string lastName = " Kumar";
                Console.WriteLine(string.Concat(firstName,lastName));
            ```
           Example:
            ```C#
                Console.WriteLine(5 + 2); //Output: 7
                Console.WriteLine('5' + '5'); //Output: 52
                Console.WriteLine("5" + "2"); //Output: 52
                Console.WriteLine(true + true); //Output: Error

                Console.WriteLine(String.Concat(5, 2)); //Output: 52
                Console.WriteLine(String.Concat('5', '2')); //Output: 52
                Console.WriteLine(String.Concat("5", "2")); //Output: 52

                Console.WriteLine(String.Concat(true, true)); //Output: TrueTrue
            ```
    - String Interpolation: (Another method of concatenation by using `$` symbole)
        ```C#
            string firstName = "Mritunjay";
            string lastName = "Kumar";
            Console.WriteLine($"My full name is: {firstName} {lastName}"); //Output: My full name is: Mritunjay Kumar
        ```
    - Access Strings:
        ```C#
            string firstName = "Mritunjay Kumar";
            Console.WriteLine(firstName[0]); //Output: M
            Console.WriteLine(firstName.IndexOf('i')); //Output: 2
            Console.WriteLine(firstName.IndexOf('e')); //Output: -1
            Console.WriteLine(firstName.IndexOf('M')); //Output: 0
            Console.WriteLine(firstName.IndexOf('m')); //Output: -1
            Console.WriteLine(firstName.IndexOf('y')); //Output: 2
            Console.WriteLine(firstName.IndexOf('x')); //Output: -1
            Console.WriteLine(firstName.IndexOf(' ')); //Output: 9
            Console.WriteLine(firstName.IndexOf('K')); //Output: 10

            int a = firstName.IndexOf('K'); //a = 10
            Console.WriteLine(firstName.Substring(a)); //Output: Kumar
        ```        
    - Special Characters:
        - `string txt = "My name is "Mritunjay Kumar";` It's wrong.
        
        | Escape character | Result |  Description |
        |------------------|--------|--------------|
        |        \'        |   '    | Single quote |
        |        \"        |   "    | Double quote |
        |        \\        |   \    | Backslash    |

        | Code |   Result  |
        |------|-----------|
        |  \n  | New Line  |
        |  \t  | Tab       |
        |  \b  | Backspace |

11. Booleans
    - ( YES / NO ), ( ON / OFF ), and ( TRUE / FALSE ).
    ```C#
        bool isFinish = true;
        bool isNotFinish = false;
        Console.WriteLine(isFinish); //Outputs: True
        Console.WriteLine(isNotFinish); //Output: False
        Console.WriteLine(10>9); //Output: True
        Console.WriteLine(10==10); //Output: True
        Console.WriteLine(10==12); //Output: False
        Console.WriteLine(10>=7); //Output: True        
    ```
 
12. if...else if...else:
Syntex:

    ```C#
        if (condition)
        {
            //Block of Code
        }else if(condition 2){
            //Block of Code
        }else { 
            //Block of Code
        }
    ```
Example:

   ```C#
       int time = 22;
       if (time < 10)
       {
           //Not execute
       }else if(time == 22){
           //Execute
       }else { 
           //Not execute
       }
   ```
13. Ternary Operator:

Syntex:

   ```C#
       variable = condition ? executeTruePartOfCode : executeFalsePartOfCode;
   ```
Example:

   ```C#
       Console.WriteLine((2>1)?"2 is gratter":"1 is gratter");
   ```    
    
14. Switch Case:
    - The `switch` statement works with various types of variables including `int`, `char`, `string`, `bool` and `enums`.  It also supports pattern matching.
    - Each `case` label must be a constant value.
    - You cannot have duplicate `case` labels in the same `switch` statement.
    - Each `case` label ends with a colon (`:`).
    - Each `case` typically ends with a `break` statement another wize it go to the next `case`.
    - The `default` case is optional but recommended.
    - It executes if none of the other cases match the switch expression.
    
    - Syntex:
    
        ```C#
            switch(expression) 
            {
              case x:
                // code block
                break;
              case y:
                // code block
                break;
              default:
                // code block
                break;
            }
        ```
   - Example:
   
        ```C#
            int day = 4;
            switch (day) 
            {
              case 1:
                Console.WriteLine("Monday");
                break;
              case 2:
                Console.WriteLine("Tuesday");
                break;
              case 3:
                Console.WriteLine("Wednesday");
                break;
              case 4:
                Console.WriteLine("Thursday");
                break;
              case 5:
                Console.WriteLine("Friday");
                break;
              case 6:
                Console.WriteLine("Saturday");
                break;
              case 7:
                Console.WriteLine("Sunday");
                break;
            }
            // Outputs "Thursday" (day 4)
        ```    

- C# 7.0 introduced `pattern matching`, allowing more complex conditions in `switch` statements.
- Example:

     ```C#
         string command = "start";
         switch (command)
         {
             case "start":
               Console.WriteLine("Starting");
               break;
             case "stop":
               Console.WriteLine("Stopping");
               break;
             case "pause":
               Console.WriteLine("Pausing");
               break;
             default:
               Console.WriteLine("Unknown command");
               break;
         }
     ```     

Example: Type Pattern Matching with `switch`:
- If `obj` is an `int`, the value is assigned to the variable `i`, and the corresponding block is executed, printing the integer value.
- If `obj` is a `string`, the value is assigned to the variable `s`, and the corresponding block is executed, printing the string value.
- If `obj` is `null`, the corresponding block is executed, printing `"Null"`.

    ```C#
        object obj1 = "Hello";
        switch (obj1)
        {
            case int i:
                Console.WriteLine($"Integer: {i}");
                break;
            case string s when s.Length > 5:
                Console.WriteLine($"Long string: {s}");
                break;
            default:
                Console.WriteLine("Other type or shorter string");
                break;
        }
    ```

Example: Pattern Matching with Additional Conditions:
- If `obj1` is an `int`, the value is assigned to the variable `i`, and the `corresponding block is executed`, printing the `integer value`.
- If `obj1` is a `string` and its `length is greater than 5`, the value is assigned to the variable `s`, and the `corresponding block is executed`, printing the `string value`.

    ```C#
        object obj1 = "Hello";
        switch (obj1)
        {
            case int i:
                Console.WriteLine($"Integer: {i}");
                break;
            case string s when s.Length > 5:
                Console.WriteLine($"Long string: {s}");
                break;
            default:
                Console.WriteLine("Other type or shorter string");
                break;
        }
    ``` 

 Example: Switch Expression:
 - Introduced in C# 8.0, which provides a more concise syntax for assigning a value based on the matched case.
 - The `switch` expression evaluates the value of `variable` and matches it against the specified patterns.
 - The underscore `_` serves as a wildcard pattern that matches any value not covered by the previous cases. The expression evaluates to `"Default result"`.
 - The `result` variable will be assigned the value corresponding to the matched case. This approach simplifies the assignment logic compared to a traditional `switch` statement.
 
    ```C#
        var result = variable switch
        {
            value1 => "Result for value1",
            value1 => "Result for value2",
            _ => "Default result",
        };
    ```     
    ```C#
        int variable = 1;
        var result = variable switch
        {
            1 => "Result for value1",
            2 => "Result for value2",
            _ => "Default result",
        };
        Console.WriteLine(result);
    ``` 
15. While Loop:
- Syntax:

     ```C#
         while(condition)
         {
             //Code block
         };
     ```  
- Example:

     ```C#
         int i = 1;
         while(i<5)
         {
             Console.WriteLine(i);
             i++;
         };
     ``` 
16. do While Loop:
- Syntax:
     ```C#
         do
         {
             //Code block
         } while(condition);
     ```  
- Example:
     ```C#
         int i = 1;
         do
         {
             Console.WriteLine(i);
             i++;
         }while(i<5);
     ``` 
17. do While Loop:
- Syntax:
     ```C#
         do
         {
             //Code block
         } while(condition);
     ```  
- Example:
     ```C#
         int i = 1;
         do
         {
             Console.WriteLine(i);
             i++;
         }while(i<5);
     ```
18. For Loop:
- Syntax:

    ```C#
        for (statement 1; statement 2; statement 3) 
        {
          // code block to be executed
        }
    ```  
- Example:

    ```C#
        for (int i = 0; i < 5; i++) 
        {
          Console.WriteLine(i);
        }
    ```
- Nested Loop:
- Example:
    ```C#
        // Outer loop
        for (int i = 1; i <= 2; ++i) 
        {
          Console.WriteLine("Outer: " + i);  // Executes 2 times
          // Inner loop
          for (int j = 1; j <= 3; j++) 
          {
            Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
          }
        }
    ```  
19. Foreach loop:
- There is also a foreach loop, which is used exclusively to loop through elements in an `array`:
- Syntax:

    ```C#
        foreach (type variableName in arrayName) 
        {
          // code block to be executed
        }
    ```  
- Example:

    ```C#
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i in cars) 
        {
          Console.WriteLine(i);
        }
    ```
20. Break & Continue:
- The `break` statement used to jump out of a loop.
- The `continue` statement breaks one `iteration` (in the loop), if a `specified condition occurs`, and `continues with the next iteration in the loop`.    

21. Array: