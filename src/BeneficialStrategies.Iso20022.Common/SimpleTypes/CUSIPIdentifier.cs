// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that
/// created and maintains the securities classification system in the US. Non-US securities have a
/// similar number called the CINS number.
/// </summary>
/// <remarks>
/// ISO 20022 itself defines no format for this identifier beyond "IdentifierSet, no formal
/// pattern" — the structure (length, character values, check-digit algorithm) is defined entirely
/// by CUSIP Global Services, external to ISO 20022. Per CLAUDE.md's exception for primitives
/// defined by an external standard, the following is sourced from published third-party
/// implementations, not from the ISO 20022 MCP server:
/// <list type="bullet">
///   <item><description>
///   Structure: 9 characters — an 8-character <see cref="Core"/> (issuer + issue, alphanumeric
///   plus the special characters <c>* @ #</c>) followed by 1 numeric <see cref="CheckDigit"/>.
///   Source:
///   <see href="https://commons.apache.org/validator/apidocs/org/apache/commons/validator/routines/checkdigit/CUSIPCheckDigit.html">Apache Commons Validator — CUSIPCheckDigit</see>,
///   <see href="https://rosettacode.org/wiki/CUSIP">Rosetta Code — CUSIP</see>.
///   </description></item>
///   <item><description>
///   Check-digit algorithm ("Modulus 10 Double Add Double"): each of the 8 core characters maps to
///   a value (digit → itself; letter → 10 + its 0-based alphabet position, so A=10, B=11 ... Z=35;
///   <c>*</c>=36, <c>@</c>=37, <c>#</c>=38). Characters at the 2nd/4th/6th/8th position (1-based)
///   are doubled; every resulting value (doubled or not) has its digits summed
///   (<c>value/10 + value%10</c>); all 8 digit-sums are added together; check digit =
///   <c>(10 - (total mod 10)) mod 10</c>.
///   </description></item>
/// </list>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YYLJ5dp-Ed-ak6NoX_4Aeg_-1084539446")]
[Description(@"Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. Non-US securities have a similar number called the CINS number.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<CUSIPIdentifier>))]
public readonly struct CUSIPIdentifier : IIsoSimpleValue<string>, IEquatable<CUSIPIdentifier>
{
    /// <summary>Full-value format constraint: 8-character core + 1 numeric check digit.</summary>
    public const string Pattern = @"^[A-Z0-9*@#]{8}[0-9]$";

    /// <summary>Core-only format constraint (accepted for check-digit auto-generation — see the constructor).</summary>
    private const string CorePattern = @"^[A-Z0-9*@#]{8}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The 8-character issuer+issue identifier body, excluding the check digit.</summary>
    public string Core => Value[..8];

    /// <summary>The trailing numeric check digit, computed from <see cref="Core"/> per CUSIP's Modulus 10 Double Add Double algorithm.</summary>
    public char CheckDigit => Value[8];

    /// <summary>
    /// Initializes a new instance from either a full 9-character value (core + check digit, which
    /// is verified) or an 8-character core alone (in which case the check digit is computed and
    /// appended automatically).
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value is neither
    /// a valid 8-character core nor a valid 9-character full value, or with
    /// <see cref="Iso20022FormatViolation.CheckDigitMismatch"/> when a 9-character value's check
    /// digit doesn't match the one computed from its core.
    /// </exception>
    public CUSIPIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length == 8 && Regex.IsMatch(value, CorePattern))
        {
            Value = value + ComputeCheckDigit(value);
            return;
        }
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(CUSIPIdentifier), value, Pattern);
        char expected = ComputeCheckDigit(value[..8]);
        if (value[8] != expected)
            throw Iso20022FormatException.ForCheckDigitMismatch(typeof(CUSIPIdentifier), value, expected, value[8]);
        Value = value;
    }

    /// <summary>
    /// Computes the CUSIP check digit for an 8-character core, per the published Modulus 10
    /// Double Add Double algorithm (see the type's <c>remarks</c> for the source and full
    /// description).
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when <paramref name="core"/> is not a valid 8-character CUSIP core.</exception>
    public static char ComputeCheckDigit(string core)
    {
        if (core is null || !Regex.IsMatch(core, CorePattern))
            throw new ArgumentException("Must be an 8-character CUSIP core.", nameof(core));
        int sum = 0;
        for (int i = 0; i < 8; i++)
        {
            int v = CharValue(core[i]);
            if ((i + 1) % 2 == 0) v *= 2; // 1-based positions 2, 4, 6, 8 are doubled
            sum += (v / 10) + (v % 10);
        }
        return (char)('0' + ((10 - (sum % 10)) % 10));
    }

    private static int CharValue(char c) => c switch
    {
        >= '0' and <= '9' => c - '0',
        >= 'A' and <= 'Z' => 10 + (c - 'A'),
        '*' => 36,
        '@' => 37,
        '#' => 38,
        _ => throw new ArgumentOutOfRangeException(nameof(c), c, "Not a valid CUSIP core character."),
    };

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid CUSIP core or full value.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out CUSIPIdentifier result)
    {
        if (value is not null)
        {
            try { result = new CUSIPIdentifier(value); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="CUSIPIdentifier"/>.</summary>
    public static implicit operator CUSIPIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(CUSIPIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(CUSIPIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CUSIPIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(CUSIPIdentifier a, CUSIPIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(CUSIPIdentifier a, CUSIPIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(CUSIPIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(CUSIPIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, CUSIPIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, CUSIPIdentifier b) => a != b.Value;
}
