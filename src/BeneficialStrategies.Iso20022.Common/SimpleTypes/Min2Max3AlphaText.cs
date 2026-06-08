// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies an alpha string with a minimum length of 2 characters and a maximum length of 3 characters.</summary>
[DataContract]
[Serializable]
[IsoId("_4qROcGeeEeSh-d9-KfCEyA")]
[Description(@"Specifies an alpha string with a minimum length of 2 characters and a maximum length of 3 characters.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Min2Max3AlphaText>))]
public readonly struct Min2Max3AlphaText : IIsoSimpleValue<string>, IEquatable<Min2Max3AlphaText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[a-zA-Z]{2,3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public Min2Max3AlphaText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Min2Max3AlphaText), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Min2Max3AlphaText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator Min2Max3AlphaText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Min2Max3AlphaText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Min2Max3AlphaText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Min2Max3AlphaText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Min2Max3AlphaText a, Min2Max3AlphaText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Min2Max3AlphaText a, Min2Max3AlphaText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Min2Max3AlphaText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Min2Max3AlphaText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Min2Max3AlphaText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Min2Max3AlphaText b) => a != b.Value;
}
