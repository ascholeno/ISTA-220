#### Anthony Scholeno
#### HW_11



1. What is a parameter array?

A Parameter array allows you to pass a variable number of arguments to a method

2. How do you define a method that takes an arbitrary number of arguments?

By using a parameter array, which is declared by using the params keyword. 

3. How do you call a method that takes an arbitrary number of arguments?

As long as the method was defined with the params keyword the method can be called the same way any other method would be called and entering the desired arguments into the method call. 

4. Why can’t you use an array to pass an arbitrary number of arguments to a method?

You have to know the size of the array

5. How many parameters can a method have?

 As many as it wants

6. Do parameter arguments have to have the same type?

Yes, but also maybe. (object can be anything) 

7. What is the difference between a method that takes a parameter argument and one that takes optional
arguments?

A method that takes optional parameters still has a fixed parameter list, and you can not pass an arbitrary list of arguments. A method that uses a parameter array effectively has a completely arbitrary list of parameters, and none of them has a default value. 

8. How do you define a method that takes different (and arbitrary) types of arguments?

You use the params array of object types to create a method that accepts any number of arguments of any type. 

9. Write a method that accepts any number of arguments of a given type.
	
Public static void UseParams(params int[] list)

10. Write a method that accepts any number of arguments of any type.
	
Public static void UseParams2(params object[] list)