// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer Identification2.
/// </summary>
[IsoId("_83etz248EeiU9cctagi5ow")]
[DisplayName("Customer Identification2")]
public partial record CustomerIdentification2
{
    #nullable enable

    /// <summary>
    /// Authority Request.
    /// </summary>
    [DisplayName("Authority Request")]
    [IsoXmlTag("AuthrtyReq")]
    public ValueList<AuthorityInvestigation2> AuthorityRequest { get; init; } = [];

    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification272 Party { get; init; } 

    
    #nullable disable
    
}
