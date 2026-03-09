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
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_HPltAQc_EeSyIPzOZ6VzBQ")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice19( UnitPriceType2Choice_ reqPriceType,PriceValue1 reqValue )
    {
        PriceType = reqPriceType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of price.
    /// </summary>
    [IsoId("_Hp64kQc_EeSyIPzOZ6VzBQ")]
    [DisplayName("Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricTp")]
    #endif
    [IsoXmlTag("PricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitPriceType2Choice_ PriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitPriceType2Choice_ PriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitPriceType2Choice_ PriceType { get; init; } 
    #else
    public UnitPriceType2Choice_ PriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, that is, as a currency and value.
    /// </summary>
    [IsoId("_Hp64kwc_EeSyIPzOZ6VzBQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceValue1 Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceValue1 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1 Value { get; init; } 
    #else
    public PriceValue1 Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
