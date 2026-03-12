// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Container for proprietary information. Business content of this element is not specified.
/// </summary>
[IsoId("_1UAkgYKYEee7hrXqLO3yQg")]
[DisplayName("Proprietary Data")]
public partial record ProprietaryData7
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proprietary document.
    /// </summary>
    [IsoId("_1gNNcYKYEee7hrXqLO3yQg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Proprietary data content.
    /// </summary>
    [IsoId("_1gNNc4KYEee7hrXqLO3yQg")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public required ProprietaryData6 Data { get; init; } 
    
    
    #nullable disable
    
}
