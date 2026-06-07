// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the mandate setup reason, as published in an external mandate setup reason code set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hsQScD2MEeS6DKIV6SF6gw")]
[Description(@"Specifies the mandate setup reason, as published in an external mandate setup reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalMandateSetupReasonCode))]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalMandateSetupReason1Code>))]
public readonly struct ExternalMandateSetupReason1Code : IIsoExternalCode, IEquatable<ExternalMandateSetupReason1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given mandate setup reason code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalMandateSetupReason1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalMandateSetupReason1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalMandateSetupReason1Code result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalMandateSetupReason1Code"/>.</summary>
    public static implicit operator ExternalMandateSetupReason1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalMandateSetupReason1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalMandateSetupReason1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalMandateSetupReason1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ExternalMandateSetupReason1Code a, ExternalMandateSetupReason1Code b) => a.Equals(b);
    public static bool operator !=(ExternalMandateSetupReason1Code a, ExternalMandateSetupReason1Code b) => !a.Equals(b);
    public static bool operator ==(ExternalMandateSetupReason1Code a, string? b) => a.Value == b;
    public static bool operator !=(ExternalMandateSetupReason1Code a, string? b) => a.Value != b;
    public static bool operator ==(string? a, ExternalMandateSetupReason1Code b) => a == b.Value;
    public static bool operator !=(string? a, ExternalMandateSetupReason1Code b) => a != b.Value;
}
