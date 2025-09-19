# C# Abstract Class Example

This project demonstrates how to use an **abstract class** in C# to define a method that must be implemented by derived classes.  
It also shows how to combine output from multiple implementations.

---

## 📋 Description
The program defines:
- **`MessageProvider`** – An abstract class declaring the `GetMessage()` method.
- **`GreetingProvider1`** – Returns `"Hello"`.
- **`GreetingProvider2`** – Returns `"welcome to C#"`.

In the `Main()` method, two provider instances are created, and their messages are combined to produce:
