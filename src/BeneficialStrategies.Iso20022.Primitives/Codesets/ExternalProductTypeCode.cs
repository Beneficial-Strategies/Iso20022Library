// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of asset class a non-equity financial instrument can be classified as.
/// </summary>
/// <remarks>
/// Per MCP, derived by ExternalProductType1Code.
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_RpYqYG8qEe6_0L6gLGEkbA")]
[Description(@"Specifies the type of asset class a non-equity financial instrument can be classified as.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalProductTypeCode>))]
public readonly struct ExternalProductTypeCode : IIsoExternalCode, IEquatable<ExternalProductTypeCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalProductTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalProductTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalProductTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalProductTypeCode"/>.</summary>
    public static implicit operator ExternalProductTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalProductTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalProductTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalProductTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalProductTypeCode a, ExternalProductTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalProductTypeCode a, ExternalProductTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalProductTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalProductTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalProductTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalProductTypeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Identifies categories of instruments that are commodities.</summary>
    [IsoId("_RpYqZm8qEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    public static readonly ExternalProductTypeCode Commodity = new("COMM");

    /// <summary>Identifies categories of instruments that are credits.</summary>
    [IsoId("_RpYqdG8qEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments that are credits.")]
    public static readonly ExternalProductTypeCode Credit = new("CRDT");

    /// <summary>Identifies categories of currency instruments.</summary>
    [IsoId("_RpYqcW8qEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of currency instruments.")]
    public static readonly ExternalProductTypeCode Currency = new("CURR");

    /// <summary>Identifies categories of instruments related to emission allowance.</summary>
    [IsoId("_RpYqbG8qEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments related to emission allowance.")]
    public static readonly ExternalProductTypeCode EmissionAllowance = new("EMAL");

    /// <summary>Identifies categories of instruments related to an equity.</summary>
    [IsoId("_RpYqZG8qEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments related to an equity.")]
    public static readonly ExternalProductTypeCode Equity = new("EQUI");

    /// <summary>Identifies categories of instruments that are interest rates based.</summary>
    [IsoId("_RpYqYW8qEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments that are interest rates based.")]
    public static readonly ExternalProductTypeCode InterestRate = new("INTR");

    /// <summary>Identifies categories of instruments classified as other C10.</summary>
    [IsoId("_K3u-IG8vEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments classified as other C10.")]
    public static readonly ExternalProductTypeCode OtherC10 = new("OCTN");
}
