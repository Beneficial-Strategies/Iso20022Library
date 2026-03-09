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
/// Specifies the rate adjustments as determined by the rate schedule.
/// </summary>
[IsoId("_D6Df4CDwEeahCJeThTBhHA")]
[DisplayName("Rate Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateAdjustment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RateAdjustment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RateAdjustment1( System.Decimal reqRate,System.DateOnly reqAdjustmentDate )
    {
        Rate = reqRate;
        AdjustmentDate = reqAdjustmentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the rate as determined by the rate schedule.
    /// </summary>
    [IsoId("_J3YZ8CDwEeahCJeThTBhHA")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Rate { get; init; } 
    #else
    public System.Decimal Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies date as of which the rate is effective.
    /// </summary>
    [IsoId("_OaFwICDwEeahCJeThTBhHA")]
    [DisplayName("Adjustment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstmntDt")]
    #endif
    [IsoXmlTag("AdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate AdjustmentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly AdjustmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly AdjustmentDate { get; init; } 
    #else
    public System.DateOnly AdjustmentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
