// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the issuer and its role.
/// </summary>
[IsoId("_VeYVka4REemG7MmivSuE5g")]
[DisplayName("Issuer Agent")]
public partial record IssuerAgent3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the issuer agent.
    /// </summary>
    [IsoId("_V0Gt864REemG7MmivSuE5g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification129Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Role of the issuer agent.
    /// </summary>
    [IsoId("_V0Gt9a4REemG7MmivSuE5g")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public AgentRole1Code? Role { get; init; } 
    
    
    #nullable disable
    
}
