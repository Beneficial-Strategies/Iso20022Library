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
/// Price expressed as a percentage price.
/// </summary>
[IsoId("_QaQ4Ktp-Ed-ak6NoX_4Aeg_724274037")]
[DisplayName("Percentage Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PercentagePrice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PercentagePrice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PercentagePrice1( PriceRateType3Code reqPercentagePriceType,System.Decimal reqPriceValue )
    {
        PercentagePriceType = reqPercentagePriceType;
        PriceValue = reqPriceValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of percentage price.
    /// </summary>
    [IsoId("_QaaCENp-Ed-ak6NoX_4Aeg_724274055")]
    [DisplayName("Percentage Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgPricTp")]
    #endif
    [IsoXmlTag("PctgPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateType3Code PercentagePriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateType3Code PercentagePriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateType3Code PercentagePriceType { get; init; } 
    #else
    public PriceRateType3Code PercentagePriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value of price.
    /// </summary>
    [IsoId("_QaaCEdp-Ed-ak6NoX_4Aeg_724274080")]
    [DisplayName("Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricVal")]
    #endif
    [IsoXmlTag("PricVal")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate PriceValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal PriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal PriceValue { get; init; } 
    #else
    public System.Decimal PriceValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
