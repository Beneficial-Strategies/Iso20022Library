// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a type of identification requested for an organisation.
/// </summary>
[IsoId("_AGP6yeH5Eeqbls7Gk4-ckA")]
[DisplayName("Organisation Type")]
public partial record OrganisationType2
{
    #nullable enable
    
    /// <summary>
    /// Business identification code of the organisation is requested.
    /// Usage: When absent (default value), the identification is not requested. 
    /// </summary>
    [IsoId("_AIL0ceH5Eeqbls7Gk4-ckA")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AnyBIC { get; init; } 
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a party is requested.
    /// Usage: When absent (default value), the identification is not requested. 
    /// </summary>
    [IsoId("_AIL0c-H5Eeqbls7Gk4-ckA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? LEI { get; init; } 
    
    /// <summary>
    /// Address for electronic mail (e-mail) is requested.
    /// Usage: When absent (default value), the identification is not requested. 
    /// </summary>
    [IsoId("_MfUwQeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EmailAddress { get; init; } 
    
    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme is requested.
    /// </summary>
    [IsoId("_AIL0deH5Eeqbls7Gk4-ckA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericOrganisationType1? Other { get; init; } 
    
    
    #nullable disable
    
}
