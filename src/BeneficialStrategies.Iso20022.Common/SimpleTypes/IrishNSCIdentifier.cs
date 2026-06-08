// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Irish National Sorting Code. Identifies Irish financial institutions on the Irish national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXSZEdp-Ed-ak6NoX_4Aeg_-870707931")]
[Description(@"Irish National Sorting Code. Identifies Irish financial institutions on the Irish national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<IrishNSCIdentifier>))]
public readonly struct IrishNSCIdentifier : IIsoSimpleValue<string>, IEquatable<IrishNSCIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^IE[0-9]{6,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public IrishNSCIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(IrishNSCIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out IrishNSCIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="IrishNSCIdentifier"/>.</summary>
    public static implicit operator IrishNSCIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(IrishNSCIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(IrishNSCIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is IrishNSCIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(IrishNSCIdentifier a, IrishNSCIdentifier b) => a.Equals(b);
    public static bool operator !=(IrishNSCIdentifier a, IrishNSCIdentifier b) => !a.Equals(b);
    public static bool operator ==(IrishNSCIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(IrishNSCIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, IrishNSCIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, IrishNSCIdentifier b) => a != b.Value;
}
