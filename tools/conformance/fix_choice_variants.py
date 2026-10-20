#!/usr/bin/env python3
"""Give every choice variant the shape its repository element asks for (#39). A variant has one of two shapes, which write the same XML:
  a Value of the element's type, tagged with the element's tag (any type: a leaf, a choice X_, or a component), or
  the members of the component inlined under a class-level tag that is the element's tag.
Fixed here:
  a variant of a choice type with no member               -> a 'Value' of that choice
  a variant of a component with neither shape             -> the class-level tag (its members are checked by variants_vs_repo.py)
  a class-level tag that is not the element's            -> the element's tag"""
import json, os, re, collections
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'Common')
WORK = os.environ.get('ISO20022_WORK', os.path.join(ROOT, '..', '_work', 'Iso20022Library'))
E = json.load(open(os.path.join(WORK, 'repo-structure.json')))['entries']
by_name = collections.defaultdict(list)
for k, v in E.items(): by_name[v['name']].append(k)
HEADER = re.compile(r'^([ \t]*)public[ \t]+record[ \t]+(\w+)\s*:\s*(\w+)(\s*\{\s*\})?', re.M)
PROP = re.compile(r'public\s+(?:required\s+)?[\w.]+(?:<[\w.<>?, ]+>)?\??\s+\w+\s*\{\s*get;\s*init;\s*\}')
stats = collections.Counter()
for f in sorted(os.listdir(LIB + '/Choices')):
    if not f.endswith('_.cs'): continue
    cname = f[:-4]
    ids = [k for k in by_name.get(cname, []) if E[k]['kind'] == 'ChoiceComponent']
    if not ids: continue
    for e in E[ids[0]]['elements']:
        p = '%s/Choices/%s/%s.cs' % (LIB, cname, e['name'])
        if not os.path.exists(p): continue
        raw = open(p, 'rb').read(); bom = raw.startswith(b'\xef\xbb\xbf'); text = raw.decode('utf-8-sig')
        nl = '\r\n' if '\r\n' in text else '\n'
        text = text.replace('\r\n', '\n')
        m = HEADER.search(text)
        if not m: stats['no record header'] += 1; continue
        before = text[:m.start()]
        class_tag = re.search(r'\[IsoXmlTag\("([^"]+)"\)\]\s*$', before)
        member_tags = re.findall(r'\[IsoXmlTag\("([^"]+)"\)\]\s*\n(?:\s*\[[^\n]*\]\s*\n)*\s*public\s', text[m.end():])
        n_members = len(PROP.findall(text[m.end():]))
        t = E.get(e['type'], {}); kind = t.get('kind')
        new = None
        indent = m.group(1)
        if kind == 'ChoiceComponent' and n_members == 0:
            block = ('%spublic record %s : %s\n%s{\n%s    /// <summary>Contains the main value for the container.</summary>\n'
                     '%s    [IsoXmlTag("%s")]\n%s    public required %s_ Value {{ get; init; }}\n%s}}') % (
                indent, m.group(2), m.group(3), indent, indent, indent, e['tag'], indent, t['name'], indent)
            block = block.replace('{{', '{').replace('}}', '}')
            new = text[:m.start()] + block + text[m.end():]
            stats['choice-typed variant given a Value'] += 1
        elif kind == 'MessageComponent':
            value_form = class_tag is None and n_members == 1 and member_tags == [e['tag']]
            if class_tag is None and not value_form:
                new = text[:m.start()] + '%s[IsoXmlTag("%s")]\n' % (indent, e['tag']) + text[m.start():]
                stats['component variant given its tag'] += 1
            elif class_tag is not None and class_tag.group(1) != e['tag']:
                new = before[:class_tag.start(1)] + e['tag'] + before[class_tag.end(1):] + text[m.start():]
                stats['class tag corrected'] += 1
        if new is not None:
            open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + new.replace('\n', nl).encode('utf-8'))

# ---- second pass: the members inlined under a class tag have the occurrences of the component's elements ----
complex_names = {f[:-3] for f in os.listdir(LIB + '/Components') if f.endswith('.cs')} | {f[:-4] + '_' for f in os.listdir(LIB + '/Choices') if f.endswith('_.cs')}
PROPLINE = re.compile(r'^(\s*)public\s+(required\s+)?([\w.]+(?:<[\w.<>?, ]+>)?\??)\s+(\w+)\s*\{\s*get;\s*init;\s*\}\s*$')
for f in sorted(os.listdir(LIB + '/Choices')):
    if not f.endswith('_.cs'): continue
    cname = f[:-4]
    ids = [k for k in by_name.get(cname, []) if E[k]['kind'] == 'ChoiceComponent']
    if not ids: continue
    for e in E[ids[0]]['elements']:
        comp = E.get(e['type'], {})
        if comp.get('kind') != 'MessageComponent': continue
        p = '%s/Choices/%s/%s.cs' % (LIB, cname, e['name'])
        if not os.path.exists(p): continue
        raw = open(p, 'rb').read(); bom = raw.startswith(b'\xef\xbb\xbf'); text = raw.decode('utf-8-sig')
        if not re.search(r'\[IsoXmlTag\("%s"\)\]\s*\n(?:\s*\[[^\n]*\]\s*\n)*\s*public\s+record' % re.escape(e['tag']), text): continue
        want = {x['tag']: x for x in comp['elements']}
        nl = '\r\n' if '\r\n' in text else '\n'
        lines = text.split(nl); out = []; changed = False; pend = None
        for l in lines:
            tg = re.search(r'\[IsoXmlTag\("([^"]+)"\)\]', l)
            if tg: pend = tg.group(1)
            pm = PROPLINE.match(l)
            if pm and pend in want and pend != e['tag']:
                indent, req, typ, name = pm.groups(); x = want[pend]
                many = x['max'] != '1'; is_coll = bool(re.match(r'(Simple)?ValueList<', typ))
                if many and not is_coll:
                    core = typ.rstrip('?')
                    coll = ('ValueList<%s>' if core in complex_names else 'SimpleValueList<%s>') % core
                    if x['max'] is not None:
                        out.append('%s[MinLength(%s)]' % (indent, x['min'])); out.append('%s[MaxLength(%s)]' % (indent, x['max']))
                    out.append('%spublic %s %s { get; init; } = [];' % (indent, coll, name))
                    changed = True; stats['inlined member to collection'] += 1; pend = None; continue
                if not many and not is_coll and x['min'] == '1' and not req:
                    out.append('%spublic required %s %s { get; init; }' % (indent, typ.rstrip('?'), name)); changed = True
                    stats['inlined member to required'] += 1; pend = None; continue
                if not many and not is_coll and x['min'] == '0' and req:
                    out.append('%spublic %s? %s { get; init; }' % (indent, typ.rstrip('?'), name)); changed = True
                    stats['inlined member to optional'] += 1; pend = None; continue
                pend = None
            out.append(l)
        if changed:
            open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + nl.join(out).encode('utf-8'))
print(dict(stats))
