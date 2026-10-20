// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of instrument or product to which the exception/investigation refers, as published in an external investigation instrument code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_umAlME8pEe23pvrrPZbpBg")]
[Description(@"Specifies the type of instrument or product to which the exception/investigation refers, as published in an external investigation instrument code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationInstrumentCode>))]
public readonly struct ExternalInvestigationInstrumentCode : IIsoExternalCode, IEquatable<ExternalInvestigationInstrumentCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation instrument code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationInstrumentCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationInstrumentCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationInstrumentCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationInstrumentCode"/>.</summary>
    public static implicit operator ExternalInvestigationInstrumentCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationInstrumentCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationInstrumentCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationInstrumentCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationInstrumentCode a, ExternalInvestigationInstrumentCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationInstrumentCode a, ExternalInvestigationInstrumentCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationInstrumentCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationInstrumentCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationInstrumentCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationInstrumentCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation is related to an ACH or mass payment.</summary>
    [IsoId("__-YKPNYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to an ACH or mass payment.")]
    public static readonly ExternalInvestigationInstrumentCode ACHOrMass = new("ACHP");

    /// <summary>Investigation is related to a card transaction.</summary>
    [IsoId("__-YKPtYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a card transaction.")]
    public static readonly ExternalInvestigationInstrumentCode Card = new("CARD");

    /// <summary>Investigation is related to a cheque.</summary>
    [IsoId("__-YKOdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a cheque.")]
    public static readonly ExternalInvestigationInstrumentCode Cheque = new("CHQB");

    /// <summary>Investigation is related to a direct debit.</summary>
    [IsoId("__-YKPdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a direct debit.")]
    public static readonly ExternalInvestigationInstrumentCode DirectDebit = new("DDTP");

    /// <summary>Investigation is related to a draft.</summary>
    [IsoId("__-YKQdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a draft.")]
    public static readonly ExternalInvestigationInstrumentCode Draft = new("DRFT");

    /// <summary>Investigation is related to an instant credit transfer.</summary>
    [IsoId("__-YKOtYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to an instant credit transfer.")]
    public static readonly ExternalInvestigationInstrumentCode InstantCreditTransfer = new("INST");

    /// <summary>Other underlying instrument.</summary>
    [IsoId("__-YKQ9YUEe68t8Cw380-tA")]
    [Description(@"Other underlying instrument.")]
    public static readonly ExternalInvestigationInstrumentCode Other = new("OTHR");

    /// <summary>Investigation is related to a request to pay.</summary>
    [IsoId("__-YKQtYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a request to pay.")]
    public static readonly ExternalInvestigationInstrumentCode RequestToPay = new("SRTP");

    /// <summary>Investigation is related to a statement entry.</summary>
    [IsoId("__-YKQNYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a statement entry.")]
    public static readonly ExternalInvestigationInstrumentCode StatementEntry = new("STAT");

    /// <summary>Investigation is related to a wire/high value payment.</summary>
    [IsoId("__-YKP9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a wire/high value payment.")]
    public static readonly ExternalInvestigationInstrumentCode HVPOrWire = new("URGP");

    /// <summary>Investigation is related to a cross border payment.</summary>
    [IsoId("__-YKO9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a cross border payment.")]
    public static readonly ExternalInvestigationInstrumentCode CrossBorderCreditTransfer = new("XBCT");
}
