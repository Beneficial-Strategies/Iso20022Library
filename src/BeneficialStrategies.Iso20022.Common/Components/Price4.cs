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
/// Provides the value and optionaly the type of price.
/// </summary>
[IsoId("_QeScgNp-Ed-ak6NoX_4Aeg_2016277432")]
[DisplayName("Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Price4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Price4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Price4( PriceRateOrAmountChoice_ reqValue )
    {
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QeScgdp-Ed-ak6NoX_4Aeg_-1069713425")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmountChoice_ Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateOrAmountChoice_ Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmountChoice_ Value { get; init; } 
    #else
    public PriceRateOrAmountChoice_ Value { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_QeScgtp-Ed-ak6NoX_4Aeg_61095194")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValueType7Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueType7Code? Type { get; init; } 
    #else
    public PriceValueType7Code? Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
