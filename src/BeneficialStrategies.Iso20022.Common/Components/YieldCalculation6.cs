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
[IsoId("_1qNR4Wp7EemmaZLSPtWX5A")]
[DisplayName("Yield Calculation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record YieldCalculation6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a YieldCalculation6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public YieldCalculation6( System.Decimal reqValue,System.DateOnly reqValueDate,DateTimePeriod1Choice_ reqValuePeriod,System.DateTime reqCalculationDate )
    {
        Value = reqValue;
        ValueDate = reqValueDate;
        ValuePeriod = reqValuePeriod;
        CalculationDate = reqCalculationDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Result of the yield calculation.
    /// </summary>
    [IsoId("_12n9QWp7EemmaZLSPtWX5A")]
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
    [IsoId("_12n9SWp7EemmaZLSPtWX5A")]
    [DisplayName("Calculation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnTp")]
    #endif
    [IsoXmlTag("ClctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CalculationType3Choice_? CalculationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CalculationType3Choice_? CalculationType { get; init; } 
    #else
    public CalculationType3Choice_? CalculationType { get; set; } 
    #endif
    
    /// <summary>
    /// Price to which the yield has been calculated.
    /// </summary>
    [IsoId("_12n9UWp7EemmaZLSPtWX5A")]
    [DisplayName("Redemption Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPric")]
    #endif
    [IsoXmlTag("RedPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price8? RedemptionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price8? RedemptionPrice { get; init; } 
    #else
    public Price8? RedemptionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the calculation is based, for example, valuation on October 1 (price date) based on price of September 19 ( value date).
    /// </summary>
    [IsoId("_12n9X2p7EemmaZLSPtWX5A")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValueDate { get; init; } 
    #else
    public System.DateOnly ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Period on which the calculation is based.
    /// </summary>
    [IsoId("_12n9Z2p7EemmaZLSPtWX5A")]
    [DisplayName("Value Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValPrd")]
    #endif
    [IsoXmlTag("ValPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateTimePeriod1Choice_ ValuePeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateTimePeriod1Choice_ ValuePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_ ValuePeriod { get; init; } 
    #else
    public DateTimePeriod1Choice_ ValuePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Clarifies yield irregularities associated with date, for example when it falls on a non-business day.
    /// </summary>
    [IsoId("_12n9b2p7EemmaZLSPtWX5A")]
    [DisplayName("Calculation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnDt")]
    #endif
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CalculationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CalculationDate { get; init; } 
    #else
    public System.DateTime CalculationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
