// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// The International Securities Identification Number is a code allocated to financial instruments as described in the ISO 6166 standard.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rMvjUYIXEeWE0I8iABxEQA")]
[Description(@"The International Securities Identification Number is a code allocated to financial instruments as described in the ISO 6166 standard.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ISINOct2015Identifier>))]
public readonly struct ISINOct2015Identifier : IIsoSimpleValue<string>, IEquatable<ISINOct2015Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public ISINOct2015Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISINOct2015Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISINOct2015Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISINOct2015Identifier"/>.</summary>
    public static implicit operator ISINOct2015Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(ISINOct2015Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISINOct2015Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISINOct2015Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ISINOct2015Identifier a, ISINOct2015Identifier b)  => a.Equals(b);
    public static bool operator !=(ISINOct2015Identifier a, ISINOct2015Identifier b)  => !a.Equals(b);
    public static bool operator ==(ISINOct2015Identifier a, string? b)  => a.Value == b;
    public static bool operator !=(ISINOct2015Identifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, ISINOct2015Identifier b)  => a == b.Value;
    public static bool operator !=(string? a, ISINOct2015Identifier b)  => a != b.Value;
}
