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
[IsoId("_M6nGkfo1EeCqjOT-vUu2sQ")]
[DisplayName("Corporate Action Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice26
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
    [IsoId("_M6nGl_o1EeCqjOT-vUu2sQ")]
    [DisplayName("Indicative Or Market Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndctvOrMktPric")]
    #endif
    [IsoXmlTag("IndctvOrMktPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndicativeOrMarketPrice5Choice_? IndicativeOrMarketPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndicativeOrMarketPrice5Choice_? IndicativeOrMarketPrice { get; init; } 
    #else
    public IndicativeOrMarketPrice5Choice_? IndicativeOrMarketPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_M6nGofo1EeCqjOT-vUu2sQ")]
    [DisplayName("Cash In Lieu Of Share Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInLieuOfShrPric")]
    #endif
    [IsoXmlTag("CshInLieuOfShrPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat19Choice_? CashInLieuOfSharePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat19Choice_? CashInLieuOfSharePrice { get; init; } 
    #else
    public PriceFormat19Choice_? CashInLieuOfSharePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    [IsoId("_PRkW6_o1EeCqjOT-vUu2sQ")]
    [DisplayName("Cash Value For Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshValForTax")]
    #endif
    [IsoXmlTag("CshValForTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat29Choice_? CashValueForTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat29Choice_? CashValueForTax { get; init; } 
    #else
    public PriceFormat29Choice_? CashValueForTax { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [IsoId("_cUHN4_o6EeCVCIR-Uq3c5A")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricPdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricPdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat23Choice_? GenericCashPricePaidPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat23Choice_? GenericCashPricePaidPerProduct { get; init; } 
    #else
    public PriceFormat23Choice_? GenericCashPricePaidPerProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_eMEOA_o6EeCVCIR-Uq3c5A")]
    [DisplayName("Generic Cash Price Received Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricRcvdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat20Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat20Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #else
    public PriceFormat20Choice_? GenericCashPriceReceivedPerProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}
