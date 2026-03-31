// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[IsoId("_UeI9S9p-Ed-ak6NoX_4Aeg_-1742366346")]
[DisplayName("Transaction Details")]
public record TransactionDetails7
{
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    [IsoId("_UeI9TNp-Ed-ak6NoX_4Aeg_1252539964")]
    [DisplayName("Transaction Activity")]
    [IsoXmlTag("TxActvty")]
    public required TransactionActivity1Choice_ TransactionActivity { get; init; }

    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    [IsoId("_UeI9Tdp-Ed-ak6NoX_4Aeg_-167505846")]
    [DisplayName("Settlement Transaction Or Corporate Action Event Type")]
    [IsoXmlTag("SttlmTxOrCorpActnEvtTp")]
    public SettlementOrCorporateActionEvent2Choice_? SettlementTransactionOrCorporateActionEventType { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_UeI9Ttp-Ed-ak6NoX_4Aeg_1252540024")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_UeI9T9p-Ed-ak6NoX_4Aeg_1252540084")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_UeI9UNp-Ed-ak6NoX_4Aeg_-1742365305")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails7? SettlementParameters { get; init; }

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_UeI9Udp-Ed-ak6NoX_4Aeg_1518824684")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification4? PlaceOfTrade { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_UeSHMNp-Ed-ak6NoX_4Aeg_1661725317")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and wich facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_UeSHMdp-Ed-ak6NoX_4Aeg_-562011714")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_UeSHMtp-Ed-ak6NoX_4Aeg_-980497464")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity of financial instrument (to be) posted to the safekeeping account.
    /// </summary>
    [IsoId("_UeSHM9p-Ed-ak6NoX_4Aeg_-32673285")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required Quantity6Choice_ PostingQuantity { get; init; }

    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_UeSHNNp-Ed-ak6NoX_4Aeg_-1742366254")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public AmountAndDirection8? PostingAmount { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_UeSHNdp-Ed-ak6NoX_4Aeg_-1742365853")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate1Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_UeSHNtp-Ed-ak6NoX_4Aeg_-1742365915")]
    [DisplayName("Expected Settlement Date")]
    [IsoXmlTag("XpctdSttlmDt")]
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_UeSHN9p-Ed-ak6NoX_4Aeg_-1742365884")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate2Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_UeSHONp-Ed-ak6NoX_4Aeg_1950522037")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; }

    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    [IsoId("_UeSHOdp-Ed-ak6NoX_4Aeg_-1742365823")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_Ueb4MNp-Ed-ak6NoX_4Aeg_92365268")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties2? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_Ueb4Mdp-Ed-ak6NoX_4Aeg_80360967")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties2? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_Ueb4Mtp-Ed-ak6NoX_4Aeg_-1742365945")]
    [DisplayName("Transaction Additional Details")]
    [IsoXmlTag("TxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? TransactionAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ueb4M9p-Ed-ak6NoX_4Aeg_-796810387")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension2> Extension { get; init; } = [];
}
