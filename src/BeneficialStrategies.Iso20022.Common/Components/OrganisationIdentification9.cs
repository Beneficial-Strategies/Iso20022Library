// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_Jswv4RBBEeGyZLI6olyk-Q")]
[DisplayName("Organisation Identification")]
public partial record OrganisationIdentification9
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to an institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_Jswv4xBBEeGyZLI6olyk-Q")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? AnyBIC { get; init; } 
    
    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_Jswv5xBBEeGyZLI6olyk-Q")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericOrganisationIdentification2? Other { get; init; } 
    
    
    #nullable disable
    
}
