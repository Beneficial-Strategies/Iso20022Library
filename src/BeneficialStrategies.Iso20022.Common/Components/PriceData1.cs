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
/// Indicates the details of the price applicable to the derivative transaction.
/// </summary>
[IsoId("_hM_uQHizEeqKjIYaFgh_2g")]
[DisplayName("Price Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable: fees, taxes or commissions.
    /// </summary>
    [IsoId("_nPhRYXizEeqKjIYaFgh_2g")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice17Choice_? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice17Choice_? Price { get; init; } 
    #else
    public SecuritiesTransactionPrice17Choice_? Price { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions with prices varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_olN5AXizEeqKjIYaFgh_2g")]
    [DisplayName("Price Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricSchdl")]
    #endif
    [IsoXmlTag("PricSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Schedule1? PriceSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Schedule1? PriceSchedule { get; init; } 
    #else
    public Schedule1? PriceSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unit of measure in which the price is expressed.
    /// </summary>
    [IsoId("_N--_EX_3EeqdQubSe21TTw")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure12Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure12Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure12Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// </summary>
    [IsoId("_p2moYXizEeqKjIYaFgh_2g")]
    [DisplayName("Price Multiplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMltplr")]
    #endif
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLongFraction19DecimalNumber? PriceMultiplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PriceMultiplier { get; init; } 
    #else
    public System.UInt64? PriceMultiplier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
