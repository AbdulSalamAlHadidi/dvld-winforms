# DVLD UI Architecture

## Goal

Build a modern, maintainable, dark-theme-ready WinForms user interface for the DVLD desktop application.

The UI Shell:
- Persistent sidebar navigation.
- A top application bar.
- A central content area for pages.
- Reusable UI controls.
- Consistent typography, spacing, colors, and component behavior.

## UI Shell

```text
MainForm
├── SidebarPanel
├── TopBarPanel
└── ContentPanel
```

## UI Responsibilities

The Presentation Layer is responsible for:
- Displaying data.
- Collecting user input.
- Providing navigation.
- Showing validation feedback.
- Showing loading, empty, success, and error states.

The Presentation Layer must not contain:
- SQL queries.
- Database connection code.
- Business rules.
- Direct database access.

## Navigation

Main navigation sections:

1. Dashboard
2. People
3. Drivers
4. Applications
5. Licenses
6. Users
7. Settings

## Core UI Principle

MainForm hosts the application shell.
Each major screen is implemented as a UserControl and displayed inside ContentPanel.
Forms are reserved for login, dialogs, confirmations, and other modal workflows.

## Theme Direction

Initial direction: Dark theme.

Theme colors, typography, spacing, and reusable visual styles will be centralized later in the Theme folder.