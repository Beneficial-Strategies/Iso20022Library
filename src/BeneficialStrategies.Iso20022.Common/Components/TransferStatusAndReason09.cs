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
[IsoId("5d59e824-c7dc-44e1-8320-59c3e1ab7ac7")]
[DisplayName("Transfer Status And Reason09")]
public record TransferStatusAndReason09
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("30a7fb95-c436-4763-ad21-ce22ab52e55f")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("f1ae4781-d0a0-4167-a9d2-33950126d478")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    public required AdditionalReference10 TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("43368377-e8b2-4cb1-8f02-cf2b359838b7")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("f7873ada-a5a9-45d1-b05e-0e8219a24a2b")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Type of event for which the message is sent.
    /// </summary>
    [IsoId("30f1743b-3abf-47b0-81fa-0e8629dceacf")]
    [DisplayName("Transfer Event Type")]
    [IsoXmlTag("TrfEvtTp")]
    public ValueList<TransferStatusType3Choice_> TransferEventType { get; init; } = [];

    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("205ca276-b198-47db-9d31-3fc28d751a84")]
    [DisplayName("Transfer Status")]
    [IsoXmlTag("TrfSts")]
    public required TransferStatus5Choice_ TransferStatus { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("3b331438-c22e-40af-a2b1-e16258e86269")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public FinancialInstrument101Choice_? Instrument { get; init; }

    /// <summary>
    /// Investment account information of the transfer for which the status or information is provided.
    /// </summary>
    [IsoId("4fc7e525-b771-4487-bd1c-f75988a389d7")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public Account36? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("78a74c05-fc0c-4325-9445-14a123d4e4a2")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary48> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date on which the transfer was executed.|In some scenarios, this is the date and time to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("6a8dae3c-d1e1-4ce6-92fc-be1b00873bc6")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date at which the securities are to be exchanged or were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("0b234e04-0203-46ff-8be8-2de650c44538")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("521ceaa7-1297-4439-af3e-eb11d5543685")]
    [DisplayName("Send Out Date")]
    [IsoXmlTag("SndOutDt")]
    public IsoISODate? SendOutDate { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("d2721621-4d25-4152-b912-21cd64e272cd")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Number of units to be transferred.
    /// </summary>
    [IsoId("baefca67-646a-41b9-a742-f705b5fb9fab")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public IsoDecimalNumber? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Weighted average price of the units in the account. The average price may also be known as the average acquisition price.
    /// </summary>
    [IsoId("bd0b051a-a729-4d0f-884b-53d1913a7f8d")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("87724e29-ea6e-4226-96b0-82bbb2e763c3")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Information about the source security following a conversion.
    /// </summary>
    [IsoId("7dce11ee-4a27-4f04-8ed0-51ce461aa1d2")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public Conversion4? Conversion { get; init; }

    /// <summary>
    /// Total transfer value.
    /// </summary>
    [IsoId("af9dd867-7089-42ef-9d41-58501b7fa847")]
    [DisplayName("Total Transfer Value")]
    [IsoXmlTag("TtlTrfVal")]
    public ActiveCurrencyAnd13DecimalAmount? TotalTransferValue { get; init; }

    /// <summary>
    /// Details of a payment that will result from or resulting from the liquation of an asset and transfer of cash or for the transfer of cash that was not invested.
    /// </summary>
    [IsoId("681b13a3-7e98-49fd-93a5-f36c803c0bae")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public ValueList<PaymentInstrument23> PaymentDetails { get; init; } = [];

    /// <summary>
    /// Information about the realisation of benefits taken from a pension.
    /// </summary>
    [IsoId("d49de491-7fe7-4b74-8c48-0795ac42b5da")]
    [DisplayName("Benefit Crystallisation Event")]
    [IsoXmlTag("BnftCrstllstnEvt")]
    public ValueList<BenefitCrystallisationEvent2> BenefitCrystallisationEvent { get; init; } = [];

    /// <summary>
    /// Details of a drawdown tranche.
    /// </summary>
    [IsoId("a8d700d5-6791-4959-aff8-d796c3bfb099")]
    [DisplayName("Drawdown Tranche")]
    [IsoXmlTag("DrwdwnTrch")]
    public ValueList<Drawdown04> DrawdownTranche { get; init; } = [];

    /// <summary>
    /// Drawdown information not specifically associated with a drawdown tranche.
    /// </summary>
    [IsoId("206941e0-4037-4212-9e77-2b50034981d0")]
    [DisplayName("Other Drawdown Information")]
    [IsoXmlTag("OthrDrwdwnInf")]
    public Drawdown3? OtherDrawdownInformation { get; init; }

    /// <summary>
    /// Response information.
    /// </summary>
    [IsoId("f3147b52-3021-483f-8de7-a8aa3bb0de10")]
    [DisplayName("Query Response")]
    [IsoXmlTag("QryRspn")]
    public SimpleValueList<IsoMax350Text> QueryResponse { get; init; } = [];

    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("1b304978-0bad-46f3-84be-4a7fed1277de")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }

    /// <summary>
    /// Party that issues the status or information message.
    /// </summary>
    [IsoId("2f26d2c6-6482-49f1-a821-332f10643a53")]
    [DisplayName("Status Issuer")]
    [IsoXmlTag("StsIssr")]
    public PartyIdentification139? StatusIssuer { get; init; }

    /// <summary>
    /// Party that receives the status or information message.
    /// </summary>
    [IsoId("35d6ced9-3b55-4d99-9c67-a6ef2b524223")]
    [DisplayName("Status Recipient")]
    [IsoXmlTag("StsRcpt")]
    public PartyIdentification139? StatusRecipient { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("563df2ff-7ad3-42b6-9cee-ece1c790c111")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
