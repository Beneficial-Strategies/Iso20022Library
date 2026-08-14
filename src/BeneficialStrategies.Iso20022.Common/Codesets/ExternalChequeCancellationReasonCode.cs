// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external cheque cancellation reason code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_5ApoQ7twEeq_cfXrH83Rcw")]
[Description(@"Specifies the external cheque cancellation reason code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalChequeCancellationReasonCode>))]
public readonly struct ExternalChequeCancellationReasonCode : IIsoExternalCode, IEquatable<ExternalChequeCancellationReasonCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given cheque cancellation reason code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalChequeCancellationReasonCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalChequeCancellationReasonCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalChequeCancellationReasonCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalChequeCancellationReasonCode"/>.</summary>
    public static implicit operator ExternalChequeCancellationReasonCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalChequeCancellationReasonCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalChequeCancellationReasonCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalChequeCancellationReasonCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalChequeCancellationReasonCode a, ExternalChequeCancellationReasonCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalChequeCancellationReasonCode a, ExternalChequeCancellationReasonCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalChequeCancellationReasonCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalChequeCancellationReasonCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalChequeCancellationReasonCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalChequeCancellationReasonCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Customer requested to stop/cancel the cheque.</summary>
    [IsoId("_gjEe0EDwEe6lGub-LSlOyg")]
    [Description(@"Customer requested to stop/cancel the cheque.")]
    public static readonly ExternalChequeCancellationReasonCode RequestedByCustomer = new("CUST");

    /// <summary>Cheque has been issued in duplication of another cheque.</summary>
    [IsoId("_a97l0EDxEe6lGub-LSlOyg")]
    [Description(@"Cheque has been issued in duplication of another cheque.")]
    public static readonly ExternalChequeCancellationReasonCode Duplicate = new("DUPL");

    /// <summary>Cheque has been issued fraudulently.</summary>
    [IsoId("_Qf1PQEDxEe6lGub-LSlOyg")]
    [Description(@"Cheque has been issued fraudulently.")]
    public static readonly ExternalChequeCancellationReasonCode Fraud = new("FRAD");

    /// <summary>Cheque has been stolen/lost.</summary>
    [IsoId("_v4UKgEDwEe6lGub-LSlOyg")]
    [Description(@"Cheque has been stolen/lost.")]
    public static readonly ExternalChequeCancellationReasonCode Lost = new("LOST");

    /// <summary>Reason is provided as narrative information in the additional reason information.</summary>
    [IsoId("_k_bf8EDxEe6lGub-LSlOyg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    public static readonly ExternalChequeCancellationReasonCode Narrative = new("NARR");
}
