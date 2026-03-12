// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and an end date.
/// </summary>
[IsoId("_xQkf4DckEeidBoT_PugKiA")]
[DisplayName("Period")]
public partial record Period15
{
    #nullable enable
    
    /// <summary>
    /// Date on which the range starts.
    /// </summary>
    [IsoId("_5dmLsDckEeidBoT_PugKiA")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate StartDate { get; init; } 
    
    /// <summary>
    /// Date on which the range ends.
    /// </summary>
    [IsoId("_6oR2IDckEeidBoT_PugKiA")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EndDate { get; init; } 
    
    
    #nullable disable
    
}
