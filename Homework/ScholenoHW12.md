# C# Chapter 12 Homework
### Anthony Scholeno


1. How does inheritance promote the principal of don't repeat yourself?

Inheritance promotes less repetition by allowing for the creation of a base class that derived classes can inherit from. In this way, common functionality between different classes can be shared if the different classes are derived from the same base class.  The code for the common functionality only has to be written once, even though it can be used by multiple classes.

2. What is the syntax of a derived class that inherits from a base class?

`class DerivedClass : BaseClass { }`

3. Do all user defined types (classes and structs) inherit from some base class? If so what is it?

Yes, all classes inherit from the System.Object class and all structs inherit from an abstract class known as System.ValueType. 

4. What happens if you do not have a default constructor in a base class when creating a derived class?

The compiler will generate a default constructor if one is not explicitly written, but if the incorrect one is called it results in a compile time error. 

5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?

Yes, In the book example the base class is mammal and the derived classes are horse and whale.  A horse object can be assigned to a type mammal because all horses are mammals and inherit from the mammal class.  However a horse object assigned as a mammal variable will not have access to methods and fields in the horse class only the methods and fields available in the mammal class. 

6. Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?

No you can not. Using the preceding example a horse object could not be assigned to a whale variable.  Although they both inherit from and share the same attributes of the base class mammal they do not inherit from and share attributes with each other and therefore can not be assigned to each other, it would be out of scope. 

7. Can you assign a variable of a base class to another variable of a derived class why or why not?

As a general rule no you can not. However, you can if you use the "as" or "is" keyword or do a cast to ensure the object being referred to is actually of the appropriate type.  This ensures a mammal object that is a whale type does not get assigned to a variable of type horse. 

8. Under what circumstances would you want to use the new keyword when defining a method in a derived class?

If you were declaring a method that shared a signature with another method higher up the inheritance hierarchy.  This would hide the method higher up from any classes deriving below the existing class.  This generates a warning, however if you are doing this intentionally and want to move forward using the new keyword eliminates the warning.  

9. What is a virtual method? Why would you want to define a virtual method?

A method that is intended to be overridden is called a virtual method. Overriding a method is a mechanism for providing different implementations of the same method. Hiding a method is a means of replacing one method with another.  

10. What does override do? Why does it do it?

The override keyword declares another implementation of a virtual method.  It does this generally to make a more specific implementation of a generic method. 

11. How do you define an extension type?

You define an extension method in a static class and specify the type to which the method applies as the first parameter to the method, along with the "this" keyword. 

12. Why do you define an extension type?         

Using an extension method, you can extend an existing type with additional static methods. These static methods become immediately available to your code in any statements that reference data of the type being extended. 

13. Explain the Liskov substitution principle.

 principle in object-oriented programming stating that, in a computer program, if S is a subtype of T, then objects of type T may be replaced with objects of type S (i.e. an object of type T may be substituted with any object of a subtype S) without altering any of the desirable properties of the program