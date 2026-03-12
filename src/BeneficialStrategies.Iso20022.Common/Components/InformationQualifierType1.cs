// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further qualifies the information provided in terms of its importance and its format.
/// </summary>
[IsoId("_59y2N5lZEeeE1Ya-LgRsuQ")]
[DisplayName("Information Qualifier Type")]
public partial record InformationQualifierType1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the information is formatted.
    /// </summary>
    [IsoId("_6FzisZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Is Formatted")]
    [IsoXmlTag("IsFrmtd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? IsFormatted { get; init; } 
    
    /// <summary>
    /// Priority of the information.
    /// </summary>
    [IsoId("_6Fzis5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public Priority1Code? Priority { get; init; } 
    
    
    #nullable disable
    
}
