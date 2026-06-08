// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Indicates that the investment plan issued during all the previous years have to be transferred.</summary>
[DataContract]
[Serializable]
[IsoId("_YYxm2Np-Ed-ak6NoX_4Aeg_-1132097713")]
[Description(@"Indicates that the investment plan issued during all the previous years have to be transferred.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<PreviousAll>))]
public readonly struct PreviousAll : IIsoSimpleValue<string>, IEquatable<PreviousAll>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^ALL$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public PreviousAll(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(PreviousAll), value, Pattern);
        Value = value;
    }

    public static bool TryCreate(string? value, [NotNullWhen(true)] out PreviousAll result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    public static implicit operator PreviousAll(string value) => new(value);
    public static implicit operator string(PreviousAll t) => t.Value;
    public override string ToString() => Value ?? string.Empty;
    public bool Equals(PreviousAll other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is PreviousAll other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    public static bool operator ==(PreviousAll a, PreviousAll b) => a.Equals(b);
    public static bool operator !=(PreviousAll a, PreviousAll b) => !a.Equals(b);
    public static bool operator ==(PreviousAll a, string? b) => a.Value == b;
    public static bool operator !=(PreviousAll a, string? b) => a.Value != b;
    public static bool operator ==(string? a, PreviousAll b) => a == b.Value;
    public static bool operator !=(string? a, PreviousAll b) => a != b.Value;
}
