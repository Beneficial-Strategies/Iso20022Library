#!/usr/bin/env python3
"""A message building block that the repository allows many times (absent maxOccurs = unbounded) is a ValueList, not a single
property; one that is required (minOccurs 1, maxOccurs 1) is not optional. Same form as the components: [MinLength]/[MaxLength]
when the maximum is a number, nothing when it is unbounded."""
import json, os, re, collections
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'Common')
WORK = os.environ.get('ISO20022_WORK', os.path.join(ROOT, '..', '_work', 'Iso20022Library'))
D = json.load(open(os.path.join(WORK, 'repo-structure.json')))
M = D['messages']
complex_names = {f[:-3] for f in os.listdir(LIB + '/Components') if f.endswith('.cs')} | {f[:-4] + '_' for f in os.listdir(LIB + '/Choices') if f.endswith('_.cs')}
PROP = re.compile(r'^(\s*)public\s+(required\s+)?([\w.]+(?:<[\w.<>?, ]+>)?\??)\s+(\w+)\s*\{\s*get;\s*init;\s*\}\s*$')
stats = collections.Counter()
for area in sorted(os.listdir(LIB + '/MessageDefinitions')):
    for f in sorted(os.listdir(LIB + '/MessageDefinitions/' + area)):
        if not f.endswith('.cs') or f.endswith('.Interfaces.cs'): continue
        p = LIB + '/MessageDefinitions/%s/%s' % (area, f)
        raw = open(p, 'rb').read(); bom = raw.startswith(b'\xef\xbb\xbf'); text = raw.decode('utf-8-sig')
        ident = re.search(r'IsoIdentifier = "([^"]+)"', text).group(1)
        m = M.get(ident)
        if not m: continue
        blocks = {b['tag']: b for b in m['blocks']}
        nl = '\r\n' if '\r\n' in text else '\n'
        lines = text.split(nl); out = []; changed = False; pending = None
        for l in lines:
            t = re.search(r'\[IsoXmlTag\("([^"]+)"\)\]', l)
            if t: pending = t.group(1)
            pm = PROP.match(l)
            if pm and pending in blocks:
                indent, req, typ, name = pm.groups()
                b = blocks[pending]
                many = b['max'] != '1'
                is_coll = bool(re.match(r'(Simple)?ValueList<', typ))
                if many and not is_coll:
                    core = typ.rstrip('?')
                    coll = ('ValueList<%s>' if core in complex_names else 'SimpleValueList<%s>') % core
                    if b['max'] is not None:
                        out.append('%s[MinLength(%s)]' % (indent, b['min']))
                        out.append('%s[MaxLength(%s)]' % (indent, b['max']))
                    out.append('%spublic %s %s { get; init; } = [];' % (indent, coll, name))
                    changed = True; stats['to collection'] += 1; pending = None
                    continue
                if not many and not is_coll and b['min'] == '1' and not req:
                    out.append('%spublic required %s %s { get; init; }' % (indent, typ.rstrip('?'), name))
                    changed = True; stats['to required'] += 1; pending = None
                    continue
                pending = None
            out.append(l)
        if changed:
            open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + nl.join(out).encode('utf-8'))
print(dict(stats))
