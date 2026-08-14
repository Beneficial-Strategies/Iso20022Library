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
[IsoId("_5vuigFEUEe2YkcF60skG_A")]
[Description(@"Specifies the investigation sub type, as published in an external investigation sub type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationSubType1Code>))]
public readonly struct ExternalInvestigationSubType1Code : IIsoExternalCode, IEquatable<ExternalInvestigationSubType1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation sub type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationSubType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationSubType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationSubType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationSubType1Code"/>.</summary>
    public static implicit operator ExternalInvestigationSubType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationSubType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationSubType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationSubType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationSubType1Code a, ExternalInvestigationSubType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationSubType1Code a, ExternalInvestigationSubType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationSubType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationSubType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationSubType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationSubType1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation relates to anti-money laundering.</summary>
    [IsoId("___Q7GdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to anti-money laundering.")]
    public static readonly ExternalInvestigationSubType1Code AntiMoneyLaundering = new("AMLI");

    /// <summary>Investigation relates to financial crimes compliance.</summary>
    [IsoId("___Q7IdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to financial crimes compliance.")]
    public static readonly ExternalInvestigationSubType1Code FinancialCrimeCompliance = new("FCCI");

    /// <summary>Investigation relates to fraud.</summary>
    [IsoId("___Q7HdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to fraud.")]
    public static readonly ExternalInvestigationSubType1Code Fraud = new("FRAD");

    /// <summary>Investigation relates to funds/wire transfer regulation.</summary>
    [IsoId("___Q7I9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to funds/wire transfer regulation.")]
    public static readonly ExternalInvestigationSubType1Code FundsWireTransferRegulation = new("FWTR");

    /// <summary>Other</summary>
    [IsoId("_wPOmYcnxEfCY0M4eFzOwyQ")]
    [Description(@"Other")]
    public static readonly ExternalInvestigationSubType1Code Other = new("OTHR");

    /// <summary>Investigation relating to charges that have been taken or are requested.</summary>
    [IsoId("_q1gvssnxEfCY0M4eFzOwyQ")]
    [Description(@"Investigation relating to charges that have been taken or are requested.")]
    public static readonly ExternalInvestigationSubType1Code RequestRelatedToCharges = new("RQCH");

    /// <summary>Debit authorisation on an entry is requested.</summary>
    [IsoId("_O8bwAsnxEfCY0M4eFzOwyQ")]
    [Description(@"Debit authorisation on an entry is requested.")]
    public static readonly ExternalInvestigationSubType1Code RequestDebitAuthorisation = new("RQDA");

    /// <summary>Use of funds on an entry is requested.</summary>
    [IsoId("__7fgYsnwEfCY0M4eFzOwyQ")]
    [Description(@"Use of funds on an entry is requested.")]
    public static readonly ExternalInvestigationSubType1Code RequestUseOfFunds = new("RQUF");

    /// <summary>Revaluation of an entry is requested.</summary>
    [IsoId("_g-4o0cnxEfCY0M4eFzOwyQ")]
    [Description(@"Revaluation of an entry is requested.")]
    public static readonly ExternalInvestigationSubType1Code RequestValueDateAdjustment = new("RQVA");

    /// <summary>Investigation relates to sanctions.</summary>
    [IsoId("___Q7G9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to sanctions.")]
    public static readonly ExternalInvestigationSubType1Code Sanctions = new("SANC");

    /// <summary>Investigation relates to a transaction that cannot be executed.</summary>
    [IsoId("___Q7H9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to a transaction that cannot be executed.")]
    public static readonly ExternalInvestigationSubType1Code UnableToExecute = new("UTEX");
}
