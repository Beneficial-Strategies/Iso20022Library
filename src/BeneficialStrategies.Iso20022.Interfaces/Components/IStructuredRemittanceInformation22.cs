// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
/// </summary>
[IsoId("228ed14b-2fc2-4f3f-bc8e-47c7306ee6f5")]
public interface IStructuredRemittanceInformation22 : IIsoComponent
{
    /// <summary>
    /// Provides the identification and the content of the referred document.
    /// </summary>
    [IsoId("bca856fd-f648-4226-b434-720e4690a282")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    IEnumerable<IReferredDocumentInformation8> ReferredDocumentInformation { get; }

    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [IsoId("4f957ffb-5d3b-4394-9a7f-2a9e29fd7de3")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    IRemittanceAmount4? ReferredDocumentAmount { get; }

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("1b8df50c-23eb-430b-bee1-bbb7a69a330f")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    ICreditorReferenceInformation3? CreditorReferenceInformation { get; }

    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [IsoId("e833af6d-1941-4fbc-9309-a36a6a12dcdf")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    IPartyIdentification272? Invoicer { get; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("1d324249-cab3-4481-8edd-a84312709aaf")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    IPartyIdentification272? Invoicee { get; }

    /// <summary>
    /// Provides remittance information about a payment made for tax-related purposes.
    /// </summary>
    [IsoId("54566ff8-4585-4417-a80c-60cec518d1a2")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    ITaxData1? TaxRemittance { get; }

    /// <summary>
    /// Provides remittance information about a payment for garnishment-related purposes.
    /// </summary>
    [IsoId("f4f6fbbd-f620-47af-b240-ef0295b3863a")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    IGarnishment4? GarnishmentRemittance { get; }

    /// <summary>
    /// Provides information on the securities trades that make up the payment.
    /// </summary>
    [IsoId("37a60672-6182-4d2f-aaac-fef4ab894dee")]
    [DisplayName("Securities Data")]
    [IsoXmlTag("SctiesData")]
    IEnumerable<ISecuritiesAttributes1> SecuritiesData { get; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("a58c069f-f64a-40e8-bccf-9f64dc1c1edf")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    IEnumerable<Max140Text> AdditionalRemittanceInformation { get; }
}
