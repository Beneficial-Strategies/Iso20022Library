// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a proprietary date.
/// </summary>
[IsoId("_rtZ5466OEeexrtTFgmVD3Q")]
[DisplayName("Proprietary Date")]
public partial record ProprietaryDate3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_r2LbU66OEeexrtTFgmVD3Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Date in ISO format.
    /// </summary>
    [IsoId("_r2LbVa6OEeexrtTFgmVD3Q")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required DateAndDateTime2Choice_ Date { get; init; } 
    
    
    #nullable disable
    
}
