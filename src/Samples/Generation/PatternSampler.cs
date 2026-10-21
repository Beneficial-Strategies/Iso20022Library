// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text;

namespace BeneficialStrategies.Iso20022.Samples;

/// <summary>
/// Makes a string that matches one of the patterns of the primitive types (the subset of regular expressions the ISO 20022 schemas use:
/// literals, classes, <c>\d</c>, groups, alternatives and counts). It is not a general generator: it takes the first alternative, the first
/// character of a class and the smallest count that the pattern allows, so that the same pattern always gives the same string.
/// </summary>
internal sealed class PatternSampler
{
    private readonly string _pattern;
    private readonly int _extra;
    private int _at;

    private PatternSampler(string pattern, int extra) => (_pattern, _extra) = (pattern, extra);

    /// <param name="pattern">The pattern of the type, with or without the anchors.</param>
    /// <param name="extra">How many more than the smallest count each repeat takes (up to its largest), for a type whose length rules ask for more.</param>
    /// <returns>A string that matches, or <see langword="null"/> when the pattern uses something this does not understand.</returns>
    internal static string? Sample(string pattern, int extra = 0)
    {
        try
        {
            var text = pattern;
            if (text.StartsWith("^", StringComparison.Ordinal))
                text = text.Substring(1);
            if (text.EndsWith("$", StringComparison.Ordinal))
                text = text.Substring(0, text.Length - 1);
            else if (text.EndsWith("\\z", StringComparison.Ordinal))
                text = text.Substring(0, text.Length - 2);
            var sampler = new PatternSampler(text, extra);
            var result = sampler.Alternatives();
            return sampler._at == text.Length ? result : null;
        }
        catch (FormatException)
        {
            return null;
        }
    }

    private string Alternatives()
    {
        var first = Sequence();
        while (_at < _pattern.Length && _pattern[_at] == '|')
        {
            _at++;
            Sequence(); // read past it: only the first alternative is used
        }
        return first;
    }

    private string Sequence()
    {
        var result = new StringBuilder();
        while (_at < _pattern.Length && _pattern[_at] != '|' && _pattern[_at] != ')')
        {
            var atom = Atom();
            var (min, max) = Count();
            var times = Math.Min(max, min + _extra);
            for (var i = 0; i < times; i++)
                result.Append(atom);
        }
        return result.ToString();
    }

    private string Atom()
    {
        var c = _pattern[_at++];
        switch (c)
        {
            case '(':
                if (_pattern.Length > _at + 1 && _pattern[_at] == '?')
                {
                    if (_pattern[_at + 1] != ':')
                        throw new FormatException("a group of this kind is not supported");
                    _at += 2;
                }
                var inner = Alternatives();
                Expect(')');
                return inner;
            case '[':
                return Class();
            case '\\':
                return Escape(_pattern[_at++]);
            case '.':
                return "A";
            case '*' or '+' or '?' or '{':
                throw new FormatException("a count with nothing to repeat");
            default:
                return c.ToString();
        }
    }

    private static string Escape(char c) => c switch
    {
        'd' => "1",
        's' => " ",
        'w' => "A",
        'D' or 'W' => "A",
        'S' => "A",
        't' => "\t",
        'n' => "\n",
        'r' => "\r",
        'p' or 'P' or 'b' or 'B' or 'k' or 'u' or 'x' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9'
            => throw new FormatException("an escape of this kind is not supported"),
        _ => c.ToString(),
    };

    private string Class()
    {
        var negated = _pattern[_at] == '^';
        if (negated)
            _at++;
        var members = new List<(char From, char To)>();
        var first = (char?)null;
        while (_pattern[_at] != ']')
        {
            var from = ClassChar(out var wasClass);
            if (wasClass is not null)
            {
                members.AddRange(wasClass);
                first ??= wasClass[0].From;
                continue;
            }
            var to = from;
            if (_pattern[_at] == '-' && _pattern[_at + 1] != ']')
            {
                _at++;
                to = ClassChar(out _);
            }
            members.Add((from, to));
            first ??= from;
        }
        _at++;
        if (!negated)
            return (first ?? throw new FormatException("an empty class")).ToString();
        foreach (var candidate in "Aa1x_ ")
            if (!members.Exists(m => candidate >= m.From && candidate <= m.To))
                return candidate.ToString();
        throw new FormatException("a class that excludes the usual characters");
    }

    private char ClassChar(out List<(char From, char To)>? set)
    {
        set = null;
        var c = _pattern[_at++];
        if (c != '\\')
            return c;
        var e = _pattern[_at++];
        switch (e)
        {
            case 'd': set = [('1', '9'), ('0', '0')]; return '1';
            case 's': set = [(' ', ' '), ('\t', '\t'), ('\n', '\n'), ('\r', '\r')]; return ' ';
            case 'w': set = [('A', 'Z'), ('a', 'z'), ('0', '9'), ('_', '_')]; return 'A';
            case 't': return '\t';
            case 'n': return '\n';
            case 'r': return '\r';
            case 'p' or 'P' or 'D' or 'W' or 'S' or 'u' or 'x':
                throw new FormatException("an escape of this kind is not supported");
            default: return e;
        }
    }

    private (int Min, int Max) Count()
    {
        if (_at >= _pattern.Length)
            return (1, 1);
        switch (_pattern[_at])
        {
            case '?': _at++; return (0, 1);
            case '*': _at++; return (0, int.MaxValue);
            case '+': _at++; return (1, int.MaxValue);
            case '{':
                var close = _pattern.IndexOf('}', _at);
                if (close < 0)
                    throw new FormatException("an unclosed count");
                var body = _pattern.Substring(_at + 1, close - _at - 1);
                _at = close + 1;
                var parts = body.Split(',');
                var min = int.Parse(parts[0], System.Globalization.CultureInfo.InvariantCulture);
                var max = parts.Length == 1 ? min : parts[1].Length == 0 ? int.MaxValue : int.Parse(parts[1], System.Globalization.CultureInfo.InvariantCulture);
                return (min, max);
            default:
                return (1, 1);
        }
    }

    private void Expect(char c)
    {
        if (_at >= _pattern.Length || _pattern[_at] != c)
            throw new FormatException($"'{c}' expected");
        _at++;
    }
}
