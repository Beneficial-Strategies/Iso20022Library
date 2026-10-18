// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
/// </summary>
/// <remarks>
/// Per MCP, a versioned restriction of ParentCurrencyCode — includes historic/withdrawn currency codes in addition to active ones (contrast ActiveCurrencyCode, which is active-only).
/// Pattern facet from MCP get_code_set_details: [A-Z]{3,3}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_bqIp6tp-Ed-ak6NoX_4Aeg_1823330336")]
[Description(@"A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 ""Codes for the representation of currencies and funds"".")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ActiveOrHistoricCurrencyCode>))]
public readonly struct ActiveOrHistoricCurrencyCode : IIsoExternalCode, IEquatable<ActiveOrHistoricCurrencyCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[A-Z]{3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ActiveOrHistoricCurrencyCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ActiveOrHistoricCurrencyCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ActiveOrHistoricCurrencyCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ActiveOrHistoricCurrencyCode"/>.</summary>
    public static implicit operator ActiveOrHistoricCurrencyCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ActiveOrHistoricCurrencyCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ActiveOrHistoricCurrencyCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ActiveOrHistoricCurrencyCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ActiveOrHistoricCurrencyCode a, ActiveOrHistoricCurrencyCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ActiveOrHistoricCurrencyCode a, ActiveOrHistoricCurrencyCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ActiveOrHistoricCurrencyCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ActiveOrHistoricCurrencyCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ActiveOrHistoricCurrencyCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ActiveOrHistoricCurrencyCode b) => a != b.Value;
}
