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
/// Execution of a switch order.
/// </summary>
[IsoId("_VVkUhdp-Ed-ak6NoX_4Aeg_-1431911896")]
[DisplayName("Switch Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchExecution3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SwitchExecution3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchExecution3( System.String reqDealReference,System.String reqOrderReference,InvestmentAccount13 reqInvestmentAccountDetails )
    {
        DealReference = reqDealReference;
        OrderReference = reqOrderReference;
        InvestmentAccountDetails = reqInvestmentAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VVkUhtp-Ed-ak6NoX_4Aeg_-1431911877")]
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
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_VVkUh9p-Ed-ak6NoX_4Aeg_-1431911853")]
    [DisplayName("Deal Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealRef")]
    #endif
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DealReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DealReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DealReference { get; init; } 
    #else
    public System.String DealReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VVkUiNp-Ed-ak6NoX_4Aeg_-1431911836")]
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
    [IsoId("_VVkUidp-Ed-ak6NoX_4Aeg_-1431911041")]
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
    /// Amount of money used to determine the quantity of investment fund units to be redeemed.
    /// </summary>
    [IsoId("_VVkUitp-Ed-ak6NoX_4Aeg_-1431911818")]
    [DisplayName("Total Redemption Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRedAmt")]
    #endif
    [IsoXmlTag("TtlRedAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalRedemptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money used to determine the quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_VVkUi9p-Ed-ak6NoX_4Aeg_-1431911801")]
    [DisplayName("Total Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSbcptAmt")]
    #endif
    [IsoXmlTag("TtlSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amount of money paid by the investor in addition to the switch redemption amount.
    /// </summary>
    [IsoId("_VVkUjNp-Ed-ak6NoX_4Aeg_-1431911783")]
    [DisplayName("Additional Cash In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCshIn")]
    #endif
    [IsoXmlTag("AddtlCshIn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AdditionalCashIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AdditionalCashIn { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AdditionalCashIn { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that results from a switch-out, that is not reinvested in another investment fund, and is repaid to the investor.
    /// </summary>
    [IsoId("_VVuFgNp-Ed-ak6NoX_4Aeg_-1431911541")]
    [DisplayName("Resulting Cash Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltgCshOut")]
    #endif
    [IsoXmlTag("RsltgCshOut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ResultingCashOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ResultingCashOut { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ResultingCashOut { get; set; } 
    #endif
    
    /// <summary>
    /// Redemption leg of a switch order execution.
    /// </summary>
    [IsoId("_VVuFgdp-Ed-ak6NoX_4Aeg_-1431911410")]
    [DisplayName("Redemption Leg Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedLegDtls")]
    #endif
    [IsoXmlTag("RedLegDtls")]
    public ValueList<SwitchRedemptionLegExecution2> RedemptionLegDetails { get; init; } = new ValueList<SwitchRedemptionLegExecution2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VVuFgdp-Ed-ak6NoX_4Aeg_-1431911410
    
    /// <summary>
    /// Subscription leg of a switch order execution.
    /// </summary>
    [IsoId("_VVuFgtp-Ed-ak6NoX_4Aeg_-1431911480")]
    [DisplayName("Subscription Leg Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptLegDtls")]
    #endif
    [IsoXmlTag("SbcptLegDtls")]
    public ValueList<SwitchSubscriptionLegExecution2> SubscriptionLegDetails { get; init; } = new ValueList<SwitchSubscriptionLegExecution2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VVuFgtp-Ed-ak6NoX_4Aeg_-1431911480
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VVuFg9p-Ed-ak6NoX_4Aeg_-1431911368")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction14? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction14? CashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction14? CashSettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Currency exchange related to the execution of an investment fund order.
    /// </summary>
    [IsoId("_VVuFhNp-Ed-ak6NoX_4Aeg_-1431911102")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
