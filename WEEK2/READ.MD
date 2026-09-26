# DISCOUS CHAPTER2
​Reading input from TextBoxes and getting started with Variables.  
​Numeric Data Types and Performing Calculations.  
​Data Conversion: Converting text (String) to numbers and converting numbers back to text.  
​TextBox Text & Variables:
​The .Text property of a TextBox stores input data as a String.  
​How to clear a TextBox: textBox1.Text = "";, textBox1.Text = string.Empty;, or textBox1.Clear();.  
​A variable is a temporary storage location in memory used to hold data.  
​Data Types & Variable Naming Rules:
​Primitive Types: Numbers (int, double, float, decimal), characters (char), or boolean values (bool).  
​Naming rules: Variable names must begin with a letter or an underscore (_), cannot contain spaces, and cannot use C# reserved keywords.  
​String Concatenation:
​Joining two strings or combining a string with a number using the + operator (e.g., "Total is " + 25.75).
​Variable Scope and Common Errors:
​Local Variables: A variable declared inside a specific method can only be accessed within that method.  
​A variable must be initialized with a value before it can be used, otherwise a compiler error will occur.  
​Calculations & Data Conversion (Parsing & ToString):
​Differences and assignment compatibility between int, double, and decimal.  
​Reading numbers from TextBoxes: Input text must be converted to numeric types using int.Parse(), double.Parse(), or decimal.Parse().  
​Displaying numeric output: Numbers must be converted back to strings using .ToString() to display them in a Label or TextBox.