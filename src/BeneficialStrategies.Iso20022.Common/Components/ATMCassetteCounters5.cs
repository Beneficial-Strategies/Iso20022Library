// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Cassette Counters5.
/// </summary>
[IsoId("_L-0XIZ9NEe-nbM0aSPcoiQ")]
[DisplayName("ATM Cassette Counters5")]
public record ATMCassetteCounters5
{
    /// <summary>
    /// Added Number.
    /// </summary>
    [DisplayName("Added Number")]
    [IsoXmlTag("AddedNb")]
    public IsoNumber? AddedNumber { get; init; }

    /// <summary>
    /// Deposited Amount.
    /// </summary>
    [DisplayName("Deposited Amount")]
    [IsoXmlTag("DpstdAmt")]
    public ImpliedCurrencyAndAmount? DepositedAmount { get; init; }

    /// <summary>
    /// Deposited Number.
    /// </summary>
    [DisplayName("Deposited Number")]
    [IsoXmlTag("DpstdNb")]
    public IsoNumber? DepositedNumber { get; init; }

    /// <summary>
    /// Dispensed Number.
    /// </summary>
    [DisplayName("Dispensed Number")]
    [IsoXmlTag("DspnsdNb")]
    public IsoNumber? DispensedNumber { get; init; }

    /// <summary>
    /// Initial Amount.
    /// </summary>
    [DisplayName("Initial Amount")]
    [IsoXmlTag("InitlAmt")]
    public ImpliedCurrencyAndAmount? InitialAmount { get; init; }

    /// <summary>
    /// Initial Number.
    /// </summary>
    [DisplayName("Initial Number")]
    [IsoXmlTag("InitlNb")]
    public IsoNumber? InitialNumber { get; init; }

    /// <summary>
    /// Presented Number.
    /// </summary>
    [DisplayName("Presented Number")]
    [IsoXmlTag("PresntdNb")]
    public IsoNumber? PresentedNumber { get; init; }

    /// <summary>
    /// Recycled Number.
    /// </summary>
    [DisplayName("Recycled Number")]
    [IsoXmlTag("RcycldNb")]
    public IsoNumber? RecycledNumber { get; init; }

    /// <summary>
    /// Rejected Number.
    /// </summary>
    [DisplayName("Rejected Number")]
    [IsoXmlTag("RjctdNb")]
    public IsoNumber? RejectedNumber { get; init; }

    /// <summary>
    /// Removed Amount.
    /// </summary>
    [DisplayName("Removed Amount")]
    [IsoXmlTag("RmvdAmt")]
    public ImpliedCurrencyAndAmount? RemovedAmount { get; init; }

    /// <summary>
    /// Removed Number.
    /// </summary>
    [DisplayName("Removed Number")]
    [IsoXmlTag("RmvdNb")]
    public IsoNumber? RemovedNumber { get; init; }

    /// <summary>
    /// Retracted Amount.
    /// </summary>
    [DisplayName("Retracted Amount")]
    [IsoXmlTag("RtrctdAmt")]
    public ImpliedCurrencyAndAmount? RetractedAmount { get; init; }

    /// <summary>
    /// Retracted Number.
    /// </summary>
    [DisplayName("Retracted Number")]
    [IsoXmlTag("RtrctdNb")]
    public IsoNumber? RetractedNumber { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCounterType3Code Type { get; init; }
}
