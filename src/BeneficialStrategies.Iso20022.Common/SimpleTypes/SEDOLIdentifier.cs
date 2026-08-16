// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to
/// identify foreign stocks, especially those that aren't actively traded in the US and don't have
/// a CUSIP number.
/// </summary>
/// <remarks>
/// ISO 20022 itself defines no format for this identifier beyond "IdentifierSet, no formal
/// pattern" — the structure (length, character values, check-digit algorithm) is defined entirely
/// by the London Stock Exchange, external to ISO 20022. Per CLAUDE.md's exception for primitives
/// defined by an external standard, the following is sourced from published third-party
/// implementations, not from the ISO 20022 MCP server:
/// <list type="bullet">
///   <item><description>
///   Structure: 7 characters — a 6-character alphanumeric <see cref="Core"/> followed by 1
///   numeric <see cref="CheckDigit"/>. Source:
///   <see href="https://commons.apache.org/proper/commons-validator/apidocs/org/apache/commons/validator/routines/checkdigit/SedolCheckDigit.html">Apache Commons Validator — SedolCheckDigit</see>,
///   <see href="https://www.isin.org/fix-sedol/">isin.org — Fix SEDOL / Calculate SEDOL Check Digit</see>.
///   </description></item>
///   <item><description>
///   Check-digit algorithm: each of the 6 core characters maps to a value (digit → itself;
///   letter → 9 + its 1-based alphabet position, so A=10, B=11 ... Z=35 — note vowels are
///   conventionally never assigned in real-world SEDOLs, but the algorithm itself doesn't special
///   -case them, and this implementation doesn't reject them either, deliberately staying
///   permissive per "easier to tighten than loosen"). Weight the 6 values by
///   <c>[1, 3, 1, 7, 3, 9]</c>, sum, then check digit = <c>(10 - (sum mod 10)) mod 10</c>.
///   </description></item>
/// </list>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YYer4Np-Ed-ak6NoX_4Aeg_1975412972")]
[Description(@"Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren't actively traded in the US and don't have a CUSIP number.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<SEDOLIdentifier>))]
public readonly struct SEDOLIdentifier : IIsoSimpleValue<string>, IEquatable<SEDOLIdentifier>
{
    /// <summary>Full-value format constraint: 6-character alphanumeric core + 1 numeric check digit.</summary>
    public const string Pattern = @"^[A-Z0-9]{6}[0-9]$";

    /// <summary>Core-only format constraint (accepted for check-digit auto-generation — see the constructor).</summary>
    private const string CorePattern = @"^[A-Z0-9]{6}$";

    private static readonly int[] Weights = [1, 3, 1, 7, 3, 9];

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The 6-character alphanumeric identifier body, excluding the check digit.</summary>
    public string Core => Value[..6];

    /// <summary>The trailing numeric check digit, computed from <see cref="Core"/> per the LSE's SEDOL algorithm.</summary>
    public char CheckDigit => Value[6];

    /// <summary>
    /// Initializes a new instance from either a full 7-character value (core + check digit, which
    /// is verified) or a 6-character core alone (in which case the check digit is computed and
    /// appended automatically).
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value is neither
    /// a valid 6-character core nor a valid 7-character full value, or with
    /// <see cref="Iso20022FormatViolation.CheckDigitMismatch"/> when a 7-character value's check
    /// digit doesn't match the one computed from its core.
    /// </exception>
    public SEDOLIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length == 6 && Regex.IsMatch(value, CorePattern))
        {
            Value = value + ComputeCheckDigit(value);
            return;
        }
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(SEDOLIdentifier), value, Pattern);
        char expected = ComputeCheckDigit(value[..6]);
        if (value[6] != expected)
            throw Iso20022FormatException.ForCheckDigitMismatch(typeof(SEDOLIdentifier), value, expected, value[6]);
        Value = value;
    }

    /// <summary>
    /// Computes the SEDOL check digit for a 6-character core, per the LSE's published algorithm
    /// (see the type's <c>remarks</c> for the source and full description).
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when <paramref name="core"/> is not a valid 6-character SEDOL core.</exception>
    public static char ComputeCheckDigit(string core)
    {
        if (core is null || !Regex.IsMatch(core, CorePattern))
            throw new ArgumentException("Must be a 6-character alphanumeric SEDOL core.", nameof(core));
        int sum = 0;
        for (int i = 0; i < 6; i++)
            sum += CharValue(core[i]) * Weights[i];
        return (char)('0' + ((10 - (sum % 10)) % 10));
    }

    private static int CharValue(char c) =>
        c is >= '0' and <= '9' ? c - '0' : 9 + (c - 'A' + 1);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid SEDOL core or full value.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out SEDOLIdentifier result)
    {
        if (value is not null)
        {
            try { result = new SEDOLIdentifier(value); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="SEDOLIdentifier"/>.</summary>
    public static implicit operator SEDOLIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(SEDOLIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(SEDOLIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is SEDOLIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(SEDOLIdentifier a, SEDOLIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(SEDOLIdentifier a, SEDOLIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(SEDOLIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(SEDOLIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, SEDOLIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, SEDOLIdentifier b) => a != b.Value;
}
