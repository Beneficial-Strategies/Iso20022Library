// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security.
/// </summary>
[IsoId("_TBKB89p-Ed-ak6NoX_4Aeg_-524266634")]
[DisplayName("Security Identification")]
public partial record SecurityIdentification11
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_TBTL0Np-Ed-ak6NoX_4Aeg_2142645963")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification11Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [IsoId("_TBTL0dp-Ed-ak6NoX_4Aeg_-152087608")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
