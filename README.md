# VS2026Handbook_Chapter26_2

A simple C# console application demonstrating command dispatch with a dictionary and delegates.

## Overview

The application defines a `Dictionary<string, Func<string>>` containing `time`, `stock`, and `help` commands. It then executes `help`, `stock`, and `delete`, printing the returned result or a not-allowed message for an unknown command.

## Requirements

- .NET 10 SDK

## Run

```bash
dotnet run
```

## Example output

```text
help: Allowed commands: time, stock, help
stock: Available products: 12
delete: Command not allowed
```
