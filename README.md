# Libralink

Libralink is a library management API and web application developed using ASP.NET Core, GraphQL, and Angular. It provides a comprehensive solution for managing library resources and services efficiently.

## Table of Contents

- [Libralink](#libralink)
- [Contributing](#contributing)
  - [Commits](#commits)
  - [Branches](#branches)
  - [Pull Requests](#pull-requests)

## Contributing

### Commits

Commits in this project should adhere to the [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/) standard. This ensures consistency and clarity in the development process.

Examples of commit messages:

```
feat: Add new feature

- More details about the feature.
- Why it was added.
- How it works.

- Refs: #123
```

```
fix(scope): Fix bug

- More details about the bug.
- Actual and expected behavior.
- How it was fixed.

- Refs: #123
```

```
feat!: New breaking feature

- More details about the feature.

- Refs: #123
```

Notes:

- All commit sentences should be in the present tense.
- Header, body, and footer should be separated by a blank line.
- The commit name should start with a capital letter and end with a period.
- Commit descriptions should be in bullet points and end with a period.
- Related tasks should be referenced at the end of the commit description.
- Commits can have an optional scope.
- Breaking changes should be marked with a `!` after the type.

### Branches

Branches should be named following the convention:

`{type}/{task_id}-{description}`

Where the type can be one of the following:
- `feat` - for new features or enhancements
- `fix` - for bug fixes
- `exp` - for experiments, debugging, or other non-production code

Task ID should be the corresponding GitHub Projects task ID, and the description should provide a short summary of the task.

### Pull Requests

Pull requests should be named similarly to commits and include a description of the changes made. Merging should be done using the **"Squash and Merge"** option for a clean and organized commit history.

With these guidelines, we aim to maintain a high level of organization and clarity throughout the development process in the Libralink project. Thank you for your contributions! 🚀📚

