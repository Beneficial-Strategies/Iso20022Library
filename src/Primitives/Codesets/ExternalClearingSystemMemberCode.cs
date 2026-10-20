// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external clearing system member code in the format of character string with a maximum length of 35 characters.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// Length facet from MCP: minLength=1, maxLength=35
/// registrationStatus=Obsolete in the ISO 20022 repository, removalDate 2022-12-31.
/// </remarks>
[Obsolete("registrationStatus=Obsolete in the ISO 20022 repository, removalDate 2022-12-31.")]
[DataContract]
[Serializable]
[IsoId("_amVqltp-Ed-ak6NoX_4Aeg_-1092960871")]
[Description(@"Specifies the external clearing system member code in the format of character string with a maximum length of 35 characters.|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalClearingSystemMemberCode>))]
public readonly struct ExternalClearingSystemMemberCode : IIsoExternalCode, IEquatable<ExternalClearingSystemMemberCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,35}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalClearingSystemMemberCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalClearingSystemMemberCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalClearingSystemMemberCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalClearingSystemMemberCode"/>.</summary>
    public static implicit operator ExternalClearingSystemMemberCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalClearingSystemMemberCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalClearingSystemMemberCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalClearingSystemMemberCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalClearingSystemMemberCode a, ExternalClearingSystemMemberCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalClearingSystemMemberCode a, ExternalClearingSystemMemberCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalClearingSystemMemberCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalClearingSystemMemberCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalClearingSystemMemberCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalClearingSystemMemberCode b) => a != b.Value;
}
