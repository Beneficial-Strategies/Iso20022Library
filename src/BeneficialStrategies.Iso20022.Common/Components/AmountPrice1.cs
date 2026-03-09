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
/// Price expressed as an amount.
/// </summary>
[IsoId("_Qa2uCNp-Ed-ak6NoX_4Aeg_-199225391")]
[DisplayName("Amount Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountPrice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountPrice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountPrice1( AmountPriceType1FormatChoice_ reqAmountPriceType,ActiveCurrencyAnd13DecimalAmount reqPriceValue )
    {
        AmountPriceType = reqAmountPriceType;
        PriceValue = reqPriceValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_QbAfANp-Ed-ak6NoX_4Aeg_-167828504")]
    [DisplayName("Amount Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtPricTp")]
    #endif
    [IsoXmlTag("AmtPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountPriceType1FormatChoice_ AmountPriceType { get; init; } 
    #else
    public AmountPriceType1FormatChoice_ AmountPriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QbAfAdp-Ed-ak6NoX_4Aeg_-140122918")]
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
