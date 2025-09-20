# C# Abstract Class Example

This project demonstrates how to use an **abstract class** in C# to define a method that must be implemented by derived classes.  
It also shows how to combine output from multiple implementations.

---

## 📋 Description
The program defines:
- **`MessageProvider`** – An abstract class declaring the `GetMessage()` method.
- **`GreetingProvider1`** – Returns `"Hello"`.
- **`GreetingProvider2`** – Returns `"welcome to C#"`.
- **`Main Program`** – Returns `"Hello, welcome to C#"`.
  
In the `Main()` method, two provider instances are created, and their messages are combined to produce:

Hello, welcome to C#


---

## 🛠 How It Works
1. The abstract class enforces that all derived classes implement the `GetMessage()` method.
2. `GreetingProvider1` and `GreetingProvider2` each return different strings.
3. These strings are concatenated using string interpolation:
```csharp
   string combinedMessage = $"{provider1.GetMessage()}, {provider2.GetMessage()}";
```

---

## MessageProvider

```csharp

abstract class MessageProvider
{
    // Abstract method must use the abstract keyword and no body
    public abstract string GetMessage();
}
```

## First provider: returns "Hello"

```csharp
class GreetingProvider1 : MessageProvider
{
    public override string GetMessage()
    {
        return "Hello";
    }
}
```

## Second provider: returns "welcome to C#"

```csharp
class GreetingProvider2 : MessageProvider
{
    public override string GetMessage()
    {
        return "welcome to C#";
    }
}
```

## Main Program: returns Hello, welcome to C#

```csharp
MessageProvider provider1 = new GreetingProvider1();
MessageProvider provider2 = new GreetingProvider2();

// Combine their messages with a comma and space
string combinedMessage = $"{provider1.GetMessage()}, {provider2.GetMessage()}";

Console.WriteLine(combinedMessage);
// Output: Hello, welcome to C#
```

🖥 Expected Output
```csharp
Hello, welcome to C#!
```

📚 Key Concepts Demonstrated

- Abstract Classes: Define method signatures without implementation.
- Method Overriding: Derived classes provide specific implementations.
- String Interpolation: Combine multiple strings into one output.

 Key Points about Abstract Classes
 - Declared using the abstract keyword
 - Cannot be instantiated: MessageProvider s = new MessageProvider(); // ❌
 - Can include both abstract and non-abstract members
 - Derived classes must implement abstract members
 - Supports constructors and fields
   


