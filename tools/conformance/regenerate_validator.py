#!/usr/bin/env python3
"""Rewrite the validator of a component whose members were regenerated: one injected validator per distinct component or choice type
(when a validator class exists for it), a rule per member (required: SetValidator; optional: When not null; list: RuleForEach)."""
import os, re, sys, collections
ROOT = os.path.abspath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', '..'))
SRC = os.path.join(ROOT, 'src')
REC = SRC + '/BeneficialStrategies.Iso20022.Common/Components/%s.cs'
VAL = SRC + '/BeneficialStrategies.Iso20022.FluentValidation/Validators'
PROP = re.compile(r'^\s*public\s+(required\s+)?([\w.]+(?:<[\w.<>?, ]+>)?\??)\s+(\w+)\s*\{\s*get;\s*init;\s*\}')

def validator_class(t):
    name = t.rstrip('_')
    if t.endswith('_'):
        return ('%s_Validator' % name) if os.path.exists('%s/Choices/%s_Validator.cs' % (VAL, name)) else None
    return ('%sValidator' % name) if os.path.exists('%s/Components/%sValidator.cs' % (VAL, name)) else None

def camel(s): return s[0].lower() + s[1:]

for comp in sys.argv[1:]:
    lines = open(REC % comp, encoding='utf-8-sig').read().split('\n')
    members = []
    for l in lines:
        m = PROP.match(l)
        if m:
            req, typ, name = m.groups()
            lst = re.match(r'(?:Simple)?ValueList<(.+)>$', typ)
            core = (lst.group(1) if lst else typ).rstrip('?')
            members.append(dict(name=name, core=core, kind='list' if lst else ('required' if req else 'optional')))
    types = []
    for m in members:
        v = validator_class(m['core'])
        m['validator'] = v
        if v and m['core'] not in types: types.append(m['core'])
    params = ['        IValidator<%s> %sValidator' % (t, camel(t.rstrip('_'))) for t in types]
    rules = []
    for m in members:
        if not m['validator']: continue
        p = camel(m['core'].rstrip('_')) + 'Validator'
        n = m['name']
        if m['kind'] == 'list': rules.append('        RuleForEach(x => x.%s).SetValidator(%s!);' % (n, p))
        elif m['kind'] == 'required': rules.append('        RuleFor(x => x.%s).SetValidator(%s!);' % (n, p))
        else: rules.append('        When(\n            x => x.%s is not null,\n            () => RuleFor(x => x.%s).SetValidator(%s!)\n        );' % (n, n, p))
    table = []
    for m in members:
        card = {'required': 'required (1..1)', 'optional': 'optional (0..1)', 'list': 'collection (0..n)'}[m['kind']]
        table.append('///   <item><term>%s</term><description>%s — %s</description></item>' % (m['name'], m['core'], card))
    path = '%s/Components/%sValidator.cs' % (VAL, comp)
    if not types:
        # nothing to inject: the members are simple types and code sets, which check themselves
        out = ['// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.', '',
               'namespace BeneficialStrategies.Iso20022.Validation.Components;', '',
               '/// <summary>', '/// Validates <see cref="%s"/> per the ISO 20022 specification.' % comp, '/// </summary>', '/// <remarks>',
               '/// Written from the ISO 20022 repository (#47). Every member is a simple type or a code set, which check themselves when they are',
               '/// built, so there is no rule to add at this level; the validator exists so the type is recorded as reviewed and a message that',
               '/// reaches it is validated end to end.', '/// <list type="table">'] + table + ['/// </list>', '/// </remarks>',
               'public class %sValidator : AbstractValidator<%s> { }' % (comp, comp)]
        open(path, 'w', encoding='utf-8').write('\n'.join(out) + '\n')
        print(comp, 'no nested validators'); continue
    out = ['// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.', '',
           'namespace BeneficialStrategies.Iso20022.Validation.Components;', '',
           '/// <summary>', '/// Validates <see cref="%s"/> per the ISO 20022 specification.' % comp, '/// </summary>', '/// <remarks>',
           '/// Rewritten from the ISO 20022 repository when the members of the component were corrected (#47): the members, their order and',
           '/// occurrences are the repository\'s. Every member that is a component or a choice is validated by an injected',
           '/// <see cref="IValidator{T}"/>; the simple types and code sets check themselves when they are built.',
           '/// <list type="table">'] + table + ['/// </list>', '/// </remarks>',
           'public class %sValidator : AbstractValidator<%s>' % (comp, comp), '{',
           '    /// <summary>', '    /// Initializes a new instance using dependency injection: the caller supplies the validators',
           '    /// — e.g. resolved from a DI container — instead of this type constructing its own.', '    /// </summary>',
           '    public %sValidator(' % comp, ',\n'.join(params), '    )', '    {'] + rules + ['    }', '',
           '    /// <summary>', '    /// Initializes a new instance using default dependencies. Convenience constructor for callers',
           '    /// not using a DI container.', '    /// </summary>', '    public %sValidator()' % comp, '        : this(',
           ',\n'.join('            new %s()' % validator_class(t) for t in types), '        ) { }', '}']
    open(path, 'w', encoding='utf-8').write('\n'.join(out) + '\n')
    print(comp, len(types), 'validators injected,', len(rules), 'rules')
