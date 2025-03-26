EmoteSlate - A Simple Emoji Clipboard Utility

Hello! My name is Vishal, and this is my first public project. EmoteSlate is a small Windows application that allows you to quickly copy emojis to your clipboard.

Compiling from Source:

This application is written in C# and can be compiled using the .NET SDK or the C# compiler (csc.exe).

**Recommended Method: Using csc.exe (C# Compiler)**

csc.exe is the C# command-line compiler, and is designed for windows.

1.  **Prerequisites:**
    * You need the .NET Framework SDK installed.
    * Ensure that `csc.exe` is in your system's PATH environment variable. If it's not, you'll need to use the full path to `csc.exe` in the command below.

2.  **Compilation Command:**
    * Open your command prompt (cmd.exe) and navigate to the directory containing `Program.cs` and `EmoteSlate.ico`.
    * Run the following command:

        ```
        csc /target:winexe /out:EmoteSlate.exe /win32icon:EmoteSlate.ico Program.cs
        ```

    * This command will compile `Program.cs` into an executable named `EmoteSlate.exe`, and it will use `EmoteSlate.ico` as the application's icon.

**Alternative Method: Using dotnet CLI**

The .NET SDK can also be used to compile this application. However, by default, `dotnet build` produces console applications. To create a Windows Forms application, you'll need to modify the project file.

1.  **Modify the Project File:**
    * Open `EmojiBoard.csproj` in a text editor.
    * Add the following `<PropertyGroup>` element within the `<Project>` element:

        ```xml
        <PropertyGroup>
            <OutputType>WinExe</OutputType>
        </PropertyGroup>
        ```

2.  **Compilation Command:**
    * Open your command prompt or terminal and navigate to the directory containing `EmojiBoard.csproj`.
    * Run the following command:

        ```
        dotnet build -c Release
        ```

    * The executable will be located in the `bin\Release` directory.

**Note on Cross-Platform Compilation:**

* `csc.exe` is primarily a Windows compiler. For macOS and Linux, the .NET SDK (`dotnet`) is the standard compilation tool.
* Compilation using `dotnet` will require the project file to be correctly configured for a WinExe output, as described above. If the project is not configured properly, it will generate a console application.
* This project is a windows forms application, and therefore will not function on Linux or MacOS without using a compatibility layer like WINE.
