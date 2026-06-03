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
    [IsoId("361f143c-8b16-4773-8b22-ffc1a2824c84")]
    [DisplayName("Units")]
    [IsoXmlTag("Units")]
    public required Unit1Choice_ Units { get; init; }

    [IsoId("f203d74c-333f-479a-981d-32bf141e3454")]
    [DisplayName("Order Date")]
    [IsoXmlTag("OrdrDt")]
    public IsoISODate? OrderDate { get; init; }

    [IsoId("dd712deb-6b4b-4353-8f02-4048c8ff7da2")]
    [DisplayName("Acquisition Date")]
    [IsoXmlTag("AcqstnDt")]
    public IsoISODate? AcquisitionDate { get; init; }

    [IsoId("22d6590d-9c91-4e64-b02b-ff655513bb53")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SimpleValueList<IsoMax35Text> CertificateNumber { get; init; } = [];

    [IsoId("dda7ae3d-6619-4d5b-a808-dcc96b68dc4d")]
    [DisplayName("Group1 Or2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    [IsoId("8617f1c1-2b57-431e-9ef2-e22b15b27a4c")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }
}
