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
/// Return provided by a financial instrument.
/// </summary>
[IsoId("_eFO8kQeCEe2fOITqoTnSLQ")]
[DisplayName("Yield Calculation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record YieldCalculation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a YieldCalculation7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public YieldCalculation7( System.Decimal reqValue,CalculationType1Code reqCalculationType )
    {
        Value = reqValue;
        CalculationType = reqCalculationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Result of the yield calculation.
    /// </summary>
    [IsoId("_eXkCsQeCEe2fOITqoTnSLQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Value { get; init; } 
    #else
    public System.Decimal Value { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of calculation.
    /// </summary>
    [IsoId("_eXkCuQeCEe2fOITqoTnSLQ")]
    [DisplayName("Calculation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnTp")]
    #endif
    [IsoXmlTag("ClctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CalculationType1Code CalculationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CalculationType1Code CalculationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CalculationType1Code CalculationType { get; init; } 
    #else
    public CalculationType1Code CalculationType { get; set; } 
    #endif
    
    /// <summary>
    /// Price to which the yield has been calculated.
    /// </summary>
    [IsoId("_eXkCwQeCEe2fOITqoTnSLQ")]
    [DisplayName("Redemption Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPric")]
    #endif
    [IsoXmlTag("RedPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? RedemptionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? RedemptionPrice { get; init; } 
    #else
    public Price14? RedemptionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the calculation is based, for example, valuation on October 1 (price date) based on price of September 19 ( value date).
    /// </summary>
    [IsoId("_eXkCzweCEe2fOITqoTnSLQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDate { get; init; } 
    #else
    public System.DateOnly? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Period on which the calculation is based.
    /// </summary>
    [IsoId("_eXkC1weCEe2fOITqoTnSLQ")]
    [DisplayName("Value Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValPrd")]
    #endif
    [IsoXmlTag("ValPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1Choice_? ValuePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_? ValuePeriod { get; init; } 
    #else
    public DateTimePeriod1Choice_? ValuePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Included as needed to clarify yield irregularities associated with date, e.g. when it falls on a non-business day.
    /// </summary>
    [IsoId("_eXkC3weCEe2fOITqoTnSLQ")]
    [DisplayName("Calculation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnDt")]
    #endif
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CalculationDate { get; init; } 
    #else
    public System.DateOnly? CalculationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
