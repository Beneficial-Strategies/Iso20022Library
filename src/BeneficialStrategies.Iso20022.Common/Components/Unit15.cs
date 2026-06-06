// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about units to transfer.
/// </summary>
[IsoId("607716b7-1b36-4700-a221-9e3cd96f2f1f")]
[DisplayName("Unit15")]
public record Unit15
{
    /// <summary>
    /// Quantity of units or digital tokens.
    /// </summary>
    [IsoId("361f143c-8b16-4773-8b22-ffc1a2824c84")]
    [DisplayName("Units")]
    [IsoXmlTag("Units")]
    public required Unit1Choice_ Units { get; init; }

    /// <summary>
    /// Date the investor or its agent placed the original order.
    /// </summary>
    [IsoId("f203d74c-333f-479a-981d-32bf141e3454")]
    [DisplayName("Order Date")]
    [IsoXmlTag("OrdrDt")]
    public IsoISODate? OrderDate { get; init; }

    /// <summary>
    /// Date the investor purchased the financial instrument.
    /// </summary>
    [IsoId("dd712deb-6b4b-4353-8f02-4048c8ff7da2")]
    [DisplayName("Acquisition Date")]
    [IsoXmlTag("AcqstnDt")]
    public IsoISODate? AcquisitionDate { get; init; }

    /// <summary>
    /// Certificate representing the security.
    /// </summary>
    [IsoId("22d6590d-9c91-4e64-b02b-ff655513bb53")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SimpleValueList<IsoMax35Text> CertificateNumber { get; init; } = [];

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("dda7ae3d-6619-4d5b-a808-dcc96b68dc4d")]
    [DisplayName("Group1 Or2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    /// <summary>
    /// Reference to the units number. This may be the order reference of the original acquisition, the identification of a lot, a client reference, a sub-position reference or other related reference.
    /// </summary>
    [IsoId("8617f1c1-2b57-431e-9ef2-e22b15b27a4c")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }
}
