// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[IsoId("_jm0boeWhEeevU7McUP3D1w")]
[DisplayName("Period")]
public partial record Period14
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_jvxjUeWhEeevU7McUP3D1w")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public required DateFormat56Choice_ StartDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_jvxjU-WhEeevU7McUP3D1w")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public required DateFormat56Choice_ EndDate { get; init; } 
    
    
    #nullable disable
    
}
