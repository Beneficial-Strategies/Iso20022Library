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
[IsoId("_U4XbJNp-Ed-ak6NoX_4Aeg_-1749119969")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice1( TypeOfPrice2Code reqType,PriceValue1 reqValue )
    {
        Type = reqType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U4XbJdp-Ed-ak6NoX_4Aeg_-1749119968")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice2Code Type { get; init; } 
    #else
    public TypeOfPrice2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4XbJtp-Ed-ak6NoX_4Aeg_-1749119967")]
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
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_U4XbJ9p-Ed-ak6NoX_4Aeg_225497879")]
    [DisplayName("Price Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMtd")]
    #endif
    [IsoXmlTag("PricMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceMethod1Code? PriceMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceMethod1Code? PriceMethod { get; init; } 
    #else
    public PriceMethod1Code? PriceMethod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
