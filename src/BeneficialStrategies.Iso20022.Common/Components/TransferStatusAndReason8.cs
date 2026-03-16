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
[IsoId("_UEdjodx9EeqKxsvOxFQHKA")]
[DisplayName("Transfer Status And Reason")]
public record TransferStatusAndReason8
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_UXplY9x9EeqKxsvOxFQHKA")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_UXplZdx9EeqKxsvOxFQHKA")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_UXzWYdx9EeqKxsvOxFQHKA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_UXzWY9x9EeqKxsvOxFQHKA")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Type of event for which the message is sent.
    /// </summary>
    [IsoId("_UXzWZdx9EeqKxsvOxFQHKA")]
    [DisplayName("Transfer Event Type")]
    [IsoXmlTag("TrfEvtTp")]
    public ValueList<TransferStatusType3Choice_> TransferEventType { get; init; } = [];

    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_UXzWZ9x9EeqKxsvOxFQHKA")]
    [DisplayName("Transfer Status")]
    [IsoXmlTag("TrfSts")]
    public required TransferStatus5Choice_ TransferStatus { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_ZMzWcdx9EeqKxsvOxFQHKA")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public FinancialInstrument63Choice_? Instrument { get; init; }

    /// <summary>
    /// Investment account information of the transfer for which the status or information is provided.
    /// </summary>
    [IsoId("_chGYwdx9EeqKxsvOxFQHKA")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public Account33? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_vRGQMXdhEeuvip1zrZRWzw")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary48> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date on which the transfer was executed.
    /// In some scenarios, this is the date and time to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_UXzWadx9EeqKxsvOxFQHKA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date at which the securities are to be exchanged or were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_UXzWa9x9EeqKxsvOxFQHKA")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("_UXzWbdx9EeqKxsvOxFQHKA")]
    [DisplayName("Send Out Date")]
    [IsoXmlTag("SndOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SendOutDate { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_0ksRsXgaEeuvip1zrZRWzw")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Number of units to be transferred.
    /// </summary>
    [IsoId("_UXzWb9x9EeqKxsvOxFQHKA")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Weighted average price of the units in the account. The average price may also be known as the average acquisition price.
    /// </summary>
    [IsoId("_UXzWcdx9EeqKxsvOxFQHKA")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("_UXzWc9x9EeqKxsvOxFQHKA")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit11> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Information about the source security following a conversion.
    /// </summary>
    [IsoId("_zeZsAXwgEeuQY_68iqAoCQ")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public Conversion2? Conversion { get; init; }

    /// <summary>
    /// Total transfer value.
    /// </summary>
    [IsoId("_UXzWddx9EeqKxsvOxFQHKA")]
    [DisplayName("Total Transfer Value")]
    [IsoXmlTag("TtlTrfVal")]
    public ActiveCurrencyAnd13DecimalAmount? TotalTransferValue { get; init; }

    /// <summary>
    /// Details of a payment that will result from or resulting from the liquation of an asset and transfer of cash or for the transfer of cash that was not invested.
    /// </summary>
    [IsoId("_UXzWd9x9EeqKxsvOxFQHKA")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public ValueList<PaymentInstrument18> PaymentDetails { get; init; } = [];

    /// <summary>
    /// Information about the realisation of benefits taken from a pension.
    /// </summary>
    [IsoId("_UXzWedx9EeqKxsvOxFQHKA")]
    [DisplayName("Benefit Crystallisation Event")]
    [IsoXmlTag("BnftCrstllstnEvt")]
    public ValueList<BenefitCrystallisationEvent2> BenefitCrystallisationEvent { get; init; } = [];

    /// <summary>
    /// Details of a drawdown tranche.
    /// </summary>
    [IsoId("_UXzWe9x9EeqKxsvOxFQHKA")]
    [DisplayName("Drawdown Tranche")]
    [IsoXmlTag("DrwdwnTrch")]
    public ValueList<Drawdown2> DrawdownTranche { get; init; } = [];

    /// <summary>
    /// Drawdown information not specifically associated with a drawdown tranche.
    /// </summary>
    [IsoId("_3A6zoHzoEeuEHsEB8Johfw")]
    [DisplayName("Other Drawdown Information")]
    [IsoXmlTag("OthrDrwdwnInf")]
    public Drawdown3? OtherDrawdownInformation { get; init; }

    /// <summary>
    /// Response information.
    /// </summary>
    [IsoId("_OfS3sXp6EeuldpLtvj4F0Q")]
    [DisplayName("Query Response")]
    [IsoXmlTag("QryRspn")]
    public SimpleValueList<IsoMax350Text> QueryResponse { get; init; } = [];

    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_UXzWfdx9EeqKxsvOxFQHKA")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }

    /// <summary>
    /// Party that issues the status or information message.
    /// </summary>
    [IsoId("_UXzWf9x9EeqKxsvOxFQHKA")]
    [DisplayName("Status Issuer")]
    [IsoXmlTag("StsIssr")]
    public PartyIdentification139? StatusIssuer { get; init; }

    /// <summary>
    /// Party that receives the status or information message.
    /// </summary>
    [IsoId("_UXzWgdx9EeqKxsvOxFQHKA")]
    [DisplayName("Status Recipient")]
    [IsoXmlTag("StsRcpt")]
    public PartyIdentification139? StatusRecipient { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_tGEMsXp6EeuldpLtvj4F0Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
