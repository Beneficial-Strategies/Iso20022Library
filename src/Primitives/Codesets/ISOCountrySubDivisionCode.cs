// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify an area of geopolitical interest, based on names obtained from the United Nations ISO 3166-2 or the local authority.
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [A-Z]{2,3}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_7Zt_EBvJEey2RdTw-AkXzg")]
[Description(@"Code to identify an area of geopolitical interest, based on names obtained from the United Nations ISO 3166-2 or the local authority.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISOCountrySubDivisionCode>))]
public readonly struct ISOCountrySubDivisionCode : IIsoExternalCode, IEquatable<ISOCountrySubDivisionCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[A-Z]{2,3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISOCountrySubDivisionCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISOCountrySubDivisionCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISOCountrySubDivisionCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISOCountrySubDivisionCode"/>.</summary>
    public static implicit operator ISOCountrySubDivisionCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISOCountrySubDivisionCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISOCountrySubDivisionCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISOCountrySubDivisionCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISOCountrySubDivisionCode a, ISOCountrySubDivisionCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISOCountrySubDivisionCode a, ISOCountrySubDivisionCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISOCountrySubDivisionCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOCountrySubDivisionCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISOCountrySubDivisionCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISOCountrySubDivisionCode b) => a != b.Value;
}
