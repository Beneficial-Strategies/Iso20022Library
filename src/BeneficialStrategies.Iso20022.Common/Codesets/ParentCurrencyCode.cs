// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code allocated to a currency, by a maintenance agency, under an international identification scheme as described in the latest edition of the international standard ISO 4217 &quot;Codes for the representation of currencies and funds&quot;. Valid currency codes are registered with the ISO 4217 Maintenance Agency, and consist of three contiguous letters.
/// </summary>
/// <remarks>
/// Per MCP, the base code set derived by both ActiveCurrencyCode and ActiveOrHistoricCurrencyCode.
/// Pattern facet from MCP get_code_set_details: [A-Z]{3,3}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_VFizcvS0EeirnowYkPlyRw")]
[Description(@"Code allocated to a currency, by a maintenance agency, under an international identification scheme as described in the latest edition of the international standard ISO 4217 ""Codes for the representation of currencies and funds"". Valid currency codes are registered with the ISO 4217 Maintenance Agency, and consist of three contiguous letters.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ParentCurrencyCode>))]
public readonly struct ParentCurrencyCode : IIsoExternalCode, IEquatable<ParentCurrencyCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[A-Z]{3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ParentCurrencyCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ParentCurrencyCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ParentCurrencyCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ParentCurrencyCode"/>.</summary>
    public static implicit operator ParentCurrencyCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ParentCurrencyCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ParentCurrencyCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ParentCurrencyCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ParentCurrencyCode a, ParentCurrencyCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ParentCurrencyCode a, ParentCurrencyCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ParentCurrencyCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ParentCurrencyCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ParentCurrencyCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ParentCurrencyCode b) => a != b.Value;
}
