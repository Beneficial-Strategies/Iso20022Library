"""Moves every fluent construction out of validator tests that the Rewriter (or convert_tests.py) has already rewritten into
IsoDataFactory.Make<...>(...), into the Samples package, at every level: the object a test asks for and everything inside it.

Usage:  make_samples.py <test file>...

Layout of the result (the pattern for the rest of the conversion):

    src/Samples/<Type>/Valid/<Scenario>.cs      namespace BeneficialStrategies.Iso20022.Samples.<Type>.Valid
                                                public static class <Scenario> { public static I... Minimal; public static I... Maximal; }

  * a variant of a choice: <Type> is the choice (AccountIdentification4Choice), <Scenario> the variant (Other);
  * any other message or component: <Type> is its name (CashAccount40), <Scenario> is `Standard`.

Of the shapes found for one scenario, the one with the fewest members set is Minimal and the one with the most is Maximal (written only
when there is a second one); a third shape is an error to resolve by hand. A construction inside another is replaced by a reference to its
own sample, so larger samples are built from smaller ones, and equal constructions from different tests share one sample. A scenario named
like a type of System (bcl-names.txt) gets an underscore: Valid.DateTime_. Every test statement becomes a reference to its sample.
The existing src/Samples/<Type> folders of the files given are rebuilt from scratch.
"""
import re, shutil, sys
from collections import defaultdict
from pathlib import Path

HERE = Path(__file__).resolve().parent
SRC = HERE.parents[1] / 'src'
S = 'BeneficialStrategies.Iso20022.Samples'
BCL = set((HERE / 'bcl-names.txt').read_text().split())

def cls_name(v): return v + '_' if v in BCL else v

# namespace of every interface of the model
NAMESPACE = {}
for f in (SRC / 'Interfaces').rglob('*.cs'):
    if '/obj/' in str(f) or '/bin/' in str(f): continue
    text = f.read_text()
    ns = re.search(r'^namespace\s+([\w.]+)', text, re.M)
    if not ns: continue
    for m in re.finditer(r'public interface (I\w+)', text):
        NAMESPACE.setdefault(m.group(1), ns.group(1))

MAKE = re.compile(r'IsoDataFactory\.Make<([\w.]+)>\(')

def match_paren(s, i):
    depth, in_str, j = 0, False, i
    while j < len(s):
        c = s[j]
        if in_str:
            if c == '\\': j += 1
            elif c == '"': in_str = False
        elif c == '"': in_str = True
        elif s.startswith('//', j):
            j = s.find('\n', j)
            if j < 0: break
        elif c == "'" and j + 2 < len(s) and (s[j + 2] == "'" or s[j + 1] == '\\'):
            j = s.find("'", j + 2)
        elif c == '(': depth += 1
        elif c == ')':
            depth -= 1
            if depth == 0: return j
        j += 1
    raise ValueError('unbalanced')

def norm(e):
    e = re.sub(r'\s+', ' ', e).strip()
    return re.sub(r'\b([bx])\d+\b', r'\1', e)

def where(type_name):
    """(folder, scenario, interface name with namespace) for the type argument of a Make call."""
    m = re.match(r'^(?:[\w.]+\.)?Choices\.(\w+)\.(I\w+)$', type_name)
    if m:
        return m.group(1), m.group(2)[1:], f'BeneficialStrategies.Iso20022.Choices.{m.group(1)}.{m.group(2)}'
    name = type_name.split('.')[-1]
    if name not in NAMESPACE: raise ValueError(f'no interface {name}')
    return name[1:], 'Standard', f'{NAMESPACE[name]}.{name}'

shapes = {}            # id -> {'folder', 'scenario', 'iface', 'text'}
by_text = {}           # (folder, scenario, normalized text) -> id

def register(type_name, text):
    folder, scenario, iface = where(type_name)
    key = (folder, scenario, norm(text))
    if key not in by_text:
        by_text[key] = len(shapes)
        shapes[by_text[key]] = {'folder': folder, 'scenario': scenario, 'iface': iface, 'text': text}
    return by_text[key]

def extract(text):
    """Replace every Make call in text by a placeholder, innermost first."""
    out, pos = '', 0
    while True:
        m = MAKE.search(text, pos)
        if not m: return out + text[pos:]
        end = match_paren(text, m.end() - 1)
        inner = text[m.start():m.end()] + extract(text[m.end():end]) + ')'
        out += text[pos:m.start()] + f'@@{register(m.group(1), inner)}@@'
        pos = end + 1

files = [Path(a).resolve() for a in sys.argv[1:]]
rewritten = {}
for f in files:
    s = f.read_text()
    # a statement `var x = Make...;` or `X x = Make...;` keeps its declaration; only the construction becomes a placeholder
    rewritten[f] = extract(s)

# Minimal / Maximal per scenario
families = defaultdict(list)
for sid, d in shapes.items():
    families[(d['folder'], d['scenario'])].append(sid)
name_of = {}
for (folder, scenario), ids in families.items():
    ids.sort(key=lambda i: (shapes[i]['text'].count('.Set('), norm(shapes[i]['text'])))
    if len(ids) > 2:
        raise SystemExit(f'{folder}.{scenario}: {len(ids)} shapes, at most two (Minimal, Maximal) are supported:\n' + '\n---\n'.join(shapes[i]['text'] for i in ids))
    for rank, i in enumerate(ids):
        name_of[i] = ('Minimal' if rank == 0 else 'Maximal')

def ref(i):
    d = shapes[i]
    return f'{S}.{d["folder"]}.Valid.{cls_name(d["scenario"])}.{name_of[i]}'

def resolve(text):
    prev = None
    while prev != text:
        prev = text
        text = re.sub(r'@@(\d+)@@', lambda m: ref(int(m.group(1))), text)
    return text

USINGS = '''using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;
'''

# Samples bodies still hold placeholders for the constructions inside them
root = SRC / 'Samples'
for folder in {d['folder'] for d in shapes.values()}:
    shutil.rmtree(root / folder, ignore_errors=True)
for (folder, scenario), ids in sorted(families.items()):
    props, iface = [], shapes[ids[0]]['iface']
    for i in ids:
        # the construction itself, with the Make( ... ) of the shape re-expanded at the top level
        text = shapes[i]['text']
        body = resolve(text)
        body = re.sub(r'new (DateTime|DateOnly|TimeOnly)\(', r'new System.\1(', body)
        kind = name_of[i]
        what = 'few members set (what the validator tests needed)' if kind == 'Minimal' else 'more members set than Minimal'
        props.append(f'    /// <summary>A valid <c>{scenario}</c> of <c>{folder}</c> with {what}. A new object on every access.</summary>\n'
                     f'    public static {iface} {kind} =>\n        {body};')
    d = root / folder / 'Valid'
    d.mkdir(parents=True, exist_ok=True)
    (d / f'{cls_name(scenario)}.cs').write_text(
        '// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.\n\n'
        f'{USINGS}\nnamespace {S}.{folder}.Valid;\n\n'
        f'/// <summary>Valid samples of <c>{scenario}</c> of <c>{folder}</c>.</summary>\npublic static class {cls_name(scenario)}\n{{\n' + '\n\n'.join(props) + '\n}\n')

for f, text in rewritten.items():
    f.write_text(resolve(text))
print(f'{len(shapes)} constructions -> {len(families)} sample classes in {len({k[0] for k in families})} types')
