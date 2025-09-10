# GitHub Copilot Instructions for RimWorld Modding Project: CloseAll (Continued)

## Mod Overview and Purpose
CloseAll (Continued) is a RimWorld mod designed to enhance the user interface by adding a convenient alert feature. It introduces an alert button above the in-game letters, allowing players to close all active notifications with a single click. This mod streamlines gameplay by reducing the distraction of managing multiple on-screen messages, providing a cleaner and more efficient user experience.

## Key Features and Systems
- **Alert Management**: Provides a new alert button for closing all active game notifications simultaneously.
- **User Interface Integration**: Ensures seamless integration into the existing RimWorld UI without altering the game's core mechanic interfaces.
- **Compatibility and Stability**: Designed to be safe for existing saves, ensuring no disruptions to ongoing games upon installation.

## Coding Patterns and Conventions
- **Class Design**: Utilize clear and descriptive class names such as `AlertCloseAll` and `Main` to signify their roles.
- **Method Organization**: Group related functionality within appropriate classes. Ensure methods are focused on single tasks, and adopt a consistent naming convention to enhance readability and maintenance.
- **Modular Code**: Structure code to be modular and separate concerns efficiently. For example, handling UI elements should be distinct from alert management logic.

## XML Integration
- **Defs and XML Structure**: Any modifications or additions to the game's XML should be structured to use Defs smartly and consistently referenced in the C# code.
- **Language Data**: Ensure that any user-facing text strings are stored in language data XML for easy localization. Use the `<Key>` and `<Value>` format for entries.

## Harmony Patching
- **Patch Application**: Use Harmony to apply patches without altering the original game code directly. This ensures mod compatibility and minimizes the risk of introducing bugs.
- **Patch Structure**: Implement patches in a static class like `AlertNotifyStartedPatch` and categorize patches by their function to keep code clean and organized.
- **Safeguards**: Use try-catch blocks around patching code to handle potential exceptions gracefully and avoid crashing the game.

## Suggestions for Copilot
- **Pattern Recognition**: Suggest design patterns that suit modular UI features and effective event handling.
- **Code Efficiency**: Recommend optimizations for performance, especially related to event listeners and UI updates.
- **Documentation Comments**: Automatically generate summary comments for classes and methods based on their names and intended functionality to enhance code documentation.
- **Harmony Examples**: Provide relevant examples or templates for applying Harmony patches that target specific methods or properties within RimWorld's assembly.
- **Localization Assistance**: Suggest best practices for managing multi-language support in mods, ensuring all text strings are easily replaceable based on the user's language selection.

By following these guidelines and instructions, developers can efficiently contribute to and expand the functionality of the CloseAll (Continued) mod while maintaining high code quality and performance standards.
