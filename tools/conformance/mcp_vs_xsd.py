#!/usr/bin/env python3
"""Compare the ISO 20022 repository file the MCP serves (snapshot 20260904) with ISO's published XSDs.

For every XSD in the folder whose message is in the repository: the elements of each complex type (order, tag, min/max occurs)
and the alternatives of each choice. Writes repo-structure.json (the structure of every component, choice and message, in the
repository's order) as the source for fixing the Library, and prints the counts."""
import json, os, re, sys, collections
import os
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'Common')
# derived files go to the work folder next to the repository (CLAUDE.md), never into the repository
WORK = os.environ.get('ISO20022_WORK', os.path.join(ROOT, '..', '_work', 'Iso20022Library'))
STRUCTURE = os.path.join(WORK, 'repo-structure.json')
import xml.etree.ElementTree as ET

REPO = os.path.expanduser('~/.iso20022/snapshots/20260904_ISO20022_2013_eRepository.iso20022')
XSD_DIR = sys.argv[1]
OUT = sys.argv[2]
XSI = '{http://www.w3.org/2001/XMLSchema-instance}type'
XMI = '{http://www.omg.org/XMI}id'

# ---- the repository: one pass, keep only what is needed ----
entries = {}          # id -> dict(kind, name, elements[list of dict])
messages = {}         # 'camt.062.001.03' -> dict(name, blocks[list])
stack = []
for ev, el in ET.iterparse(REPO, events=('start', 'end')):
    tag = el.tag
    if ev == 'start':
        stack.append(el)
        continue
    stack.pop()
    if tag == 'topLevelDictionaryEntry':
        t = el.get(XSI, '').split(':')[-1]
        if t in ('MessageComponent', 'ChoiceComponent'):
            elems = []
            for c in el:
                if c.tag == 'messageElement':
                    elems.append(dict(name=c.get('name'), tag=c.get('xmlTag'), min=c.get('minOccurs'), max=c.get('maxOccurs'),
                                      type=c.get('complexType') or c.get('simpleType') or c.get('type'), kind=c.get(XSI, '').split(':')[-1],
                                      status=c.get('registrationStatus')))
            entries[el.get(XMI)] = dict(kind=t, name=el.get('name'), elements=elems, status=el.get('registrationStatus'))
        else:
            entries[el.get(XMI)] = dict(kind=t, name=el.get('name'), elements=[])
        el.clear()
    elif tag == 'messageDefinition':
        ident = None
        blocks = []
        for c in el:
            if c.tag == 'messageDefinitionIdentifier':
                ident = '%s.%s.%s.%s' % (c.get('businessArea'), c.get('messageFunctionality'), c.get('flavour'), c.get('version'))
            elif c.tag == 'messageBuildingBlock':
                blocks.append(dict(name=c.get('name'), tag=c.get('xmlTag'), min=c.get('minOccurs'), max=c.get('maxOccurs'),
                                   type=c.get('complexType') or c.get('simpleType') or c.get('type'), status=c.get('registrationStatus')))
        if ident:
            messages[ident] = dict(name=el.get('name'), id=el.get(XMI), root=el.get('xmlTag'), blocks=blocks)
        el.clear()
print('repository: %d dictionary entries, %d messages' % (len(entries), len(messages)))

with open(OUT, 'w', encoding='utf-8') as f:
    json.dump(dict(entries=entries, messages=messages), f)

# ---- the XSDs ----
XS = '{http://www.w3.org/2001/XMLSchema}'
def load_xsd(path):
    root = ET.parse(path).getroot()
    types = {}
    def flatten(p, out):
        for c in p:
            if c.tag == XS + 'element':
                out.append((c.get('name'), c.get('type'), c.get('minOccurs', '1'), c.get('maxOccurs', '1')))
            elif c.tag in (XS + 'sequence', XS + 'choice'):
                flatten(c, out)
    for ct in root.findall(XS + 'complexType'):
        seq = ct.find(XS + 'sequence'); ch = ct.find(XS + 'choice')
        p = seq if seq is not None else ch
        els = []
        kind = 'other'
        if p is not None:
            flatten(p, els)
            # a choice is either the type's own particle, or the only child of its sequence (older schemas)
            inner = [c for c in p if c.tag in (XS + 'sequence', XS + 'choice', XS + 'element')]
            kind = 'choice' if (ch is not None or (len(inner) == 1 and inner[0].tag == XS + 'choice')) else 'sequence'
        types[ct.get('name')] = (kind, els)
    return root, types

def occ(mn, mx):
    """The repository leaves out what is the default of the XML Schema model: observe, do not assume."""
    return (mn, mx)

stats = collections.Counter()
seen = collections.Counter()      # (repo min,max) -> (xsd min,max)
problems = collections.defaultdict(list)
checked_types = set()
by_name = collections.defaultdict(list)
for k, v in entries.items():
    by_name[v['name']].append(k)

def compare_type(tname, xtypes, repo_id, where, msg):
    key = (tname, repo_id)
    if key in checked_types:
        return
    checked_types.add(key)
    xkind, xels = xtypes.get(tname, ('missing', []))
    ent = entries.get(repo_id)
    if ent is None or xkind in ('other', 'missing'):
        return
    stats['types compared'] += 1
    relems = ent['elements']
    if ent['kind'] == 'ChoiceComponent' and xkind != 'choice':
        problems['kind'].append('%s %s: repository choice, XSD %s' % (msg, tname, xkind)); return
    if ent['kind'] == 'MessageComponent' and xkind != 'sequence':
        problems['kind'].append('%s %s: repository component, XSD %s' % (msg, tname, xkind)); return
    rtags = [r['tag'] for r in relems]
    xtags = [x[0] for x in xels]
    if rtags == xtags:
        stats['element order+names equal'] += 1
    elif sorted(rtags) == sorted(xtags):
        problems['order'].append('%s %s: repo %s / xsd %s' % (msg, tname, rtags, xtags))
    else:
        problems['names'].append('%s %s: repo %s / xsd %s' % (msg, tname, rtags, xtags))
    if ent['kind'] == 'MessageComponent':
        for r, x in zip(relems, xels):
            if r['tag'] != x[0]:
                continue
            seen[((r['min'], r['max']), (x[2], x[3]))] += 1
    for r, x in zip(relems, xels):
        if r['tag'] == x[0] and x[1] in xtypes and r['type'] in entries:
            compare_type(x[1], xtypes, r['type'], where + '/' + r['tag'], msg)

files = sorted(f for f in os.listdir(XSD_DIR) if re.match(r'^[a-z]{4}\.\d{3}\.\d{3}\.\d{2}\.xsd$', f))
for f in files:
    ident = f[:-4]
    if ident not in messages:
        stats['xsd without repository message'] += 1
        continue
    stats['messages compared'] += 1
    root, xtypes = load_xsd(os.path.join(XSD_DIR, f))
    m = messages[ident]
    # Document -> root element -> message type
    doc = xtypes.get('Document')
    if not doc or not doc[1]:
        continue
    mtype = doc[1][0][1]
    xkind, xels = xtypes.get(mtype, ('missing', []))
    rtags = [b['tag'] for b in m['blocks']]
    xtags = [x[0] for x in xels]
    if rtags == xtags:
        stats['message blocks order+names equal'] += 1
    elif sorted(rtags) == sorted(xtags):
        problems['order'].append('%s %s: repo %s / xsd %s' % (ident, mtype, rtags, xtags))
    else:
        problems['names'].append('%s %s: repo %s / xsd %s' % (ident, mtype, rtags, xtags))
    for b, x in zip(m['blocks'], xels):
        if b['tag'] == x[0]:
            seen[((b['min'], b['max']), (x[2], x[3]))] += 1
        if b['tag'] == x[0] and x[1] in xtypes and b['type'] in entries:
            compare_type(x[1], xtypes, b['type'], ident + '/' + b['tag'], ident)

print(dict(stats))
print('problems:', {k: len(v) for k, v in problems.items()})
print('repository (min,max) -> XSD (min,max):')
for (r, x), n in sorted(seen.items(), key=lambda kv: -kv[1]):
    print('  %-16s -> %-16s %d' % (r, x, n))
for k, v in problems.items():
    print('== %s' % k)
    for x in v[:6]:
        print('  ', x[:300])
