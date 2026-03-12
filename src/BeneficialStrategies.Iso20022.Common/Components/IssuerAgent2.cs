// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the role of the issuer agent.
/// </summary>
[IsoId("_ciBrAVthEeSwKe7KuKvXhg")]
[DisplayName("Issuer Agent")]
public partial record IssuerAgent2
{
    #nullable enable
    
    /// <summary>
    /// Identifies issuer agent.
    /// </summary>
    [IsoId("_c_C-M1thEeSwKe7KuKvXhg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification40Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Specifies the role of the issuer agent.
    /// </summary>
    [IsoId("_c_C-NVthEeSwKe7KuKvXhg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public AgentRole1Code? Role { get; init; } 
    
    
    #nullable disable
    
}
