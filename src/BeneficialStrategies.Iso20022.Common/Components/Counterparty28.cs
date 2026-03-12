// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
[IsoId("_fXcpwZQMEeiILOjNP8ro1w")]
[DisplayName("Counterparty")]
public partial record Counterparty28
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the other counterparty of the contract.
    /// Usage:
    /// This field shall be filled from the perspective of the reporting counterparty. In case of a private individual a client code shall be used in a consistent manner.
    /// </summary>
    [IsoId("_fi32oZQMEeiILOjNP8ro1w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification9Choice_ Identification { get; init; } 
    
    /// <summary>
    /// The code of country where the registered office of the other counterparty is located or country of residence in case that the other counterparty is a natural person.
    /// </summary>
    [IsoId("_fi32o5QMEeiILOjNP8ro1w")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    
    #nullable disable
    
}
