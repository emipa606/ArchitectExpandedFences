# GitHub Copilot Instructions for RimWorld Modding Project

## Mod Overview and Purpose

This RimWorld mod aims to enhance the game's construction and defense systems by introducing new gate and fence mechanics. The mod is designed to integrate seamlessly with the existing game world, providing players with additional strategic options for colony management and fortification.

## Key Features and Systems

- **Gates and Fence Systems**: Introduces new building types such as `Building_Gate` and `Blueprint_Gate` that allow players to construct gates as a part of their defense systems. These buildings integrate with existing fences to create a more robust and interactive perimeter.
  
- **Harmony Patches**: Utilizes Harmony, a dynamic library patching tool, to ensure compatibility and extend the functionality of existing game methods without altering original game files. This is primarily handled in `Patch_GenConstruct` and `Patch_GenSpawn`.
  
- **XML Integration**: The mod will use XML files to define new blueprint and building properties, ensuring easy modifications and extensions.

## Coding Patterns and Conventions

- **Naming Conventions**: This project follows standard C# naming conventions. Classes are named using PascalCase, e.g., `Building_Gate`, while methods within these classes follow the same pattern.

- **Class Design**: The core mod functionality extends from existing game classes. For example, `Building_Gate` extends `Building_Door`, demonstrating inheritance and leveraging polymorphic behavior.

- **Modular Architecture**: Classes such as `Patch_GenConstruct` and `Patch_GenSpawn` are implemented as static classes focusing on specific game functionalities, promoting clean separation of concerns.

## XML Integration

- The mod utilizes XML files for defining new structures and items. This allows easy configuration of properties such as material costs, construction time, and structural integrity. XML files can be found typically under a `Defs` directory and are essential for integrating new content without direct C# implementation.

## Harmony Patching

- **Harmony Usage**: The mod's harmony patches are initialized in `HarmonyInit`. This involves creating postfix methods, like `Postfix_CanPlaceBlueprintOver`, which modify or extend base game behaviors. 

- **Patch Structure**: Patches are organized within their respective classes, such as `Patch_GenConstruct` or `Patch_GenSpawn`. Each patch targets specific methods in RimWorld's code to enhance mod functionality while preserving baseline game mechanics.

## Suggestions for Copilot

To maximize the efficiency of GitHub Copilot in this project, consider the following:

- **Comment Thoroughly**: Comment your code effectively, explaining logic and decision-making processes. This helps Copilot better understand the context and provide relevant suggestions.

- **Standardizing Code Patterns**: Maintain consistent coding patterns across your C# and XML files. This includes following the aforementioned naming and structural conventions to allow Copilot to leverage pattern recognition more effectively.

- **Incremental Development**: Introduce new features and patches incrementally. As new functionality is added, this allows Copilot to adjust its suggestions based on newly introduced code segments, aiding smoother development processes.

- **Utilize Copilot for Refactoring**: When working on enhancing or refactoring code, use Copilot to suggest optimizations or alternative approaches that align with C# best practices and Harmony usage. 

By adhering to these guidelines, GitHub Copilot can significantly aid in the development and maintenance of your RimWorld mod, providing suggestions that respect the game's architectural design and functionality.
