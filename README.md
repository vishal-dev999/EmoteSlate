# EmoteSlate - A Simple Emoji Clipboard Utility 🎉  

Hey there! I'm **Vishal**, and this is my first public project. **EmoteSlate** is a lightweight Windows application that lets you quickly copy emojis to your clipboard. No bloat, no nonsense—just pure efficiency.  

---

## **Download & Usage** 🚀  

You can either **download the pre-compiled executable** or **build it yourself** using `csc.exe` (C# Compiler).  

### **🔹 Option 1: Download the Executable**  
No setup required! Just grab the `.exe` and run it. **[https://github.com/vishal-dev999/EmoteSlate/releases/download/v1.0.1/EmoteSlate.exe](#)** 

---

## **🔹 Option 2: Compile from Source using `csc.exe`**  

### **1️⃣ Prerequisites**  
- You need the **.NET Framework SDK** installed.  
- Ensure `csc.exe` is in your **system's PATH**. If not, use its full path in the command.  

### **2️⃣ Compilation Command**  
1. Open **Command Prompt (`cmd.exe`)**.  
2. Navigate to the directory containing `Program.cs` and `EmoteSlate.ico`.  
3. Run:  

    ```sh
    csc /target:winexe /out:EmoteSlate.exe /win32icon:EmoteSlate.ico Program.cs
    ```

This generates `EmoteSlate.exe` with the **EmoteSlate.ico** as its app icon.

---

## **❌ What About .NET SDK?**  
Forget it! `dotnet build` is **bloated** and **unnecessary** for this project. This is a **pure Windows app**, and `csc.exe` is **all you need**.  

---

## **📌 Notes**  
- **Windows-Only**: Since this is a **WinForms** app, it won’t work on Linux/macOS (unless you use WINE).  
- **No Dependencies**: The compiled `.exe` is **small & standalone**—no extra DLLs needed.  

---

🔥 Enjoy using EmoteSlate! Feel free to contribute or report issues.  

