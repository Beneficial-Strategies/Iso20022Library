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
[IsoId("048dbd95-6d8d-4a94-a06a-d42e897c999f")]
[DisplayName("Unit14")]
public record Unit14
{
    [IsoId("1052fd56-7e77-4bd5-9de6-af378248c963")]
    [DisplayName("Units")]
    [IsoXmlTag("Units")]
    public required Unit1Choice_ Units { get; init; }

    [IsoId("739db2a6-05db-4f05-8190-6f9d442508cb")]
    [DisplayName("Order Date")]
    [IsoXmlTag("OrdrDt")]
    public IsoISODate? OrderDate { get; init; }

    [IsoId("8dc01c1b-b5d9-474e-beb1-5b722ff9b192")]
    [DisplayName("Acquisition Date")]
    [IsoXmlTag("AcqstnDt")]
    public IsoISODate? AcquisitionDate { get; init; }

    [IsoId("9d9d957c-a724-4213-b2cf-9168479a3d0a")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SimpleValueList<IsoMax35Text> CertificateNumber { get; init; } = [];

    [IsoId("77b0eae1-7693-4697-9f66-1812146ef245")]
    [DisplayName("Group1 Or2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    [IsoId("8323e500-e1eb-415f-8731-44d8f9c78b93")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    [IsoId("093f6423-10cc-4187-ac65-65c143260aca")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public UnitPrice23? PriceDetails { get; init; }

    [IsoId("172420ee-5434-4fc1-b61b-6425f5630366")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes44? TransactionOverhead { get; init; }

    [IsoId("cbd6f98d-ca10-4901-9561-dd79529c3ae2")]
    [DisplayName("Other Amount")]
    [IsoXmlTag("OthrAmt")]
    public ValueList<OtherAmount1> OtherAmount { get; init; } = [];
}
