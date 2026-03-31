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

### 5. Build verification

Before merging, confirm the build is clean locally:

```bash
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release
```

Fix any errors before proceeding.

### 6. Merge to main

```bash
git checkout main
git merge <current-branch>
git push origin main
```

**Merge conflict warning:** If the working branch renamed or deleted many files (e.g. `.g.cs` → `.cs`), the merge may produce a large number of conflicts. Use `git merge -X theirs <branch>` to auto-resolve all conflicts in favour of the incoming branch, which avoids the risk of accidentally deleting files via `git rm` during manual resolution.

After merging, verify the build is still clean:

```bash
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release
```

### 7. Tag and push

```bash
git tag v$ARGUMENTS
git push origin main
git push origin v$ARGUMENTS
```

The `v*` tag push triggers the GitHub Actions workflow (`.github/workflows/publish.yml`), which builds, packs, and pushes the NuGet package automatically. No manual publish step needed.
