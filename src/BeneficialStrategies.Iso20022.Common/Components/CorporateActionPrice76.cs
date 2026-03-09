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
/// Specifies prices related to a corporate action option.
/// </summary>
[IsoId("_OovFnRuyEeyhRdHRjakS2w")]
[DisplayName("Corporate Action Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice76
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [IsoId("_O9l7RRuyEeyhRdHRjakS2w")]
    [DisplayName("Indicative Or Market Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndctvOrMktPric")]
    #endif
    [IsoXmlTag("IndctvOrMktPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndicativeOrMarketPrice8Choice_? IndicativeOrMarketPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndicativeOrMarketPrice8Choice_? IndicativeOrMarketPrice { get; init; } 
    #else
    public IndicativeOrMarketPrice8Choice_? IndicativeOrMarketPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    [IsoId("_O9l7TRuyEeyhRdHRjakS2w")]
    [DisplayName("Issue Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssePric")]
    #endif
    [IsoXmlTag("IssePric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat50Choice_? IssuePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat50Choice_? IssuePrice { get; init; } 
    #else
    public PriceFormat50Choice_? IssuePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_O9l7VRuyEeyhRdHRjakS2w")]
    [DisplayName("Generic Cash Price Received Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricRcvdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat66Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat66Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #else
    public PriceFormat66Choice_? GenericCashPriceReceivedPerProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [IsoId("_O9l7XRuyEeyhRdHRjakS2w")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricPdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricPdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat50Choice_? GenericCashPricePaidPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat50Choice_? GenericCashPricePaidPerProduct { get; init; } 
    #else
    public PriceFormat50Choice_? GenericCashPricePaidPerProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}
