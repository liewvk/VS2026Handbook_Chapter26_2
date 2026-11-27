using System;
using System.Collections.Generic;
using System.Linq;
var commands = new Dictionary<string, Func<string>>
{
    ["time"] = () => DateTime.Now.ToString("HH:mm"),
    ["stock"] = () => "Available products: 12",
    ["help"] = () => "Allowed commands: time, stock, help"
};
foreach (string command in new[] { "help", "stock", "delete" })
{
    string result = commands.TryGetValue(command, out var action)
        ? action() : "Command not allowed";
    Console.WriteLine($"{command}: {result}");
}

