// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of regulatory reporting, as published in an external code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// Per MCP, a versioned restriction of the base ExternalRegulatoryReportingTypeCode (not itself part of this defect batch).
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_8T8SAHeKEfCdoODv2ypKfw")]
[Description(@"Specifies the type of regulatory reporting, as published in an external code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalRegulatoryReportingType1Code>))]
public readonly struct ExternalRegulatoryReportingType1Code : IIsoExternalCode, IEquatable<ExternalRegulatoryReportingType1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalRegulatoryReportingType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalRegulatoryReportingType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalRegulatoryReportingType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalRegulatoryReportingType1Code"/>.</summary>
    public static implicit operator ExternalRegulatoryReportingType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalRegulatoryReportingType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalRegulatoryReportingType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalRegulatoryReportingType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalRegulatoryReportingType1Code a, ExternalRegulatoryReportingType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalRegulatoryReportingType1Code a, ExternalRegulatoryReportingType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalRegulatoryReportingType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalRegulatoryReportingType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalRegulatoryReportingType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalRegulatoryReportingType1Code b) => a != b.Value;
}
