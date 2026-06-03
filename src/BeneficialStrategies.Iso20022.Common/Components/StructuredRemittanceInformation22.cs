// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
/// </summary>
[IsoId("228ed14b-2fc2-4f3f-bc8e-47c7306ee6f5")]
[DisplayName("Structured Remittance Information22")]
public record StructuredRemittanceInformation22
{
    [IsoId("bca856fd-f648-4226-b434-720e4690a282")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation8> ReferredDocumentInformation { get; init; } = [];

    [IsoId("4f957ffb-5d3b-4394-9a7f-2a9e29fd7de3")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount4? ReferredDocumentAmount { get; init; }

    [IsoId("1b8df50c-23eb-430b-bee1-bbb7a69a330f")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation3? CreditorReferenceInformation { get; init; }

    [IsoId("e833af6d-1941-4fbc-9309-a36a6a12dcdf")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification272? Invoicer { get; init; }

    [IsoId("1d324249-cab3-4481-8edd-a84312709aaf")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification272? Invoicee { get; init; }

    [IsoId("54566ff8-4585-4417-a80c-60cec518d1a2")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxData1? TaxRemittance { get; init; }

    [IsoId("f4f6fbbd-f620-47af-b240-ef0295b3863a")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment4? GarnishmentRemittance { get; init; }

    [IsoId("37a60672-6182-4d2f-aaac-fef4ab894dee")]
    [DisplayName("Securities Data")]
    [IsoXmlTag("SctiesData")]
    public ValueList<SecuritiesAttributes1> SecuritiesData { get; init; } = [];

    [IsoId("a58c069f-f64a-40e8-bccf-9f64dc1c1edf")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    public SimpleValueList<IsoMax140Text> AdditionalRemittanceInformation { get; init; } = [];
}
