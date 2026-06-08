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
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_amVqltp-Ed-ak6NoX_4Aeg_-1092960871")]
[Description(@"Specifies the external clearing system member code in the format of character string with a maximum length of 35 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Obsolete("Marked obsolete in the ISO 20022 2026-05-11 snapshot. No removal date recorded.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalClearingSystemMemberCode_Obsolete>))]
public readonly struct ExternalClearingSystemMemberCode_Obsolete : IIsoExternalCode, IEquatable<ExternalClearingSystemMemberCode_Obsolete>
{
    /// <summary>ISO 20022 format constraint — 1 to 35 characters.</summary>
    public const string Pattern = @"^.{1,35}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given clearing system member code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalClearingSystemMemberCode_Obsolete(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalClearingSystemMemberCode_Obsolete), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalClearingSystemMemberCode_Obsolete result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalClearingSystemMemberCode_Obsolete"/>.</summary>
    public static implicit operator ExternalClearingSystemMemberCode_Obsolete(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalClearingSystemMemberCode_Obsolete code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalClearingSystemMemberCode_Obsolete other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalClearingSystemMemberCode_Obsolete other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalClearingSystemMemberCode_Obsolete a, ExternalClearingSystemMemberCode_Obsolete b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalClearingSystemMemberCode_Obsolete a, ExternalClearingSystemMemberCode_Obsolete b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalClearingSystemMemberCode_Obsolete a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalClearingSystemMemberCode_Obsolete a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalClearingSystemMemberCode_Obsolete b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalClearingSystemMemberCode_Obsolete b) => a != b.Value;
}
