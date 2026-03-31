// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties related to an investment fund.
/// </summary>
[IsoId("_FCdpMF_6EeiNMJ262H2pWg")]
[DisplayName("Fund Parties")]
public record FundParties1
{
    /// <summary>
    /// Guarantor of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00080.
    /// </summary>
    [IsoId("_KGpUwV_6EeiNMJ262H2pWg")]
    [DisplayName("Guarantor")]
    [IsoXmlTag("Guarntr")]
    public ContactAttributes5? Guarantor { get; init; }

    /// <summary>
    /// Party that regularly monitors compliance with the legal regulations.
    /// </summary>
    [IsoId("_Nn5N8l_6EeiNMJ262H2pWg")]
    [DisplayName("Auditor")]
    [IsoXmlTag("Audtr")]
    public ContactAttributes5? Auditor { get; init; }

    /// <summary>
    /// Legal owner of the financial instrument. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [IsoId("_Nn5N81_6EeiNMJ262H2pWg")]
    [DisplayName("Trustee")]
    [IsoXmlTag("Trstee")]
    public ContactAttributes5? Trustee { get; init; }

    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_F-x3wWALEeiNMJ262H2pWg")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ValueList<ExtendedParty13> OtherParty { get; init; } = [];
}
