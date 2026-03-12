// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a party.
/// </summary>
[IsoId("_PZcUWdp-Ed-ak6NoX_4Aeg_-1177692250")]
[DisplayName("Name And Address")]
public partial record NameAndAddress5
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PZcUWtp-Ed-ak6NoX_4Aeg_-1177692231")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [IsoId("_PZleQNp-Ed-ak6NoX_4Aeg_670261447")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public PostalAddress1? Address { get; init; } 
    
    
    #nullable disable
    
}
