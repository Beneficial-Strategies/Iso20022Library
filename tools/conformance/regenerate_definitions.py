#!/usr/bin/env python3
"""Rewrite the properties of the named components and messages from the ISO 20022 repository file (the members, their order, occurrences,
types, tags, ids and definitions), in the form the other records have. Usage: regenerate_definitions.py Name [Name ...]
(a component name, or a message identifier such as cain.005.001.05). The header of the file and the other members stay."""
import os, re, sys, collections
import xml.etree.ElementTree as ET
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
LIB = os.path.join(ROOT, 'src', 'Common')
REPO = os.environ.get('ISO20022_REPO', os.path.expanduser('~/.iso20022/snapshots/20260904_ISO20022_2013_eRepository.iso20022'))
XSI = '{http://www.w3.org/2001/XMLSchema-instance}type'; XMI = '{http://www.omg.org/XMI}id'
wanted = set(sys.argv[1:])

# ---- the repository: kinds of all types (id -> name, kind) and the elements of the wanted ones ----
types = {}; targets = {}
for ev, el in ET.iterparse(REPO, events=('end',)):
    if el.tag == 'topLevelDictionaryEntry':
        kind = el.get(XSI, '').split(':')[-1]; types[el.get(XMI)] = (el.get('name'), kind)
        if el.get('name') in wanted and kind == 'MessageComponent':
            targets[el.get('name')] = [dict(c.attrib) for c in el if c.tag == 'messageElement']
        el.clear()
    elif el.tag == 'messageDefinition':
        ident = None
        for c in el:
            if c.tag == 'messageDefinitionIdentifier':
                ident = '%s.%s.%s.%s' % (c.get('businessArea'), c.get('messageFunctionality'), c.get('flavour'), c.get('version'))
        if ident in wanted:
            targets[ident] = [dict(c.attrib) for c in el if c.tag == 'messageBuildingBlock']
        el.clear()

# ---- how the existing records write each type: IsoSimpleType and the facet attributes ----
facets = {}; simple_attr = {}
PROP = re.compile(r'^\s*public\s+(?:required\s+)?([\w.]+)\??\s+\w+\s*\{\s*get;\s*init;\s*\}')
for f in sorted(os.listdir(LIB + '/Components')):
    if not f.endswith('.cs'): continue
    lines = open(LIB + '/Components/' + f, encoding='utf-8-sig').read().split('\n')
    attrs = []
    for l in lines:
        s = l.strip()
        if s.startswith('['): attrs.append(l)
        elif s.startswith('///') or s == '': 
            if s == '': attrs = []
        else:
            m = PROP.match(l)
            if m and m.group(1) not in facets:
                keep = [a for a in attrs if not re.match(r'\s*\[(IsoId|DisplayName|IsoXmlTag|MinLength|MaxLength)\(', a)]
                facets[m.group(1)] = keep
            attrs = []
SIMPLE_KINDS = {'Text', 'IdentifierSet', 'Date', 'DateTime', 'Rate', 'Quantity', 'IndicatorSet', 'Binary', 'Time', 'Year', 'Month', 'YearMonth', 'Indicator'}

def display(name):
    s = re.sub(r'(?<=[a-z0-9])(?=[A-Z])', ' ', name)
    return re.sub(r'(?<=[A-Z])(?=[A-Z][a-z])', ' ', s)

def esc(t):
    return t.replace('&', '&amp;').replace('<', '&lt;').replace('>', '&gt;')

def chunk(e, indent='    '):
    tid = e.get('complexType') or e.get('simpleType') or e.get('type')
    tname, kind = types[tid]
    cs = tname + ('_' if kind == 'ChoiceComponent' else '')
    mn = e.get('minOccurs', '0'); mx = e.get('maxOccurs')
    out = []
    d = re.sub(r'\s*[\r\n]+\s*', '|', (e.get('definition') or '').strip())   # the records write a line break of ISO's text as |
    if d:
        out += [indent + '/// <summary>', indent + '/// ' + esc(d), indent + '/// </summary>']
    out += [indent + '[IsoId("%s")]' % e.get(XMI), indent + '[DisplayName("%s")]' % display(e.get('name')), indent + '[IsoXmlTag("%s")]' % e.get('xmlTag')]
    if kind in SIMPLE_KINDS and tname in facets:
        out += [indent + a.strip() for a in facets[tname]]
    elif kind in SIMPLE_KINDS:
        out += [indent + '[IsoSimpleType(IsoSimpleType.%s)]' % tname]
    if mx != '1':
        coll = ('ValueList<%s>' if kind in ('MessageComponent', 'ChoiceComponent') else 'SimpleValueList<%s>') % cs
        if mx is not None:
            out += [indent + '[MinLength(%s)]' % mn, indent + '[MaxLength(%s)]' % mx]
        out += [indent + 'public %s %s { get; init; } = [];' % (coll, e.get('name'))]
    elif mn == '1':
        out += [indent + 'public required %s %s { get; init; }' % (cs, e.get('name'))]
    else:
        out += [indent + 'public %s? %s { get; init; }' % (cs, e.get('name'))]
    return out

DECL = re.compile(r'^\s*public\s+(abstract\s+)?(partial\s+)?record\s+(\w+)')
for name in sorted(wanted):
    if name not in targets: print('not found in the repository:', name); continue
    if '.' in name:
        for area in os.listdir(LIB + '/MessageDefinitions'):
            for f in os.listdir('%s/MessageDefinitions/%s' % (LIB, area)):
                p = '%s/MessageDefinitions/%s/%s' % (LIB, area, f)
                if 'IsoIdentifier = "%s"' % name in open(p, encoding='utf-8-sig').read(): path = p
    else:
        path = '%s/Components/%s.cs' % (LIB, name)
    raw = open(path, 'rb').read(); bom = raw.startswith(b'\xef\xbb\xbf'); text = raw.decode('utf-8-sig')
    nl = '\r\n' if '\r\n' in text else '\n'; lines = text.split(nl)
    di = next(i for i, l in enumerate(lines) if DECL.match(l)); oi = next(i for i in range(di, len(lines)) if lines[i].strip() == '{')
    indent = re.match(r'\s*', lines[oi]).group(0); ci = next(i for i in range(oi + 1, len(lines)) if lines[i] == indent + '}')
    body = lines[oi + 1:ci]
    # keep the chunks that are not properties (constants of a message), drop the properties
    chunks = []; cur = []
    for l in body:
        if l.strip() == '':
            if cur: chunks.append(cur); cur = []
        else: cur.append(l)
    if cur: chunks.append(cur)
    keep = [c for c in chunks if not any(PROP.match(l) or re.match(r'^\s*public\s+(required\s+)?[\w.<>?]+\s+\w+\s*\{\s*get;\s*init;\s*\}', l) for l in c)]
    new_body = []
    for c in keep: new_body += c + ['']
    elems = targets[name]
    for e in elems: new_body += chunk(e, indent + '    ') + ['']
    new_body = new_body[:-1]
    out = lines[:oi + 1] + new_body + lines[ci:]
    open(path, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + nl.join(out).encode('utf-8'))
    print(name, '->', len(elems), 'members')
