"""Moves the choice-variant constructions out of validator tests that convert_tests.py has already rewritten, into the Samples package.

Usage:  make_samples.py <test file>...

For each `var x = IsoDataFactory.Make<...Choices.<Type>.I<Variant>>(...)` statement in the files it writes
src/Samples/<Type>/Valid/<Variant>.cs and points the test at the sample. Of the shapes found for one variant, the one with the fewest
members set becomes Minimal and the one with the most becomes Maximal (only when they differ). A nested construction that equals
another sample is replaced by a reference to it, which is how larger samples are built from smaller ones. A variant named like a
type of System (bcl-names.txt) gets an underscore: Valid.DateTime_.
The first slice of #88 was made this way; the values are those the tests had, so Minimal and Maximal are not "every required
member" and "every member" in the sense of the model.
"""
import re, sys, collections
from pathlib import Path

HERE = Path(__file__).resolve().parent
SRC = HERE.parents[1] / 'src'
files = [Path(a).resolve() for a in sys.argv[1:]]

STMT = re.compile(r'var (\w+) = (IsoDataFactory\.Make<((?:[\w]+\.)*Choices\.(\w+)\.I(\w+))>)\(')

def match_paren(s, i):
    depth, in_str, j = 0, False, i
    while j < len(s):
        c = s[j]
        if in_str:
            if c == '\\': j += 1
            elif c == '"': in_str = False
        elif c == '"': in_str = True
        elif c == '(': depth += 1
        elif c == ')':
            depth -= 1
            if depth == 0: return j
        j += 1
    raise ValueError

BCL = set(open(HERE / 'bcl-names.txt').read().split())
# a sample class named like a type of System (DateTime, Type, ...) gets an underscore, as the model's own clashing names do
def cls(v): return v + '_' if v in BCL else v

def norm(e): return re.sub(r'\b([bx])\d+\b', r'\1', re.sub(r'\s+', ' ', e).strip())

found = collections.defaultdict(list)   # (type, variant) -> [(file, start, end, var, expr)]
texts = {}   # file -> text
for f in files:
    s = f.read_text()
    texts[f] = s
    for m in STMT.finditer(s):
        end = match_paren(s, m.end() - 1)
        expr = s[m.start(2):end + 1]
        found[(m.group(4), m.group(5))].append((f, m.start(2), end + 1, m.group(1), expr, m.group(3)))

samples = {}   # (type, variant) -> {'Minimal': expr, 'Maximal': expr, 'iface': full interface}
for key, items in found.items():
    uniq = {}
    for it in items: uniq.setdefault(norm(it[4]), it)
    ordered = sorted(uniq.values(), key=lambda it: it[4].count('.Set('))
    d = {'iface': ordered[0][5], 'Minimal': ordered[0][4]}
    if len(ordered) > 1: d['Maximal'] = ordered[-1][4]
    if len(ordered) > 2: print('WARN more than two shapes for', key, len(ordered))
    samples[key] = d

ref = {}
for (t, v), d in samples.items():
    for kind in ('Minimal', 'Maximal'):
        if kind in d: ref[norm(d[kind])] = f'BeneficialStrategies.Iso20022.Samples.{t}.Valid.{cls(v)}.{kind}'

def reuse(expr, own):
    """Replace nested Make calls that are themselves samples by a reference to them."""
    out, pos = '', 0
    for m in STMT.finditer('var _ = ' + expr):
        pass
    i = 0
    result = expr
    # nested occurrences, outermost first not needed: search for the start of each Make<...Choices.X.IY>( after position 0
    for m in re.finditer(r'IsoDataFactory\.Make<((?:\w+\.)*Choices\.(\w+)\.I(\w+))>\(', expr):
        if m.start() == 0: continue
        end = match_paren(expr, m.end() - 1)
        inner = expr[m.start():end + 1]
        r = ref.get(norm(inner))
        if r and r != own:
            result = result.replace(inner, r)
    return result

USINGS = '''using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;
'''
out_root = SRC / 'Samples'
for (t, v), d in sorted(samples.items()):
    folder = out_root / t / 'Valid'
    folder.mkdir(parents=True, exist_ok=True)
    iface = d['iface']
    body = []
    for kind, doc in (('Minimal', 'few members set (what the validator tests needed)'), ('Maximal', 'more members set than Minimal')):
        if kind not in d: continue
        expr = reuse(d[kind], f'BeneficialStrategies.Iso20022.Samples.{t}.Valid.{cls(v)}.{kind}')
        expr = re.sub(r'new (DateTime|DateOnly|TimeOnly)\(', r'new System.\1(', expr)
        body.append(f'    /// <summary>The {v} variant of <c>{t}</c> with {doc}. A new object on every access.</summary>\n    public static {iface} {kind} =>\n        {expr};')
    (folder / f'{cls(v)}.cs').write_text(
        f'// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.\n\n{USINGS}\n'
        f'namespace BeneficialStrategies.Iso20022.Samples.{t}.Valid;\n\n'
        f'/// <summary>Valid samples of the <c>{v}</c> variant of <c>{t}</c>.</summary>\npublic static class {cls(v)}\n{{\n' + '\n\n'.join(body) + '\n}\n')

# rewrite the tests: each statement becomes a reference to its sample
for f in files:
    s = texts[f]
    edits = []
    for (t, v), items in found.items():
        d = samples[(t, v)]
        for (fn, a, b, var, expr, _) in items:
            if fn != f: continue
            kind = 'Maximal' if 'Maximal' in d and norm(expr) == norm(d['Maximal']) else 'Minimal'
            edits.append((a, b, f'BeneficialStrategies.Iso20022.Samples.{t}.Valid.{cls(v)}.{kind}'))
    for a, b, r in sorted(edits, reverse=True):
        s = s[:a] + r + s[b:]
    f.write_text(s)
print(len(samples), 'samples in', len({t for t, _ in samples}), 'types;', sum(len(v) for v in found.values()), 'constructions replaced')
