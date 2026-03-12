// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the entity to which the financial instruments are pledged expressed as a code and a narrative description.
/// </summary>
[IsoId("_Sg8bNW_nEeSNvKTulh2IuA")]
[DisplayName("Pledgee Type And Text")]
public partial record PledgeeTypeAndText2
{
    #nullable enable
    
    /// <summary>
    /// Additional information about the entity to which the financial instruments are pledged.
    /// </summary>
    [IsoId("_Sg8bN2_nEeSNvKTulh2IuA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax30Text)]
    [StringLength(maximumLength: 30 ,MinimumLength = 1)]
    public IsoRestrictedFINMax30Text? Identification { get; init; } 
    
    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    [IsoId("_Sg8bOW_nEeSNvKTulh2IuA")]
    [DisplayName("Pledgee Type")]
    [IsoXmlTag("PldgeeTp")]
    public required PledgeeType1Code PledgeeType { get; init; } 
    
    
    #nullable disable
    
}
