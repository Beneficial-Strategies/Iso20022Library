// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of regulatory information.
/// </summary>
/// <remarks>
/// Per MCP, a versioned restriction of ExternalRegulatoryInformationTypeCode.
/// Exact-length facet from MCP: length=6 (a fixed xs:length facet, not a minLength/maxLength range — verified via forceVerbose raw XMI properties).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YIGo0OIXEe-eFYnrXcX-mQ")]
[Description(@"Specifies the type of regulatory information.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalRegulatoryInformationType1Code>))]
public readonly struct ExternalRegulatoryInformationType1Code : IIsoExternalCode, IEquatable<ExternalRegulatoryInformationType1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalRegulatoryInformationType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalRegulatoryInformationType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalRegulatoryInformationType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalRegulatoryInformationType1Code"/>.</summary>
    public static implicit operator ExternalRegulatoryInformationType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalRegulatoryInformationType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalRegulatoryInformationType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalRegulatoryInformationType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalRegulatoryInformationType1Code a, ExternalRegulatoryInformationType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalRegulatoryInformationType1Code a, ExternalRegulatoryInformationType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalRegulatoryInformationType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalRegulatoryInformationType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalRegulatoryInformationType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalRegulatoryInformationType1Code b) => a != b.Value;
}
