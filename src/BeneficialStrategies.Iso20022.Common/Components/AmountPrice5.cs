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
[IsoId("_Wi6RZdp-Ed-ak6NoX_4Aeg_-2041286606")]
[DisplayName("Amount Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountPrice5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountPrice5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountPrice5( AmountPriceType1Code reqAmountPriceType,RestrictedFINActiveCurrencyAnd13DecimalAmount reqPriceValue )
    {
        AmountPriceType = reqAmountPriceType;
        PriceValue = reqPriceValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_Wi6RZtp-Ed-ak6NoX_4Aeg_259535984")]
    [DisplayName("Amount Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtPricTp")]
    #endif
    [IsoXmlTag("AmtPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountPriceType1Code AmountPriceType { get; init; } 
    #else
    public AmountPriceType1Code AmountPriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_Wi6RZ9p-Ed-ak6NoX_4Aeg_-1734608722")]
    [DisplayName("Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricVal")]
    #endif
    [IsoXmlTag("PricVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
