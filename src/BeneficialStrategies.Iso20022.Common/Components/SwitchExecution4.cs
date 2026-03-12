// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a switch order.
/// </summary>
[IsoId("_SLzuSNp-Ed-ak6NoX_4Aeg_1493111261")]
[DisplayName("Switch Execution")]
public partial record SwitchExecution4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_SLzuSdp-Ed-ak6NoX_4Aeg_-1713227853")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_SLzuStp-Ed-ak6NoX_4Aeg_1493111287")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_SLzuS9p-Ed-ak6NoX_4Aeg_-948123298")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount21? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_SLzuTNp-Ed-ak6NoX_4Aeg_1493111303")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text DealReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SLzuTdp-Ed-ak6NoX_4Aeg_1493111321")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_SL9fQNp-Ed-ak6NoX_4Aeg_-424660134")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Amount of money used to determine the quantity of investment fund units to be redeemed.
    /// </summary>
    [IsoId("_SL9fQdp-Ed-ak6NoX_4Aeg_1493111594")]
    [DisplayName("Total Redemption Amount")]
    [IsoXmlTag("TtlRedAmt")]
    public ActiveCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    
    /// <summary>
    /// Amount of money used to determine the quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_SL9fQtp-Ed-ak6NoX_4Aeg_1493111629")]
    [DisplayName("Total Subscription Amount")]
    [IsoXmlTag("TtlSbcptAmt")]
    public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Confirmation of the information about parties related to the transaction.
    /// </summary>
    [IsoId("_SL9fQ9p-Ed-ak6NoX_4Aeg_736746595")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = new ValueList<Intermediary9>(){};
    
    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_SL9fRNp-Ed-ak6NoX_4Aeg_1095438285")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    
    /// <summary>
    /// Additional amount of money paid by the investor in addition to the switch redemption amount.
    /// </summary>
    [IsoId("_SL9fRdp-Ed-ak6NoX_4Aeg_1493111689")]
    [DisplayName("Additional Cash In")]
    [IsoXmlTag("AddtlCshIn")]
    public ActiveCurrencyAndAmount? AdditionalCashIn { get; init; } 
    
    /// <summary>
    /// Amount of money that results from a switch-out, that is not reinvested in another investment fund, and is repaid to the investor.
    /// </summary>
    [IsoId("_SL9fRtp-Ed-ak6NoX_4Aeg_1493111706")]
    [DisplayName("Resulting Cash Out")]
    [IsoXmlTag("RsltgCshOut")]
    public ActiveCurrencyAndAmount? ResultingCashOut { get; init; } 
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SL9fR9p-Ed-ak6NoX_4Aeg_2067777163")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SL9fSNp-Ed-ak6NoX_4Aeg_2067777223")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; } 
    
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_SL9fSdp-Ed-ak6NoX_4Aeg_1838695671")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    
    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("_SMGpMNp-Ed-ak6NoX_4Aeg_-1048855952")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; } 
    
    /// <summary>
    /// Redemption leg of a switch order execution.
    /// </summary>
    [IsoId("_SMGpMdp-Ed-ak6NoX_4Aeg_1493112217")]
    [DisplayName("Redemption Leg Details")]
    [IsoXmlTag("RedLegDtls")]
    public ValueList<SwitchRedemptionLegExecution3> RedemptionLegDetails { get; init; } = new ValueList<SwitchRedemptionLegExecution3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SMGpMdp-Ed-ak6NoX_4Aeg_1493112217
    
    /// <summary>
    /// Subscription leg of a switch order execution.
    /// </summary>
    [IsoId("_SMGpMtp-Ed-ak6NoX_4Aeg_1493111880")]
    [DisplayName("Subscription Leg Details")]
    [IsoXmlTag("SbcptLegDtls")]
    public ValueList<SwitchSubscriptionLegExecution3> SubscriptionLegDetails { get; init; } = new ValueList<SwitchSubscriptionLegExecution3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SMGpMtp-Ed-ak6NoX_4Aeg_1493111880
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_SMGpM9p-Ed-ak6NoX_4Aeg_1494032794")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction26? CashSettlementDetails { get; init; } 
    
    /// <summary>
    /// Currency exchange related to the execution of an investment fund order.
    /// </summary>
    [IsoId("_SMGpNNp-Ed-ak6NoX_4Aeg_1494032267")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms7? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_SMGpNdp-Ed-ak6NoX_4Aeg_238748541")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_SMGpNtp-Ed-ak6NoX_4Aeg_229422838")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    
    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("_SMGpN9p-Ed-ak6NoX_4Aeg_660770285")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; } 
    
    
    #nullable disable
    
}
