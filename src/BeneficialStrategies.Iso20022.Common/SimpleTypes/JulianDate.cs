// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Date in form yddd format where y=0-9 (year within decade), ddd=001-366 (day of year).</summary>
[DataContract]
[Serializable]
[IsoId("_AtIIESnUEfCD0_iZ8tw-zA")]
[Description(@"Date in form yddd format where y=0-9 (year within decade), ddd=001-366 (day of year).")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<JulianDate>))]
public readonly struct JulianDate : IIsoSimpleValue<string>, IEquatable<JulianDate>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[0-9](00[1-9]|0[1-9][0-9]|[12][0-9]{2}|3[0-5][0-9]|36[0-6])$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public JulianDate(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(JulianDate), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out JulianDate result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator JulianDate(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(JulianDate t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(JulianDate other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is JulianDate other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(JulianDate a, JulianDate b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(JulianDate a, JulianDate b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(JulianDate a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(JulianDate a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, JulianDate b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, JulianDate b) => a != b.Value;
}
