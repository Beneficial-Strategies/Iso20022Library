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
[IsoId("_XES6ISJBEe2zWP9pqvmqdw")]
[DisplayName("Notional Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotionalQuantity9
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
    [IsoId("_XFM5ESJBEe2zWP9pqvmqdw")]
    [DisplayName("Total Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlQty")]
    #endif
    [IsoXmlTag("TtlQty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLongFraction19DecimalNumber? TotalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalQuantity { get; init; } 
    #else
    public System.UInt64? TotalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
    /// </summary>
    [IsoId("_XFM5FSJBEe2zWP9pqvmqdw")]
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
    /// Indicates the schedule or frequency of the derivative transactions.
    /// </summary>
    [IsoId("_ZJkvICJCEe2zWP9pqvmqdw")]
    [DisplayName("Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dtls")]
    #endif
    [IsoXmlTag("Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrTerm1Choice_? Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrTerm1Choice_? Details { get; init; } 
    #else
    public QuantityOrTerm1Choice_? Details { get; set; } 
    #endif
    
    
    #nullable disable
    
}
