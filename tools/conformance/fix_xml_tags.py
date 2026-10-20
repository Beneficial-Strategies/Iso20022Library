#!/usr/bin/env python3
"""XML tags in the records that are not the repository's (typos and old spellings: TrmnlMgrId / TermnlMgrId): rename the tag where the
type has the same number of unmatched tags on both sides, pairing them by similarity. Types whose members differ more than that
(an outdated definition) are listed, not changed."""
import difflib, json, os, re, collections
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'Common')
WORK = os.environ.get('ISO20022_WORK', os.path.join(ROOT, '..', '_work', 'Iso20022Library'))
r = json.load(open(os.path.join(WORK, 'code-vs-repo.json')))
renamed = collections.Counter(); left = []
def path_of(where, kind):
    if kind == 'component-names': return '%s/Components/%s.cs' % (LIB, where)
    area = where.split('.')[0]
    for f in os.listdir('%s/MessageDefinitions/%s' % (LIB, area)):
        p = '%s/MessageDefinitions/%s/%s' % (LIB, area, f)
        if 'IsoIdentifier = "%s"' % where in open(p, encoding='utf-8-sig').read(): return p
for kind in ('component-names', 'message-names'):
    for where, ct, rt in r.get(kind, []):
        onlyc = [x for x in ct if x not in rt]; onlyr = [x for x in rt if x not in ct]
        if len(onlyc) != len(onlyr) or not onlyc:
            left.append((where, onlyc, onlyr)); continue
        pairs = {}; free = list(onlyr)
        for c in onlyc:
            m = difflib.get_close_matches(c, free, n=1, cutoff=0.6)
            if not m: break
            pairs[c] = m[0]; free.remove(m[0])
        if len(pairs) != len(onlyc):
            left.append((where, onlyc, onlyr)); continue
        p = path_of(where, kind)
        raw = open(p, 'rb').read(); bom = raw.startswith(b'\xef\xbb\xbf'); t = raw.decode('utf-8-sig')
        for c, n in pairs.items():
            t = t.replace('[IsoXmlTag("%s")]' % c, '[IsoXmlTag("%s")]' % n); renamed[(c, n)] += 1
        open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + t.encode('utf-8'))
print(len(renamed), 'tags renamed')
print('left (the definition differs more than in tags):')
for w, a, b in left: print('  ', w, 'code only', a[:6], 'repo only', b[:6])
