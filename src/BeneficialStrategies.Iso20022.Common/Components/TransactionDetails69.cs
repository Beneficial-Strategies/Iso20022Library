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
[IsoId("_ShwnA032EeSGA7fXFuKIIQ")]
[DisplayName("Transaction Details")]
public record TransactionDetails69
{
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    [IsoId("_S-UnE032EeSGA7fXFuKIIQ")]
    [DisplayName("Transaction Activity")]
    [IsoXmlTag("TxActvty")]
    public required TransactionActivity1Choice_ TransactionActivity { get; init; }

    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    [IsoId("_S-UnF032EeSGA7fXFuKIIQ")]
    [DisplayName("Settlement Transaction Or Corporate Action Event Type")]
    [IsoXmlTag("SttlmTxOrCorpActnEvtTp")]
    public SettlementOrCorporateActionEvent10Choice_? SettlementTransactionOrCorporateActionEventType { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_S-UnG032EeSGA7fXFuKIIQ")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_S-UnH032EeSGA7fXFuKIIQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_S-UnI032EeSGA7fXFuKIIQ")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails74? SettlementParameters { get; init; }

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_S-UnJ032EeSGA7fXFuKIIQ")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification78? PlaceOfTrade { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_S-UnK032EeSGA7fXFuKIIQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_S-UnL032EeSGA7fXFuKIIQ")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_S-UnM032EeSGA7fXFuKIIQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Quantity of financial instrument (to be) posted to the safekeeping account.
    /// </summary>
    [IsoId("_S-UnN032EeSGA7fXFuKIIQ")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required Quantity6Choice_ PostingQuantity { get; init; }

    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_S-UnO032EeSGA7fXFuKIIQ")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public AmountAndDirection8? PostingAmount { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_S-UnP032EeSGA7fXFuKIIQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate1Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    [IsoId("_S-UnQ032EeSGA7fXFuKIIQ")]
    [DisplayName("Expected Settlement Date")]
    [IsoXmlTag("XpctdSttlmDt")]
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_S-UnR032EeSGA7fXFuKIIQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate2Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_S-UnS032EeSGA7fXFuKIIQ")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; }

    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    [IsoId("_S-UnT032EeSGA7fXFuKIIQ")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_S-UnU032EeSGA7fXFuKIIQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties13? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_S-UnV032EeSGA7fXFuKIIQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties13? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_S-UnW032EeSGA7fXFuKIIQ")]
    [DisplayName("Transaction Additional Details")]
    [IsoXmlTag("TxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? TransactionAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_S-UnX032EeSGA7fXFuKIIQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
