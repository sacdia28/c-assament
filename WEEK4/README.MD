# DISCOUS CHAPTER 4
While Loop – It is used to repeat code while a condition is true. It is a pretest loop, so the condition is checked first. If the condition is false, the loop does not execute. The chapter also explains infinite loops.
Increment and Decrement – ++ is used to increase a value by 1, while -- is used to decrease a value by 1. It also explains prefix and postfix.
For Loop – It is used when a counter controls how many times the loop executes. It has three parts: initialization, test, and update.
Do-While Loop – It is a posttest loop. The code executes at least once before the condition is checked.
Files for Data Storage – This section explains how to store data in files. The three steps are open, process, and close. There are text files and binary files, but the chapter focuses on text files.
Writing Files – StreamWriter is used to write data to a file. Write() and WriteLine() are used to write data. CreateText() creates a file, while AppendText() adds new data to an existing file.
Reading Files – StreamReader is used to read files. It includes Read(), ReadLine(), ReadToEnd(), and File.ReadAllText(). EndOfStream is used to detect when the end of a file is reached.
OpenFileDialog and SaveFileDialog – They allow the user to open or save files. DialogResult.OK means the user selected OK, while Cancel means the operation was cancelled.
Random Numbers – The Random class is used to generate random numbers. Next() generates an integer, while NextDouble() generates a decimal number.
Load Event – It occurs when the Form is opened. Code inside Form1_Load runs when the application starts.