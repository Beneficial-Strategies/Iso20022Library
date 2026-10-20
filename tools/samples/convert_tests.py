"""Converts `new Record { A = x, B = new Other { ... } }` in test files to
IsoDataFactory.Make<IRecord>(b => b.Set(x => x.A).To(...)), the form that needs the interfaces and the Factory, not the records.

Usage (from anywhere):  convert_tests.py <test file>...
Rewrites the files in place and prints the number of constructions converted per file. A file with something it cannot read
(a comment inside an initializer, say) is skipped. It does not handle `with` expressions or target-typed `new()`: those need the
type the compiler infers, which is what the Roslyn rewriter of #88 is for.
"""
import re, sys
from pathlib import Path

SRC = Path(__file__).resolve().parents[2] / 'src'
interfaces = set()
for f in (SRC / 'Interfaces').rglob('*.cs'):
    if '/obj/' in str(f) or '/bin/' in str(f):
        continue
    for m in re.finditer(r'public interface (I\w+)', f.read_text()):
        interfaces.add(m.group(1))

NEW = re.compile(r'new\s+((?:[A-Za-z_]\w*\.)*)([A-Za-z_]\w*)\s*(?=\{)')

def match_brace(s, i):
    depth = 0
    in_str = False
    j = i
    while j < len(s):
        c = s[j]
        if in_str:
            if c == '\\' : j += 1
            elif c == '"': in_str = False
        else:
            if c == '"': in_str = True
            elif c in '{[(': depth += 1
            elif c in '}])':
                depth -= 1
                if depth == 0: return j
        j += 1
    raise ValueError('unbalanced')

def split_top(s):
    parts, depth, cur, in_str = [], 0, '', False
    k = 0
    while k < len(s):
        c = s[k]
        if in_str:
            cur += c
            if c == '\\': k += 1; cur += s[k]
            elif c == '"': in_str = False
        else:
            if c == '"': in_str = True; cur += c
            elif c in '{[(': depth += 1; cur += c
            elif c in '}])': depth -= 1; cur += c
            elif c == ',' and depth == 0: parts.append(cur); cur = ''
            else: cur += c
        k += 1
    if cur.strip(): parts.append(cur)
    return parts

count = 0
BASE = ''
def convert(s, depth=0):
    global count
    out, pos = '', 0
    while True:
        m = NEW.search(s, pos)
        if not m: return out + s[pos:]
        qual, name = m.group(1), m.group(2)
        iface = 'I' + name
        if iface not in interfaces:
            out += s[pos:m.end()]; pos = m.end(); continue
        open_i = s.index('{', m.end() - 1)
        close_i = match_brace(s, open_i)
        body = s[open_i + 1:close_i]
        sets = []
        for part in split_top(body):
            part = part.strip()
            if not part: continue
            mm = re.match(r'(\w+)\s*=\s*(.*)$', part, re.S)
            if not mm: raise ValueError('initializer ' + part[:40])
            sets.append((mm.group(1), convert(mm.group(2).strip(), depth + 1)))
        count += 1
        if sets:
            b, x = ('b', 'x') if depth == 0 else (f'b{depth + 1}', f'x{depth + 1}')
            line_start = s.rfind('\n', 0, m.start()) + 1
            global BASE
            if depth == 0: BASE = re.match(r'\s*', s[line_start:m.start()]).group(0)
            indent = BASE + '    ' * (depth + 2)
            chain = ''.join(f'\n{indent}.Set({x} => {x}.{n}).To({v})' for n, v in sets)
            call = f'IsoDataFactory.Make<{qual}{iface}>({b} => {b}{chain})'
        else:
            call = f'IsoDataFactory.Make<{qual}{iface}>()'
        out += s[pos:m.start()] + call
        pos = close_i + 1

def declared_as_var(text):
    # `Some.Type_ name =\n  IsoDataFactory.Make` -> `var name = IsoDataFactory.Make`
    return re.sub(r'(?m)^(\s*)(?:[A-Za-z_]\w*\.)*[A-Za-z_]\w*\s+(\w+)\s*=\s*\s*IsoDataFactory\.Make', r'\1var \2 = IsoDataFactory.Make', text)

for path in sys.argv[1:]:
    p = Path(path)
    text = p.read_text()
    count = 0
    try:
        new = declared_as_var(convert(text))
    except ValueError as e:
        print(f'SKIP {p.name}: {e}'); continue
    if count:
        p.write_text(new)
    print(f'{p.name}: {count}')
