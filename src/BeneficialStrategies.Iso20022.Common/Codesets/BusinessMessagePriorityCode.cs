// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority levels for the BusinessMessage. The different priorities are typically user / service / implementation dependent. The semantics of the different values for a Mesage (Set) need to be defined by the relevant user community (SEG.).
/// </summary>
/// <remarks>
/// Valid values are defined externally by the relevant user community and are not enumerated
/// in the ISO 20022 eRepository. Use <c>new BusinessMessagePriorityCode("NORM")</c> (or any
/// community-defined string satisfying <see cref="Pattern"/>) to assign a value.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_BusinessMessagePriorityCode")]
[Description(
    @"Specifies the priority levels for the BusinessMessage. The different priorities are typically user / service / implementation dependent. The semantics of the different values for a Mesage (Set) need to be defined by the relevant user community (SEG.)."
)]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<BusinessMessagePriorityCode>))]
public readonly struct BusinessMessagePriorityCode
    : IIsoExternalCode, IEquatable<BusinessMessagePriorityCode>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9]{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code string.</summary>
    /// <exception cref="Iso20022FormatException">
    /// Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public BusinessMessagePriorityCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(BusinessMessagePriorityCode), value, Pattern);
        Value = value;
    }

    /// <summary>
    /// Returns <see langword="true"/> and a valid instance when <paramref name="value"/>
    /// satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.
    /// </summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out BusinessMessagePriorityCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="BusinessMessagePriorityCode"/>.</summary>
    public static implicit operator BusinessMessagePriorityCode(string value) => new(value);

    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(BusinessMessagePriorityCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;

    /// <inheritdoc/>
    public bool Equals(BusinessMessagePriorityCode other) => Value == other.Value;

    /// <inheritdoc/>
    public override bool Equals(object? obj) =>
        obj is BusinessMessagePriorityCode other && Equals(other);

    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc cref="Equals(BusinessMessagePriorityCode)"/>
    public static bool operator ==(BusinessMessagePriorityCode a, BusinessMessagePriorityCode b) =>
        a.Equals(b);

    /// <inheritdoc cref="Equals(BusinessMessagePriorityCode)"/>
    public static bool operator !=(BusinessMessagePriorityCode a, BusinessMessagePriorityCode b) =>
        !a.Equals(b);

    /// <summary>Compares the code value to a raw string without constructing a new instance.</summary>
    public static bool operator ==(BusinessMessagePriorityCode a, string? b) => a.Value == b;
    /// <inheritdoc cref="op_Equality(BusinessMessagePriorityCode,string)"/>
    public static bool operator !=(BusinessMessagePriorityCode a, string? b) => a.Value != b;
    /// <inheritdoc cref="op_Equality(BusinessMessagePriorityCode,string)"/>
    public static bool operator ==(string? a, BusinessMessagePriorityCode b) => a == b.Value;
    /// <inheritdoc cref="op_Equality(BusinessMessagePriorityCode,string)"/>
    public static bool operator !=(string? a, BusinessMessagePriorityCode b) => a != b.Value;
}
