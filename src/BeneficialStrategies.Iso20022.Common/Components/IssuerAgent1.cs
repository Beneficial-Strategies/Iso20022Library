// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the role of the Issuer agent.
/// </summary>
[IsoId("_QO7x5Np-Ed-ak6NoX_4Aeg_2141002567")]
[DisplayName("Issuer Agent")]
public partial record IssuerAgent1
{
    #nullable enable
    
    /// <summary>
    /// Identifies Issuer Agent.
    /// </summary>
    [IsoId("_QO7x5dp-Ed-ak6NoX_4Aeg_740533956")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification9Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Specifies the role of the Issuer agent.
    /// </summary>
    [IsoId("_QO7x5tp-Ed-ak6NoX_4Aeg_-1839969529")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public AgentRole1Code? Role { get; init; } 
    
    
    #nullable disable
    
}
