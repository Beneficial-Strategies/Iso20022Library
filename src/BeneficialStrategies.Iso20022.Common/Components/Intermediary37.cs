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
[IsoId("_5Wx6hpNLEeWGlc8L7oPDIg")]
[DisplayName("Intermediary")]
public partial record Intermediary37
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_5Wx6iJNLEeWGlc8L7oPDIg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification111 Identification { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary (investment funds).
    /// </summary>
    [IsoId("_5Wx6ipNLEeWGlc8L7oPDIg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role7Choice_? Role { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_5Wx6jJNLEeWGlc8L7oPDIg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account21? Account { get; init; } 
    
    
    #nullable disable
    
}
