# Date Information – Visual C# Windows Forms

## 1. First Image – Greeting to Concatenation
The first image shows how the program receives date information from the user. It declares variables such as `DayoftheWeek`, `Month`, `Day`, `Year`, and `FullDate`. The values are taken from TextBoxes and combined using **string concatenation (`+`)** to create one complete date. The result is then displayed in the output Label.

## 2. Second Image – Clear
The second image shows the **Clear Button**. It uses the `.Clear()` method to remove the information entered in the TextBoxes and clears the output. This allows the user to enter new information.

## 3. Third Image – `this.Close()`
The third image shows the **Exit Button**. It uses:

```csharp
this.Close();