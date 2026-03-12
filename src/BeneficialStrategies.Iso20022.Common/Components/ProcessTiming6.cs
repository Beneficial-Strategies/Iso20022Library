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
[IsoId("_-WUSYTAREeugIJ3Gvoevmg")]
[DisplayName("Process Timing")]
public partial record ProcessTiming6
{
    #nullable enable
    
    /// <summary>
    /// Date and time to start the action.
    /// </summary>
    [IsoId("_-njzYTAREeugIJ3Gvoevmg")]
    [DisplayName("Start Time")]
    [IsoXmlTag("StartTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartTime { get; init; } 
    
    /// <summary>
    /// Date and time after which the action cannot be processed.
    /// </summary>
    [IsoId("_-njzYzAREeugIJ3Gvoevmg")]
    [DisplayName("End Time")]
    [IsoXmlTag("EndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EndTime { get; init; } 
    
    /// <summary>
    /// Period delay between cyclic action activation in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_-njzZTAREeugIJ3Gvoevmg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? Period { get; init; } 
    
    /// <summary>
    /// Identification of the minimum unit of time used by time configuration parameters.
    /// </summary>
    [IsoId("_BJdvcTASEeugIJ3Gvoevmg")]
    [DisplayName("Unit Of Time")]
    [IsoXmlTag("UnitOfTm")]
    public TimeUnit1Code? UnitOfTime { get; init; } 
    
    
    #nullable disable
    
}
