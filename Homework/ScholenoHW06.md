# Programming in C# Chapter 6 Homework
### Anthony Scholeno
### July 21 2020


1. What is an exception?

An exception is an error condition within a line of code.

2. What happens in a try block if the program executes without errors?

If a program within a try block executes without errors, the program continues to run consecutively to completion.

3. How does the catch mechanism work for unhandled exceptions?

If this occurs and the try block is part of a method, the method immediately exits and execution returns to the calling method. If the calling method uses a try block, the runtime attempts to locate a matching catch handler for this try block and execute it.  If the calling method does not use a try block or there is no matching catch handler, the calling method immediately exits and execution returns to its caller, where the process is repeated.  If a matching catch handler is eventually found, the handler runs and execution continues with the first statement that follows the catch handler in the catching method.

4. What happens in a program if an exception block fails to handle a particular error?

If, after cascading back through the list of calling methods, the runtime is unable to find a matching catch handler, the program will terminate with an unhandled exception.

5. What is the parent class for all exceptions? How does this work?

The parent class for all exceptions is the family called Exception.  If one uses catch Exception, the handler traps every possible exception that can occur.

6. How do you determine the type of an error?

Visual studio when run in debug mode will identify exceptions unhandled by the user code, however the exception identified is frequently a result of several exceptions that occurred previously in the code.  By digging into the view detail dialog box and then into the inner exception property view the initial exception can be identified and dealt with.

7. What is the purpose of integer checking?

The purpose of integer checking is to determine whether or not an arithmetically calculated integer will exceed the allowable limits for an integer value.  If the checking is applied and the value exceeds the allowable limits and overflow exception is thrown.  If the unchecked keyword is applied an overflow exception will never be thrown.  If a value exceeds the allowable limit it will roll over into a negative integer value.

8. What is the range of values than a signed int32 type can contain? state the lowest value and the highest value.

–2147483648 to 2147483647

9. What is the range of values that an unsigned int32 type can contain? State the lowest value and the highest value. What is the difference between a signed integer and unsigned integer? Can signed integers and unsigned integers represent the same amount of numbers

0 to 4,294,967,295  An unsigned variable type of int can hold zero and positive numbers, and a signed int holds negative, zero and positive numbers

10. What does the finally block do?

A finally block occurs immediately after a try block or immediately after the last catch handler after a try block.  As long as the program enter the try block associated with a finally block, the finally block will always be run, even if an exception occurs.

11. When would you not use a finally block in a try/catch construction
