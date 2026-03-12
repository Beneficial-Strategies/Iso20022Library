// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_-uz88UTbEeWxJ7Dl62pKvQ")]
[DisplayName("Intermediary")]
public partial record Intermediary35
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("__LX9I0TbEeWxJ7Dl62pKvQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification70Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("__LX9JUTbEeWxJ7Dl62pKvQ")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account20? Account { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("__LX9J0TbEeWxJ7Dl62pKvQ")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role4Choice_? Role { get; init; } 
    
    
    #nullable disable
    
}
