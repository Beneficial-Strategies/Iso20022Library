// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
[IsoId("_XV2VwY7DEeaa5_S8lsRKCQ")]
[DisplayName("Securities Financing Transaction Details")]
public record SecuritiesFinancingTransactionDetails35
{
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_Xj-4ZY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_Xj-4aY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClosingLegIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Xj-4bY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_Xj-4cY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent&apos;s/service-provider&apos;s point of view.
    /// </summary>
    [IsoId("_Xj-4dY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("_Xj-4eY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Xj-4fY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification98? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Xj-4gY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_Xj-4hY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace1? SafekeepingPlace { get; init; }

    /// <summary>
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    [IsoId("_Xj-4iY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_Xj-4jY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_Xj-4kY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required Quantity6Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.
    /// </summary>
    [IsoId("_Xj-4lY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Opening Settlement Amount")]
    [IsoXmlTag("OpngSttlmAmt")]
    public AmountAndDirection51? OpeningSettlementAmount { get; init; }

    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_Xj-4mY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection21? TerminationTransactionAmount { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_Xj-4nY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Opening Settlement Date")]
    [IsoXmlTag("OpngSttlmDt")]
    public required SettlementDate10Choice_ OpeningSettlementDate { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_Xj-4oY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate4Choice_? TerminationDate { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_Xj-4pY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate5Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    [IsoId("_Xj-4qY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Expected Settlement Date")]
    [IsoXmlTag("XpctdSttlmDt")]
    public DateAndDateTimeChoice_? ExpectedSettlementDate { get; init; }

    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    [IsoId("_Xj-4rY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public DateAndDateTimeChoice_? ExpectedValueDate { get; init; }

    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_Xj-4sY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; }

    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_Xj-4tY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    public DateAndDateTimeChoice_? RateChangeDate { get; init; }

    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    [IsoId("_Xj-4uY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_Xj-4vY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_Xj-4wY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_Xj-4xY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails98? SettlementParameters { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_Xj-4yY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType35Choice_? RateType { get; init; }

    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    [IsoId("_Xj-4zY7DEeaa5_S8lsRKCQ")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; }

    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_Xj-40Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; }

    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender&apos;s risk.
    /// </summary>
    [IsoId("_Xj-41Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_Xj-42Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; }

    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_Xj-43Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice_? PricingRate { get; init; }

    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_Xj-44Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public Rate2? Spread { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_Xj-45Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties36? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_Xj-46Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties36? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_Xj-47Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification99? Investor { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_Xj-48Y7DEeaa5_S8lsRKCQ")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
