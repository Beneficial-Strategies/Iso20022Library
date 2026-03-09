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
[IsoId("_K9M-I31DEeCF8NjrBemJWQ_817576617")]
[DisplayName("Process Timing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessTiming1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Waiting time after the previous action in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_K9M-JH1DEeCF8NjrBemJWQ_1403344682")]
    [DisplayName("Waiting Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WtgTm")]
    #endif
    [IsoXmlTag("WtgTm")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax9NumericText? WaitingTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WaitingTime { get; init; } 
    #else
    public System.String? WaitingTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time to start the action.
    /// </summary>
    [IsoId("_K9M-JX1DEeCF8NjrBemJWQ_-894476748")]
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
    [IsoId("_K9M-Jn1DEeCF8NjrBemJWQ_-229688670")]
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
    [IsoId("_K9WvIH1DEeCF8NjrBemJWQ_1138907236")]
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
    /// Maximum number of cyclic calls.
    /// </summary>
    [IsoId("_K9WvIX1DEeCF8NjrBemJWQ_181960059")]
    [DisplayName("Maximum Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxNb")]
    #endif
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumNumber { get; init; } 
    #else
    public System.UInt64? MaximumNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_K9WvIn1DEeCF8NjrBemJWQ_-1376294666")]
    [DisplayName("Re Try")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReTry")]
    #endif
    [IsoXmlTag("ReTry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessRetry1? ReTry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessRetry1? ReTry { get; init; } 
    #else
    public ProcessRetry1? ReTry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
