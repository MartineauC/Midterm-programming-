using System;

class Eliza {
    static void Main() {
        string input;
        do {
            Console.Write("You: ");
            input = Console.ReadLine();
            Console.WriteLine("Eliza: " + CreateElizaResponse(input));
        } while (input != "exit");
    }

    static string CreateElizaResponse(string input) {
        if (input.Contains("my ")) {
            int startIndex = input.IndexOf("my ") + 3;
            int endIndex = input.IndexOf(' ', startIndex);
            if (endIndex == -1) {
                endIndex = input.Length;
            }
            string noun = input.Substring(startIndex, endIndex - startIndex);
            return "Tell me more about your " + noun + ".";
        }
        else if (input.Contains("love") || input.Contains("hate")) {
            return "You have strong feelings about that!";
        }
        else {
            string[] responses = { "Please go on.", "Tell me more.", "Continue." };
            return responses[new Random().Next(responses.Length)];
        }
    }
}