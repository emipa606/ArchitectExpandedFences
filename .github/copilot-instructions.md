# GitHub Copilot Instructions for Architect Expanded - Fences (Continued) Mod

## Mod Overview and Purpose
The Architect Expanded - Fences (Continued) mod is an update to Nifs' original mod, adding eight types of fences that integrate well with the vanilla aesthetic. These fences can be used as defense cover and are easily customizable using the mod settings provided by the Toolbox. The mod also includes gates that can be modified to fit with the fences.

## Key Features and Systems
- **Eight Types of Fences**: Each fence type can be customized with various properties such as cover percentage, fill percentage, and more.
- **Toolbox Integration**: The mod leverages the Toolbox mod to provide extensive mod settings and customization options.
- **Blueprint and Gate Support**: The mod supports blueprints for gates and ensures they align correctly with the fences once built.
- **Compatibility**: The mod is compatible with save games, removable from save games, and can be used on saves that previously used Vanilla Fences, albeit with some drawbacks.

## Coding Patterns and Conventions
- **C# Code Structure**: The mod follows a structured C# codebase with classes and methods organized into logical namespaces.
- **XML Definitions**: XML files define various game elements such as fences and gates, ensuring they are correctly integrated into the game.

## XML Integration
The mod extensively uses XML files to define game elements. Here are some key XML files and their purposes:
- `Fence_BaseDef.xml`: Defines the base properties of fences.
- `Fence_TypeDef.xml`: Defines specific types of fences.
- `Fences+Gates.xml`: Contains definitions for fences and gates.
- `FenceSettingsDef.xml`: Defines settings related to fences, integrated with the Toolbox.
- `Gate_BaseDef.xml`: Defines the base properties of gates.

## Harmony Patching
The mod uses Harmony for patching vanilla game behavior. Here are some key patches:
- **Tab Patch**: Adds a "Fences" tab in the Toolbox settings.
- **Texture Patch**: Replaces textures with the original ones from Vanilla Fences.

## Suggestions for Copilot
- **Code Completions**: Use Copilot to assist in writing methods and classes, especially when dealing with complex interactions between fences, gates, and the Toolbox.
- **XML Snippets**: Utilize Copilot to generate XML snippets for new fence or gate definitions, ensuring they follow the existing patterns and conventions.
- **Patch Implementations**: Assist in writing Harmony patches for new features or bug fixes, ensuring they integrate seamlessly with the existing mod.

## Contributing
Contributions to the mod are welcome, especially for translations and additional fence types. Please follow the coding conventions and ensure that any new features are well-documented and tested.

## Support
For any issues or bugs, please use the Discord channel for error reporting. Always provide the log using the Log Uploader for better assistance.

---

This .github/copilot-instructions.md file provides a comprehensive guide for developers working on the Architect Expanded - Fences (Continued) mod, detailing the mod's purpose, key features, coding conventions, XML integration, and suggestions for using Copilot.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

