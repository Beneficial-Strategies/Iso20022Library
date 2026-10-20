// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external cheque cancellation status code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_wRR507tvEeq_cfXrH83Rcw")]
[Description(@"Specifies the external cheque cancellation status code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalChequeCancellationStatusCode>))]
public readonly struct ExternalChequeCancellationStatusCode : IIsoExternalCode, IEquatable<ExternalChequeCancellationStatusCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given cheque cancellation status code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalChequeCancellationStatusCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalChequeCancellationStatusCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalChequeCancellationStatusCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalChequeCancellationStatusCode"/>.</summary>
    public static implicit operator ExternalChequeCancellationStatusCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalChequeCancellationStatusCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalChequeCancellationStatusCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalChequeCancellationStatusCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalChequeCancellationStatusCode a, ExternalChequeCancellationStatusCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalChequeCancellationStatusCode a, ExternalChequeCancellationStatusCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalChequeCancellationStatusCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalChequeCancellationStatusCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalChequeCancellationStatusCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalChequeCancellationStatusCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Cheque cancellation request or request to stop the cheque is accepted.</summary>
    [IsoId("_iwuXQEDyEe6lGub-LSlOyg")]
    [Description(@"Cheque cancellation request or request to stop the cheque is accepted.")]
    public static readonly ExternalChequeCancellationStatusCode AcceptedCancellationOrStopChequeRequest = new("ACCR");

    /// <summary>Cheque cancellation request or request to stop the cheque is rejected.</summary>
    [IsoId("_8D_nwEDxEe6lGub-LSlOyg")]
    [Description(@"Cheque cancellation request or request to stop the cheque is rejected.")]
    public static readonly ExternalChequeCancellationStatusCode RejectedCancellationOrStopChequeRequest = new("RJCR");
}
