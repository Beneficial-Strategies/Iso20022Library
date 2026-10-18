// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form.
/// </summary>
[IsoId("_7sv01TEsEe6GxLzpkVnWYg")]
public interface IStructuredRemittanceInformation18 : IIsoComponent
{
    /// <summary>
    /// Provides the identification and the content of the referred document.
    /// </summary>
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    IEnumerable<IReferredDocumentInformation8> ReferredDocumentInformation { get; }

    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    IRemittanceAmount4? ReferredDocumentAmount { get; }

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    ICreditorReferenceInformation3? CreditorReferenceInformation { get; }

    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    IPartyIdentification272? Invoicer { get; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    IPartyIdentification272? Invoicee { get; }

    /// <summary>
    /// Provides remittance information about a payment made for tax-related purposes.
    /// </summary>
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    ITaxData1? TaxRemittance { get; }

    /// <summary>
    /// Provides remittance information about a payment for garnishment-related purposes.
    /// </summary>
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    IGarnishment4? GarnishmentRemittance { get; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    IEnumerable<Max140Text> AdditionalRemittanceInformation { get; }
}
