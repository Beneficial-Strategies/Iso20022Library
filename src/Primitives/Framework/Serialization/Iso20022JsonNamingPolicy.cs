// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text;
using System.Text.Json;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Converts PascalCase C# property names to the <c>snake_case</c> JSON property names
/// required by the ISO 20022 JSON binding specification.
/// </summary>
/// <remarks>
/// Source: ISO 20022 and JSON: An Implementation Best Practices Whitepaper, Annex A (2018).
/// Consecutive uppercase sequences (acronyms such as <c>BIC</c>, <c>IBAN</c>) are
/// lowercased as a group without inserted underscores: <c>BIC</c> → <c>bic</c>,
/// <c>GroupHeader</c> → <c>group_header</c>, <c>XMLParser</c> → <c>xml_parser</c>.
/// </remarks>
public sealed class Iso20022JsonNamingPolicy : JsonNamingPolicy
{
    /// <summary>Singleton — stateless, safe to share.</summary>
    public static readonly Iso20022JsonNamingPolicy Instance = new();

    /// <inheritdoc/>
    public override string ConvertName(string name)
    {
        if (string.IsNullOrEmpty(name))
            return name;

        var sb = new StringBuilder(name.Length + 4);
        for (int i = 0; i < name.Length; i++)
        {
            var c = name[i];
            if (char.IsUpper(c))
            {
                bool prevIsLower = i > 0 && char.IsLower(name[i - 1]);
                bool nextIsLower = i + 1 < name.Length && char.IsLower(name[i + 1]);
                bool prevIsUpper = i > 0 && char.IsUpper(name[i - 1]);

                if (i > 0 && (prevIsLower || (nextIsLower && prevIsUpper)))
                    sb.Append('_');

                sb.Append(char.ToLowerInvariant(c));
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
