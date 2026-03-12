// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an organisation.
/// </summary>
[IsoId("_9IxHga4OEemG7MmivSuE5g")]
[DisplayName("Issuer Information")]
public partial record IssuerInformation3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous way to identify the organisation.
    /// </summary>
    [IsoId("_9g3eca4OEemG7MmivSuE5g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification129Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_9g3ec64OEemG7MmivSuE5g")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? URLAddress { get; init; } 
    
    
    #nullable disable
    
}
