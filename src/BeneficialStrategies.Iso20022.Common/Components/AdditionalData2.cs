// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional data.
/// </summary>
[IsoId("_EFgcoTNGEeylu6lH-gut-A")]
[DisplayName("Additional Data")]
public partial record AdditionalData2
{
    #nullable enable
    
    /// <summary>
    /// Type of information.
    /// </summary>
    [IsoId("_EO5pMTNGEeylu6lH-gut-A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Detail of the specific type of data.
    /// </summary>
    [IsoId("_MhSWIDNGEeylu6lH-gut-A")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public AdditionalData1? Details { get; init; } 
    
    
    #nullable disable
    
}
