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
/// Parameters defining the timing conditions to process an action.
/// </summary>
[IsoId("_-WUSYTAREeugIJ3Gvoevmg")]
[DisplayName("Process Timing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessTiming6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time to start the action.
    /// </summary>
    [IsoId("_-njzYTAREeugIJ3Gvoevmg")]
    [DisplayName("Start Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartTm")]
    #endif
    [IsoXmlTag("StartTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StartTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StartTime { get; init; } 
    #else
    public System.DateTime? StartTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time after which the action cannot be processed.
    /// </summary>
    [IsoId("_-njzYzAREeugIJ3Gvoevmg")]
    [DisplayName("End Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndTm")]
    #endif
    [IsoXmlTag("EndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? EndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? EndTime { get; init; } 
    #else
    public System.DateTime? EndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Period delay between cyclic action activation in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_-njzZTAREeugIJ3Gvoevmg")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax9NumericText? Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Period { get; init; } 
    #else
    public System.String? Period { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the minimum unit of time used by time configuration parameters.
    /// </summary>
    [IsoId("_BJdvcTASEeugIJ3Gvoevmg")]
    [DisplayName("Unit Of Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfTm")]
    #endif
    [IsoXmlTag("UnitOfTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeUnit1Code? UnitOfTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeUnit1Code? UnitOfTime { get; init; } 
    #else
    public TimeUnit1Code? UnitOfTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
