# Contributing

Thank you for looking. This library is free (MIT) and is kept current by a small team. Help is welcome in several forms; see [Help keep this library maintained](README.md#help-keep-this-library-maintained).

## Reporting a bug

Use the **Bug** form. The fastest fix starts from a **unit test that fails today**: add it in a branch or a pull request and link it in the issue. The pull request that fixes the bug makes that test pass and says `Closes #<the issue>`.

## Asking for a message

Use the **Support for a message** form with the message identifier, your use case and, if you can, a valid sample (anonymised). It decides the order.

## Pull requests

- Every pull request is linked to an issue: write `Closes #123` (or `Refs #123` for a tracking issue) in the description. A check enforces it; a typo or generated file can take the `no-issue` label from a maintainer.
- A bug fix includes a test that failed before the fix, named in the pull request.
- Add a `Release note:` line if the issue title would not tell a consumer what changed. It goes into the NuGet release notes.
- The build treats warnings as errors, and both target frameworks are built and tested: run `dotnet build src/iso20022.sln -c Release` and `dotnet test src/iso20022.sln -c Release --no-build` first.
- Generated files carry the verbatim ISO 20022 descriptions; see `CLAUDE.md` for the conventions the code follows.

## How releases work

See [doc/Releasing.md](doc/Releasing.md). The labels on closed issues choose the version and write the release notes.
