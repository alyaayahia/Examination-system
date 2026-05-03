# 📚 Examination System – Console-Based C# Application

A modular, object-oriented examination system built using C#.  
Create subjects, design exams, collect answers, and evaluate results — all from the console.

---

## ✨ Features

- Create and manage **Subjects** (ID + Name)
- Dynamically build different types of **Exams** (Final, Practical, etc.)
- Display questions and capture **user answers** interactively
- Fully **object-oriented design** — easy to extend and maintain
- Clean and organized **console output** with screen transitions

---

## 🧱 Project Structure

| File | Responsibility |
|------|---------------|
| `Program.cs` | Entry point — initializes subjects and starts the exam flow |
| `Subject.cs` | Defines the `Subject` entity and manages exam creation |
| `Exam.cs` | Abstract base class for all exam types |
| `Questions.cs` | Defines question types (MCQ, True/False, etc.) |
| `Answer.cs` | Represents a user's answer and handles evaluation |

```
/Examination_system
├── Program.cs
├── Subject.cs
├── Exam.cs
├── Questions.cs
└── Answer.cs
```

> ⚠️ **Note:** If you encounter a file named `Qeestions.cs` in the repository, this is a known typo.  
> Please rename it to `Questions.cs` before building.

---

## 🚀 Getting Started

### 🔧 Prerequisites

- [.NET SDK 6.0](https://dotnet.microsoft.com/download) or later
- [Git](https://git-scm.com/)
- Any C# IDE: [Visual Studio](https://visualstudio.microsoft.com/), [Rider](https://www.jetbrains.com/rider/), or [VS Code](https://code.visualstudio.com/)

### ▶️ Installation & Run

```bash
# 1. Clone the repository
git clone https://github.com/alyaayahia/Examination-system.git

# 2. Navigate into the project folder
cd Examination-system

# 3. Build the project
dotnet build

# 4. Run the application
dotnet run
```

---

## 💡 Example Run

```
Enter Subject ID: 101
Enter Subject Name: C# Programming

[System creates exam dynamically]

Starting Exam...

Question 1: What is encapsulation?
  1. Hiding implementation details
  2. Inheriting from a base class
  3. Multiple methods with the same name

Enter your answer (1-3): 1
✔ Correct!

...

─────────────────────────────────
  Exam Finished!
  Your total score: 8 / 10
─────────────────────────────────
```

---

## 🧩 Extending the System

The system is designed with extensibility in mind using **inheritance** and **polymorphism**.

### ➕ Add a New Exam Type

1. Create a new class that inherits from `Exam`
2. Override the `ShowExam()` method
3. Implement your custom logic inside it

```csharp
public class PracticalExam : Exam
{
    public override void ShowExam()
    {
        // 1. Display each question to the user
        // 2. Collect and store user answers
        // 3. Grade answers and display the final score
    }
}
```

4. Register the new type inside `Subject.CreateExam()` so it can be selected at runtime.

---

## ⚠️ Limitations & Known Issues

| Limitation | Details |
|-----------|---------|
| No persistent storage | All data is lost when the program exits |
| Console only | No GUI at this time |
| Limited input validation | Invalid inputs may not be handled gracefully |
| No exam timer | Questions are not time-limited |

---

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. **Fork** the repository
2. **Create** a new branch using a descriptive name (e.g., `feature/add-timer`, `fix/input-validation`)
3. **Commit** your changes with clear, concise messages
4. **Open a Pull Request** and describe what your change does and why

Please keep code style consistent with the existing codebase.

---

## 📄 License

This project is licensed under the **MIT License**.  
See the [LICENSE](LICENSE) file for full details.

---

## 📬 Contact

For questions or suggestions, feel free to open an [Issue](https://github.com/alyaayahia/Examination-system/issues) or reach out via [@alyaayahia](https://github.com/alyaayahia).
