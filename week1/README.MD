Chapter 1 — Introduction to Visual C#

## Overview

This chapter introduces the fundamentals of Visual C# and Windows Forms Application Development using Visual Studio.

It covers the Visual Studio environment, objects, controls, projects, solutions, GUI design, properties, basic C# code, event-driven programming, MessageBox, Label, PictureBox, IntelliSense, comments, and syntax errors.


## Learning Objectives

After completing this chapter, you should be able to:

- Understand what an object is in programming.
- Explain properties and methods.
- Understand GUI controls such as Label, Button, TextBox, and PictureBox.
- Identify the main parts of the Visual Studio environment.
- Understand the difference between a project and a solution.
- Create and design a Windows Forms application.
- Display and use the Solution Explorer, Toolbox, Designer, and Properties Window.
- Change control properties using the Properties Window.
- Write basic C# event-handler code.
- Display messages using "MessageBox.Show()".
- Display output using a Label control.
- Understand IntelliSense.
- Use comments, blank lines, and indentation.
- Close a form using "this.Close()".
- Recognize and correct syntax errors.



## Visual Studio Environment

Visual Studio is an Integrated Development Environment (IDE) used to create, edit, debug, and run C# applications.

Important parts of Visual Studio include:

- Designer Window
- Solution Explorer
- Properties Window
- Toolbox
- Code Editor
- Menu Bar
- Standard Toolbar



## How to Display Solution Explorer

To display the Solution Explorer:

1. Click View.
2. Click Solution Explorer.

Properties Window

To display the Properties Window:

1. Click View.
2. Click Properties Window.



## How to Display the Designer

The Designer is the area where you visually design your Windows Forms application.

To open the Designer:

1. Go to Solution Explorer.
2. Find "Form1.cs".
3. Right-click "Form1.cs".
4. Select View Designer.

The Designer allows you to visually add and arrange controls on the form.



## Toolbox

The Toolbox is a window used to select controls that can be added to a Windows Forms application.

The Toolbox usually appears on the left side of Visual Studio and may be in Auto Hide mode.

Common sections include:

- All Windows Forms
- Common Controls

Common Controls

Some commonly used controls are:

- Button
- Label
- TextBox
- CheckBox
- ComboBox
- ListBox
- PictureBox

---

## Form in the Designer

When a form is displayed in the Designer, it is enclosed by thin dotted lines called the bounding box.

The form has small sizing handles that can be used to resize it.

You can use the Designer to:

- Resize a control.
- Move a control.
- Change its properties.
- Delete a control.

---

## Properties Window

The Properties Window is used to control how an object or control looks and behaves.

Each property normally has two columns:

Column| Description
Left| Property name
Right| Property value

Changing Property Values

To change a property:

1. Select the object or control.
2. Click the control once.
3. Find the property in the Properties Window.
4. Change its value.

---

## Text Property

The Text property determines the text displayed by a control.

For a Form, the "Text" property determines the text displayed in the form title bar.

For example:

Text = Welcome to C#

This changes the title displayed on the form.



## Adding Controls to a Form

There are two common ways to add a control from the Toolbox.

Method 1  2 Double Click

1. Select a control in the Toolbox.
2. Double-click the control.

The control will automatically be added to the form.

1 Method 2  Drag and Drop

1. Select a control from the Toolbox.
2. Click and hold it.
3. Drag it onto the form.
4. Release the mouse button.



## Working with Controls on the Form

After adding a control, you can:

A. Resize the Control

Use the bounding box and sizing handles to change its size.

B. Move the Control

Drag the control to another position on the form.

C. Change Its Properties

Select the control and modify its properties in the Properties Window.

D. Delete the Control

Select the control and press the Delete key.



## Naming Conventions

Control names are also known as identifiers.

Common naming rules include:

- The first character must be a letter or underscore.
- A name cannot contain spaces.
- Reserved C# keywords should not be used as identifiers.
- Special symbols should generally be avoided.

Example

Valid:

studentName
studentName1
_studentName

Invalid:

student name
1student
class



## C# Code Structure

C# code is primarily organized into three important levels:

1. Namespace

A namespace is a container that holds classes.

2. Class

A class is a container that holds methods and other members.

3. Method

A method is a group of one or more programming statements that performs an operation.

## Basic Structure

namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            // Programming statements
        }
    }
}



## Source Code File

A file that contains program code is called a source code file.

Program.cs

"Program.cs" contains the application startup code that is executed when the application runs.

Form1.cs

"Form1.cs" contains the C# code associated with the "Form1" form.



## Event-Driven Programming

Windows Forms applications are event-driven.

This means the application responds to events that occur while the program is running.

Examples of events include:

- Mouse clicking
- Key pressing
- Mouse movement
- Selecting a control



## Event Handler

An event handler is a method that executes when a specific event occurs.

For example, double-clicking a Button in the Designer can automatically create its default Click event handler.

private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}


## Hello World Example

A Button can display a message when the user clicks it.

private void messageButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}



## MessageBox

A MessageBox is used to display a message to the user.

It can be used to display simple output.

Example

MessageBox.Show("Hello World");

"MessageBox.Show()" accepts a string message.



## Label Control

A Label control is used to display text on a form.

It can display:

- Fixed text
- Program output

Example

answerLabel.Text = "Hello World";

To clear the Label:

answerLabel.Text = "";


## Common Label Properties

Property| Description
"Text"| Gets or sets the text displayed by the Label
"Name"| Gets or sets the name of the Label control
"Font"| Controls the font type and size
"ForeColor"| Controls the text color
"BorderStyle"| Controls the border style
"AutoSize"| Determines whether the control automatically adjusts its size
"TextAlign"| Determines the alignment of the text

BorderStyle Values

Common values include:

- "None"
- "FixedSingle"
- "Fixed3D"

AutoSize

"AutoSize" has two main values:

True
False

The default value is usually "True".

TextAlign

Common alignment options include:

- TopLeft
- TopCenter
- TopRight
- MiddleLeft
- MiddleCenter
- MiddleRight
- BottomLeft
- BottomCenter
- BottomRight



## IntelliSense

IntelliSense is a Visual Studio feature that provides automatic code completion while writing C# code.

It can suggest:

- Keywords
- Variables
- Methods
- Classes
- Properties

IntelliSense makes programming easier and helps developers write code faster.


## PictureBox Control

A PictureBox is a Windows Forms control used to display images.

Important properties include:

Property| Description
"Image"| Specifies the image displayed
"SizeMode"| Controls how the image is displayed
"Visible"| Determines whether the PictureBox is visible



## Comments and Code Formatting

Comments are notes written in source code to explain how the program works.

Comments are ignored by the compiler.

Single-Line Comment

// This is a single-line comment.

Multi-Line Comment

/*
   This is a
   multi-line comment.
*/

Blank Lines

Blank lines can make code easier to read.

Indentation

Indentation helps organize code and makes the program easier to understand.



## Closing a Form

To close the current form:

this.Close();

To close the entire application:

Application.Exit();



## Syntax Errors

A syntax error occurs when code does not follow the rules of the C# programming language.

Visual Studio usually identifies syntax errors while the code is being written.

A syntax error may appear as a red jagged underline in the Code Editor.

Example

Incorrect:

MessageBox.Show("Hello"

Correct:

MessageBox.Show("Hello");

Syntax errors should be corrected before successfully compiling and running the application.




