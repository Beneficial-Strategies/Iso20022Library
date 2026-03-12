// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, eg, party identification or account identification.
/// </summary>
[IsoId("_V6-HoNp-Ed-ak6NoX_4Aeg_-2073103164")]
[DisplayName("Restricted Identification")]
public partial record RestrictedIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    [IsoId("_V6-Hodp-Ed-ak6NoX_4Aeg_-2073103104")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Specifies the nature of the identifier.|Usage: IdentificationType is used to specify what kind of identifier is used. It should be used in case the identifier is different from the identifiers listed in the pre-defined identifier list.
    /// </summary>
    [IsoId("_V6-Hotp-Ed-ak6NoX_4Aeg_-2073103138")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    [IsoSimpleType(IsoSimpleType.RestrictedSEPACodeText)]
    public required IsoRestrictedSEPACodeText IdentificationType { get; init; } 
    
    
    #nullable disable
    
}
