#!/usr/bin/env python3
"""Generate the interfaces of #27 from the records of Common (spike).

For every message of the chosen business areas, and every component and choice they reach, it writes
  * the interface (one file, in the Interfaces project, same folder layout), and
  * a partial of the record (next to the record) that adds the interface and the explicit members the interface needs.
With --partial it also turns `record X` into `partial record X` in the record files; with --inheritdoc it replaces the
documentation of the record and of its members with <inheritdoc cref="..."/> (the text is then on the interface only).

Run from the repository root:  python3 tools/interfaces/generate_interfaces.py --areas pacs
"""
import argparse
import re
import sys
from pathlib import Path

COMMON = Path("src/BeneficialStrategies.Iso20022.Common")
OUT = Path("src/BeneficialStrategies.Iso20022.Interfaces")
KEEP_ATTRS = ("IsoId", "DisplayName", "IsoXmlTag")

DECL = re.compile(r"^\s*public\s+(abstract\s+)?(partial\s+)?record\s+(\w+)(?:\s*:\s*([\w.]+))?")
NS = re.compile(r"^\s*namespace\s+([\w.]+)")
PROP = re.compile(r"^\s*public\s+(required\s+)?([\w.]+(?:<[\w.<>?, ]+>)?\??)\s+(\w+)\s*\{\s*get;\s*init;\s*\}")


class Member:
    def __init__(self, name, type_, required, doc, attrs):
        self.name, self.type, self.required, self.doc, self.attrs = name, type_, required, doc, attrs


class Rec:
    def __init__(self, path, kind, ns, name, base, doc, attrs, members):
        self.path, self.kind, self.ns, self.name, self.base = path, kind, ns, name, base
        self.doc, self.attrs, self.members = doc, attrs, members


STRINGS = re.compile(r'@"(?:[^"]|"")*"|"(?:\\.|[^"\\])*"')


def read_attr(lines, i):
    """An attribute may span lines: read until the brackets balance (not counting those inside string literals)."""
    text = lines[i].strip()
    while True:
        bare = STRINGS.sub('""', text)
        if bare.count("[") <= bare.count("]") and bare.count("(") <= bare.count(")"):
            return text, i
        i += 1
        text += "\n" + lines[i].strip()


def parse(path):
    lines = path.read_text(encoding="utf-8-sig").split("\n")
    ns = next((NS.match(l).group(1) for l in lines if NS.match(l)), None)
    doc, attrs, members, rec = [], [], [], None
    i = 0
    while i < len(lines):
        s = lines[i].strip()
        if s.startswith("///"):
            doc.append(s)
        elif s.startswith("//"):
            pass   # an ordinary comment between the documentation, the attributes and the member
        elif s.startswith("["):
            a, i = read_attr(lines, i)
            attrs.append(a)
        else:
            m = DECL.match(lines[i])
            if m and rec is None:
                kind = "choice" if m.group(1) else "record"
                rec = dict(kind=kind, name=m.group(3), base=m.group(4), doc=doc, attrs=attrs)
                doc, attrs = [], []
            else:
                p = PROP.match(lines[i])
                if p and rec is not None:
                    members.append(Member(p.group(3), p.group(2), bool(p.group(1)), doc, attrs))
                doc, attrs = [], []
        i += 1
    if rec is None:
        return None
    if any("<inheritdoc" in d for d in rec["doc"]) or any("<inheritdoc" in d for m in members for d in m.doc):
        sys.exit(f"{path}: the documentation was already moved to the interface; restore the record files before generating again.")
    return Rec(path, rec["kind"], ns, rec["name"], rec["base"], rec["doc"], rec["attrs"], members)


def cs_files(directory, pattern):
    """The record files of a folder, not the partials this script wrote next to them."""
    return [p for p in sorted(directory.glob(pattern)) if not p.name.endswith(".Interfaces.cs")]


def load_all(areas):
    comps, choices, variants, messages = {}, {}, {}, {}
    for p in cs_files(COMMON / "Components", "*.cs"):
        r = parse(p)
        if r:
            comps[r.name] = r
    for p in cs_files(COMMON / "Choices", "*_.cs"):
        r = parse(p)
        if r:
            choices[r.name] = r
    for d in sorted((COMMON / "Choices").iterdir()):
        if d.is_dir():
            for p in cs_files(d, "*.cs"):
                r = parse(p)
                if r:
                    variants.setdefault(d.name + "_", []).append(r)
    for a in areas:
        for p in cs_files(COMMON / "MessageDefinitions" / a, "*.cs"):
            r = parse(p)
            if r:
                messages[r.name] = r
    return comps, choices, variants, messages


def element_type(t):
    """('list', X) for ValueList<X>, ('simplelist', X) for SimpleValueList<X>, else ('one', X) (with the ? kept)."""
    m = re.fullmatch(r"(Simple)?ValueList<(.+)>", t)
    if m:
        return ("simplelist" if m.group(1) else "list"), m.group(2)
    return "one", t


def iface_name(n):
    return "I" + (n[:-1] if n.endswith("_") else n)


def map_type(t, comps, choices):
    """The interface type for a record type, or the same type for a primitive."""
    core = t.rstrip("?")
    q = "?" if t.endswith("?") else ""
    if core in comps or core in choices:
        return iface_name(core) + q, True
    return t, False


def closure(messages, comps, choices, variants):
    seen_c, seen_ch, todo = set(), set(), []
    for m in messages.values():
        todo += [x.type for x in m.members]
    while todo:
        t = todo.pop()
        _, e = element_type(t)
        e = e.rstrip("?")
        if e in comps and e not in seen_c:
            seen_c.add(e)
            todo += [x.type for x in comps[e].members]
        elif e in choices and e not in seen_ch:
            seen_ch.add(e)
            for v in variants.get(e, []):
                todo += [x.type for x in v.members]
    return seen_c, seen_ch


def indent(lines, n):
    pad = " " * n
    return [pad + l if l else l for l in lines]


def keep(attrs):
    return [a for a in attrs if a.startswith(tuple("[" + k + "(" for k in KEEP_ATTRS))]


def member_decl(m, comps, choices):
    kind, elem = element_type(m.type)
    if kind == "one":
        t, mapped = map_type(m.type, comps, choices)
        return f"{t} {m.name} {{ get; }}", mapped, t
    if kind == "list":
        t, _ = map_type(elem, comps, choices)
        return f"IEnumerable<{t}> {m.name} {{ get; }}", True, f"IEnumerable<{t}>"
    return f"IEnumerable<{elem}> {m.name} {{ get; }}", True, f"IEnumerable<{elem}>"


def write_interface(r, base_list, comps, choices, out_root):
    rel = r.path.relative_to(COMMON)
    name = iface_name(r.name)
    lines = ["// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.", "",
             "// <auto-generated>Written by tools/interfaces/generate_interfaces.py from the record; change the record and run the tool again.</auto-generated>",
             "#nullable enable", "",
             f"namespace {r.ns};", ""]
    lines += r.doc + [a for a in keep(r.attrs) if a.startswith("[IsoId(")]   # DisplayName is not valid on an interface
    lines.append(f"public interface {name} : {', '.join(base_list)}")
    lines.append("{")
    body = []
    for m in r.members:
        decl, _, _ = member_decl(m, comps, choices)
        body += indent(m.doc + keep(m.attrs) + [decl], 4) + [""]
    lines += body[:-1] if body else []
    lines.append("}")
    dest = out_root / rel.parent / (name + ".cs")
    dest.parent.mkdir(parents=True, exist_ok=True)
    dest.write_text("\n".join(lines) + "\n", encoding="utf-8")


def write_partial(r, ifaces, comps, choices, abstract=False):
    explicit = []
    own = iface_name(r.name) if r.kind != "choice" else iface_name(r.name)
    for m in r.members:
        decl, mapped, t = member_decl(m, comps, choices)
        if mapped:
            explicit.append(f"    {t} {own}.{m.name} => {m.name};")
    mods = "public abstract partial record" if abstract else "public partial record"
    lines = ["// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.", "",
             "// <auto-generated>Written by tools/interfaces/generate_interfaces.py from the record; change the record and run the tool again.</auto-generated>",
             "#nullable enable", "",
             "using BeneficialStrategies.Iso20022.Choices;", "using BeneficialStrategies.Iso20022.Components;", "using BeneficialStrategies.Iso20022.ExternalSchema;", "using BeneficialStrategies.Iso20022.UserDefined;", "",
             f"namespace {r.ns};", "", f"{mods} {r.name} : {', '.join(ifaces)}", "{"] + explicit + ["}"]
    dest = r.path.with_name(r.path.stem + ".Interfaces.cs")
    dest.write_text("\n".join(lines) + "\n", encoding="utf-8")


def make_partial_and_inheritdoc(r, do_partial, do_inheritdoc, comps, choices):
    text = r.path.read_text(encoding="utf-8-sig")
    if do_partial:
        text = re.sub(r"(public\s+(?:abstract\s+)?)record(\s+" + re.escape(r.name) + r"\b)", r"\1partial record\2", text, count=1)
    if do_inheritdoc:
        iname = iface_name(r.name)
        lines = text.split("\n")
        out, i = [], 0
        pending_doc = False
        while i < len(lines):
            s = lines[i].strip()
            if s.startswith("///"):
                j = i
                while j < len(lines) and lines[j].strip().startswith("///"):
                    j += 1
                # the doc belongs to whatever follows the attributes
                k = j
                while k < len(lines) and (lines[k].strip().startswith("[") or lines[k].strip() == ""):
                    # skip attributes, including multi-line ones
                    if lines[k].strip().startswith("["):
                        _, k2 = read_attr(lines, k)
                        k = k2 + 1
                    else:
                        break
                target = lines[k] if k < len(lines) else ""
                pad = re.match(r"\s*", lines[i]).group(0)
                p = PROP.match(target)
                if p:
                    out.append(f'{pad}/// <inheritdoc cref="{iname}.{p.group(3)}"/>')
                elif DECL.match(target) and DECL.match(target).group(3) == r.name:
                    out.append(f'{pad}/// <inheritdoc cref="{iname}"/>')
                else:
                    out += lines[i:j]
                i = j
                continue
            out.append(lines[i])
            i += 1
        text = "\n".join(out)
    r.path.write_text(text, encoding="utf-8")


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--areas", nargs="+", required=True)
    ap.add_argument("--partial", action="store_true", help="make the records partial")
    ap.add_argument("--inheritdoc", action="store_true", help="replace the record documentation by <inheritdoc cref/>")
    args = ap.parse_args()

    comps, choices, variants, messages = load_all(args.areas)
    seen_c, seen_ch = closure(messages, comps, choices, variants)
    n = {"message": 0, "component": 0, "choice": 0, "variant": 0, "members": 0, "explicit": 0}

    def count(r):
        n["members"] += len(r.members)
        n["explicit"] += sum(1 for m in r.members if member_decl(m, comps, choices)[1])

    for r in messages.values():
        write_interface(r, ["IOuterRecord"], comps, choices, OUT)
        write_partial(r, [iface_name(r.name)], comps, choices)
        n["message"] += 1; count(r)
        make_partial_and_inheritdoc(r, args.partial, args.inheritdoc, comps, choices)
    for name in sorted(seen_c):
        r = comps[name]
        write_interface(r, ["IIsoComponent"], comps, choices, OUT)
        write_partial(r, [iface_name(name)], comps, choices)
        n["component"] += 1; count(r)
        make_partial_and_inheritdoc(r, args.partial, args.inheritdoc, comps, choices)
    for name in sorted(seen_ch):
        r = choices[name]
        write_interface(r, ["IIsoChoice"], comps, choices, OUT)
        write_partial(r, [iface_name(name)], comps, choices, abstract=True)
        n["choice"] += 1
        make_partial_and_inheritdoc(r, args.partial, args.inheritdoc, comps, choices)
        for v in variants.get(name, []):
            write_interface(v, [iface_name(name), "IIsoChoiceVariant"], comps, choices, OUT)
            write_partial(v, [iface_name(v.name)], comps, choices)
            n["variant"] += 1; count(v)
            make_partial_and_inheritdoc(v, args.partial, args.inheritdoc, comps, choices)
    print(n)


if __name__ == "__main__":
    sys.exit(main())
