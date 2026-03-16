// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the status of a transfer instruction and its reason.
/// </summary>
[IsoId("_Z8uG8VNUEeijdq8ilaxyOA")]
[DisplayName("Transfer Status And Reason")]
public record TransferStatusAndReason6
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_aOIAA1NUEeijdq8ilaxyOA")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_aOIABVNUEeijdq8ilaxyOA")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_aOIAB1NUEeijdq8ilaxyOA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_aOIACVNUEeijdq8ilaxyOA")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Type of event for which the message is sent.
    /// </summary>
    [IsoId("_A-_MIFNWEeijdq8ilaxyOA")]
    [DisplayName("Transfer Event Type")]
    [IsoXmlTag("TrfEvtTp")]
    public TransferStatusType1Choice_? TransferEventType { get; init; }

    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_aOIAC1NUEeijdq8ilaxyOA")]
    [DisplayName("Transfer Status")]
    [IsoXmlTag("TrfSts")]
    public required TransferStatus3Choice_ TransferStatus { get; init; }

    /// <summary>
    /// Date on which the transfer was executed.
    /// In some scenarios, this is the date and time to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_aOIADVNUEeijdq8ilaxyOA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date at which the securities are to be exchanged or were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_inRw8Oi9EeifCsigq7uLaQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("_aOIAD1NUEeijdq8ilaxyOA")]
    [DisplayName("Send Out Date")]
    [IsoXmlTag("SndOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SendOutDate { get; init; }

    /// <summary>
    /// Number of units to be transferred.
    /// </summary>
    [IsoId("_aOIAEVNUEeijdq8ilaxyOA")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Weighted average price of the units in the account. The average price may also be known as the average acquisition price.
    /// </summary>
    [IsoId("_aOIAE1NUEeijdq8ilaxyOA")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("_aOIAFVNUEeijdq8ilaxyOA")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit11? UnitsDetails { get; init; }

    /// <summary>
    /// Total transfer value.
    /// </summary>
    [IsoId("_HZm3cFNcEeijdq8ilaxyOA")]
    [DisplayName("Total Transfer Value")]
    [IsoXmlTag("TtlTrfVal")]
    public ActiveCurrencyAnd13DecimalAmount? TotalTransferValue { get; init; }

    /// <summary>
    /// Details of a payment that will result from or resulting from the liquation of an asset and transfer of cash or for the transfer of cash that was not invested.
    /// </summary>
    [IsoId("_1xGlIFNaEeijdq8ilaxyOA")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument15? PaymentDetails { get; init; }

    /// <summary>
    /// Information about the realisation of benefits taken from a pension.
    /// </summary>
    [IsoId("_5Gfn4LTnEeiWMOV-LTfmAw")]
    [DisplayName("Benefit Crystallisation Event")]
    [IsoXmlTag("BnftCrstllstnEvt")]
    public BenefitCrystallisationEvent1? BenefitCrystallisationEvent { get; init; }

    /// <summary>
    /// Details of a drawdown tranche.
    /// </summary>
    [IsoId("_2NBaMFNcEeijdq8ilaxyOA")]
    [DisplayName("Drawdown Tranche")]
    [IsoXmlTag("DrwdwnTrch")]
    public Drawdown1? DrawdownTranche { get; init; }

    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_aOIAF1NUEeijdq8ilaxyOA")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }

    /// <summary>
    /// Party that issues the status message.
    /// </summary>
    [IsoId("_zj9isFNbEeijdq8ilaxyOA")]
    [DisplayName("Status Issuer")]
    [IsoXmlTag("StsIssr")]
    public PartyIdentification139? StatusIssuer { get; init; }

    /// <summary>
    /// Party that receives the status message.
    /// </summary>
    [IsoId("_3-oXMFNbEeijdq8ilaxyOA")]
    [DisplayName("Status Recipient")]
    [IsoXmlTag("StsRcpt")]
    public PartyIdentification139? StatusRecipient { get; init; }
}
