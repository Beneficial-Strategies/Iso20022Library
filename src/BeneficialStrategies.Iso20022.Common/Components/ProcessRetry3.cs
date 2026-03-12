// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Definition of retry process if activation of an action fails.
/// </summary>
[IsoId("_M4Y0sTASEeugIJ3Gvoevmg")]
[DisplayName("Process Retry")]
public partial record ProcessRetry3
{
    #nullable enable
    
    /// <summary>
    /// Time period to wait for a retry in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_NGOcYTASEeugIJ3Gvoevmg")]
    [DisplayName("Delay")]
    [IsoXmlTag("Dely")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText Delay { get; init; } 
    
    /// <summary>
    /// Maximum number of retries.
    /// </summary>
    [IsoId("_NGOcYzASEeugIJ3Gvoevmg")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; } 
    
    /// <summary>
    /// Identification of the minimum unit of time used by time configuration parameters.
    /// </summary>
    [IsoId("_P-GocTASEeugIJ3Gvoevmg")]
    [DisplayName("Unit Of Time")]
    [IsoXmlTag("UnitOfTm")]
    public TimeUnit1Code? UnitOfTime { get; init; } 
    
    
    #nullable disable
    
}
