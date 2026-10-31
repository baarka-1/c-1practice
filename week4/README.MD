Chapter 4: Loops, Files, and Random Numbers

Introduction

This chapter explains how to use loops, file handling, random numbers, and the Load Event in C#. These concepts help programmers repeat tasks, store data, read files, and generate random values.

1. The while Loop

- The while loop repeats statements as long as a Boolean expression is true.
- It is a pretest loop because it checks the condition before executing.
- It can execute zero or more times.
- A counter variable tracks how many times the loop runs.

Example:

int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count++;
}

2. Increment and Decrement Operators

- Increment (++) increases a variable by 1.
- Decrement (--) decreases a variable by 1.

Examples:

count++;
count--;

Other forms:

count += 1;
count = count + 1;

count -= 1;
count = count - 1;

Prefix and Postfix

- Postfix: Uses the old value first, then changes it.
- Prefix: Changes the value first, then uses it.

3. The for Loop

The for loop is used when you know how many times a loop should repeat.

It has three expressions:

1. Initialization: Sets the starting value.
2. Test: Checks the condition.
3. Update: Increases or decreases the counter.

Example:

for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}

Other Forms of Update

Counting by 10:

for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

Counting backward:

for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}

4. The do-while Loop

- The do-while loop executes statements before checking the condition.
- It is a posttest loop.
- It always executes at least once.

Example:

int number = 1;

do
{
    MessageBox.Show(number.ToString());
}
while (number < 0);

5. Using Files for Data Storage

Files are used to save data for later use.

There are three main steps:

1. Open the file.
2. Process the file by reading or writing data.
3. Close the file.

Types of Files

- Text File: Contains data encoded as text.
- Binary File: Contains data that has not been converted into text.

File Classes

- StreamWriter: Used to write data to a text file.
- StreamReader: Used to read data from a text file.

Writing Data to a File

WriteLine(): Writes data and moves to a new line.

Write(): Writes data without moving to a new line.

Example:

StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Computer Science");
outputFile.WriteLine("English");
outputFile.Close();

CreateText() and AppendText()

- CreateText(): Creates a new file or replaces the contents of an existing file.
- AppendText(): Adds new data to an existing file without deleting previous content.

Reading Data from a File

- ReadLine(): Reads one line of text.
- Read(): Reads the next character or characters.
- ReadToEnd(): Reads all remaining characters.
- File.ReadAllText(): Reads all text from a file.

Example:

StreamReader inputFile;

inputFile = File.OpenText("students.txt");

string line = inputFile.ReadLine();

inputFile.Close();

Reading a File with a Loop

The EndOfStream property checks whether the end of a file has been reached.

Example:

while (!inputFile.EndOfStream)
{
    string line = inputFile.ReadLine();
}

6. OpenFileDialog and SaveFileDialog

These controls allow users to open and save files using Windows dialog boxes.

- OpenFileDialog: Displays a dialog box for opening files.
- SaveFileDialog: Displays a dialog box for saving files.

ShowDialog()

Displays the dialog box.

DialogResult

- DialogResult.OK: The user selects Open or Save.
- DialogResult.Cancel: The user cancels the operation.

Filename Property

Stores the selected file's path and filename.

InitialDirectory Property

Specifies the directory that appears first when the dialog box opens.

7. Random Numbers

C# provides the Random class to generate random numbers.

Creating a Random object:

Random rand = new Random();

Random Methods

- Next(): Generates a random integer.
- NextDouble(): Generates a floating-point number between 0.0 and 1.0.

Example:

Random rand = new Random();

int number1 = rand.Next();
double number2 = rand.NextDouble();

Random.Next() Syntax

int number = rand.Next(100);

This generates a random integer from 0 to 99.

8. The Load Event

- The Load event occurs when a form is loaded into memory.
- It executes code when the application form starts.
- To create a Load event handler, double-click the form in the Designer.

Example:

private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}

Conclusion

This chapter covers the while, for, and do-while loops, increment and decrement operators, file handling, OpenFileDialog, SaveFileDialog, random number generation, and the Load Event. These concepts are important for developing Windows Forms applications using C#.