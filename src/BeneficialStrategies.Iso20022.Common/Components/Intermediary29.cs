// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_sWVbIaB-EeOEyO7fCl8lLA")]
[DisplayName("Intermediary")]
public record Intermediary29
{
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_s2Bn16B-EeOEyO7fCl8lLA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification100 Identification { get; init; }

    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_s2Bn3aB-EeOEyO7fCl8lLA")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public required Role5Choice_ Role { get; init; }

    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_s2Bn26B-EeOEyO7fCl8lLA")]
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_yAcG4W5FEeSFHPWGV34yZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
