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
[IsoId("_WIiCh9p-Ed-ak6NoX_4Aeg_1795584190")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification17
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    [IsoId("_WIiCiNp-Ed-ak6NoX_4Aeg_1795584192")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax34Text)]
    [StringLength(maximumLength: 34 ,MinimumLength = 1)]
    public required IsoRestrictedFINMax34Text Identification { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_WIiCidp-Ed-ak6NoX_4Aeg_1796504223")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public required IsoMax8Text Issuer { get; init; } 
    
    
    #nullable disable
    
}
