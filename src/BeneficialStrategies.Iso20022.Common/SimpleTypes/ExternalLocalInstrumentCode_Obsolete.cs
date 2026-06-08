// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies the external local instrument code in the format of character string with a maximum length of 35 characters. The list of valid codes is an external code list published separately.</summary>
[DataContract]
[Serializable]
[IsoId("_ame0gtp-Ed-ak6NoX_4Aeg_-386465801")]
[Description(@"Specifies the external local instrument code in the format of character string with a maximum length of 35 characters. The list of valid codes is an external code list published separately.")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ExternalLocalInstrumentCode_Obsolete>))]
public readonly struct ExternalLocalInstrumentCode_Obsolete : IIsoSimpleValue<string>, IEquatable<ExternalLocalInstrumentCode_Obsolete>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 35;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with TooShort or TooLong.</exception>
    public ExternalLocalInstrumentCode_Obsolete(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(ExternalLocalInstrumentCode_Obsolete), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(ExternalLocalInstrumentCode_Obsolete), value, MaxLength);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ExternalLocalInstrumentCode_Obsolete result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <inheritdoc/>
    public static implicit operator ExternalLocalInstrumentCode_Obsolete(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(ExternalLocalInstrumentCode_Obsolete t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalLocalInstrumentCode_Obsolete other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalLocalInstrumentCode_Obsolete other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(ExternalLocalInstrumentCode_Obsolete a, ExternalLocalInstrumentCode_Obsolete b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalLocalInstrumentCode_Obsolete a, ExternalLocalInstrumentCode_Obsolete b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalLocalInstrumentCode_Obsolete a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalLocalInstrumentCode_Obsolete a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalLocalInstrumentCode_Obsolete b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalLocalInstrumentCode_Obsolete b) => a != b.Value;
}
