#!/usr/bin/env python3
"""Put the properties of every component and message record in the order of the repository (= ISO's XSDs)."""
import json, os, re, sys, collections
import os
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'BeneficialStrategies.Iso20022.Common')
# derived files go to the work folder next to the repository (CLAUDE.md), never into the repository
WORK = os.environ.get('ISO20022_WORK', os.path.join(ROOT, '..', '_work', 'Iso20022Library'))
STRUCTURE = os.path.join(WORK, 'repo-structure.json')
D = json.load(open(STRUCTURE))
E, M = D['entries'], D['messages']
by_name = collections.defaultdict(list)
for k, v in E.items(): by_name[v['name']].append(k)
PROP = re.compile(r'^\s*public\s+(required\s+)?([\w.]+(?:<[\w.<>?, ]+>)?\??)\s+(\w+)\s*\{\s*get;\s*init;\s*\}')
DECL = re.compile(r'^\s*public\s+(abstract\s+)?(partial\s+)?record\s+(\w+)')
TAG = re.compile(r'\[IsoXmlTag\("([^"]+)"\)\]')

def reorder(path, order):
    raw = open(path, 'rb').read(); bom = raw.startswith(b'\xef\xbb\xbf'); text = raw.decode('utf-8-sig')
    nl = '\r\n' if '\r\n' in text else '\n'
    lines = text.split(nl)
    di = next(i for i, l in enumerate(lines) if DECL.match(l))
    oi = next(i for i in range(di, len(lines)) if lines[i].strip() == '{')
    # the record's closing brace: first line equal to the opening line's indentation + '}' after oi
    indent = re.match(r'\s*', lines[oi]).group(0)
    ci = next(i for i in range(oi + 1, len(lines)) if lines[i] == indent + '}')
    body = lines[oi + 1:ci]
    chunks = []; cur = []
    for l in body:
        if l.strip() == '':
            if cur: chunks.append(('chunk', cur)); cur = []
            chunks.append(('blank', [l]))
        else:
            cur.append(l)
    if cur: chunks.append(('chunk', cur))
    def tag_of(c):
        if not any(PROP.match(l) for l in c): return None
        t = [m.group(1) for l in c for m in [TAG.search(l)] if m]
        return t[0] if t else None
    prop_idx = [i for i, (k, c) in enumerate(chunks) if k == 'chunk' and tag_of(c)]
    tags = [tag_of(chunks[i][1]) for i in prop_idx]
    if any(t not in order for t in tags):
        return 'skip-unknown-tag'
    if tags == sorted(tags, key=order.index):
        return 'ok'
    sorted_chunks = [chunks[i] for i in sorted(prop_idx, key=lambda i: order.index(tag_of(chunks[i][1])))]
    for slot, ch in zip(prop_idx, sorted_chunks):
        chunks[slot] = ch
    new_body = [l for k, c in chunks for l in c]
    assert sorted(new_body) == sorted(body), path
    out = lines[:oi + 1] + new_body + lines[ci:]
    open(path, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + nl.join(out).encode('utf-8'))
    return 'fixed'

stats = collections.Counter()
for f in sorted(os.listdir(LIB + '/Components')):
    if not f.endswith('.cs'): continue
    p = LIB + '/Components/' + f
    cls = f[:-3]
    ids = [k for k in by_name.get(cls, []) if E[k]['kind'] == 'MessageComponent']
    if not ids: stats['component not in repo'] += 1; continue
    stats['component ' + reorder(p, [e['tag'] for e in E[ids[0]]['elements']])] += 1
for area in sorted(os.listdir(LIB + '/MessageDefinitions')):
    for f in sorted(os.listdir(LIB + '/MessageDefinitions/' + area)):
        if not f.endswith('.cs'): continue
        p = LIB + '/MessageDefinitions/%s/%s' % (area, f)
        ident = re.search(r'IsoIdentifier = "([^"]+)"', open(p, encoding='utf-8-sig').read()).group(1)
        m = M.get(ident)
        if not m: stats['message not in repo'] += 1; continue
        stats['message ' + reorder(p, [b['tag'] for b in m['blocks']])] += 1
print(dict(stats))
