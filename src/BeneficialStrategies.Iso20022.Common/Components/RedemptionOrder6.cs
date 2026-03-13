// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
[IsoId("_SDKvrdp-Ed-ak6NoX_4Aeg_-97453543")]
[DisplayName("Redemption Order")]
public partial record RedemptionOrder6
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SDKvrtp-Ed-ak6NoX_4Aeg_-97453041")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_SDT5kNp-Ed-ak6NoX_4Aeg_-2113576602")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SDT5kdp-Ed-ak6NoX_4Aeg_-1276615968")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_SDT5ktp-Ed-ak6NoX_4Aeg_1272445004")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<FundOrderType2> OrderType { get; init; } = [];
    
    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_SDT5k9p-Ed-ak6NoX_4Aeg_-95607462")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Subdivision of an account used to segregate specific holdings.
    /// </summary>
    [IsoId("_SDT5lNp-Ed-ak6NoX_4Aeg_1342474079")]
    [DisplayName("Sub Account For Holding")]
    [IsoXmlTag("SubAcctForHldg")]
    public SubAccount1? SubAccountForHolding { get; init; } 
    
    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    [IsoId("_SDT5ldp-Ed-ak6NoX_4Aeg_-96532837")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold, before deduction of charges, commissions, and taxes.|[Quantity * Price].
    /// </summary>
    [IsoId("_SDT5ltp-Ed-ak6NoX_4Aeg_-96532362")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public required ActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; } 
    
    /// <summary>
    /// Amount of money to be received following redemption after deduction of charges, commissions and taxes and used to derive the quantity of investment fund units to be sold.|[(Quantity * Price) - (Charges + Commissions +Taxes)].
    /// </summary>
    [IsoId("_SDT5l9p-Ed-ak6NoX_4Aeg_-96532439")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; } 
    
    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_SDT5mNp-Ed-ak6NoX_4Aeg_-96532379")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate HoldingsRedemptionRate { get; init; } 
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_SDT5mdp-Ed-ak6NoX_4Aeg_-96532404")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; } 
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SDdqkNp-Ed-ak6NoX_4Aeg_954543403")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SDdqkdp-Ed-ak6NoX_4Aeg_954543498")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; } 
    
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_SDdqktp-Ed-ak6NoX_4Aeg_477424110")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_SDdqk9p-Ed-ak6NoX_4Aeg_-95606377")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_SDdqlNp-Ed-ak6NoX_4Aeg_-96532344")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; } 
    
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_SDdqldp-Ed-ak6NoX_4Aeg_-96531941")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
    
    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_SDdqltp-Ed-ak6NoX_4Aeg_-122473916")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge17? ChargeDetails { get; init; } 
    
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_SDdql9p-Ed-ak6NoX_4Aeg_1964867528")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission10? CommissionDetails { get; init; } 
    
    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_SDdqmNp-Ed-ak6NoX_4Aeg_264482669")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public Tax16? TaxDetails { get; init; } 
    
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_SDdqmdp-Ed-ak6NoX_4Aeg_-94684463")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_SDnbkNp-Ed-ak6NoX_4Aeg_-96531906")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    
    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_SDnbkdp-Ed-ak6NoX_4Aeg_-94685724")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_SDnbktp-Ed-ak6NoX_4Aeg_-96531534")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_SDnbk9p-Ed-ak6NoX_4Aeg_-96531071")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_SDnblNp-Ed-ak6NoX_4Aeg_-44786573")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction21? CashSettlementDetails { get; init; } 
    
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_SDnbldp-Ed-ak6NoX_4Aeg_-1024261303")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("_SDnbltp-Ed-ak6NoX_4Aeg_-1561368990")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = [];
    
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_SDnbl9p-Ed-ak6NoX_4Aeg_1260784231")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_SDnbmNp-Ed-ak6NoX_4Aeg_-651618158")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_SDnbmdp-Ed-ak6NoX_4Aeg_1257603756")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = [];
    
    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_SDwlgNp-Ed-ak6NoX_4Aeg_919005614")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; } 
    
    
    #nullable disable
    
}
