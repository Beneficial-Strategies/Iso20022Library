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
[IsoId("_GiI3gx5dEeWE3PufGMdJ3w")]
[DisplayName("Intermediary")]
public partial record Intermediary32
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_HCkrAx5dEeWE3PufGMdJ3w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification100 Identification { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary (investment funds).
    /// </summary>
    [IsoId("_HCkrBR5dEeWE3PufGMdJ3w")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role6Choice_? Role { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_HCkrBx5dEeWE3PufGMdJ3w")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account18? Account { get; init; } 
    
    
    #nullable disable
    
}
