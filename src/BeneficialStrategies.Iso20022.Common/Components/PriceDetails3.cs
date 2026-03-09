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
/// Provides information about the prices related to a corporate action option.
/// </summary>
[IsoId("_5aw-RuzaEd-Z2q4-Bbm3ZA")]
[DisplayName("Price Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// 1. Price at which security will be purchased/sold if warrant is exercised, either as an actual amount or a percentage.|2. Price at which a bond is converted to underlying security either as an actual amount or a percentage.|3. Strike price of an option, represented either as an actual amount, a percentage or a number of points above an index.
    /// </summary>
    [IsoId("_XrRAMOtLEd-PFJLHKom6FA")]
    [DisplayName("Exercise Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcPric")]
    #endif
    [IsoXmlTag("ExrcPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat23Choice_? ExercisePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat23Choice_? ExercisePrice { get; init; } 
    #else
    public PriceFormat23Choice_? ExercisePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [IsoId("_ZGwt0OtLEd-PFJLHKom6FA")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricPdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricPdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat19Choice_? GenericCashPricePaidPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat19Choice_? GenericCashPricePaidPerProduct { get; init; } 
    #else
    public PriceFormat19Choice_? GenericCashPricePaidPerProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_OyHXIffhEd-ebNlrGf0-3Q")]
    [DisplayName("Generic Cash Price Received Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricRcvdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat22Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat22Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #else
    public PriceFormat22Choice_? GenericCashPriceReceivedPerProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}
