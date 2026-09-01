---
name: bump-and-release
description: Bump the shared package version, write release notes, update README install instructions, commit, merge to main, tag, and push to trigger NuGet publish.
argument-hint: <new-version> (e.g. 0.6.0-alpha)
---

# Bump and Release

Prepare and publish a new version of the `BeneficialStrategies.Iso20022*` NuGet packages.

The version to release is: **$ARGUMENTS**

## Steps

### 1. Release notes

Open `src/BeneficialStrategies.Iso20022.Common/release-notes.txt` (and the equivalent
`release-notes.txt` for any other package with meaningful changes this release —
`BeneficialStrategies.Iso20022.FluentValidation`, `BeneficialStrategies.Iso20022.MassTransit.Sagas`).

Add a new entry for `$ARGUMENTS` at the bottom of each. Review commits since the last version bump
(`git log <last-bump-tag>..HEAD --oneline`) and summarize the meaningful changes — one bullet per
logical group of commits. Skip pure doc/housekeeping commits unless they are user-facing.

### 2. Version bump

All packages share one version in lockstep — see `CLAUDE.md`'s "Multi-Package Repository
Strategy." Set it in exactly one place, `src/Directory.Build.props`:

```xml
<Version>$ARGUMENTS</Version>
```

Do **not** add a per-project `<Version>` to any individual `.csproj` — that would fork a package
off the shared version, defeating the point of centralizing it here.

### 3. Message-count references (PackageDescription, Common's README, root README, Scope-Statement.md)

> **2026-08-17 addition**: none of this was covered by the skill at all, and every one of these
> locations sat stale — some through two full snapshot syncs (0.4.0-alpha and 0.5.0-alpha) —
> before being caught and hand-fixed in the same sitting the user asked "did Scope-Statement.md
> get updated also? It should." Always do this step on every release, not just when a snapshot
> sync happened to run first — message counts drift on every sync even without a version bump.
>
> **2026-08-31 restructuring note**: this used to be a 4-file list including a separate
> `doc/package/README.md` (the file actually packed as the NuGet page's README, distinct from and
> frequently out of sync with root `README.md`). That duplication is exactly what caused the drift
> this note originally warned about. Each package now has exactly **one** `README.md`, living in
> its own project root (`src/{ProjectName}/README.md`), which is both what GitHub shows for that
> folder and what gets packed — see each `.csproj`'s `<None Include="README.md">`. The list below
> reflects that; there is no more separate `doc/package/` tree to keep in sync.

Files that hardcode a message count and must be kept in sync together:

- `src/BeneficialStrategies.Iso20022.Common/BeneficialStrategies.Iso20022.Common.csproj` — `PackageDescription`:
  ```xml
  <PackageDescription>The entirety of the ISO20022 message domain model. {N} B2B financial messages structured as immutable records based on the ISO20022 standard.</PackageDescription>
  ```
- `src/BeneficialStrategies.Iso20022.Common/README.md` — opening sentence: `...containers for {N} different types of financial services messages...`
- `README.md` (root) — the package table's one-line description of `BeneficialStrategies.Iso20022` (now much smaller surface area than before the restructuring — a single table cell, not a duplicated paragraph).
- `doc/Scope-Statement.md` — full regeneration, see below. Its own summary line and per-business-area table use the same `{N}`.

**Recompute `{N}`** as the actual count of files under `src/BeneficialStrategies.Iso20022.Common/MessageDefinitions/`:

```bash
find src/BeneficialStrategies.Iso20022.Common/MessageDefinitions -iname "*.cs" | wc -l
```

Use this file count, not `get_repository_statistics`' MCP-reported total, for `{N}` in the
PackageDescription and the README — they can differ by a handful (e.g. 3,311 shipped files vs.
3,312 MCP-reported messages, seen 2026-08-17) and these should describe what's actually in the
shipped package, not what the live MCP snapshot currently claims. Update the number with thousands
separators matching the existing style (`3,311`, not `3311`). The vaguer "over 2,600 messages"
phrasing already present in a couple of spots in the Common README doesn't need to track this
exactly — only the precise counts do.

**Regenerate `doc/Scope-Statement.md` in full** — its whole reason to exist is being an accurate,
per-business-area snapshot, so partial updates leave it self-contradictory:
1. Recompute the file-count-per-business-area table:
   ```bash
   cd src/BeneficialStrategies.Iso20022.Common/MessageDefinitions
   for d in */; do echo "${d%/} $(find "${d%/}" -iname '*.cs' | wc -l)"; done | sort
   ```
2. Call `mcp__plugin_iso20022-staging_iso20022-staging__get_repository_statistics` for the "Spec" column per business area and
   the message-definition total, and for the Supporting Architecture Counts table (internal/
   external code sets, message components, business components, simple types, external schemas,
   user-defined entries, choice types, total).
3. Diff Library vs. Spec per row. Any mismatch needs a real explanation in the Notes column, not
   a guess — grep the cached `snapshot-sync/{date}/spec-snapshot.tsv` for duplicate `MSGDEF` names
   within that business area (`grep "^MSGDEF" spec-snapshot.tsv | awk -F'\t' '$4=="{area}" {print $2}' | sort | uniq -d`)
   to confirm a duplicate-entry artifact before writing that explanation, the same way the
   `RequestToModifyPaymentV03` camt duplicate was confirmed 2026-08-17 (two distinct `xmi:id`
   records sharing one name). Don't just carry forward whatever explanation the previous revision
   used for a similarly-shaped row — reverify it, since the specific duplicate can change between
   snapshots even if the row's off-by-one pattern looks familiar.
4. Update the "Counts verified against actual files in the repository ({month} {year})" and
   "ISO 20022 spec snapshot ({date})" phrasing at the top of both sections to the current date.

### 4. README install instructions

Every package with a `PackageReadmeFile` (currently `BeneficialStrategies.Iso20022` and
`BeneficialStrategies.Iso20022.FluentValidation`; `BeneficialStrategies.Iso20022.MassTransit.Sagas`
once it's actually published) has its own `dotnet add package ... --version` line(s), in its own
`src/{ProjectName}/README.md` — one edit per package now, not two:

```bash
dotnet add package BeneficialStrategies.Iso20022 --version $ARGUMENTS
```

`src/BeneficialStrategies.Iso20022.FluentValidation/README.md` has two such lines (it installs
both `BeneficialStrategies.Iso20022` and `BeneficialStrategies.Iso20022.FluentValidation`) — update
both. A mechanical backstop also exists for this specific step:
`src/BeneficialStrategies.Iso20022.Common.Tests/ReadmeVersionPinTests.cs` fails the test suite if
any package README's version pin drifts from `Directory.Build.props`, so a missed line here
surfaces immediately in step 6 below rather than silently shipping stale.

### 5. Commit

Stage and commit the changed files together (release notes, `Directory.Build.props`, the
`PackageDescription` edit, the affected package READMEs, and `doc/Scope-Statement.md`):

```
Bump version to $ARGUMENTS and add release notes
```

### 6. Build verification

Before merging, confirm the build and the README version-pin guard test are clean locally:

```bash
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release
cd src && dotnet test BeneficialStrategies.Iso20022.Common.Tests
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

The `v*` tag push triggers the GitHub Actions workflow (`.github/workflows/publish.yml`), which
builds, packs, and pushes the NuGet packages automatically via Trusted Publishing (OIDC) — no
manual publish step, and no long-lived API key involved.
