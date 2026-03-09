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
/// Specifies a percentage together with a period of time. For overlapping periods, the maximum of all applicable elements at a given date is the result.
/// </summary>
[IsoId("_OTgzMzg0-AOSNFX-8224502")]
[DisplayName("Percentage And Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PercentageAndPeriod1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PercentageAndPeriod1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PercentageAndPeriod1( System.Decimal reqPercentage )
    {
        Percentage = reqPercentage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Covered percentage (max 100%).
    /// </summary>
    [IsoId("_OTgzMzg1-AOSNFX-8224502")]
    [DisplayName("Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pctg")]
    #endif
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageBoundedRate Percentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Percentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Percentage { get; init; } 
    #else
    public System.Decimal Percentage { get; set; } 
    #endif
    
    /// <summary>
    /// Start of period or immediate if not specified.
    /// </summary>
    [IsoId("_OTgzMzg2-AOSNFX-8224502")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// End of period or indefinite if not specified.
    /// </summary>
    [IsoId("_OThzMzg2-AOSNFX-8224502")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EndDate { get; init; } 
    #else
    public System.DateOnly? EndDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
