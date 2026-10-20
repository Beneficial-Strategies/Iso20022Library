// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction or adjustment, as provided to the instructed agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEAp2bt6Eeq_cfXrH83Rcw")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction or adjustment, as provided to the instructed agent.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInstructedAgentInstruction1Code>))]
public readonly struct ExternalInstructedAgentInstruction1Code : IIsoExternalCode, IEquatable<ExternalInstructedAgentInstruction1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given instructed agent instruction code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInstructedAgentInstruction1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInstructedAgentInstruction1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInstructedAgentInstruction1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInstructedAgentInstruction1Code"/>.</summary>
    public static implicit operator ExternalInstructedAgentInstruction1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInstructedAgentInstruction1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInstructedAgentInstruction1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInstructedAgentInstruction1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInstructedAgentInstruction1Code a, ExternalInstructedAgentInstruction1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInstructedAgentInstruction1Code a, ExternalInstructedAgentInstruction1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInstructedAgentInstruction1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInstructedAgentInstruction1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInstructedAgentInstruction1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInstructedAgentInstruction1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Reminder. A charge request message has been previously sent.</summary>
    [IsoId("_sGUQEtVPEe62uOJHIwvcig")]
    [Description(@"Reminder. A charge request message has been previously sent.")]
    public static readonly ExternalInstructedAgentInstruction1Code Reminder = new("REMD");
}
