# Releasing

Releases are driven by issues. An issue closed as completed since the last release becomes a line in the release notes, and its labels choose the version.

## How the version is chosen

The highest label among the issues closed since the last `v*` tag wins.

| Label on the issue | Bump | Example |
|---|---|---|
| `breaking-change` | major | a renamed public type |
| `enhancement`, `message-support`, `snapshot-sync` | minor | a new message, a snapshot sync |
| anything else (`bug`, `documentation`, `tech-debt`, `ci`) | revision | a fixed exception |

The pre-release suffix (`-alpha`) is kept. **A `breaking-change` while the version is 0.x would mean 1.0.0, the first production release**, so the script refuses that on its own; leaving 0.x is done on purpose with the `graduate` option (and a `suffix` if you want one, for example `-beta`, or empty for none).

An issue closed as *not planned*, and an issue labelled `no-release-notes`, are left out of the notes and of the bump. Area labels route a line: `area:primitives` to the Primitives notes only, `area:interfaces` to the Interfaces notes only, `area:validation` to the FluentValidation notes only, `area:payloads` to the Payloads notes only, `area:xml` to the Xml notes only, `area:core` to the core notes only, none to all six, `area:sagas` nowhere (that package is not published).

## What goes into the notes

For each issue, in this order: a `Release note:` line in the pull request that closed it, a `Release note:` line in the issue, else the issue title. Lines are grouped under *Breaking change*, *Added*, *Fixed* and *Changed*, each ending with the issue number, in the style of the existing `release-notes.txt` files.

## Steps

1. Close the issues you want in the release (a merged pull request with `Closes #n` does it).
2. **Actions, Prepare release, Run workflow.** Leave *dry run* ticked the first time: the job summary shows the version and the notes and pushes nothing.
3. Run it again with *dry run* unticked. It pushes a `release/vX.Y.Z` branch changing `<Version>` in `src/Directory.Build.props` and appending to each package's `release-notes.txt`. The job summary has the link to open the pull request.
4. Edit the notes in that pull request if you want your own words, and merge it.
5. Tag the merge commit `vX.Y.Z` and push the tag. `publish.yml` packs, pushes to NuGet by Trusted Publishing, and creates the GitHub Release with the same notes (marked pre-release while the version has a suffix).

The tag stays a manual step on purpose: publishing to NuGet cannot be taken back.

Locally: `python3 tools/releasing/prepare_release.py --dry-run` (needs `gh` logged in). The logic is tested in `tools/releasing/test_prepare_release.py`, which CI runs.

## Pull requests and issues

Every pull request is linked to an issue: `Closes #n`, or `Refs #n` for a tracking issue. A check fails the pull request otherwise; a maintainer adds the `no-issue` label for a typo or a generated file. A bug fix names the test that failed before the fix, and the bug issue links to that test.
