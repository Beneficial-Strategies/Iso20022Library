// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the industry sector according to a regulatory framework.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KejWwcA8Ee6Po8t8GRsqAQ")]
[Description(@"Specifies the industry sector according to a regulatory framework.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalIndustrySectorClassificationCode>))]
public readonly struct ExternalIndustrySectorClassificationCode : IIsoExternalCode, IEquatable<ExternalIndustrySectorClassificationCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given sector classification code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalIndustrySectorClassificationCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalIndustrySectorClassificationCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalIndustrySectorClassificationCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalIndustrySectorClassificationCode"/>.</summary>
    public static implicit operator ExternalIndustrySectorClassificationCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalIndustrySectorClassificationCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalIndustrySectorClassificationCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalIndustrySectorClassificationCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ExternalIndustrySectorClassificationCode a, ExternalIndustrySectorClassificationCode b) => a.Equals(b);
    public static bool operator !=(ExternalIndustrySectorClassificationCode a, ExternalIndustrySectorClassificationCode b) => !a.Equals(b);
    public static bool operator ==(ExternalIndustrySectorClassificationCode a, string? b) => a.Value == b;
    public static bool operator !=(ExternalIndustrySectorClassificationCode a, string? b) => a.Value != b;
    public static bool operator ==(string? a, ExternalIndustrySectorClassificationCode b) => a == b.Value;
    public static bool operator !=(string? a, ExternalIndustrySectorClassificationCode b) => a != b.Value;
}
