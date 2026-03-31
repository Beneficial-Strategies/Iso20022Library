// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a switch order.
/// </summary>
[IsoId("_8EacxzbsEead9bDRE_1DAQ")]
[DisplayName("Switch Execution")]
public record SwitchExecution7
{
    /// <summary>
    /// Indicates whether the confirmation is an amendment of a previous confirmation.
    /// </summary>
    [IsoId("_hwj2gVAMEeal4_lvhAnyGQ")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_8d2QOTbsEead9bDRE_1DAQ")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_f8QiwTxBEea9KZ_pBxG-rQ")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("_8d2QOzbsEead9bDRE_1DAQ")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date and time the order was received by the executing party, for example, the transfer agent.
    /// </summary>
    [IsoId("_4HuFYTw6Eea0R-RTP9Wg-Q")]
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("_8d2QPzbsEead9bDRE_1DAQ")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_8d2QQTbsEead9bDRE_1DAQ")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_8d2QQzbsEead9bDRE_1DAQ")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("_8d2QPTbsEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount58? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [IsoId("_8d2QSTbsEead9bDRE_1DAQ")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary39> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("_lcv-UUG8EeaDto2WJ2T9Tw")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_8d2QSzbsEead9bDRE_1DAQ")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_8d2QUTbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_8d2QUzbsEead9bDRE_1DAQ")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_8d2QVTbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Choice between additional cash in or resulting cash out.
    /// </summary>
    [IsoId("_pOZHIUHAEeaNEqIb_fgRZg")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public AdditionalAmount1Choice_? AdditionalAmount { get; init; }

    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("_8d2QVzbsEead9bDRE_1DAQ")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    /// <summary>
    /// Redemption leg of a switch order execution.
    /// </summary>
    [IsoId("_8d2QWTbsEead9bDRE_1DAQ")]
    [DisplayName("Redemption Leg Details")]
    [IsoXmlTag("RedLegDtls")]
    public ValueList<SwitchRedemptionLegExecution4> RedemptionLegDetails { get; init; } = [];

    // ID for the above is _8d2QWTbsEead9bDRE_1DAQ

    /// <summary>
    /// Subscription leg of a switch order execution.
    /// </summary>
    [IsoId("_8d2QWzbsEead9bDRE_1DAQ")]
    [DisplayName("Subscription Leg Details")]
    [IsoXmlTag("SbcptLegDtls")]
    public ValueList<SwitchSubscriptionLegExecution4> SubscriptionLegDetails { get; init; } = [];

    // ID for the above is _8d2QWzbsEead9bDRE_1DAQ

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_8d2QXTbsEead9bDRE_1DAQ")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction71? CashSettlementDetails { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    [IsoId("_8d2QXzbsEead9bDRE_1DAQ")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms33> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_8d2QYTbsEead9bDRE_1DAQ")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_8d2QYzbsEead9bDRE_1DAQ")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("_8d2QZTbsEead9bDRE_1DAQ")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("_PmHxUTlNEeaYrqEUdbYZQQ")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("_AfqQ0ToDEeabspMEjqY5TQ")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("_ijJyEToIEeabspMEjqY5TQ")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; }

    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [IsoId("_z-EQIVAJEeal4_lvhAnyGQ")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
