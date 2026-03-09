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
/// Price expressed as an actual amount.
/// </summary>
[IsoId("_QaHHItp-Ed-ak6NoX_4Aeg_-176433856")]
[DisplayName("Amount Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountPrice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountPrice2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountPrice2( AmountPriceType2Code reqAmountPriceType,ActiveCurrencyAnd13DecimalAmount reqPriceValue )
    {
        AmountPriceType = reqAmountPriceType;
        PriceValue = reqPriceValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_QaHHI9p-Ed-ak6NoX_4Aeg_141257751")]
    [DisplayName("Amount Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtPricTp")]
    #endif
    [IsoXmlTag("AmtPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountPriceType2Code AmountPriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountPriceType2Code AmountPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountPriceType2Code AmountPriceType { get; init; } 
    #else
    public AmountPriceType2Code AmountPriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QaHHJNp-Ed-ak6NoX_4Aeg_94966020")]
    [DisplayName("Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricVal")]
    #endif
    [IsoXmlTag("PricVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount PriceValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
