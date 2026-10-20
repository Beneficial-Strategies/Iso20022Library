#!/usr/bin/env python3
"""
Apply class-level [IsoXmlTag("...")] to complex choice variant files.

Reads class_to_xmltag.json  (produced by the MCP lookup agent) and patches
every complex variant .cs file (2+ [IsoXmlTag] properties, no class-level tag).

Usage:
    python3 apply_xmltags.py [--dry-run]
"""
import os, re, json, sys

dry_run = "--dry-run" in sys.argv

with open("class_to_xmltag.json") as f:
    mapping = json.load(f)   # {class_name: xml_tag}

# Pattern: [IsoXmlTag(...)] on property (followed by property eventually)
# We detect class-level by checking if [IsoXmlTag] appears immediately before "public record"
CLASS_TAG_RE = re.compile(r'\[IsoXmlTag\([^\]]+\)\]\s*\n\s*public record')
PROP_TAG_RE  = re.compile(r'^\s*\[IsoXmlTag\(', re.MULTILINE)
# Insert [IsoXmlTag("...")] between [DisplayName("...")] and "public record"
INSERT_RE    = re.compile(
    r'(\s*\[DisplayName\([^\]]*\)\]\s*\n)(\s*public record\s)',
    re.MULTILINE
)

fixed = 0
skipped_no_mapping = []
conflicts = []

for folder in sorted(os.listdir('.')):
    if not os.path.isdir(folder):
        continue
    for fname in sorted(os.listdir(folder)):
        if not fname.endswith('.cs'):
            continue
        stem = fname[:-3]
        path = os.path.join(folder, fname)
        content = open(path).read()

        prop_tags = len(PROP_TAG_RE.findall(content))
        has_class_tag = bool(CLASS_TAG_RE.search(content))

        if prop_tags < 2 or has_class_tag:
            continue  # single-property or already has class-level tag

        if stem not in mapping:
            skipped_no_mapping.append(path)
            continue

        xml_tag = mapping[stem]
        # Replace: insert [IsoXmlTag("tag")] before "public record"
        def inserter(m):
            indent = re.match(r'^(\s*)', m.group(2)).group(1)
            return m.group(1) + f'{indent}[IsoXmlTag("{xml_tag}")]\n' + m.group(2)

        new_content = INSERT_RE.sub(inserter, content, count=1)
        if new_content == content:
            skipped_no_mapping.append(f"REGEX_NO_MATCH:{path}")
            continue

        if not dry_run:
            with open(path, 'w') as f:
                f.write(new_content)
        fixed += 1

print(f"Fixed: {fixed}")
print(f"Skipped (no mapping): {len(skipped_no_mapping)}")
for p in skipped_no_mapping[:20]:
    print(f"  {p}")
if len(skipped_no_mapping) > 20:
    print(f"  ... and {len(skipped_no_mapping)-20} more")
