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
/// &quot;Methode&quot; (with a trailing e) is ISO 20022's own spelling for this type name, preserved verbatim rather than corrected. Per MCP, a versioned restriction of ExternalPaymentMethodeCode.
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_966f0NEvEfCli6pH8hj5ag")]
[Description(@"Specifies the method of payment for the remittance of the invoicer to the invoicee.|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPaymentMethode1Code>))]
public readonly struct ExternalPaymentMethode1Code : IIsoExternalCode, IEquatable<ExternalPaymentMethode1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPaymentMethode1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPaymentMethode1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPaymentMethode1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPaymentMethode1Code"/>.</summary>
    public static implicit operator ExternalPaymentMethode1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPaymentMethode1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPaymentMethode1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPaymentMethode1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPaymentMethode1Code a, ExternalPaymentMethode1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPaymentMethode1Code a, ExternalPaymentMethode1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPaymentMethode1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPaymentMethode1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPaymentMethode1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPaymentMethode1Code b) => a != b.Value;
}
