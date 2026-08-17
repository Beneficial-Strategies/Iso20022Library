// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tracker notification sub type, as published in an external tracker notification sub type code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// No derivation relationship reported by MCP (unlike the similarly-named ExternalNotificationSubType1Code/Code pair, already implemented) - standalone type.
/// Length facet from MCP: minLength=1, maxLength=4
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_lF7dQEN-Ee-QZYT2pcGFZw")]
[Description(@"Specifies the tracker notification sub type, as published in an external tracker notification sub type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalTrackerNotificationSubTypeCode>))]
public readonly struct ExternalTrackerNotificationSubTypeCode : IIsoExternalCode, IEquatable<ExternalTrackerNotificationSubTypeCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalTrackerNotificationSubTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalTrackerNotificationSubTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalTrackerNotificationSubTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalTrackerNotificationSubTypeCode"/>.</summary>
    public static implicit operator ExternalTrackerNotificationSubTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalTrackerNotificationSubTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalTrackerNotificationSubTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalTrackerNotificationSubTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalTrackerNotificationSubTypeCode a, ExternalTrackerNotificationSubTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalTrackerNotificationSubTypeCode a, ExternalTrackerNotificationSubTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalTrackerNotificationSubTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalTrackerNotificationSubTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalTrackerNotificationSubTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalTrackerNotificationSubTypeCode b) => a != b.Value;
}
