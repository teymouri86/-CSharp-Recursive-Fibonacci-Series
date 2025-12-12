# 🌀 C# Recursive Fibonacci Series

A simple C# console application that receives a number from the user and prints the Fibonacci series up to that number using a **recursive method**.

## ✨ Features
- Takes a single integer input
- Uses a **recursive function** to calculate Fibonacci numbers
- Prints the Fibonacci sequence from 0 up to n
- Clean and beginner-friendly code

## 📌 Fibonacci Recursive Method

```csharp
static int Fibonacci(int n)
{
    if (n == 0)
        return 0;

    if (n == 1)
        return 1;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
```

## 🚀 Run the Project
1. Clone the repository:
```bash
git clone https://github.com/YourUserName/CSharp-Recursive-Fibonacci-Series
```
2. Open the project in Visual Studio or VS Code  
3. Build & run

