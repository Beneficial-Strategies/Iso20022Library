// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method of payment for the remittance of the invoicer to the invoicee.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// &quot;Methode&quot; (with a trailing e) is ISO 20022's own spelling for this type name, preserved verbatim rather than corrected. Per MCP, derived by ExternalPaymentMethode1Code.
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_izwsUNEvEfCli6pH8hj5ag")]
[Description(@"Specifies the method of payment for the remittance of the invoicer to the invoicee.|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPaymentMethodeCode>))]
public readonly struct ExternalPaymentMethodeCode : IIsoExternalCode, IEquatable<ExternalPaymentMethodeCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPaymentMethodeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPaymentMethodeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPaymentMethodeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPaymentMethodeCode"/>.</summary>
    public static implicit operator ExternalPaymentMethodeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPaymentMethodeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPaymentMethodeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPaymentMethodeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPaymentMethodeCode a, ExternalPaymentMethodeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPaymentMethodeCode a, ExternalPaymentMethodeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPaymentMethodeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPaymentMethodeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPaymentMethodeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPaymentMethodeCode b) => a != b.Value;
}
