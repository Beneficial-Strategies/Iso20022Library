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
[IsoId("_ckC_d5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice64
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
    [IsoId("_ckC_e5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cash In Lieu Of Share Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInLieuOfShrPric")]
    #endif
    [IsoXmlTag("CshInLieuOfShrPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat52Choice_? CashInLieuOfSharePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat52Choice_? CashInLieuOfSharePrice { get; init; } 
    #else
    public PriceFormat52Choice_? CashInLieuOfSharePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    [IsoId("_ckC_g5KQEeWHWpTQn1FFVg")]
    [DisplayName("Indicative Or Market Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndctvOrMktPric")]
    #endif
    [IsoXmlTag("IndctvOrMktPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndicativeOrMarketPrice9Choice_? IndicativeOrMarketPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndicativeOrMarketPrice9Choice_? IndicativeOrMarketPrice { get; init; } 
    #else
    public IndicativeOrMarketPrice9Choice_? IndicativeOrMarketPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    [IsoId("_ckC_i5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cash Value For Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshValForTax")]
    #endif
    [IsoXmlTag("CshValForTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountPrice4? CashValueForTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountPrice4? CashValueForTax { get; init; } 
    #else
    public AmountPrice4? CashValueForTax { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    [IsoId("_ckC_jZKQEeWHWpTQn1FFVg")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricPdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricPdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat55Choice_? GenericCashPricePaidPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat55Choice_? GenericCashPricePaidPerProduct { get; init; } 
    #else
    public PriceFormat55Choice_? GenericCashPricePaidPerProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_ckC_j5KQEeWHWpTQn1FFVg")]
    [DisplayName("Generic Cash Price Received Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricRcvdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat56Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat56Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #else
    public PriceFormat56Choice_? GenericCashPriceReceivedPerProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}
