## Chapter 2 — Processing Data




🎯 Learning Objectives

After completing this chapter, you should be able to:

- Read user input using TextBox controls.
- Understand what a variable is.
- Declare and initialize variables.
- Understand local variables and variable scope.
- Use string variables.
- Perform string concatenation.
- Use numeric data types such as "int", "double", and "decimal".
- Understand numeric literals.
- Understand assignment compatibility.
- Convert values using type casting.
- Use the "var" keyword.
- Perform arithmetic calculations.
- Understand integer division.
- Convert TextBox input from string to numeric values.
- Display numeric values using "ToString()".
- Format numbers using the "ToString()" method.
- Understand exception handling.
- Use "try-catch" statements.
- Display exception messages.
- Create named constants using "const".
- Declare variables as fields.
- Use methods from the "Math" class.
- Understand Tab Order and keyboard focus.
- Assign keyboard access keys to buttons.
- Set colors and background images.
- Understand GroupBox and Panel controls.
- Use the Visual Studio debugger to find logic errors.
- Use breakpoints, Locals, Watch, and single-stepping.



## Reading Input with TextBox Controls

A "TextBox" is a rectangular control that allows the user to enter information using the keyboard.

The TextBox control is located in the Common Controls section of the Toolbox.

When a TextBox is added to a form, its default name is usually:

textBox1

The number changes depending on how many TextBox controls are added.



## Text Property

The "Text" property stores the text entered into a TextBox.

Example:

textBox1.Text = "Hello";

To clear the contents of a TextBox:

textBox1.Text = string.Empty;

or:

textBox1.Clear();

You can also use:

textBox1.Text = "";


## Variables

A variable is a storage location in memory.

A variable name represents that memory location.

Before using a variable, it must be declared.

Basic syntax:

DataType VariableName;

Example:

string name;

A variable must have a data type that specifies what kind of data it can store.



## Data Types

A data type specifies the type of data that a variable can hold.

C# provides basic built-in data types.

Examples include:

- "string"
- "int"
- "double"
- "decimal"

The term primitive means basic, simple, or built-in.


## Variable Naming Rules

A variable name identifies a variable.

Variable names should be meaningful.

Basic rules include:

- The first character must be a letter or underscore "_".
- A variable name cannot contain spaces.
- Reserved C# keywords should not be used as variable names.

Example:

studentName
studentName1
_studentName



## String Variables

A "string" is a combination of characters.

A string variable can store values such as:

- Names
- Phone numbers
- Descriptions
- Other text

Example:

string productDescription;

productDescription = "Jamhuuriya University";

A string value is normally written inside double quotation marks.

You can display a string using a MessageBox:

MessageBox.Show(productDescription);



## String Concatenation

Concatenation means joining one string to another.

The "+" operator is used for concatenation.

Example:

string firstName = "Baarliin";
string lastName = "Abdullahi";

string fullName = firstName + " " + lastName;

The "+" operator can also combine strings with other data types.

Example:

int apples = 12;

string message = apples + " apples";

Another example:

double price = 25.75;

string output = "Total is " + price;



## Local Variables and Scope

A local variable belongs to the method in which it is declared.

Only statements inside that method can access the local variable.

Scope describes the part of a program where a variable can be accessed.

Lifetime describes the period during which the variable exists in memory while the program is executing.

A local variable is created when its method starts executing and is destroyed when the method ends.

Example:

private void firstButton_Click(object sender, EventArgs e)
{
    string myName;

    myName = nameTextBox.Text;
}

The variable "myName" can only be accessed inside that method.



## Duplicate Variable Names

You cannot declare two variables with the same name in the same scope.

For example:

string name;
string name;

This is not allowed in the same scope.

However, variables with the same name can exist in different methods because each method has its own local scope.



## Assignment Compatibility

A value can be assigned to a variable only when the value is compatible with the variable's data type.

Example:

string name = "Baarliin";

A string value is compatible with a "string" variable.



## Initializing Variables

A variable should be assigned a value before it is used.

Example:

string productDescription = "Laptop";

If a local variable is declared but not assigned a value before being used, the C# compiler reports an error.

Example:

string productDescription;

MessageBox.Show(productDescription);

This produces an error because the variable has not been assigned a value.


## Declaring Multiple Variables

You can declare multiple variables of the same data type in one statement.

Example:

string lastName, firstName, middleName;

You can also initialize multiple variables:

string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi";



## Numeric Data Types

Numeric data types are used when numbers need to be stored and used in mathematical operations.

Common numeric data types include:

Data Type| Description
"int"| Whole numbers
"double"| Real numbers, including fractional values
"decimal"| Numbers stored with greater precision, commonly used for financial applications

Example:

int hoursWorked = 40;

double temperature = 87.6;

decimal payRate = 28.75m;



## Numeric Literals

A numeric literal is a number written directly in program code.

Examples:

int hoursWorked = 40;

double temperature = 87.6;

Integer literals such as "40" and "99" are treated as "int".

Numbers with decimal points such as "87.6" and "3.14" are treated as "double".

To create a decimal literal, add "m" or "M":

decimal payRate = 28.75m;



## Assignment Compatibility for Numeric Types

An "int" value can be assigned to an "int" variable:

int hoursWorked = 40;

But a "double" or "decimal" value cannot automatically be assigned to an "int".

Example:

int score = -25.5;   // ERROR

A "double" variable can accept an "int" value:

double speed = 75;

A "decimal" variable can accept an "int" value:

decimal price = 50;



## Type Casting

Type casting allows you to explicitly convert a value from one data type to another compatible type.

The cast operator is the type name placed inside parentheses.

Example:

decimal moneyNumber = 4500m;

int wholeNumber = (int)moneyNumber;

Another example:

decimal moneyNumber = 625.70m;

double realNumber = (double)moneyNumber;

Type casting is called explicit conversion because the programmer specifies the conversion.


## The "var" Keyword

The "var" keyword allows the compiler to determine the data type from the value assigned to the variable.

Example:

var interestRate = 12.0;

var stockCode = "D465U";

var accountBalance = 1000.0m;

The compiler determines the type automatically.

When using "var", you must provide an initialization value.

var name = "Baarliin";

The "var" keyword can be used to declare local variables.



## Performing Calculations

C# provides arithmetic operators for mathematical calculations.

Operator| Name| Description
"+"| Addition| Adds two numbers
"-"| Subtraction| Subtracts one number from another
"*"| Multiplication| Multiplies two numbers
"/"| Division| Divides one number by another
"%"| Modulus| Returns the remainder

Example:

int x = 5;
int y = 4;

MessageBox.Show((x + y).ToString());



## Rules for Performing Calculations

A mathematical expression performs a calculation and produces a value.

Example:

int x = 5;
int y = 4;

MessageBox.Show((x + y).ToString());

Parentheses can be used to control the order of operations.

Example:

result = (a + b) / 4;

When different numeric data types are used:

- "int" with "double" produces a "double".
- "int" with "decimal" produces a "decimal".
- An operation between "double" and "decimal" is not allowed directly.


## Integer Division

When an integer is divided by another integer, the result is an integer.

Example:

int x = 7;
int y = 3;

MessageBox.Show((x / y).ToString());

The result is:

2

To obtain a decimal result, use "double":

double x = 7;
double y = 3;

MessageBox.Show((x / y).ToString());

Or:

int x = 7;
int y = 3;

MessageBox.Show(((double)x / y).ToString());



## Inputting Numeric Values

TextBox controls treat keyboard input as strings.

For example, if the user enters:

25.65

the TextBox stores it as a "string", not as a number.

To use the value in a mathematical calculation, it must be converted to the appropriate numeric data type.



## Parse Methods

C# provides "Parse" methods for converting strings into numeric values.

Examples:

int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

double temperature = double.Parse(temperatureTextBox.Text);

decimal price = decimal.Parse(priceTextBox.Text);

Common methods include:

- "int.Parse()"
- "double.Parse()"
- "decimal.Parse()"



## Displaying Numeric Values

The "Text" property of a Label or TextBox accepts string values.

Therefore, numeric values can be converted to strings using the "ToString()" method.

General syntax:

variableName.ToString()

Example:

decimal grossPay = 1550.0m;

grossPayLabel.Text = grossPay.ToString();

Another example:

int myNumber = 123;

MessageBox.Show(myNumber.ToString());

You can also combine a number with a string using "+":

int idNumber = 1044;

string output = "Your ID number is " + idNumber;



## Formatting Numbers with "ToString()"

The "ToString()" method can format a number into a specific display format.

Common format strings include:

Format| Description| Example
"N"| Number format| "ToString("n3")"
"F"| Fixed-point format| "ToString("f2")"
"E"| Exponential format| "ToString("e3")"
"C"| Currency format| "ToString("C")"
"P"| Percentage format| "ToString("P")"

Example:

double number = 12.3;

string result = number.ToString("n3");

This can display:

12.300



## Exception Handling

An exception is an unexpected error that occurs while a program is running.

Examples include:

- Dividing by zero.
- Opening a file that does not exist.
- Entering invalid user input.

If an exception is not handled, the application may stop unexpectedly.

Exception handling allows a program to respond to errors instead of abruptly stopping.



## Try-Catch

The "try-catch" statement is used to handle exceptions.

Basic structure:

try
{
    // Statements that may cause an exception
}
catch
{
    // Statements that handle the exception
}

The "try" block contains code that may cause an exception.

The "catch" block contains code that responds when an exception occurs.

Example:

try
{
    double miles;
    double gallons;
    double mpg;

    miles = double.Parse(milesTextBox.Text);
    gallons = double.Parse(gallonsTextBox.Text);

    mpg = miles / gallons;

    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}



## Throwing vs Catching

Throwing means an error occurs and an exception is raised.

Catching means the program handles that exception.

Simple example:

Throwing = Error occurs
Catching = Program handles the error

Real-life example:

An ATM may raise an error when an incorrect PIN is entered.

Instead of stopping, it can display:

Invalid PIN, please try again.



## Displaying an Exception Message

Every exception in C# is represented by an object.

The "Exception" object has a "Message" property that contains a description of the error.

Example:

try
{
    // Statements
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}



## Named Constants

A named constant represents a value that cannot be changed while the program is executing.

The "const" keyword is used to declare a constant.

Example:

const double INTEREST_RATE = 0.129;

Writing constant names in uppercase letters is a common convention.

---

## Fields

A field is a variable declared at the class level.

A field is declared inside a class but outside any method.

Example:

public partial class Form1 : Form
{
    private string name = "Charles";
}

The scope of a field is the entire class.

A field is created in memory when the form is created.



## Math Class

The .NET "Math" class provides methods for mathematical calculations.

Common methods include:

Method| Description
"Math.Sqrt(x)"| Returns the square root
"Math.Pow(x, y)"| Returns x raised to the power y
"Math.Max(x, y)"| Returns the greater value
"Math.Min(x, y)"| Returns the lesser value
"Math.Round(x)"| Rounds a number to the nearest integer

The "Math" class also provides constants:

Math.PI

Represents the ratio of the circumference of a circle to its diameter.

Math.E

Represents the natural logarithmic base.



## GUI Details Tab Order

When an application is running, one control has the keyboard focus.

Focus means a control receives keyboard input.

The order in which controls receive focus is called the Tab Order.

When the user presses the "Tab" key, the application follows the tab order.

The "TabIndex" property determines the position of a control in the tab order.

The first control normally has:

TabIndex = 0



## Setting Tab Order

To set the tab order:

1. Click View on the menu bar.
2. Select Tab Order.
3. Click the controls in the order you want.

Label controls do not receive keyboard focus, so their "TabIndex" values are not relevant.



## Focus Method

The "Focus()" method can be used to move keyboard focus to a specific control.

Example:

nameTextBox.Focus();

For example, a Clear button can return the focus to a TextBox:

private void clearButton_Click(object sender, EventArgs e)
{
    nameTextBox.Focus();
}



## Keyboard Access Keys

An access key, also called a mnemonic, allows the user to access a control quickly using the "Alt" key.

An ampersand "&" can be placed before a letter in a Button's "Text" property.

For example:

&Exit

The user can use:

Alt + X

to activate the button.



🎨 Setting Colors

Forms and many controls have a "BackColor" property.

Controls that display text also have a "ForeColor" property.

Example:

messageLabel.BackColor = Color.Black;

messageLabel.ForeColor = Color.Yellow;

"BackColor" controls the background color.

"ForeColor" controls the foreground/text color.

---

🖼️ Background Images

A Form has a "BackgroundImage" property for displaying a background image.

The "BackgroundImageLayout" property controls how the image is displayed.

Common layout options include:

- None
- Tile
- Center
- Stretch
- Zoom

---

## GroupBox vs Panel

A "GroupBox" is a container that can hold other controls.

A "Panel" is also a container that can hold other controls.

Main differences:

GroupBox| Panel
Can display a title| Cannot display a title
Has a "Text" property| Does not have a "Text" property
Has a border| Border can be controlled with "BorderStyle"



## Debugging Logic Errors

A logic error is a mistake that does not prevent the program from running but causes incorrect results.

Examples include:

- Mathematical errors.
- Assigning a value to the wrong variable.
- Assigning the wrong value to a variable.

Visual Studio provides debugging tools to help locate and fix logic errors.



## Breakpoints

A breakpoint is a line of source code where you want the application to pause.

When the application reaches a breakpoint, it enters Break Mode.

While paused, you can examine:

- Variable values.
- Control properties.
- Program execution.



## Break Mode

In Break Mode, you can examine the value of a variable or control property by placing the mouse pointer over its name in the Code Editor.

This helps identify where a program is producing an incorrect result.



## Locals Window

The Locals window displays variables that belong to the current procedure.

It shows information such as:

- Variable name
- Current value
- Data type



## Watch Window

The Watch window allows you to select variables that you want to monitor.

It displays only the variables that you have added to the Watch window.

You can open the debugging windows from:

Debug - Windows



## Single-Stepping

Visual Studio allows you to execute a program one statement at a time after execution has been paused at a breakpoint.

This is called single-stepping.

It allows you to examine variable values after each statement executes.

To single-step, you can:

- Press "F11".
- Click Step Into on the toolbar.
- Select Debug → Step Into.

Chapter 2 — Processing Data

📚 Overview

This chapter introduces how to process data in Visual C# and Windows Forms applications using Visual Studio.

It covers TextBox input, variables, data types, string variables, numeric data types, calculations, type casting, the "var" keyword, numeric input and output, number formatting, exception handling, named constants, fields, the Math class, GUI details, and debugging logic errors.

---

🎯 Learning Objectives

After completing this chapter, you should be able to:

- Read user input using TextBox controls.
- Understand what a variable is.
- Declare and initialize variables.
- Understand local variables and variable scope.
- Use string variables.
- Perform string concatenation.
- Use numeric data types such as "int", "double", and "decimal".
- Understand numeric literals.
- Understand assignment compatibility.
- Convert values using type casting.
- Use the "var" keyword.
- Perform arithmetic calculations.
- Understand integer division.
- Convert TextBox input from string to numeric values.
- Display numeric values using "ToString()".
- Format numbers using the "ToString()" method.
- Understand exception handling.
- Use "try-catch" statements.
- Display exception messages.
- Create named constants using "const".
- Declare variables as fields.
- Use methods from the "Math" class.
- Understand Tab Order and keyboard focus.
- Assign keyboard access keys to buttons.
- Set colors and background images.
- Understand GroupBox and Panel controls.
- Use the Visual Studio debugger to find logic errors.
- Use breakpoints, Locals, Watch, and single-stepping.

---

📝 Reading Input with TextBox Controls

A "TextBox" is a rectangular control that allows the user to enter information using the keyboard.

The TextBox control is located in the Common Controls section of the Toolbox.

When a TextBox is added to a form, its default name is usually:

textBox1

The number changes depending on how many TextBox controls are added.

---

📄 Text Property

The "Text" property stores the text entered into a TextBox.

Example:

textBox1.Text = "Hello";

To clear the contents of a TextBox:

textBox1.Text = string.Empty;

or:

textBox1.Clear();

You can also use:

textBox1.Text = "";

---

📦 Variables

A variable is a storage location in memory.

A variable name represents that memory location.

Before using a variable, it must be declared.

Basic syntax:

DataType VariableName;

Example:

string name;

A variable must have a data type that specifies what kind of data it can store.

---

🔤 Data Types

A data type specifies the type of data that a variable can hold.

C# provides basic built-in data types.

Examples include:

- "string"
- "int"
- "double"
- "decimal"

The term primitive means basic, simple, or built-in.

---

🏷️ Variable Naming Rules

A variable name identifies a variable.

Variable names should be meaningful.

Basic rules include:

- The first character must be a letter or underscore "_".
- A variable name cannot contain spaces.
- Reserved C# keywords should not be used as variable names.

Example:

studentName
studentName1
_studentName

---

🔤 String Variables

A "string" is a combination of characters.

A string variable can store values such as:

- Names
- Phone numbers
- Descriptions
- Other text

Example:

string productDescription;

productDescription = "Jamhuuriya University";

A string value is normally written inside double quotation marks.

You can display a string using a MessageBox:

MessageBox.Show(productDescription);

---

➕ String Concatenation

Concatenation means joining one string to another.

The "+" operator is used for concatenation.

Example:

string firstName = "Baarliin";
string lastName = "Abdullahi";

string fullName = firstName + " " + lastName;

The "+" operator can also combine strings with other data types.

Example:

int apples = 12;

string message = apples + " apples";

Another example:

double price = 25.75;

string output = "Total is " + price;

---

📍 Local Variables and Scope

A local variable belongs to the method in which it is declared.

Only statements inside that method can access the local variable.

Scope describes the part of a program where a variable can be accessed.

Lifetime describes the period during which the variable exists in memory while the program is executing.

A local variable is created when its method starts executing and is destroyed when the method ends.

Example:

private void firstButton_Click(object sender, EventArgs e)
{
    string myName;

    myName = nameTextBox.Text;
}

The variable "myName" can only be accessed inside that method.

---

🚫 Duplicate Variable Names

You cannot declare two variables with the same name in the same scope.

For example:

string name;
string name;

This is not allowed in the same scope.

However, variables with the same name can exist in different methods because each method has its own local scope.

---

🔄 Assignment Compatibility

A value can be assigned to a variable only when the value is compatible with the variable's data type.

Example:

string name = "Baarliin";

A string value is compatible with a "string" variable.

---

💾 Initializing Variables

A variable should be assigned a value before it is used.

Example:

string productDescription = "Laptop";

If a local variable is declared but not assigned a value before being used, the C# compiler reports an error.

Example:

string productDescription;

MessageBox.Show(productDescription);

This produces an error because the variable has not been assigned a value.

---

📚 Declaring Multiple Variables

You can declare multiple variables of the same data type in one statement.

Example:

string lastName, firstName, middleName;

You can also initialize multiple variables:

string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi";

---

🔢 Numeric Data Types

Numeric data types are used when numbers need to be stored and used in mathematical operations.

Common numeric data types include:

Data Type| Description
"int"| Whole numbers
"double"| Real numbers, including fractional values
"decimal"| Numbers stored with greater precision, commonly used for financial applications

Example:

int hoursWorked = 40;

double temperature = 87.6;

decimal payRate = 28.75m;

---

🔢 Numeric Literals

A numeric literal is a number written directly in program code.

Examples:

int hoursWorked = 40;

double temperature = 87.6;

Integer literals such as "40" and "99" are treated as "int".

Numbers with decimal points such as "87.6" and "3.14" are treated as "double".

To create a decimal literal, add "m" or "M":

decimal payRate = 28.75m;

---

🔄 Assignment Compatibility for Numeric Types

An "int" value can be assigned to an "int" variable:

int hoursWorked = 40;

But a "double" or "decimal" value cannot automatically be assigned to an "int".

Example:

int score = -25.5;   // ERROR

A "double" variable can accept an "int" value:

double speed = 75;

A "decimal" variable can accept an "int" value:

decimal price = 50;

---

🔀 Type Casting

Type casting allows you to explicitly convert a value from one data type to another compatible type.

The cast operator is the type name placed inside parentheses.

Example:

decimal moneyNumber = 4500m;

int wholeNumber = (int)moneyNumber;

Another example:

decimal moneyNumber = 625.70m;

double realNumber = (double)moneyNumber;

Type casting is called explicit conversion because the programmer specifies the conversion.

---

🔑 The "var" Keyword

The "var" keyword allows the compiler to determine the data type from the value assigned to the variable.

Example:

var interestRate = 12.0;

var stockCode = "D465U";

var accountBalance = 1000.0m;

The compiler determines the type automatically.

When using "var", you must provide an initialization value.

var name = "Baarliin";

The "var" keyword can be used to declare local variables.

---

🧮 Performing Calculations

C# provides arithmetic operators for mathematical calculations.

Operator| Name| Description
"+"| Addition| Adds two numbers
"-"| Subtraction| Subtracts one number from another
"*"| Multiplication| Multiplies two numbers
"/"| Division| Divides one number by another
"%"| Modulus| Returns the remainder

Example:

int x = 5;
int y = 4;

MessageBox.Show((x + y).ToString());

---

📐 Rules for Performing Calculations

A mathematical expression performs a calculation and produces a value.

Example:

int x = 5;
int y = 4;

MessageBox.Show((x + y).ToString());

Parentheses can be used to control the order of operations.

Example:

result = (a + b) / 4;

When different numeric data types are used:

- "int" with "double" produces a "double".
- "int" with "decimal" produces a "decimal".
- An operation between "double" and "decimal" is not allowed directly.

---

➗ Integer Division

When an integer is divided by another integer, the result is an integer.

Example:

int x = 7;
int y = 3;

MessageBox.Show((x / y).ToString());

The result is:

2

To obtain a decimal result, use "double":

double x = 7;
double y = 3;

MessageBox.Show((x / y).ToString());

Or:

int x = 7;
int y = 3;

MessageBox.Show(((double)x / y).ToString());


## Inputting Numeric Values

TextBox controls treat keyboard input as strings.

For example, if the user enters:

25.65

the TextBox stores it as a "string", not as a number.

To use the value in a mathematical calculation, it must be converted to the appropriate numeric data type.


## Parse Methods

C# provides "Parse" methods for converting strings into numeric values.

Examples:

int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

double temperature = double.Parse(temperatureTextBox.Text);

decimal price = decimal.Parse(priceTextBox.Text);

Common methods include:

- "int.Parse()"
- "double.Parse()"
- "decimal.Parse()"



## Displaying Numeric Values

The "Text" property of a Label or TextBox accepts string values.

Therefore, numeric values can be converted to strings using the "ToString()" method.

General syntax:

variableName.ToString()

Example:

decimal grossPay = 1550.0m;

grossPayLabel.Text = grossPay.ToString();

Another example:

int myNumber = 123;

MessageBox.Show(myNumber.ToString());

You can also combine a number with a string using "+":

int idNumber = 1044;

string output = "Your ID number is " + idNumber;


## Formatting Numbers with "ToString()"

The "ToString()" method can format a number into a specific display format.

Common format strings include:

Format| Description| Example
"N"| Number format| "ToString("n3")"
"F"| Fixed-point format| "ToString("f2")"
"E"| Exponential format| "ToString("e3")"
"C"| Currency format| "ToString("C")"
"P"| Percentage format| "ToString("P")"

Example:

double number = 12.3;

string result = number.ToString("n3");

This can display:

12.300


## Exception Handling

An exception is an unexpected error that occurs while a program is running.

Examples include:

- Dividing by zero.
- Opening a file that does not exist.
- Entering invalid user input.

If an exception is not handled, the application may stop unexpectedly.

Exception handling allows a program to respond to errors instead of abruptly stopping.


## Try-Catch

The "try-catch" statement is used to handle exceptions.

Basic structure:

try
{
    // Statements that may cause an exception
}
catch
{
    // Statements that handle the exception
}

The "try" block contains code that may cause an exception.

The "catch" block contains code that responds when an exception occurs.

Example:

try
{
    double miles;
    double gallons;
    double mpg;

    miles = double.Parse(milesTextBox.Text);
    gallons = double.Parse(gallonsTextBox.Text);

    mpg = miles / gallons;

    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}



## Throwing vs Catching

Throwing means an error occurs and an exception is raised.

Catching means the program handles that exception.

Simple example:

Throwing = Error occurs
Catching = Program handles the error

Real-life example:

An ATM may raise an error when an incorrect PIN is entered.

Instead of stopping, it can display:

Invalid PIN, please try again.



## Displaying an Exception Message

Every exception in C# is represented by an object.

The "Exception" object has a "Message" property that contains a description of the error.

Example:

try
{
    // Statements
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}

---

## Named Constants

A named constant represents a value that cannot be changed while the program is executing.

The "const" keyword is used to declare a constant.

Example:

const double INTEREST_RATE = 0.129;

Writing constant names in uppercase letters is a common convention.



## Fields

A field is a variable declared at the class level.

A field is declared inside a class but outside any method.

Example:

public partial class Form1 : Form
{
    private string name = "Charles";
}

The scope of a field is the entire class.

A field is created in memory when the form is created.



## Math Class

The .NET "Math" class provides methods for mathematical calculations.

Common methods include:

Method| Description
"Math.Sqrt(x)"| Returns the square root
"Math.Pow(x, y)"| Returns x raised to the power y
"Math.Max(x, y)"| Returns the greater value
"Math.Min(x, y)"| Returns the lesser value
"Math.Round(x)"| Rounds a number to the nearest integer

The "Math" class also provides constants:

Math.PI

Represents the ratio of the circumference of a circle to its diameter.

Math.E

Represents the natural logarithmic base.



## GUI Details  Tab Order

When an application is running, one control has the keyboard focus.

Focus means a control receives keyboard input.

The order in which controls receive focus is called the Tab Order.

When the user presses the "Tab" key, the application follows the tab order.

The "TabIndex" property determines the position of a control in the tab order.

The first control normally has:

TabIndex = 0



# Setting Tab Order

To set the tab order:

1. Click View on the menu bar.
2. Select Tab Order.
3. Click the controls in the order you want.

Label controls do not receive keyboard focus, so their "TabIndex" values are not relevant.



## Focus Method

The "Focus()" method can be used to move keyboard focus to a specific control.

Example:

nameTextBox.Focus();

For example, a Clear button can return the focus to a TextBox:

private void clearButton_Click(object sender, EventArgs e)
{
    nameTextBox.Focus();
}

---

⌨️ Keyboard Access Keys

An access key, also called a mnemonic, allows the user to access a control quickly using the "Alt" key.

An ampersand "&" can be placed before a letter in a Button's "Text" property.

For example:

&Exit

The user can use:

Alt + X

to activate the button.

---

🎨 Setting Colors

Forms and many controls have a "BackColor" property.

Controls that display text also have a "ForeColor" property.

Example:

messageLabel.BackColor = Color.Black;

messageLabel.ForeColor = Color.Yellow;

"BackColor" controls the background color.

"ForeColor" controls the foreground/text color.

---

🖼️ Background Images

A Form has a "BackgroundImage" property for displaying a background image.

The "BackgroundImageLayout" property controls how the image is displayed.

Common layout options include:

- None
- Tile
- Center
- Stretch
- Zoom

---

📦 GroupBox vs Panel

A "GroupBox" is a container that can hold other controls.

A "Panel" is also a container that can hold other controls.

Main differences:

GroupBox| Panel
Can display a title| Cannot display a title
Has a "Text" property| Does not have a "Text" property
Has a border| Border can be controlled with "BorderStyle"

---

🐞 Debugging Logic Errors

A logic error is a mistake that does not prevent the program from running but causes incorrect results.

Examples include:

- Mathematical errors.
- Assigning a value to the wrong variable.
- Assigning the wrong value to a variable.

Visual Studio provides debugging tools to help locate and fix logic errors.

---

🔴 Breakpoints

A breakpoint is a line of source code where you want the application to pause.

When the application reaches a breakpoint, it enters Break Mode.

While paused, you can examine:

- Variable values.
- Control properties.
- Program execution.

---

⏸️ Break Mode

In Break Mode, you can examine the value of a variable or control property by placing the mouse pointer over its name in the Code Editor.

This helps identify where a program is producing an incorrect result.

---

📋 Locals Window

The Locals window displays variables that belong to the current procedure.

It shows information such as:

- Variable name
- Current value
- Data type

---

👀 Watch Window

The Watch window allows you to select variables that you want to monitor.

It displays only the variables that you have added to the Watch window.

You can open the debugging windows from:

Debug → Windows

---

👣 Single-Stepping

Visual Studio allows you to execute a program one statement at a time after execution has been paused at a breakpoint.

This is called single-stepping.

It allows you to examine variable values after each statement executes.

To single-step, you can:

- Press "F11".
- Click Step Into on the toolbar.
- Select Debug → Step Into.

---

📊 Quick Summary

Concept| Meaning
TextBox| Control used to receive keyboard input
Variable| Storage location in memory
String| Combination of characters
"int"| Whole-number data type
"double"| Real-number data type
"decimal"| High-precision numeric data type
Type Casting| Explicit conversion between data types
"var"| Allows the compiler to infer the variable type
"Parse"| Converts a string to a numeric type
"ToString()"| Converts a value to a string
"try-catch"| Used to handle exceptions
Constant| Value that cannot be changed during execution
Field| Variable declared at class level
Math Class| Provides mathematical methods
Tab Order| Order in which controls receive focus
Breakpoint| Point where program execution pauses
Locals Window| Displays local variables and their values
Watch Window| Displays selected variables
Single-Stepping| Executes code one statement at a time
Logic Error| Error that produces incorrect results

---

📌 Chapter Conclusion

Chapter 2 introduces the fundamental concepts of processing data in Visual C#.

It explains how to receive input using TextBox controls, store data in variables, work with strings and numeric data types, perform calculations, convert values, format numbers, and handle exceptions.

The chapter also introduces constants, fields, the Math class, Tab Order, keyboard access keys, colors, background images, GroupBox and Panel controls, and Visual Studio debugging tools.

These concepts provide the knowledge needed to create Windows Forms applications that can receive, process, calculate, and display data.

---

📚 Source

Starting Out with Visual C#, Sixth Edition — Chapter 2: Processing Data