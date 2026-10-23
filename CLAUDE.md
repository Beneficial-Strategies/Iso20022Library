# CLAUDE.md

## What this repository is now

The remains of the monorepo of the ISO 20022 .NET family. Each package is leaving it for a repository of its own (documents: the organization's repository-per-package decision), and most already have:

| Package | Repository |
|---|---|
| `BeneficialStrategies.Iso20022.Primitives` | [iso-20022-primitives](https://github.com/Beneficial-Strategies/iso-20022-primitives) |
| `BeneficialStrategies.Iso20022.Factory` | [iso-20022-factory](https://github.com/Beneficial-Strategies/iso-20022-factory) |
| `BeneficialStrategies.Iso20022.Messages` (the interfaces; prepared here as `Interfaces`) | [iso-20022-messages](https://github.com/Beneficial-Strategies/iso-20022-messages) |
| `BeneficialStrategies.Iso20022.Messages.Records` (the records, written by a source generator from the interfaces; replaces `BeneficialStrategies.Iso20022`, formerly `src/Common`, whose last version is 0.7.0-alpha) | [iso-20022-messages-records](https://github.com/Beneficial-Strategies/iso-20022-messages-records) |
| `BeneficialStrategies.Iso20022.Messages.Samples` (named valid objects for tests, and `IsoSample.Minimal<T>()`) | [iso-20022-messages-samples](https://github.com/Beneficial-Strategies/iso-20022-messages-samples) |

**What is still here** (`src/`): `MassTransit.Sagas` (a proof of concept, not published, no support intended; see #107), with its tests, and the demo that uses it. They use the published packages above, from 1.0.0-alpha up to the next breaking change; a change that needs a new version of one of them is made in its repository, released, and then the minimum is raised here.

The guidance that used to be in this file moved with the code it was about: the design pattern of the primitive types and the XML documentation rules to iso-20022-primitives (`docs/`), the rules for the documentation of the interfaces to iso-20022-messages (`docs/`), the build performance of the model and the test patterns to iso-20022-messages-records (`docs/`).

## Build and test

```bash
dotnet build src/iso20022.sln -c Release      # zero warnings are enforced (TreatWarningsAsErrors in src/Directory.Build.props)
dotnet test  src/iso20022.sln -c Release --no-build
```

CI (about 20 minutes) runs the same, plus the license check and the tests of the netstandard2.0 builds on .NET Framework 4.8 (Windows). Releases: `doc/Releasing.md`.

## Targets

What is here targets net8.0 and net10.0, the two newest .NET LTS releases (not the two newest version numbers). One .NET 10 SDK builds every target (`src/global.json`).

## Rules for working here

* Never commit, push or open a pull request unless asked in that turn. Never commit `.claude/`.
* Every public type and member has an XML documentation comment (the build fails on a missing one). For the validators it states the rule and why; for the samples, what the object is.
* Every pull request is linked to an issue (`Closes #n`); a bug fix names the test that failed before it.
* The code is public text: never name or describe anything that is not public.
