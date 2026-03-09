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
/// Environment of Retailer for this message.
/// </summary>
[IsoId("_EGn-QYX-EemxIqbaFEE8-w")]
[DisplayName("Retailer Sale Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RetailerSaleEnvironment2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Capabilities of the Sale system.
    /// </summary>
    [IsoId("_ES4RkYX-EemxIqbaFEE8-w")]
    [DisplayName("Sale Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleCpblties")]
    #endif
    [IsoXmlTag("SaleCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleCapabilities1Code? SaleCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleCapabilities1Code? SaleCapabilities { get; init; } 
    #else
    public SaleCapabilities1Code? SaleCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Default currency associated with the sale system.
    /// </summary>
    [IsoId("_KXvXAIX-EemxIqbaFEE8-w")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount the Sale System is allowed to deliver for this payment.
    /// </summary>
    [IsoId("_ES4Rk4X-EemxIqbaFEE8-w")]
    [DisplayName("Minimum Amount To Deliver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinAmtToDlvr")]
    #endif
    [IsoXmlTag("MinAmtToDlvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MinimumAmountToDeliver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MinimumAmountToDeliver { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MinimumAmountToDeliver { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount which could be requested for cash-back.
    /// </summary>
    [IsoId("_ES4RlYX-EemxIqbaFEE8-w")]
    [DisplayName("Maximum Cash Back Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxCshBckAmt")]
    #endif
    [IsoXmlTag("MaxCshBckAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MaximumCashBackAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MaximumCashBackAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MaximumCashBackAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount to split a sale transaction.
    /// </summary>
    [IsoId("_ES4Rl4X-EemxIqbaFEE8-w")]
    [DisplayName("Minimum Split Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinSpltAmt")]
    #endif
    [IsoXmlTag("MinSpltAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MinimumSplitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MinimumSplitAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MinimumSplitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Flag if preferred type of payment is a debit transaction.
    /// </summary>
    [IsoId("_ES4RmYX-EemxIqbaFEE8-w")]
    [DisplayName("Debit Preferred Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtPrefrdFlg")]
    #endif
    [IsoXmlTag("DbtPrefrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DebitPreferredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebitPreferredFlag { get; init; } 
    #else
    public System.String? DebitPreferredFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Way of Loyalty handling.
    /// </summary>
    [IsoId("_ES4Rm4X-EemxIqbaFEE8-w")]
    [DisplayName("Loyalty Handling")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyHdlg")]
    #endif
    [IsoXmlTag("LltyHdlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyHandling1Code? LoyaltyHandling { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyHandling1Code? LoyaltyHandling { get; init; } 
    #else
    public LoyaltyHandling1Code? LoyaltyHandling { get; set; } 
    #endif
    
    
    #nullable disable
    
}
