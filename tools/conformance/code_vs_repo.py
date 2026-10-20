#!/usr/bin/env python3
"""Compare the record model (Components, Choices, MessageDefinitions) with the repository structure (repo-structure.json,
verified against ISO's XSDs): element order, XML tags, multiplicity, choice variants. Writes code-vs-repo.json."""
import json, os, re, sys, collections
import os
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'Common')
# derived files go to the work folder next to the repository (CLAUDE.md), never into the repository
WORK = os.environ.get('ISO20022_WORK', os.path.join(ROOT, '..', '_work', 'Iso20022Library'))
STRUCTURE = os.path.join(WORK, 'repo-structure.json')
D = json.load(open(STRUCTURE))
E, M = D['entries'], D['messages']
by_name = collections.defaultdict(list)
for k, v in E.items():
    by_name[v['name']].append(k)

PROP = re.compile(r'^\s*public\s+(required\s+)?([\w.]+(?:<[\w.<>?, ]+>)?\??)\s+(\w+)\s*\{\s*get;\s*init;\s*\}')
DECL = re.compile(r'^\s*public\s+(abstract\s+)?(partial\s+)?record\s+(\w+)')

def parse(path):
    lines = open(path, encoding='utf-8-sig').read().split('\n')
    props = []; cls = None; cls_tag = None; pending_tag = None
    for i, l in enumerate(lines):
        m = re.search(r'\[IsoXmlTag\("([^"]+)"\)\]', l)
        if m:
            pending_tag = m.group(1); continue
        d = DECL.match(l)
        if d and cls is None:
            cls = d.group(3); cls_tag = pending_tag; pending_tag = None; continue
        p = PROP.match(l)
        if p and cls is not None:
            props.append(dict(tag=pending_tag, required=bool(p.group(1)), type=p.group(2), name=p.group(3)))
            pending_tag = None
    return cls, cls_tag, props

def is_coll(t):
    return bool(re.match(r'(Simple)?ValueList<', t))

res = collections.defaultdict(list)
n = collections.Counter()
def check_seq(kind, name, props, elems, where):
    rt = [e['tag'] for e in elems]
    ct = [p['tag'] for p in props if p['tag']]
    if ct == rt:
        n[kind + ' order ok'] += 1
    elif sorted(ct) == sorted(rt):
        res[kind + '-order'].append((where, ct, rt))
    else:
        res[kind + '-names'].append((where, ct, rt))
    byt = {p['tag']: p for p in props if p['tag']}
    for e in elems:
        p = byt.get(e['tag'])
        if not p: continue
        many = e['max'] != '1'          # absent maxOccurs = unbounded
        optional = e['min'] == '0'
        coll = is_coll(p['type'])
        if many != coll:
            res[kind + '-multiplicity-many'].append((where, e['tag'], p['type'], e['min'], e['max']))
        elif not many and optional == p['required']:
            res[kind + '-multiplicity-optional'].append((where, e['tag'], p['type'], e['min'], e['max']))

for f in sorted(os.listdir(LIB + '/Components')):
    if not f.endswith('.cs') or f.endswith('.Interfaces.cs'): continue
    cls, ct, props = parse(LIB + '/Components/' + f)
    ids = [k for k in by_name.get(cls, []) if E[k]['kind'] == 'MessageComponent']
    if not ids:
        res['component-not-in-repo'].append(cls); continue
    check_seq('component', cls, props, E[ids[0]]['elements'], cls)
for area in sorted(os.listdir(LIB + '/MessageDefinitions')):
    for f in sorted(os.listdir(LIB + '/MessageDefinitions/' + area)):
        if not f.endswith('.cs') or f.endswith('.Interfaces.cs'): continue
        p = LIB + '/MessageDefinitions/%s/%s' % (area, f)
        cls, ct, props = parse(p)
        txt = open(p, encoding='utf-8-sig').read()
        ident = re.search(r'IsoIdentifier = "([^"]+)"', txt).group(1)
        m = M.get(ident)
        if not m: res['message-not-in-repo'].append(ident); continue
        check_seq('message', cls, props, m['blocks'], ident)
for f in sorted(os.listdir(LIB + '/Choices')):
    if not f.endswith('_.cs'): continue
    cname = f[:-4]
    ids = [k for k in by_name.get(cname, []) if E[k]['kind'] == 'ChoiceComponent']
    if not ids:
        res['choice-not-in-repo'].append(cname); continue
    elems = E[ids[0]]['elements']
    vdir = LIB + '/Choices/' + cname
    code = {}
    if os.path.isdir(vdir):
        for vf in os.listdir(vdir):
            if vf.endswith('.cs') and not vf.endswith('.Interfaces.cs'):
                vcls, vtag, vprops = parse(vdir + '/' + vf)
                tag = vtag or (vprops[0]['tag'] if len(vprops) == 1 else None)
                code[vcls] = (tag, vprops, vtag)
    for e in elems:
        v = code.get(e['name'])
        if v is None:
            res['choice-variant-missing'].append((cname, e['name'])); continue
        tag, vprops, vtag = v
        if tag != e['tag']:
            kind = 'empty' if not vprops else ('inline-no-class-tag' if len(vprops) == 1 and not vtag else 'tag-differs')
            res['choice-tag-' + kind].append((cname, e['name'], tag, e['tag'], E.get(e['type'], {}).get('kind')))
    for x in set(code) - {e['name'] for e in elems}:
        res['choice-variant-extra'].append((cname, x))
print(dict(n))
for k, v in sorted(res.items(), key=lambda kv: -len(kv[1])):
    print('%-32s %d' % (k, len(v)))
json.dump(res, open(os.path.join(WORK, 'code-vs-repo.json'), 'w'))
