#!/usr/bin/env python3
"""Compare the choice variants with the repository: what a variant holds depends on the type the repository gives its element.
  a leaf type (simple type, code set, amount)  -> no class tag, one member 'Value' with the element's tag
  a choice                                     -> no class tag, one member 'Value' of the choice (X_), with the element's tag
  a component                                  -> class tag = the element's tag, and the component's members, inlined, in order"""
import json, os, re, collections
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'Common')
WORK = os.environ.get('ISO20022_WORK', os.path.join(ROOT, '..', '_work', 'Iso20022Library'))
D = json.load(open(os.path.join(WORK, 'repo-structure.json')))
E = D['entries']
by_name = collections.defaultdict(list)
for k, v in E.items(): by_name[v['name']].append(k)
PROP = re.compile(r'^\s*public\s+(required\s+)?([\w.]+(?:<[\w.<>?, ]+>)?\??)\s+(\w+)\s*\{\s*get;\s*init;\s*\}')
DECL = re.compile(r'^\s*public\s+(abstract\s+)?(partial\s+)?record\s+(\w+)')

def parse(path):
    lines = open(path, encoding='utf-8-sig').read().split('\n')
    props = []; cls = None; cls_tag = None; pend = None
    for l in lines:
        m = re.search(r'\[IsoXmlTag\("([^"]+)"\)\]', l)
        if m: pend = m.group(1); continue
        d = DECL.match(l)
        if d and cls is None: cls, cls_tag, pend = d.group(3), pend, None; continue
        p = PROP.match(l)
        if p and cls is not None:
            props.append(dict(tag=pend, required=bool(p.group(1)), type=p.group(2), name=p.group(3))); pend = None
    return cls, cls_tag, props

res = collections.defaultdict(list); n = collections.Counter()
for f in sorted(os.listdir(LIB + '/Choices')):
    if not f.endswith('_.cs'): continue
    cname = f[:-4]
    ids = [k for k in by_name.get(cname, []) if E[k]['kind'] == 'ChoiceComponent']
    if not ids: continue
    vdir = LIB + '/Choices/' + cname
    for e in E[ids[0]]['elements']:
        vp = vdir + '/' + e['name'] + '.cs'
        if not os.path.exists(vp): res['missing-file'].append((cname, e['name'])); continue
        cls, ctag, props = parse(vp)
        t = E.get(e['type'], {})
        kind = t.get('kind', 'leaf')
        if kind not in ('MessageComponent', 'ChoiceComponent'): kind = 'leaf'
        where = '%s.%s' % (cname, e['name'])
        if kind == 'leaf':
            ok = ctag is None and len(props) == 1 and props[0]['tag'] == e['tag']
            if not ok and t.get('kind') == 'Amount':
                ok = ctag == e['tag'] and [p['tag'] for p in props] == ['Currency', 'Amount'] or t['name'].startswith('Implied') or t['name'].startswith('RestrictedFINImplied')
            if not ok: res['leaf-variant'].append((where, ctag, [(p['tag'], p['type']) for p in props], e['tag']))
            else: n['leaf ok'] += 1
        elif kind == 'ChoiceComponent':
            want = t['name'] + '_'
            ok = ctag is None and len(props) == 1 and props[0]['tag'] == e['tag'] and props[0]['type'].rstrip('?') == want
            if not ok: res['choice-variant'].append((where, ctag, [(p['tag'], p['type']) for p in props], e['tag'], want))
            else: n['choice ok'] += 1
        else:
            elems = t['elements']
            wt = [x['tag'] for x in elems]
            ct = [p['tag'] for p in props]
            if ctag is None and len(props) == 1 and props[0]['tag'] == e['tag'] and props[0]['type'].rstrip('?') == t['name']:
                n['component ok (Value form)'] += 1
            elif ctag != e['tag']: res['component-variant-class-tag'].append((where, ctag, e['tag']))
            elif ct != wt: res['component-variant-members'].append((where, ct, wt))
            else:
                bad = False
                for x, p in zip(elems, props):
                    many = x['max'] != '1'; coll = bool(re.match(r'(Simple)?ValueList<', p['type']))
                    if many != coll or (not many and (x['min'] == '0') == p['required']): bad = True
                if bad: res['component-variant-multiplicity'].append((where,))
                else: n['component ok'] += 1
print(dict(n))
for k, v in sorted(res.items(), key=lambda kv: -len(kv[1])): print('%-34s %d' % (k, len(v)))
json.dump(res, open(os.path.join(WORK, 'variants-vs-repo.json'), 'w'))
