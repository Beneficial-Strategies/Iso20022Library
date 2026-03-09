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
/// Identifies the removal type, the reason, the exclusion period, the extension date and the termination date.
/// </summary>
[IsoId("_50I1UPolEeiAfJEqh4xF_Q")]
[DisplayName("Removal Type And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemovalTypeAndReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RemovalTypeAndReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RemovalTypeAndReason1( Removal1Choice_ reqRemovalType )
    {
        RemovalType = reqRemovalType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the removal processing change requested.
    /// </summary>
    [IsoId("_FKebcPomEeiAfJEqh4xF_Q")]
    [DisplayName("Removal Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmvlTp")]
    #endif
    [IsoXmlTag("RmvlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Removal1Choice_ RemovalType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Removal1Choice_ RemovalType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Removal1Choice_ RemovalType { get; init; } 
    #else
    public Removal1Choice_ RemovalType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the reason for the removal, the extension of the removal or the termination of the removal.
    /// </summary>
    [IsoId("_HcgTAfonEeiAfJEqh4xF_Q")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? Reason { get; init; } 
    #else
    public GenericIdentification30? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the period, the start date or the end date of the exclusion period.
    /// </summary>
    [IsoId("_RRHq4forEeiAfJEqh4xF_Q")]
    [DisplayName("Exclusion Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExclsnPrd")]
    #endif
    [IsoXmlTag("ExclsnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateOrDateTimePeriod3Choice_? ExclusionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrDateTimePeriod3Choice_? ExclusionPeriod { get; init; } 
    #else
    public DateOrDateTimePeriod3Choice_? ExclusionPeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
