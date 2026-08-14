// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of instrument or product to which the investigation refers, as published in an external investigation instrument code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_9cMNMFEUEe2YkcF60skG_A")]
[Description(@"Specifies the type of instrument or product to which the investigation refers, as published in an external investigation instrument code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationInstrument1Code>))]
public readonly struct ExternalInvestigationInstrument1Code : IIsoExternalCode, IEquatable<ExternalInvestigationInstrument1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation instrument code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationInstrument1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationInstrument1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationInstrument1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationInstrument1Code"/>.</summary>
    public static implicit operator ExternalInvestigationInstrument1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationInstrument1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationInstrument1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationInstrument1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationInstrument1Code a, ExternalInvestigationInstrument1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationInstrument1Code a, ExternalInvestigationInstrument1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationInstrument1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationInstrument1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationInstrument1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationInstrument1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation is related to an ACH or mass payment.</summary>
    [IsoId("___Q7K9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to an ACH or mass payment.")]
    public static readonly ExternalInvestigationInstrument1Code ACHOrMass = new("ACHP");

    /// <summary>Investigation is related to a card transaction.</summary>
    [IsoId("___Q7L9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a card transaction.")]
    public static readonly ExternalInvestigationInstrument1Code Card = new("CARD");

    /// <summary>Investigation is related to a cheque.</summary>
    [IsoId("___Q7JdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a cheque.")]
    public static readonly ExternalInvestigationInstrument1Code Cheque = new("CHQB");

    /// <summary>Investigation is related to a direct debit.</summary>
    [IsoId("___Q7LdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a direct debit.")]
    public static readonly ExternalInvestigationInstrument1Code DirectDebit = new("DDTP");

    /// <summary>Investigation is related to a draft.</summary>
    [IsoId("___Q7NdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a draft.")]
    public static readonly ExternalInvestigationInstrument1Code Draft = new("DRFT");

    /// <summary>Investigation is related to an instant credit transfer.</summary>
    [IsoId("___Q7J9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to an instant credit transfer.")]
    public static readonly ExternalInvestigationInstrument1Code InstantCreditTransfer = new("INST");

    /// <summary>Other underlying instrument.</summary>
    [IsoId("___Q7OdYUEe68t8Cw380-tA")]
    [Description(@"Other underlying instrument.")]
    public static readonly ExternalInvestigationInstrument1Code Other = new("OTHR");

    /// <summary>Investigation is related to a request to pay.</summary>
    [IsoId("___Q7N9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a request to pay.")]
    public static readonly ExternalInvestigationInstrument1Code RequestToPay = new("SRTP");

    /// <summary>Investigation is related to a statement entry.</summary>
    [IsoId("___Q7M9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a statement entry.")]
    public static readonly ExternalInvestigationInstrument1Code StatementEntry = new("STAT");

    /// <summary>Investigation is related to a wire/high value payment.</summary>
    [IsoId("___Q7MdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a wire/high value payment.")]
    public static readonly ExternalInvestigationInstrument1Code HVPOrWire = new("URGP");

    /// <summary>Investigation is related to a cross border payment.</summary>
    [IsoId("___Q7KdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a cross border payment.")]
    public static readonly ExternalInvestigationInstrument1Code CrossBorderCreditTransfer = new("XBCT");
}
