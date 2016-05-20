# String Concatenation

Text in C# is often worked with and represented as a [String](https://msdn.microsoft.com/en-us/library/system.string.aspx).
This article will cover some ways to create strings, combine strings and display string within a console application.

## Prerequisites

* [Hello World](hello-world.md) - You will need to create a new console application

## Procedurally Generated Narrative Fiction Game

Lets make a game and learn about string concatenation at the same time.
[Concatenation](https://en.wikipedia.org/wiki/Concatenation) is the act of gluing things together.
We will be making a procedurally generated narrative fiction game which involves prompting the player for a few seed words
before taking them on a unique journey with the power to evoke emotions such as joy, confusion and apathy. 

1.
Create a new Windows Console Application project in Visual Studio. Give it a name like PhrasalTemplateWordGame, GladLib or something.

2.
Like in the previous article we will have to add some code to the Main method.
Lets start by prompting our reader for the seed words.
Add the following lines to the Main method:

```csharp
Console.Write("Enter a noun then press Enter: ");
var noun1 = Console.ReadLine();
Console.Write("Enter another noun: ");
var noun2 = Console.ReadLine();
Console.Write("Enter a verb: ");
var verb1 = Console.ReadLine();
```

These six lines of code will prompt the user to enter three words and will store the three words into three variables.
A [variable](https://en.wikipedia.org/wiki/Variable_(computer_science)) is just a place where you can store stuff, like numbers or words.
Our words will be stored in our three variables: noun1, noun2 and verb1.

* `noun1` will contain the first line of text the user entered before pressing the Enter (or Return) key
* `noun2` will contain the second line of text the user entered
* `verb1` will contain the third line of text the user entered

3.
Now that we have our seed data we can use strings to construct our procedurally generated narrative experience.
Add the following lines of code within the Main method but under the six line of code you added previously:

```csharp
Console.WriteLine("You stand in a room and see a " + noun1 + " and a " + noun2 + ".");
Console.WriteLine(string.Concat("For no reason at all you decide to pick up the ", noun2, " and ", verb1, "."));
Console.WriteLine(string.Format("You {0} and {0} repeatedly and eventually trip over the {1}.", verb1, noun1));
Console.WriteLine("You consider trying to {0} again but the {1} is still there so you think better of it.", verb1, noun1);
Console.WriteLine($"Determined, you {verb1} but still trip over the {noun1}.");
```

A [string](https://msdn.microsoft.com/en-us/library/system.string.aspx) is just a sequence of characters or letters.
Strings can be long or short.
Some strings are made by joining other strings together.
The code above shows some of the different ways that we can join smaller strings together to form larger strings.

4.
The story in our game requires an ending so lets add that in.
Add the following two lines of code to the bottom of Main:

```csharp
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("You have died.\n(╯°□°)╯ / ┻━┻");
```

The first of the two lines tells the console that we are going to give it more complicated [Unicode](https://en.wikipedia.org/wiki/Unicode) text
and is required for it to display a table flip correctly but not commonly used.
The second of the two lines actually displays two lines of characters on the console instead of the usual one line.
Within the string in this code is the [escape sequence](https://msdn.microsoft.com/en-us/library/h21280bw.aspx)
of `\n` which adds a new line character to the string and causes a new line at that point in the console output.
This `\n` is what causes the [table flip](https://www.reddit.com/r/PleaseRespectTables/) to appear on a different line from the text message.
After the new line character we then have the characters for our table flip.

5.
Now would be a good time to run the program.
Within Visual Studio press the `[Ctrl]+[F5]` keyboard shortcut or choose Start Without Debugging from the Debug menu.

## Review

Lets go into some detail on the different methods of string concatenation.

### The addition operator

```casharp
"You stand in a room and see a " + noun1 + " and a " + noun2 + "."
```

While adding two strings makes absolutely no sense at all,
the `+` operator is used as a handy shortcut to indicate that you would like to join two or more strings together into a new larger string.
The example above will construct a single string made up of all the smaller parts involved.

### The String.Concat method

```csharp
string.Concat("For no reason at all you decide to pick up the ", noun2, " and ", verb1, ".")
```

This is really the same as the "addition operator" explained above but may or may not be easier for you to type.

### The String.Format method

```csharp
string.Format("You {0} and {0} repeatedly and eventually trip over the {1}.", verb1, noun1)
```

This one is a little different. Instead of doing pure string concatenation like the other examples [Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx) takes a different approach.
The first string that we give it acts like a template for the string we want to have built for us.
Any combination of text in the string that looks like `{number}` will be
replaced with another string to finally form a new string with all the `{}` parts of the template replaced.
The number inside the `{}` corresponds to the other string we specify within the Format method so that `{0}` corresponds to the first value provided, `{1}` corresponds to the second and `{2}` corresponds to the third.
It may seem odd at first that 0 means first and 1 means second but you will get used to it.
In the above example both of the `{0}` parts will be replaced with the string value in `verb1` while the `{1}` will be replaced with the value in `noun1`.

### Console.WriteLine as String.Format

```csharp
Console.WriteLine("You consider trying to {0} again but the {1} is still there so you think better of it.", verb1, noun1);
``` 

Because needing string.Format is used so frequently some other methods that deal with strings may provide similar functionality.
Thankfully [WriteLine](https://msdn.microsoft.com/en-us/library/828t9b9h.aspx) also provides this functionality and it works just as it does for Format.

### Interpolated Strings

```csharp
$"Determined, you {verb1} but still trip over the {noun1}."
```

[Interpolated strings](https://msdn.microsoft.com/en-us/library/dn961160.aspx) (sometimes called Bling Strings)
allow for an even easier way to construct strings.
This string is special in that it starts with a `$` on the outside of the `"` mark.
This `$` is how we tell the compiler that we want this special replacement behavior.
In this example the values in the `verb1` and `noun1` variables will be replaced in the template to form the new string.

You can even use an entire expression with it like `$"one plus one is {1 + 1}"` which can be really handy.
This little example would create a string with the value `one plus one is 2`.