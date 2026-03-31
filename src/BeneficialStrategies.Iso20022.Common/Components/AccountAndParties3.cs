// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account And Parties3.
/// </summary>
[IsoId("_8eTYyW48EeiU9cctagi5ow")]
[DisplayName("Account And Parties3")]
public record AccountAndParties3
{
    /// <summary>
    /// Authority Request Type.
    /// </summary>
    [DisplayName("Authority Request Type")]
    [IsoXmlTag("AuthrtyReqTp")]
    public ValueList<AuthorityRequestType1> AuthorityRequestType { get; init; } = [];

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccount43 Identification { get; init; }

    /// <summary>
    /// Investigated Parties.
    /// </summary>
    [DisplayName("Investigated Parties")]
    [IsoXmlTag("InvstgtdPties")]
    public required InvestigatedParties1Choice_ InvestigatedParties { get; init; }
}
