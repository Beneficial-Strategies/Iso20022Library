// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification of a security.
/// </summary>
[IsoId("_W9bqO9p-Ed-ak6NoX_4Aeg_419486529")]
[DisplayName("Alternate Identification")]
public partial record AlternateIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_W9bqPNp-Ed-ak6NoX_4Aeg_-1574658177")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax31Text)]
    [StringLength(maximumLength: 31 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax31Text Identification { get; init; } 
    
    /// <summary>
    /// Source of the security identification.
    /// </summary>
    [IsoId("_W9k0INp-Ed-ak6NoX_4Aeg_-1624701768")]
    [DisplayName("Identification Source")]
    [IsoXmlTag("IdSrc")]
    public required IdentificationSource2Choice_ IdentificationSource { get; init; } 
    
    
    #nullable disable
    
}
