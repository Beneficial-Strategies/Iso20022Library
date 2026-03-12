// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
/// </summary>
[IsoId("_Qd-6gNp-Ed-ak6NoX_4Aeg_431010992")]
[DisplayName("Security Identification")]
public partial record SecurityIdentification9
{
    #nullable enable
    
    /// <summary>
    /// Security identifier.
    /// </summary>
    [IsoId("_Qd-6gdp-Ed-ak6NoX_4Aeg_431931080")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification10Choice_ SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [IsoId("_Qd-6gtp-Ed-ak6NoX_4Aeg_431931018")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
