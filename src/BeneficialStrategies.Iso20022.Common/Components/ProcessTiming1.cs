// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters defining the timing conditions to process an action.
/// </summary>
[IsoId("_K9M-I31DEeCF8NjrBemJWQ_817576617")]
[DisplayName("Process Timing")]
public partial record ProcessTiming1
{
    #nullable enable
    
    /// <summary>
    /// Waiting time after the previous action in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_K9M-JH1DEeCF8NjrBemJWQ_1403344682")]
    [DisplayName("Waiting Time")]
    [IsoXmlTag("WtgTm")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? WaitingTime { get; init; } 
    
    /// <summary>
    /// Date and time to start the action.
    /// </summary>
    [IsoId("_K9M-JX1DEeCF8NjrBemJWQ_-894476748")]
    [DisplayName("Start Time")]
    [IsoXmlTag("StartTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartTime { get; init; } 
    
    /// <summary>
    /// Date and time after which the action cannot be processed.
    /// </summary>
    [IsoId("_K9M-Jn1DEeCF8NjrBemJWQ_-229688670")]
    [DisplayName("End Time")]
    [IsoXmlTag("EndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EndTime { get; init; } 
    
    /// <summary>
    /// Period delay between cyclic action activation in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_K9WvIH1DEeCF8NjrBemJWQ_1138907236")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? Period { get; init; } 
    
    /// <summary>
    /// Maximum number of cyclic calls.
    /// </summary>
    [IsoId("_K9WvIX1DEeCF8NjrBemJWQ_181960059")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; } 
    
    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_K9WvIn1DEeCF8NjrBemJWQ_-1376294666")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry1? ReTry { get; init; } 
    
    
    #nullable disable
    
}
