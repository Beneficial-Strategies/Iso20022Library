// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of customer identification requested.
/// </summary>
[IsoId("_AEhcceH5Eeqbls7Gk4-ckA")]
[DisplayName("Customer Type Request")]
public partial record CustomerTypeRequest2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the customer identification is required by the creditor or not.
    /// </summary>
    [IsoId("_AGP6w-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Requested")]
    [IsoXmlTag("Reqd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator Requested { get; init; } 
    
    /// <summary>
    /// Specifies which type of customer identification is requested for an organisation.
    /// </summary>
    [IsoId("_AGP6xeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Organisation Type")]
    [IsoXmlTag("OrgTp")]
    public OrganisationType2? OrganisationType { get; init; } 
    
    /// <summary>
    /// Specifies which type of customer identification is requested for a person.
    /// </summary>
    [IsoId("_AGP6x-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Private Type")]
    [IsoXmlTag("PrvtTp")]
    public PersonType2? PrivateType { get; init; } 
    
    
    #nullable disable
    
}
