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
/// Describes the notional quantity frequency.
/// </summary>
[IsoId("_X-QgoSJEEe2zWP9pqvmqdw")]
[DisplayName("Quantity Term")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityTerm1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_n1kXkSJEEe2zWP9pqvmqdw")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLongFraction19DecimalNumber? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Quantity { get; init; } 
    #else
    public System.UInt64? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
    /// </summary>
    [IsoId("_6LpXASJEEe2zWP9pqvmqdw")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of time units (as expressed by the frequency period) that determines the frequency at which periodic dates occur.
    /// </summary>
    [IsoId("_X_OJ8SJEEe2zWP9pqvmqdw")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Value { get; init; } 
    #else
    public System.UInt64? Value { get; set; } 
    #endif
    
    /// <summary>
    /// Unit for the frequency period.
    /// </summary>
    [IsoId("_X_EY8yJEEe2zWP9pqvmqdw")]
    [DisplayName("Time Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmUnit")]
    #endif
    [IsoXmlTag("TmUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency19Code? TimeUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency19Code? TimeUnit { get; init; } 
    #else
    public Frequency19Code? TimeUnit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
