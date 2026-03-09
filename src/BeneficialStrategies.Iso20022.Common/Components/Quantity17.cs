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
/// Quantity of the commodity.
/// </summary>
[IsoId("_jOPbKaocEemdLtwzt4CWxg")]
[DisplayName("Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Quantity17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Quantity17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Quantity17( System.UInt64 reqValue,UnitOfMeasure11Code reqUnitOfMeasure )
    {
        Value = reqValue;
        UnitOfMeasure = reqUnitOfMeasure;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Fair value of the individual collateral component expressed in price currency.
    /// </summary>
    [IsoId("_jRzsgaocEemdLtwzt4CWxg")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Value { get; init; } 
    #else
    public System.UInt64 Value { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure in which the quantity is expressed.
    /// </summary>
    [IsoId("_jRzsg6ocEemdLtwzt4CWxg")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOfMeasure11Code UnitOfMeasure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOfMeasure11Code UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure11Code UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure11Code UnitOfMeasure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
