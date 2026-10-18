#!/usr/bin/env python3
"""Expand <inheritdoc cref="..."/> in a package's XML documentation file from the XML file(s) that hold the target.

Roslyn writes <inheritdoc/> into the shipped XML as it is; an editor has to resolve it. This script writes the text in,
so IntelliSense does not depend on the editor (spike for #27).

  expand_inheritdoc.py <doc.xml> <source.xml> [<source.xml> ...]   (rewrites doc.xml in place)
"""
import re
import sys

def members(path):
    text = open(path, encoding="utf-8").read()
    return {m.group(1): m.group(2) for m in re.finditer(r'<member name="([^"]+)">(.*?)</member>', text, re.S)}

def main():
    doc, sources = sys.argv[1], sys.argv[2:]
    table = {}
    for s in sources:
        table.update(members(s))
    text = open(doc, encoding="utf-8").read()
    missing = []

    def expand(m):
        body = table.get(m.group(2))
        if body is None:
            missing.append(m.group(2))
            return m.group(0)
        return body.strip("\n")

    out = re.sub(r'(<inheritdoc cref="([^"]+)"\s*/>)', expand, text)
    open(doc, "w", encoding="utf-8").write(out)
    print(f"expanded {len(re.findall('<inheritdoc', text)) - len(missing)}, unresolved {len(missing)}")

main()
