#!/usr/bin/env python3
"""A property of a component or message that has another component or choice as its type than the repository gives its element:
set the type (keeping ?, ValueList<> and the underscore of a choice)."""
import json, os, re, collections
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'Common')
WORK = os.environ.get('ISO20022_WORK', os.path.join(ROOT, '..', '_work', 'Iso20022Library'))
D = json.load(open(os.path.join(WORK, 'repo-structure.json')))
E, M = D['entries'], D['messages']
by_name = collections.defaultdict(list)
for k, v in E.items(): by_name[v['name']].append(k)
PROP = re.compile(r'^(\s*public\s+(?:required\s+)?)([\w.]+(?:<[\w.<>?, ]+>)?\??)(\s+\w+\s*\{\s*get;\s*init;\s*\}.*)$')
def core(t):
    q = t.endswith('?'); t = t.rstrip('?')
    m = re.match(r'(Simple)?(ValueList)<(.+)>$', t)
    if m: return t, 'list', m.group(1) or '', m.group(3).rstrip('?'), q
    return t, 'one', '', t, q
def fix_file(path, elems):
    raw = open(path, 'rb').read(); bom = raw.startswith(b'\xef\xbb\xbf'); text = raw.decode('utf-8-sig')
    nl = '\r\n' if '\r\n' in text else '\n'; lines = text.split(nl); out = []; pend = None; n = 0
    want = {e['tag']: e for e in elems}
    for l in lines:
        t = re.search(r'\[IsoXmlTag\("([^"]+)"\)\]', l)
        if t: pend = t.group(1)
        m = PROP.match(l)
        if m and pend in want:
            full, kind, simple, inner, q = core(m.group(2))
            te = E.get(want[pend]['type'], {})
            if te.get('kind') in ('MessageComponent', 'ChoiceComponent'):
                name = te['name'] + ('_' if te['kind'] == 'ChoiceComponent' else '')
                if inner != name:
                    new_inner = name
                    new = ('%sValueList<%s>' % (simple, new_inner)) if kind == 'list' else new_inner
                    if kind == 'one' and q: new += '?'
                    l = m.group(1) + new + m.group(3); n += 1
            pend = None
        out.append(l)
    if n: open(path, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + nl.join(out).encode('utf-8'))
    return n
total = 0
for f in sorted(os.listdir(LIB + '/Components')):
    if not f.endswith('.cs'): continue
    ids = [k for k in by_name.get(f[:-3], []) if E[k]['kind'] == 'MessageComponent']
    if ids: total += fix_file(LIB + '/Components/' + f, E[ids[0]]['elements'])
for area in sorted(os.listdir(LIB + '/MessageDefinitions')):
    for f in sorted(os.listdir(LIB + '/MessageDefinitions/' + area)):
        p = LIB + '/MessageDefinitions/%s/%s' % (area, f)
        ident = re.search(r'IsoIdentifier = "([^"]+)"', open(p, encoding='utf-8-sig').read()).group(1)
        if ident in M: total += fix_file(p, M[ident]['blocks'])
print(total, 'property types corrected')
