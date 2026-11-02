# discous chapter3
Chapter 3 – Making Decisions
1. Decision Structures and the if Statement
A decision structure allows a program to make a decision based on a condition.
The if statement executes a block of code when the condition is true.
Relational operators include:
> Greater than
< Less than
>= Greater than or equal to
<= Less than or equal to
== Equal to
!= Not equal to
2. The if-else Statement
The if-else statement provides two possible paths.
If the condition is true, the if block executes.
If the condition is false, the else block executes.
3. Nested Decision Structures
A nested decision structure means putting one if statement inside another if statement.
It is used when the program needs to check more than one condition.
4. The if-else-if Statement
The if-else-if statement is used to test multiple conditions.
The program checks the conditions one by one until it finds a true condition.
5. Logical Operators
Logical operators are used to connect conditions.
&& = AND → both conditions must be true.
|| = OR → one or both conditions must be true.
! = NOT → reverses true and false.
6. bool Variables and Flags
A bool variable stores only two values:
true
false
A flag is a variable used to indicate whether a certain condition exists.
7. Comparing Strings
Strings can be compared using:
==
!=
String.Compare()
String.Compare() returns 0 when the two strings are equal.
8. TryParse() Method
TryParse() is used to prevent data conversion exceptions when the user enters invalid data.
Examples:
int.TryParse()
double.TryParse()
decimal.TryParse()
9. Input Validation
Input validation is the process of checking whether the data entered by the user is valid before using it.
For example, a test score should be between 0 and 100.
TryParse() checks whether the input is a valid number, but it does not check whether the number is reasonable.
10. Radio Buttons and Check Boxes
RadioButton: Allows the user to select one option from several choices.
CheckBox: Allows the user to select multiple options.
The Checked property is used to determine whether the control is selected.
11. CheckedChanged Event
The CheckedChanged event occurs when the Checked property of a RadioButton or CheckBox changes.
12. The switch Statement
The switch statement is used when a variable or expression has multiple possible values.
Important parts:
case = a possible choice
break = stops the current case
default = runs when no case matches
13. ListBox
A ListBox displays a list of items and allows the user to select an item.
Important properties and methods:
Items.Add() → adds an item
SelectedItem → gets the selected item
SelectedIndex → gets the index of the selected item
The index starts at 0. If no item is selected, SelectedIndex is -1.
14. Removing and Clearing ListBox Items
Items.Remove() → removes a specific item.
Items.RemoveAt() → removes an item at a specific index.
Items.Clear() → removes all items.