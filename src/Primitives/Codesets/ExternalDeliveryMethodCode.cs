// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external delivery method code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
/// <remarks>
/// External code set — length facet (1 to 4 characters) confirmed via MCP get_code_set_details;
/// no registry member data published in the current snapshot ("No code values are published for
/// this code set in the current snapshot"). Kept permissive per CLAUDE.md's external-standard-
/// exception guidance rather than guessing at a narrower character class.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_XaObwOOvEe-NFYIkYc90gw")]
[Description(@"Specifies the external delivery method code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalDeliveryMethodCode>))]
public readonly struct ExternalDeliveryMethodCode : IIsoExternalCode, IEquatable<ExternalDeliveryMethodCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalDeliveryMethodCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalDeliveryMethodCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalDeliveryMethodCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalDeliveryMethodCode"/>.</summary>
    public static implicit operator ExternalDeliveryMethodCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalDeliveryMethodCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalDeliveryMethodCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalDeliveryMethodCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalDeliveryMethodCode a, ExternalDeliveryMethodCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalDeliveryMethodCode a, ExternalDeliveryMethodCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalDeliveryMethodCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalDeliveryMethodCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalDeliveryMethodCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalDeliveryMethodCode b) => a != b.Value;
}
