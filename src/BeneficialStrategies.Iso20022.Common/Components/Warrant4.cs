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
/// Financial instrument that gives the holder the right to purchase shares or bonds at a given price within a specified time.
/// </summary>
[IsoId("_rfndQWf2Eembv_9KtOEw8g")]
[DisplayName("Warrant")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Warrant4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the ratio or multiply factor used to convert from contracts to shares.
    /// </summary>
    [IsoId("_rsuFIWf2Eembv_9KtOEw8g")]
    [DisplayName("Multiplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mltplr")]
    #endif
    [IsoXmlTag("Mltplr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? Multiplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Multiplier { get; init; } 
    #else
    public System.Decimal? Multiplier { get; set; } 
    #endif
    
    /// <summary>
    /// Pre-determined price at which the holder of a warrant is entitled to buy the underlying instrument.
    /// </summary>
    [IsoId("_rsuFI2f2Eembv_9KtOEw8g")]
    [DisplayName("Subscription Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPric")]
    #endif
    [IsoXmlTag("SbcptPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price8? SubscriptionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price8? SubscriptionPrice { get; init; } 
    #else
    public Price8? SubscriptionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates when a warrant can be exercised.
    /// </summary>
    [IsoId("_rsuFJWf2Eembv_9KtOEw8g")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public WarrantStyle3Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WarrantStyle3Choice_? Type { get; init; } 
    #else
    public WarrantStyle3Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Entity appointed by the issuer to process the exercising of warrants, sometimes responsible for the issuance of the warrants into the market.
    /// </summary>
    [IsoId("_rsuFJ2f2Eembv_9KtOEw8g")]
    [DisplayName("Warrant Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WarrtAgt")]
    #endif
    [IsoXmlTag("WarrtAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation38? WarrantAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation38? WarrantAgent { get; init; } 
    #else
    public Organisation38? WarrantAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
