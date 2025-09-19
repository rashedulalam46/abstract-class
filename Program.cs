// Create instances of both providers
        MessageProvider provider1 = new GreetingProvider1();
        MessageProvider provider2 = new GreetingProvider2();

        // Combine their messages with a comma and space
        string combinedMessage = $"{provider1.GetMessage()}, {provider2.GetMessage()}";

        Console.WriteLine(combinedMessage);
        // Output: Hello, welcome to C#