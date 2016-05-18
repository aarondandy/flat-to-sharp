# Hello, World!

## Environment setup

To work your way through this tutorial you will need a few things.

1. Windows

    This tutorial assumes you are on Windows 10 but should work for other versions.

2. Visual Studio 2015
    
    If you don't already have Visual Studio 2015 you will need to install it.
    Microsoft has a free Community Edition suitable for most people and small organizations which you can get from here:
    [https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)

## Creating your first C\# program

To start lets create the most basic of all programs, Hello World.

1.
Start by launching the Visual Studio desktop app.
One way to do this is to click the Start button in Windows, search for Visual Studio then click on the Visual Studio 2015 desktop app icon.

2.
With Visual Studio open locate the File menu in the top left corner of the window.
Click that then navigate to the "New" and then click the "Project..." option.

3.
You should now see the "New Project" dialog within Visual Studio.
From the options on the left side within the "Installed" group select the Windows option under Templates, Visual C#.
After selecting that you can now select Console Application from the center of the dialog.
Down below you can give your project a name such as HelloWorld, ConsoleMcConsoleFace or ConsoleApplication7.
Finally when you are satisfied with the name you can click the "OK" button in the bottom right.

Note: In .NET as in other ecosystems there are preferred ways to capitalize the names of things.
Most things in .NET will use <a href="//en.wikipedia.org/wiki/Naming_convention_(programming)#.NET">UpperCamelCase</a>
while some other things will use `lowerCamelCase`. Projects often use UpperCamelCase but certainly don't have to.

4.
After creating the project visual studio will open the code file named "Program.cs" which is the C# code that will execute when your program runs.
Currently the code on the screen in front of you does pretty much nothing at all.
Lets look at the main parts of this program that does nothing:

  * `namespace HelloWorld` - This part of the code specifies that everything within it (within the matching pair of curly braces `{ }`) is within
  the "HelloWorld" namespace, or whatever name you got. Note that the default namespace matches closely to your project name you chose before.
  A namespace is pretty much just a grouping of code and the name of the namespace is just the name for that group.
  * `class Program` - All code in C# must be within a class (or struct). That is just the rule, deal with it.
  Classes can do lots of stuff but in this tutorial we will just make it say "Hello, World!"
  * `static void Main(string[] args)` - There is a lot of stuff going on here but the most important part for us right now is the `Main(` part and the `)` part.
  This is a method named "Main" and when our program is run the code inside it's `{ }` pair will be executed.
  Right now there is nothing inside so it will do nothing when run.

5.
To make it say "Hello, World!" we must add code to make that happen.
This code should go inside of the `{ }` pair associated with Main.

<table>
<tr>
<th>**Yes!**</th><th>no</th><th>no</th><th>no</th>
</tr>
<tr>
<td>
<pre>
void Main()
{
    Code goes here.
}
</pre>
</td>
<td>
<pre>
void Main()
Code
{
}
</pre>
</td>
<td>
<pre>
void Main()
{
}
Code
</pre>
</td>
<td>
<pre>
void Main(<font>Code)
{
}
</pre>
</td>
</tr>
</table>

The statement we need to type to get the program to display the greeting is shown below:

```csharp
Console.WriteLine("Hello, World!");
```

The statement must be typed exactly as shown above including all characters. Even the little `;` at the end, all of it.
This code must be placed in the curly braces `{ }` as demonstrated above.
The final program code when typed correctly should look like this:

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

If you typed it correctly there should be no warnings, errors or red squiggly lines.

6.
You can run the program in a couple of ways to see the message output to a console window.

  * The most common way I have seen is to use the `[Ctrl]+[F5]` keyboard combination.
  * From the "Debug" menu at the top of Visual Studio select "Start Without Debugging"
  
Note: If you accidentally used the "Start" button in the toolbar, `[F5]` on its own or "Start Debugging" options you will not see the message displayed.
Those options are used to watch our code execute step by step. This program does not do much so there is not much to see yet so it closes right away.

If everything worked correctly you should see the following in the console window:

```
Hello, World!
Press any key to continue . . .
```

To close the console window press the `[Any]` key as requested.

Note: If you have trouble locating the `[Any]` key on your keyboard the `[space bar]` is a good alternative.

## Conclusion

With this tutorial complete you have learned how to create a blank console application where you can write, compile and execute your C# code.