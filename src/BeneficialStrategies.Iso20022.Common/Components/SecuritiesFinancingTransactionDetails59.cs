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
[IsoId("_DDzm4ZaFEfC2_67yGLymgA")]
[DisplayName("Securities Financing Transaction Details59")]
public record SecuritiesFinancingTransactionDetails59
{
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_DGqtr5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; }

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_DGqtt5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Financing Unique Transaction Identifier")]
    [IsoXmlTag("SctiesFincgUnqTxIdr")]
    public IsoUTIIdentifier? SecuritiesFinancingUniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_DGqtuZaFEfC2_67yGLymgA")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    public IsoMax35Text? ClosingLegIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_DGqtwZaFEfC2_67yGLymgA")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_DGqtyZaFEfC2_67yGLymgA")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    [IsoId("_DGqt0ZaFEfC2_67yGLymgA")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    [IsoId("_DGqt2ZaFEfC2_67yGLymgA")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_DGqt4ZaFEfC2_67yGLymgA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_DGqt6ZaFEfC2_67yGLymgA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_DGqt8ZaFEfC2_67yGLymgA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_DGqt95aFEfC2_67yGLymgA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace5? SafekeepingPlace { get; init; }

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_DGqt_5aFEfC2_67yGLymgA")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_DGquB5aFEfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_DGquD5aFEfC2_67yGLymgA")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required Quantity51Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.
    /// </summary>
    [IsoId("_DGquF5aFEfC2_67yGLymgA")]
    [DisplayName("Opening Settlement Amount")]
    [IsoXmlTag("OpngSttlmAmt")]
    public AmountAndDirection51? OpeningSettlementAmount { get; init; }

    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_DGquH5aFEfC2_67yGLymgA")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection21? TerminationTransactionAmount { get; init; }

    /// <summary>
    /// Amount of digital asset that is to be/was posted to the account as a means of payment.
    /// </summary>
    [IsoId("_dJqK4ZaEEfC2_67yGLymgA")]
    [DisplayName("Digital Payment Settlement")]
    [IsoXmlTag("DgtlPmtSttlm")]
    public DigitalPaymentSettlement2? DigitalPaymentSettlement { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_DGquJ5aFEfC2_67yGLymgA")]
    [DisplayName("Opening Settlement Date")]
    [IsoXmlTag("OpngSttlmDt")]
    public required SettlementDate19Choice_ OpeningSettlementDate { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_DGquL5aFEfC2_67yGLymgA")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate6Choice_? TerminationDate { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_DGquN5aFEfC2_67yGLymgA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    [IsoId("_DGquP5aFEfC2_67yGLymgA")]
    [DisplayName("Expected Settlement Date")]
    [IsoXmlTag("XpctdSttlmDt")]
    public DateAndDateTime2Choice_? ExpectedSettlementDate { get; init; }

    /// <summary>
    /// For against payment transactions, the value date/time at which the account servicer expects the settlement amount to be credited or debited.
    /// </summary>
    [IsoId("_DGquR5aFEfC2_67yGLymgA")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public DateAndDateTime2Choice_? ExpectedValueDate { get; init; }

    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_DGquT5aFEfC2_67yGLymgA")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; }

    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_DGquV5aFEfC2_67yGLymgA")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    public DateAndDateTime2Choice_? RateChangeDate { get; init; }

    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    [IsoId("_DGquX5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_DGquZ5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_DGqub5aFEfC2_67yGLymgA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_DGqud5aFEfC2_67yGLymgA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails227? SettlementParameters { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_DGquf5aFEfC2_67yGLymgA")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType35Choice_? RateType { get; init; }

    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    [IsoId("_DGquh5aFEfC2_67yGLymgA")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; }

    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_DGrUt5aFEfC2_67yGLymgA")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; }

    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender's risk.
    /// </summary>
    [IsoId("_DGrUv5aFEfC2_67yGLymgA")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_DGrUx5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; }

    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_DGrUz5aFEfC2_67yGLymgA")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice_? PricingRate { get; init; }

    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_DGrU15aFEfC2_67yGLymgA")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public Rate2? Spread { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_DGrU35aFEfC2_67yGLymgA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties127? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_DGrU55aFEfC2_67yGLymgA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties127? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_DGrU75aFEfC2_67yGLymgA")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification149? Investor { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_DGrU95aFEfC2_67yGLymgA")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
