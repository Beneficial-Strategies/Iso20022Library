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
[IsoId("_ONg8kZ-xEeO1d8sv7xazyA")]
[DisplayName("Intermediary")]
public partial record Intermediary28
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_OtXhU5-xEeO1d8sv7xazyA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification100 Identification { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_OtXhVZ-xEeO1d8sv7xazyA")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public required Role5Choice_ Role { get; init; } 
    
    
    #nullable disable
    
}
