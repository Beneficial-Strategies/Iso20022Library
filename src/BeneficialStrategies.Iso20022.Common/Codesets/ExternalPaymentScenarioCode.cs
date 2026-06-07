// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment scenario, as published in an external payment scenario code set.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_12sPUGw8Ee-t2JGPeXy0Sw")]
[Description(@"Specifies the payment scenario, as published in an external payment scenario code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalPaymentScenario1Code))]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPaymentScenarioCode>))]
public readonly struct ExternalPaymentScenarioCode : IIsoExternalCode, IEquatable<ExternalPaymentScenarioCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given payment scenario code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPaymentScenarioCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPaymentScenarioCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPaymentScenarioCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPaymentScenarioCode"/>.</summary>
    public static implicit operator ExternalPaymentScenarioCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPaymentScenarioCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPaymentScenarioCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPaymentScenarioCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ExternalPaymentScenarioCode a, ExternalPaymentScenarioCode b) => a.Equals(b);
    public static bool operator !=(ExternalPaymentScenarioCode a, ExternalPaymentScenarioCode b) => !a.Equals(b);
    public static bool operator ==(ExternalPaymentScenarioCode a, string? b) => a.Value == b;
    public static bool operator !=(ExternalPaymentScenarioCode a, string? b) => a.Value != b;
    public static bool operator ==(string? a, ExternalPaymentScenarioCode b) => a == b.Value;
    public static bool operator !=(string? a, ExternalPaymentScenarioCode b) => a != b.Value;
}
