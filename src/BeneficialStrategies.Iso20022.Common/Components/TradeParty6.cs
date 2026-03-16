// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Party6.
/// </summary>
[IsoId("_2TUDZzEyEe6g-ffJsqGiSA")]
[DisplayName("Trade Party6")]
public record TradeParty6
{
    /// <summary>
    /// Legal Organisation.
    /// </summary>
    [DisplayName("Legal Organisation")]
    [IsoXmlTag("LglOrg")]
    public LegalOrganisation2? LegalOrganisation { get; init; }

    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification272 PartyIdentification { get; init; }

    /// <summary>
    /// Tax Party.
    /// </summary>
    [DisplayName("Tax Party")]
    [IsoXmlTag("TaxPty")]
    public ValueList<TaxParty4> TaxParty { get; init; } = [];
}
