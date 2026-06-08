// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Domain identifier for NACE (Nomenclature of Economic Activities) as per rev2.1 to be used from 2025 onwards.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PO-voNpOEe-dLoCRY6a1wQ")]
[Description(@"Domain identifier for NACE (Nomenclature of Economic Activities) as per rev2.1 to be used from 2025 onwards.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<NACEDomain2025Identifier>))]
public readonly struct NACEDomain2025Identifier : IIsoSimpleValue<string>, IEquatable<NACEDomain2025Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-V]{1,1}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public NACEDomain2025Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(NACEDomain2025Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out NACEDomain2025Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="NACEDomain2025Identifier"/>.</summary>
    public static implicit operator NACEDomain2025Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(NACEDomain2025Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(NACEDomain2025Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is NACEDomain2025Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(NACEDomain2025Identifier a, NACEDomain2025Identifier b) => a.Equals(b);
    public static bool operator !=(NACEDomain2025Identifier a, NACEDomain2025Identifier b) => !a.Equals(b);
    public static bool operator ==(NACEDomain2025Identifier a, string? b) => a.Value == b;
    public static bool operator !=(NACEDomain2025Identifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, NACEDomain2025Identifier b) => a == b.Value;
    public static bool operator !=(string? a, NACEDomain2025Identifier b) => a != b.Value;
}
