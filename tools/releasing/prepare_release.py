#!/usr/bin/env python3
"""Prepare the next release: pick the version from labels, write the NuGet release notes from the issues resolved.

What it does, in order:
  1. finds the last release tag (v*) and its date;
  2. lists the issues closed as completed since then, and the merged pull requests that closed them;
  3. chooses the bump from the labels of those issues (highest wins):
       breaking-change                              -> major
       enhancement, message-support, snapshot-sync  -> minor
       anything else (bug, documentation, ...)      -> revision
  4. writes <Version> in src/Directory.Build.props and appends an entry to each package's release-notes.txt.

Nothing is committed, tagged or published here. The workflow pushes a release/vX.Y.Z branch for review; the tag that
publishes to NuGet stays a deliberate, manual act (see doc/Releasing.md).

Run locally:  python3 tools/releasing/prepare_release.py --dry-run
"""
import argparse
import json
import os
import re
import subprocess
import sys
from pathlib import Path

MAJOR_LABELS = {"breaking-change"}
MINOR_LABELS = {"enhancement", "message-support", "snapshot-sync"}
SKIP_LABELS = {"no-release-notes"}
AREA_PACKAGES = {"area:validation": {"validation"}, "area:payloads": {"payloads"}, "area:xml": {"xml"}}   # no area label: every published package
IGNORED_AREAS = {"area:sagas"}                                               # not published
NOTE_FILES = {
    "validation": "src/FluentValidation/release-notes.txt",
    "payloads": "src/FluentValidation.Payloads/release-notes.txt",
    "xml": "src/FluentValidation.Xml/release-notes.txt",
}
PROPS = "src/Directory.Build.props"
CATEGORIES = [("breaking", "Breaking change"), ("added", "Added"), ("fixed", "Fixed"), ("changed", "Changed")]
BUMP_ORDER = {"revision": 0, "minor": 1, "major": 2}


def category(labels):
    """The heading an entry goes under."""
    if labels & MAJOR_LABELS:
        return "breaking"
    if labels & MINOR_LABELS:
        return "added"
    if "bug" in labels:
        return "fixed"
    return "changed"


def bump_for(labels):
    if labels & MAJOR_LABELS:
        return "major"
    if labels & MINOR_LABELS:
        return "minor"
    return "revision"


def choose_bump(entries):
    return max((e["bump"] for e in entries), key=BUMP_ORDER.get)


def parse_version(text):
    m = re.fullmatch(r"(\d+)\.(\d+)\.(\d+)(-[0-9A-Za-z.-]+)?", text.strip())
    if not m:
        raise ValueError(f"not a version: {text!r}")
    return int(m[1]), int(m[2]), int(m[3]), m[4] or ""


def next_version(current, bump, graduate=False):
    """Bump keeping the pre-release suffix (-alpha). A major bump from 0.x would be 1.0.0, the first production
    release: that is a decision, so it is refused unless the caller says so."""
    major, minor, patch, suffix = parse_version(current)
    if bump == "major":
        if major == 0 and not graduate:
            raise SystemExit(
                f"A breaking-change label asks for a major bump, which from {current} is 1.0.0, the first production release. "
                "That is a deliberate step: rerun with --graduate (workflow input 'graduate') and with the suffix you want, "
                "or choose --bump minor.")
        return f"{major + 1}.0.0{suffix}"
    if bump == "minor":
        return f"{major}.{minor + 1}.0{suffix}"
    return f"{major}.{minor}.{patch + 1}{suffix}"


def release_note(issue, pr_bodies):
    """A 'Release note:' line in a closing pull request, then in the issue, else the issue title."""
    pattern = re.compile(r"^\s*release note:[ \t]*(.+?)\s*$", re.IGNORECASE | re.MULTILINE)
    for body in [*pr_bodies, issue.get("body") or ""]:
        m = pattern.search(body)
        if m and m[1] and not m[1].startswith("<!--"):
            return m[1]
    return issue["title"].strip()


def build_entries(issues, prs_by_issue):
    entries = []
    for issue in issues:
        labels = {l["name"] for l in issue.get("labels", [])}
        if labels & SKIP_LABELS:
            continue
        if issue.get("stateReason") not in (None, "COMPLETED"):      # closed as not planned or duplicate: nothing was done
            continue
        if labels & IGNORED_AREAS and not (labels & set(AREA_PACKAGES)):
            continue
        packages = set()
        for label, pkgs in AREA_PACKAGES.items():
            if label in labels:
                packages |= pkgs
        entries.append({
            "number": issue["number"],
            "text": release_note(issue, prs_by_issue.get(issue["number"], [])),
            "category": category(labels),
            "bump": bump_for(labels),
            "packages": packages or set(NOTE_FILES),
        })
    return sorted(entries, key=lambda e: e["number"])


def render_block(version, entries, package):
    """One version's entry in the existing release-notes.txt style: the version, then lines indented four spaces."""
    mine = [e for e in entries if package in e["packages"]]
    lines = [version]
    if not mine:
        lines.append("    No changes to this package; released in lockstep with the others.")
    for key, heading in CATEGORIES:
        for e in (x for x in mine if x["category"] == key):
            text = e["text"].rstrip(".")
            lines.append(f"    {heading}: {text} (#{e['number']}).")
    return "\n".join(lines) + "\n"


def append_block(existing, block):
    existing = existing.rstrip("\n")
    return (existing + "\n\n" if existing else "") + block


def set_version(props_text, new):
    out, n = re.subn(r"(<Version>)[^<]+(</Version>)", rf"\g<1>{new}\g<2>", props_text, count=1)
    if n != 1:
        raise SystemExit("could not find <Version> in Directory.Build.props")
    return out


# ---- GitHub and git ----

def run(*args):
    return subprocess.run(args, check=True, capture_output=True, text=True).stdout.strip()


def last_tag():
    tags = run("git", "tag", "--list", "v*", "--sort=-v:refname").split()
    return tags[0] if tags else None


def fetch(since_iso):
    issues = json.loads(run(
        "gh", "issue", "list", "--state", "closed", "--limit", "500", "--search", f"closed:>{since_iso}",
        "--json", "number,title,labels,body,stateReason,closedAt"))
    prs = json.loads(run(
        "gh", "pr", "list", "--state", "merged", "--limit", "500", "--search", f"merged:>{since_iso}",
        "--json", "number,body,closingIssuesReferences"))
    by_issue = {}
    for pr in prs:
        for ref in pr.get("closingIssuesReferences", []):
            by_issue.setdefault(ref["number"], []).append(pr.get("body") or "")
    return issues, by_issue


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--bump", choices=["auto", "major", "minor", "revision"], default="auto")
    ap.add_argument("--since", help="tag to release since (default: the newest v* tag)")
    ap.add_argument("--graduate", action="store_true", help="allow a major bump out of 0.x (the first production release)")
    ap.add_argument("--suffix", help="replace the pre-release suffix, for example -beta; '' for none")
    ap.add_argument("--dry-run", action="store_true", help="show what would change, write nothing")
    args = ap.parse_args()

    root = Path(run("git", "rev-parse", "--show-toplevel"))
    tag = args.since or last_tag()
    since = run("git", "log", "-1", "--format=%cI", tag) if tag else "1970-01-01T00:00:00Z"
    issues, prs_by_issue = fetch(since)
    entries = build_entries(issues, prs_by_issue)
    if not entries:
        print(f"Nothing to release: no issue closed as completed since {tag or 'the start'} ({since}) carries release notes.")
        return 0

    props = (root / PROPS).read_text()
    current = re.search(r"<Version>([^<]+)</Version>", props)[1]
    bump = choose_bump(entries) if args.bump == "auto" else args.bump
    version = next_version(current, bump, args.graduate)
    if args.suffix is not None:
        version = re.sub(r"-.*$", "", version) + args.suffix

    print(f"Last release: {tag} ({since})\nCurrent version: {current}\nBump: {bump}  ->  {version}\n")
    for e in entries:
        print(f"  #{e['number']:<4} {e['bump']:<8} {e['category']:<9} {','.join(sorted(e['packages'])):<16} {e['text']}")
    print()
    writes = {PROPS: set_version(props, version)}
    for package, path in NOTE_FILES.items():
        block = render_block(version, entries, package)
        writes[path] = append_block((root / path).read_text(), block)
        print(f"--- {path}\n{block}")
    if args.dry_run:
        print("Dry run: nothing written.")
    else:
        for path, text in writes.items():
            (root / path).write_text(text)
        print(f"Wrote {len(writes)} files.")
    if os.environ.get("GITHUB_OUTPUT"):
        with open(os.environ["GITHUB_OUTPUT"], "a") as f:
            f.write(f"version={version}\nbump={bump}\n")
    return 0


if __name__ == "__main__":
    sys.exit(main())
