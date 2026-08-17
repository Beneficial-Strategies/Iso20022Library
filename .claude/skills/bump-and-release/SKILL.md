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

### 3. Package description message count

> **2026-08-17 addition**: this step was missing entirely, and `PackageDescription` sat stale at
> "2,665 B2B financial messages" through two full snapshot syncs (0.4.0-alpha and 0.5.0-alpha)
> before being caught and hand-fixed. Always do this step on every release, not just when a
> snapshot sync happened to run first.

In the same `PropertyGroup` as `<Version>`, `PackageDescription` hardcodes a message count:

```xml
<PackageDescription>The entirety of the ISO20022 message domain model. {N} B2B financial messages structured as immutable records based on the ISO20022 standard.</PackageDescription>
```

Recompute `{N}` as the actual count of files under `src/BeneficialStrategies.Iso20022.Common/MessageDefinitions/`:

```bash
find src/BeneficialStrategies.Iso20022.Common/MessageDefinitions -iname "*.cs" | wc -l
```

Use this file count, not `get_repository_statistics`' MCP-reported total — they can differ by a
handful (e.g. 3,311 shipped files vs. 3,312 MCP-reported messages, seen 2026-08-17) and the
`PackageDescription` should describe what's actually in the package, not what the live MCP
snapshot currently claims. Update the number with thousands separators matching the existing
style (`3,311`, not `3311`).

### 4. README install instructions

In both `README.md` (root) and `doc/package/README.md`, update the `dotnet add package` line to reference `$ARGUMENTS`:

```bash
dotnet add package BeneficialStrategies.Iso20022 --version $ARGUMENTS
```

### 5. Commit

Stage and commit those four files together (release notes, `.csproj` — both the `<Version>` and `<PackageDescription>` edits — and both READMEs as applicable):

```
Bump version to $ARGUMENTS and add release notes
```

### 6. Build verification

Before merging, confirm the build is clean locally:

```bash
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release
```

Fix any errors before proceeding.

### 7. Merge to main

```bash
git checkout main
git merge <current-branch>
git push origin main
```

**Merge conflict warning:** If the working branch renamed or deleted many files (e.g. `.g.cs` → `.cs`), the merge may produce a large number of conflicts. Use `git merge -X theirs <branch>` to auto-resolve all conflicts in favour of the incoming branch, which avoids the risk of accidentally deleting files via `git rm` during manual resolution. Before relying on that flag, try a dry-run first — `git merge-tree $(git merge-base main <branch>) main <branch> | grep -c '^<<<<<<<'` — a 0 count means the merge is actually clean and `-X theirs` isn't needed at all (this has been the case every release so far, despite large file counts).

After merging, verify the build is still clean:

```bash
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release
```

### 8. Tag and push

```bash
git tag v$ARGUMENTS
git push origin main
git push origin v$ARGUMENTS
```

The `v*` tag push triggers the GitHub Actions workflow (`.github/workflows/publish.yml`), which builds, packs, and pushes the NuGet package automatically. No manual publish step needed.
