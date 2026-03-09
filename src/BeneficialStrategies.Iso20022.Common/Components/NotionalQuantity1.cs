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
/// Indicates the reference quantity of the transaction and the schedule applicable to the quantity computation.
/// </summary>
[IsoId("_8P5WAAbHEeqrW7Meu5r3kQ")]
[DisplayName("Notional Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotionalQuantity1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NotionalQuantity1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NotionalQuantity1( System.UInt64 reqQuantity,UnitOfMeasure12Code reqUnitOfMeasure )
    {
        Quantity = reqQuantity;
        UnitOfMeasure = reqUnitOfMeasure;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("__zSkQgbHEeqrW7Meu5r3kQ")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLongFraction19DecimalNumber Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Quantity { get; init; } 
    #else
    public System.UInt64 Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in non-monetary amounts with a notional quantity varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_ZIXWIQbIEeqrW7Meu5r3kQ")]
    [DisplayName("Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Schdl")]
    #endif
    [IsoXmlTag("Schdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Schedule2? Schedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Schedule2? Schedule { get; init; } 
    #else
    public Schedule2? Schedule { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
    /// </summary>
    [IsoId("__zSkQwbHEeqrW7Meu5r3kQ")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOfMeasure12Code UnitOfMeasure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOfMeasure12Code UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure12Code UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure12Code UnitOfMeasure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
