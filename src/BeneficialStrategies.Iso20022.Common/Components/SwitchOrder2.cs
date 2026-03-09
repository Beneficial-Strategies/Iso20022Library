// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer from one investment fund/fund class to another investment fund or investment fund class by the investor. A switch is composed of one or several subscription legs, and one or several redemption legs.
/// </summary>
[IsoId("_VVuFi9p-Ed-ak6NoX_4Aeg_-1360536112")]
[DisplayName("Switch Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchOrder2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SwitchOrder2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchOrder2( System.String reqOrderReference,InvestmentAccount13 reqInvestmentAccountDetails )
    {
        OrderReference = reqOrderReference;
        InvestmentAccountDetails = reqInvestmentAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VVuFjNp-Ed-ak6NoX_4Aeg_-1824533801")]
    [DisplayName("Order Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDtTm")]
    #endif
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OrderDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OrderDateTime { get; init; } 
    #else
    public System.DateTime? OrderDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VVuFjdp-Ed-ak6NoX_4Aeg_-1360536094")]
    [DisplayName("Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRef")]
    #endif
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OrderReference { get; init; } 
    #else
    public System.String OrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_VV3PcNp-Ed-ak6NoX_4Aeg_-1360535488")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount13 InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be redeemed.
    /// </summary>
    [IsoId("_VV3Pcdp-Ed-ak6NoX_4Aeg_-1360536077")]
    [DisplayName("Total Redemption Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRedAmt")]
    #endif
    [IsoXmlTag("TtlRedAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_VV3Pctp-Ed-ak6NoX_4Aeg_-1360536060")]
    [DisplayName("Total Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSbcptAmt")]
    #endif
    [IsoXmlTag("TtlSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_VV3Pc9p-Ed-ak6NoX_4Aeg_-1425073053")]
    [DisplayName("Expiry Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDtTm")]
    #endif
    [IsoXmlTag("XpryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExpiryDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExpiryDateTime { get; init; } 
    #else
    public System.DateTime? ExpiryDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amount of money paid by the investor in addition to the switch redemption amount.
    /// </summary>
    [IsoId("_VV3PdNp-Ed-ak6NoX_4Aeg_-1360536042")]
    [DisplayName("Additional Cash In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCshIn")]
    #endif
    [IsoXmlTag("AddtlCshIn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that results from a switch-out, that is not reinvested in another investment fund, and is repaid to the investor.
    /// </summary>
    [IsoId("_VV3Pddp-Ed-ak6NoX_4Aeg_-1360535905")]
    [DisplayName("Resulting Cash Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltgCshOut")]
    #endif
    [IsoXmlTag("RsltgCshOut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; set; } 
    #endif
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VV3Pdtp-Ed-ak6NoX_4Aeg_-1360535550")]
    [DisplayName("Cancellation Right")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRght")]
    #endif
    [IsoXmlTag("CxlRght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationRight1? CancellationRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRight1? CancellationRight { get; init; } 
    #else
    public CancellationRight1? CancellationRight { get; set; } 
    #endif
    
    /// <summary>
    /// Part of an investment fund switch order that is a redemption.
    /// </summary>
    [IsoId("_VV3Pd9p-Ed-ak6NoX_4Aeg_-1360535454")]
    [DisplayName("Redemption Leg Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedLegDtls")]
    #endif
    [IsoXmlTag("RedLegDtls")]
    public ValueList<SwitchRedemptionLegOrder2> RedemptionLegDetails { get; init; } = new ValueList<SwitchRedemptionLegOrder2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VV3Pd9p-Ed-ak6NoX_4Aeg_-1360535454
    
    /// <summary>
    /// Part of an investment fund switch order that is a subscription.
    /// </summary>
    [IsoId("_VWBAcNp-Ed-ak6NoX_4Aeg_-1360535181")]
    [DisplayName("Subscription Leg Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptLegDtls")]
    #endif
    [IsoXmlTag("SbcptLegDtls")]
    public ValueList<SwitchSubscriptionLegOrder2> SubscriptionLegDetails { get; init; } = new ValueList<SwitchSubscriptionLegOrder2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VWBAcNp-Ed-ak6NoX_4Aeg_-1360535181
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VWBAcdp-Ed-ak6NoX_4Aeg_-1360535146")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction20? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction20? CashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction20? CashSettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_VWBActp-Ed-ak6NoX_4Aeg_1639276235")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
