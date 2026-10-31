📘 CHAPTER 3: MAKING DECISIONS

Starting Out with Visual C# – Sixth Edition



📌 Chapter Overview

This chapter explains how to make decisions in C# programming. Decision structures allow a program to choose what action to perform depending on whether a condition is true or false.

📚 Table of Contents

1. Decision Structures and the "if" Statement
2. The "if-else" Statement
3. Nested Decision Structures
4. Logical Operators
5. "bool" Variables and Flags
6. Comparing Strings
7. Preventing Data Conversion Exceptions with "TryParse"
8. Input Validation
9. Radio Buttons and Check Boxes
10. The "switch" Statement
11. Introduction to List Boxes


4.1 Decision Structures and the if Statement

A decision structure allows a program to execute statements depending on a condition.

The "if" statement executes a statement only when its condition is true.

Syntax:

if (condition)
{
    statements;
}

Example:

int age = 20;

if (age >= 18)
{
    MessageBox.Show("You are an adult");
}

Relational Operators

Relational operators compare two values.

Operator| Meaning
">"| Greater than
"<"| Less than
">="| Greater than or equal to
"<="| Less than or equal to
"=="| Equal to
"!="| Not equal to


4.2 The if-else Statement

The "if-else" statement provides two possible paths.

- If the condition is true, the "if" statements execute.
- If the condition is false, the "else" statements execute.

Syntax:

if (condition)
{
    statements;
}
else
{
    statements;
}

Example:

int number = 10;

if (number > 0)
{
    MessageBox.Show("Positive number");
}
else
{
    MessageBox.Show("Not a positive number");
}



4.3 Nested Decision Structures

A nested decision structure is an "if" statement inside another "if" statement.

It is used when a program needs to check more than one condition.

Example:

int age = 20;

if (age >= 18)
{
    if (age >= 21)
    {
        MessageBox.Show("You are 21 or older");
    }
    else
    {
        MessageBox.Show("You are an adult");
    }
}
else
{
    MessageBox.Show("You are under 18");
}



4.4 Logical Operators

Logical operators combine multiple conditions or reverse a condition.

Operator| Name| Meaning
"&&"| AND| True when both conditions are true
`| | `
"!"| NOT| Reverses the condition

AND Operator ("&&")

Both conditions must be true.

if (age >= 18 && age <= 30)
{
    MessageBox.Show("Age is between 18 and 30");
}

OR Operator ("||")

At least one condition must be true.

if (day == "Saturday" || day == "Sunday")
{
    MessageBox.Show("Weekend");
}

NOT Operator ("!")

Reverses a Boolean condition.

if (!(number > 0))
{
    MessageBox.Show("Number is not positive");
}



4.5 bool Variables and Flags

A "bool" variable stores one of two values:

- "true"
- "false"

A flag is a Boolean variable used to indicate whether a particular condition or event has occurred.

Example:

bool isFound = false;

if (number == 10)
{
    isFound = true;
}

if (isFound)
{
    MessageBox.Show("Number found");
}



4.6 Comparing Strings

Strings can be compared using comparison operators.

The "==" operator checks whether two strings contain the same text.

Example:

string password = "12345";

if (password == "12345")
{
    MessageBox.Show("Correct password");
}
else
{
    MessageBox.Show("Incorrect password");
}

String comparisons can also be performed using the "Equals()" method.

string name = "Ali";

if (name.Equals("Ali"))
{
    MessageBox.Show("Names are equal");
}



4.7 Preventing Data Conversion Exceptions with TryParse

"TryParse" converts a string into another data type while checking whether the conversion is successful.

It prevents a conversion error when the user enters invalid data.

Example:

int number;

if (int.TryParse(txtNumber.Text, out number))
{
    MessageBox.Show("Valid number");
}
else
{
    MessageBox.Show("Please enter a valid number");
}

Important Points

- "TryParse" returns "true" when conversion succeeds.
- It returns "false" when conversion fails.
- The "out" keyword receives the converted value.



4.8 Input Validation

Input validation checks whether the data entered by the user is acceptable before the program processes it.

It helps prevent incorrect or invalid input.

Example:

int age;

if (int.TryParse(txtAge.Text, out age))
{
    if (age >= 18)
    {
        MessageBox.Show("Valid age");
    }
    else
    {
        MessageBox.Show("Age must be 18 or above");
    }
}
else
{
    MessageBox.Show("Please enter a valid number");
}

Why Input Validation Is Important

- Prevents invalid data.
- Reduces program errors.
- Ensures correct information is processed.



4.9 Radio Buttons and Check Boxes

Radio buttons and check boxes are Windows Forms controls used to allow users to select options.

Radio Buttons

A RadioButton allows the user to select one option from a group of options.

Important Properties:

Property| Description
"Text"| Displays the text beside the control
"Checked"| Indicates whether the button is selected
"Name"| Identifies the control

Example:

if (radioButton1.Checked)
{
    MessageBox.Show("Option 1 selected");
}

Check Boxes

A CheckBox allows the user to select or deselect an option. Multiple check boxes can be selected at the same time.

Important Properties:

Property| Description
"Text"| Displays the text
"Checked"| Checks whether the box is selected
"Name"| Identifies the control

Example:

if (checkBox1.Checked)
{
    MessageBox.Show("Check box selected");
}

Important Event

"CheckedChanged" occurs when the Checked property changes.



4.10 The switch Statement

The "switch" statement selects one block of code from several possible choices.

It is useful when a variable is compared against multiple possible values.

Syntax:

switch (expression)
{
    case value1:
        statements;
        break;

    case value2:
        statements;
        break;

    default:
        statements;
        break;
}

Important Keywords

Keyword| Description
"switch"| Starts the selection structure
"case"| Specifies a possible value
"break"| Ends the current case
"default"| Executes when no case matches

Example:

int number = 2;

switch (number)
{
    case 1:
        MessageBox.Show("One");
        break;

    case 2:
        MessageBox.Show("Two");
        break;

    case 3:
        MessageBox.Show("Three");
        break;

    default:
        MessageBox.Show("Invalid number");
        break;
}



4.11 Introduction to List Boxes

A ListBox is a Windows Forms control that displays a list of items. The user can select an item from the list.

Important ListBox Properties

Property| Description
"Items"| Contains the items in the list
"SelectedItem"| Gets the selected item
"SelectedIndex"| Gets the index of the selected item
"Text"| Gets or sets the text associated with the control

Adding Items

The "Add()" method adds an item to the ListBox.

listBox1.Items.Add("Java");
listBox1.Items.Add("C#");
listBox1.Items.Add("Python");

Removing Items

The "Remove()" method removes a specified item.

listBox1.Items.Remove("Java");

Removing an Item by Index

The "RemoveAt()" method removes an item using its index.

listBox1.Items.RemoveAt(0);

Clearing All Items

The "Clear()" method removes all items from the ListBox.

listBox1.Items.Clear();

Getting the Selected Item

string selected = listBox1.SelectedItem.ToString();

MessageBox.Show(selected);

Text and SelectedItem

Property| Description
"Text"| Gets or sets the text associated with the control
"SelectedItem"| Gets the currently selected item



⭐ Chapter Summary

This chapter covers the main decision-making structures and controls in C#.

- "if" checks a condition.
- "if-else" provides two possible paths.
- Nested "if" checks conditions inside other conditions.
- Logical operators combine or reverse conditions.
- "bool" stores "true" or "false".
- String comparison checks whether text values match.
- "TryParse" safely converts input data.
- Input validation checks user-entered information.
- RadioButton allows one selection from a group.
- CheckBox allows multiple selections.
- "switch" selects between multiple cases.
- ListBox displays and manages a collection of items.

