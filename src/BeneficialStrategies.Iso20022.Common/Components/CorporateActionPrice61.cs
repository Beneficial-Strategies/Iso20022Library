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
/// Specifies prices.
/// </summary>
[IsoId("_QCk_M0GMEeWqy4niLuXETA")]
[DisplayName("Corporate Action Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice61
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_QPYFBUGMEeWqy4niLuXETA")]
    [DisplayName("Cash In Lieu Of Share Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInLieuOfShrPric")]
    #endif
    [IsoXmlTag("CshInLieuOfShrPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat50Choice_? CashInLieuOfSharePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat50Choice_? CashInLieuOfSharePrice { get; init; } 
    #else
    public PriceFormat50Choice_? CashInLieuOfSharePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_QPYFDUGMEeWqy4niLuXETA")]
    [DisplayName("Over Subscription Deposit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OverSbcptDpstPric")]
    #endif
    [IsoXmlTag("OverSbcptDpstPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat50Choice_? OverSubscriptionDepositPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat50Choice_? OverSubscriptionDepositPrice { get; init; } 
    #else
    public PriceFormat50Choice_? OverSubscriptionDepositPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
