// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products (Investment Funds).
/// </summary>
[IsoId("_cVo1ASxxEeKgiYs1KJCQUg")]
[DisplayName("Intermediary")]
public partial record Intermediary23
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_cqqCxSxxEeKgiYs1KJCQUg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification49Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary (investment funds).
    /// </summary>
    [IsoId("_cqqCySxxEeKgiYs1KJCQUg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role2Choice_? Role { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_cqqCzSxxEeKgiYs1KJCQUg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account13? Account { get; init; } 
    
    
    #nullable disable
    
}
