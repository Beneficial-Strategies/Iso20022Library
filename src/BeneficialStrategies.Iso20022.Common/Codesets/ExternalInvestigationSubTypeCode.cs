// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation sub type, as published in an external investigation sub type code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_W99OIEk8Ee2pGuIgvBXIzg")]
[Description(@"Specifies the investigation sub type, as published in an external investigation sub type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationSubTypeCode>))]
public readonly struct ExternalInvestigationSubTypeCode : IIsoExternalCode, IEquatable<ExternalInvestigationSubTypeCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation sub type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationSubTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationSubTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationSubTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationSubTypeCode"/>.</summary>
    public static implicit operator ExternalInvestigationSubTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationSubTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationSubTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationSubTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationSubTypeCode a, ExternalInvestigationSubTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationSubTypeCode a, ExternalInvestigationSubTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationSubTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationSubTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationSubTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationSubTypeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation relates to anti-money laundering.</summary>
    [IsoId("__-YKM9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to anti-money laundering.")]
    public static readonly ExternalInvestigationSubTypeCode AntiMoneyLaundering = new("AMLI");

    /// <summary>Investigation relates to financial crimes compliance.</summary>
    [IsoId("__-YKN9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to financial crimes compliance.")]
    public static readonly ExternalInvestigationSubTypeCode FinancialCrimeCompliance = new("FCCI");

    /// <summary>Investigation relates to fraud.</summary>
    [IsoId("__-YKNdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to fraud.")]
    public static readonly ExternalInvestigationSubTypeCode Fraud = new("FRAD");

    /// <summary>Investigation relates to funds/wire transfer regulation.</summary>
    [IsoId("__-YKONYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to funds/wire transfer regulation.")]
    public static readonly ExternalInvestigationSubTypeCode FundsWireTransferRegulation = new("FWTR");

    /// <summary>Other</summary>
    [IsoId("_wPN_UMnxEfCY0M4eFzOwyQ")]
    [Description(@"Other")]
    public static readonly ExternalInvestigationSubTypeCode Other = new("OTHR");

    /// <summary>Investigation relating to charges that have been taken or are requested.</summary>
    [IsoId("_q1gvsMnxEfCY0M4eFzOwyQ")]
    [Description(@"Investigation relating to charges that have been taken or are requested.")]
    public static readonly ExternalInvestigationSubTypeCode RequestRelatedToCharges = new("RQCH");

    /// <summary>Debit authorisation on an entry is requested.</summary>
    [IsoId("_O8bwAMnxEfCY0M4eFzOwyQ")]
    [Description(@"Debit authorisation on an entry is requested.")]
    public static readonly ExternalInvestigationSubTypeCode RequestDebitAuthorisation = new("RQDA");

    /// <summary>Use of funds on an entry is requested.</summary>
    [IsoId("__7fgYMnwEfCY0M4eFzOwyQ")]
    [Description(@"Use of funds on an entry is requested.")]
    public static readonly ExternalInvestigationSubTypeCode RequestUseOfFunds = new("RQUF");

    /// <summary>Revaluation of an entry is requested.</summary>
    [IsoId("_g-4BwMnxEfCY0M4eFzOwyQ")]
    [Description(@"Revaluation of an entry is requested.")]
    public static readonly ExternalInvestigationSubTypeCode RequestValueDateAdjustment = new("RQVA");

    /// <summary>Investigation relates to sanctions.</summary>
    [IsoId("__-YKNNYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to sanctions.")]
    public static readonly ExternalInvestigationSubTypeCode Sanctions = new("SANC");

    /// <summary>Investigation relates to a transaction that cannot be executed.</summary>
    [IsoId("__-YKNtYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to a transaction that cannot be executed.")]
    public static readonly ExternalInvestigationSubTypeCode UnableToExecute = new("UTEX");
}
