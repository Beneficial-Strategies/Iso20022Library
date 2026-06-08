// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external instruction code, as provided to a cheque agent for processing, in the format of character string with a maximum length of 4 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ak80ebtoEeq_cfXrH83Rcw")]
[Description(@"Specifies the external instruction code, as provided to a cheque agent for processing, in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalChequeAgentInstructionCode))]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalChequeAgentInstruction1Code>))]
public readonly struct ExternalChequeAgentInstruction1Code : IIsoExternalCode, IEquatable<ExternalChequeAgentInstruction1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given instruction code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalChequeAgentInstruction1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalChequeAgentInstruction1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalChequeAgentInstruction1Code result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalChequeAgentInstruction1Code"/>.</summary>
    public static implicit operator ExternalChequeAgentInstruction1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalChequeAgentInstruction1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalChequeAgentInstruction1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalChequeAgentInstruction1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalChequeAgentInstruction1Code a, ExternalChequeAgentInstruction1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalChequeAgentInstruction1Code a, ExternalChequeAgentInstruction1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalChequeAgentInstruction1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalChequeAgentInstruction1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalChequeAgentInstruction1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalChequeAgentInstruction1Code b) => a != b.Value;
}
