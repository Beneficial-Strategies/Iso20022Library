#!/usr/bin/env python3
"""Moves the validators of the FluentValidation project from the records to their interfaces (#28).

AbstractValidator<Foo>, IValidator<Foo> and InlineValidator<Foo> become ...<IFoo> for every record that has an interface
(a choice Foo_ becomes IFoo; a variant Choices.Foo.Bar becomes Choices.Foo.IBar). Code sets, simple types and amounts have no
interface and are left alone. Run again after new interfaces are generated: it only touches what is still on a record.
"""
import re, sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2] / "src"
IFACES = ROOT / "BeneficialStrategies.Iso20022.Interfaces"
VAL = ROOT / "BeneficialStrategies.Iso20022.FluentValidation"

top, variants = set(), set()   # I-names directly in Components, Choices or MessageDefinitions/<area>; (choice, I-name) of variants
for p in IFACES.rglob("I*.cs"):
    rel = p.relative_to(IFACES).parts
    if rel[0] == "Choices" and len(rel) == 3:
        variants.add((rel[1], p.stem))
    elif (rel[0] in ("Components", "Choices") and len(rel) == 2) or (rel[0] == "MessageDefinitions" and len(rel) == 3):
        top.add(p.stem)

GENERIC = re.compile(r"\b(AbstractValidator|IValidator|InlineValidator)<([A-Za-z0-9_.]+)>")


def convert(arg):
    parts = arg.split(".")
    last = parts[-1]
    if len(parts) >= 2 and parts[-2] != "Choices" and ("I" + last) and (parts[-2], "I" + last) in variants:
        parts[-1] = "I" + last
        return ".".join(parts)
    if len(parts) == 1:
        base = last[:-1] if last.endswith("_") else last
        if "I" + base in top:
            return "I" + base
    return arg


ALIAS = re.compile(r"^using (\w+) = BeneficialStrategies\.Iso20022\.Choices\.(\w+);", re.MULTILINE)
VARIANT_TOKEN = re.compile(r"\b((?:Choices\.)?)(\w+)\.(\w+)\b")


def convert_variant_uses(text):
    """Alias.Variant and Choices.Choice.Variant in code (not in comments) become the variant interface, so a type test or
    a cast works for a class of someone else's that implements it, as well as for our record."""
    aliases = {a: c for a, c in ALIAS.findall(text)}
    out = []
    for line in text.split("\n"):
        if line.lstrip().startswith("//") or line.startswith("using "):
            out.append(line)
            continue

        def repl(m):
            prefix, first, second = m.groups()
            choice = aliases.get(first) if not prefix else first
            if prefix == "" and first in aliases or prefix == "Choices.":
                if (choice, "I" + second) in variants:
                    return f"{prefix}{first}.I{second}"
            return m.group(0)

        out.append(VARIANT_TOKEN.sub(repl, line))
    return "\n".join(out)


def main():
    changed = 0
    for p in VAL.rglob("*.cs"):
        if "/obj/" in str(p) or "/bin/" in str(p):
            continue
        s = p.read_text(encoding="utf-8")
        n = GENERIC.sub(lambda m: f"{m.group(1)}<{convert(m.group(2))}>", s)
        n = convert_variant_uses(n)
        if n != s:
            p.write_text(n, encoding="utf-8")
            changed += 1
    print("files changed:", changed)


if __name__ == "__main__":
    main()
