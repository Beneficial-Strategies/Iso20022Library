// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
[IsoId("_2xl7BSAeEeuyDZ-ukt4YRg")]
[DisplayName("Transaction Details")]
public record TransactionDetails145
{
    /// <summary>
    /// Specifies the type of activity to which this instruction relates.
    /// </summary>
    [IsoId("_2xl7DyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Transaction Activity")]
    [IsoXmlTag("TxActvty")]
    public required TransactionActivity4Choice_ TransactionActivity { get; init; }

    /// <summary>
    /// Choice of type for the transaction reported.
    /// </summary>
    [IsoId("_2xl7EyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Settlement Transaction Or Corporate Action Event Type")]
    [IsoXmlTag("SttlmTxOrCorpActnEvtTp")]
    public SettlementOrCorporateActionEvent33Choice_? SettlementTransactionOrCorporateActionEventType { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_2xl7FyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_2xl7GyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_2xl7HyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails198? SettlementParameters { get; init; }

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_2xl7IyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_2xl7JyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace4? SafekeepingPlace { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_2xl7KyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    /// <summary>
    /// Quantity of financial instrument (to be) posted to the safekeeping account.
    /// </summary>
    [IsoId("_2xl7LyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required Quantity10Choice_ PostingQuantity { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_2xl7MyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_2xl7NyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public AmountAndDirection18? PostingAmount { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_2xl7OyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection59? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_2xl7PyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate9Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is, payment is effected and securities are delivered.
    /// </summary>
    [IsoId("_2xl7QyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public required DateAndDateTime2Choice_ EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_2xl7RyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public SettlementDate20Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [IsoId("_2xl7SyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("_2xl7TyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    [IsoId("_2xl7USAeEeuyDZ-ukt4YRg")]
    [DisplayName("Matched Status Time Stamp")]
    [IsoXmlTag("MtchdStsTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_2xl7UyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties90? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_2xl7VyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties90? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Indicates whether it is the reversal of a previously reported movement.
    /// </summary>
    [IsoId("_2xl7WyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReversalIndicator { get; init; }

    /// <summary>
    /// Provides additional details on the transaction which cannot be included within the structured fields of the message.
    /// </summary>
    [IsoId("_2xl7XyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Transaction Additional Details")]
    [IsoXmlTag("TxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? TransactionAdditionalDetails { get; init; }
}
