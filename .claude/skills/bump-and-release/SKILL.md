---
name: bump-and-release
description: Bump the package version, write release notes, update README install instructions, commit, merge to main, tag, and push to trigger NuGet publish.
argument-hint: <new-version> (e.g. 0.6.0-alpha)
---

# Bump and Release

Prepare and publish a new version of the BeneficialStrategies.Iso20022 NuGet package.

The version to release is: **$ARGUMENTS**

## Steps

### 1. Release notes

Open `src/BeneficialStrategies.Iso20022.Common/release-notes.txt`.

Add a new entry for `$ARGUMENTS` at the bottom. Review commits since the last version bump (`git log <last-bump-tag>..HEAD --oneline`) and summarize the meaningful changes — one bullet per logical group of commits. Skip pure doc/housekeeping commits unless they are user-facing.

### 2. Version bump

In `src/BeneficialStrategies.Iso20022.Common/BeneficialStrategies.Iso20022.Common.csproj`, set:

```xml
<Version>$ARGUMENTS</Version>
```

### 3. README install instructions

In both `README.md` (root) and `doc/package/README.md`, update the `dotnet add package` line to reference `$ARGUMENTS`:

```bash
dotnet add package BeneficialStrategies.Iso20022 --version $ARGUMENTS
```

### 4. Commit

Stage and commit those three files together:

```
Bump version to $ARGUMENTS and add release notes
```

### 5. Merge to main

```bash
git checkout main
git merge <current-branch>
git push origin main
```

### 6. Tag and push

```bash
git tag v$ARGUMENTS
git push origin v$ARGUMENTS
```

The `v*` tag push triggers the GitHub Actions workflow (`.github/workflows/publish.yml`), which builds, packs, and pushes the NuGet package automatically. No manual publish step needed.
