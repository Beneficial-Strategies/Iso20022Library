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
[IsoId("_Z22DQZM5EemKz5EOjv82iQ")]
[DisplayName("Transfer Status And Reason")]
public record TransferStatusAndReason7
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_aLFN45M5EemKz5EOjv82iQ")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_aLFN5ZM5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_aLFN55M5EemKz5EOjv82iQ")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_aLFN6ZM5EemKz5EOjv82iQ")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Type of event for which the message is sent.
    /// </summary>
    [IsoId("_aLFN65M5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Event Type")]
    [IsoXmlTag("TrfEvtTp")]
    public ValueList<TransferStatusType1Choice_> TransferEventType { get; init; } = [];

    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_aLFN7ZM5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Status")]
    [IsoXmlTag("TrfSts")]
    public required TransferStatus4Choice_ TransferStatus { get; init; }

    /// <summary>
    /// Date on which the transfer was executed.
    /// In some scenarios, this is the date and time to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_aLFN75M5EemKz5EOjv82iQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date at which the securities are to be exchanged or were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_aLFN8ZM5EemKz5EOjv82iQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("_aLFN85M5EemKz5EOjv82iQ")]
    [DisplayName("Send Out Date")]
    [IsoXmlTag("SndOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SendOutDate { get; init; }

    /// <summary>
    /// Number of units to be transferred.
    /// </summary>
    [IsoId("_aLFN9ZM5EemKz5EOjv82iQ")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Weighted average price of the units in the account. The average price may also be known as the average acquisition price.
    /// </summary>
    [IsoId("_aLFN95M5EemKz5EOjv82iQ")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("_aLFN-ZM5EemKz5EOjv82iQ")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit11> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Total transfer value.
    /// </summary>
    [IsoId("_aLFN-5M5EemKz5EOjv82iQ")]
    [DisplayName("Total Transfer Value")]
    [IsoXmlTag("TtlTrfVal")]
    public ActiveCurrencyAnd13DecimalAmount? TotalTransferValue { get; init; }

    /// <summary>
    /// Details of a payment that will result from or resulting from the liquation of an asset and transfer of cash or for the transfer of cash that was not invested.
    /// </summary>
    [IsoId("_aLFN_ZM5EemKz5EOjv82iQ")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public ValueList<PaymentInstrument18> PaymentDetails { get; init; } = [];

    /// <summary>
    /// Information about the realisation of benefits taken from a pension.
    /// </summary>
    [IsoId("_aLFN_5M5EemKz5EOjv82iQ")]
    [DisplayName("Benefit Crystallisation Event")]
    [IsoXmlTag("BnftCrstllstnEvt")]
    public ValueList<BenefitCrystallisationEvent2> BenefitCrystallisationEvent { get; init; } = [];

    /// <summary>
    /// Details of a drawdown tranche.
    /// </summary>
    [IsoId("_aLFOAZM5EemKz5EOjv82iQ")]
    [DisplayName("Drawdown Tranche")]
    [IsoXmlTag("DrwdwnTrch")]
    public ValueList<Drawdown2> DrawdownTranche { get; init; } = [];

    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_aLFOA5M5EemKz5EOjv82iQ")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }

    /// <summary>
    /// Party that issues the status message.
    /// </summary>
    [IsoId("_aLFOBZM5EemKz5EOjv82iQ")]
    [DisplayName("Status Issuer")]
    [IsoXmlTag("StsIssr")]
    public PartyIdentification139? StatusIssuer { get; init; }

    /// <summary>
    /// Party that receives the status message.
    /// </summary>
    [IsoId("_aLFOB5M5EemKz5EOjv82iQ")]
    [DisplayName("Status Recipient")]
    [IsoXmlTag("StsRcpt")]
    public PartyIdentification139? StatusRecipient { get; init; }
}
