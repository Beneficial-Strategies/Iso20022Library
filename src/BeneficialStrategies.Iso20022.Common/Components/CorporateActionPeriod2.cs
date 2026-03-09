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
/// Specifies periods.
/// </summary>
[IsoId("_TfjOGdp-Ed-ak6NoX_4Aeg_-1268934712")]
[DisplayName("Corporate Action Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPeriod2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Period during which the assented line is available.
    /// </summary>
    [IsoId("_Tfs_ENp-Ed-ak6NoX_4Aeg_251714713")]
    [DisplayName("Assented Line Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssntdLinePrd")]
    #endif
    [IsoXmlTag("AssntdLinePrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? AssentedLinePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? AssentedLinePeriod { get; init; } 
    #else
    public Period1? AssentedLinePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, eg, offer period.
    /// </summary>
    [IsoId("_Tfs_Edp-Ed-ak6NoX_4Aeg_205021481")]
    [DisplayName("Action Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnPrd")]
    #endif
    [IsoXmlTag("ActnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? ActionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? ActionPeriod { get; init; } 
    #else
    public Period1? ActionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the privilege is not available, eg, this can happen whenever a meeting takes place or whenever a coupon payment is due.
    /// </summary>
    [IsoId("_Tfs_Etp-Ed-ak6NoX_4Aeg_-1027220303")]
    [DisplayName("Privilege Suspension Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvlgSspnsnPrd")]
    #endif
    [IsoXmlTag("PrvlgSspnsnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? PrivilegeSuspensionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? PrivilegeSuspensionPeriod { get; init; } 
    #else
    public Period1? PrivilegeSuspensionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, eg, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_Tfs_E9p-Ed-ak6NoX_4Aeg_-954261746")]
    [DisplayName("Parallel Trading Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParllTradgPrd")]
    #endif
    [IsoXmlTag("ParllTradgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? ParallelTradingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? ParallelTradingPeriod { get; init; } 
    #else
    public Period1? ParallelTradingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period (last day included) during which an account owner can surrender or sell securities to the issuer and receive the sale proceeds.
    /// </summary>
    [IsoId("_Tfs_FNp-Ed-ak6NoX_4Aeg_-910856320")]
    [DisplayName("Sell Thru Issuer Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellThruIssrPrd")]
    #endif
    [IsoXmlTag("SellThruIssrPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? SellThruIssuerPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? SellThruIssuerPeriod { get; init; } 
    #else
    public Period1? SellThruIssuerPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the shareholder can revoke, change or withdraw its instruction.
    /// </summary>
    [IsoId("_Tfs_Fdp-Ed-ak6NoX_4Aeg_-868373428")]
    [DisplayName("Revocability Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltyPrd")]
    #endif
    [IsoXmlTag("RvcbltyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? RevocabilityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? RevocabilityPeriod { get; init; } 
    #else
    public Period1? RevocabilityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the price of a security is determined (for outturn securities).
    /// </summary>
    [IsoId("_Tfs_Ftp-Ed-ak6NoX_4Aeg_-823779950")]
    [DisplayName("Price Calculation Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricClctnPrd")]
    #endif
    [IsoXmlTag("PricClctnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? PriceCalculationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? PriceCalculationPeriod { get; init; } 
    #else
    public Period1? PriceCalculationPeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
