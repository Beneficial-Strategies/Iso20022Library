// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
/// </summary>
[IsoId("_svCZ0bTMEeeYQd8Z9bqFog")]
public interface IStructuredRemittanceInformation15 : IIsoComponent
{
    /// <summary>
    /// Provides the identification and the content of the referred document.
    /// </summary>
    [IsoId("_s3jco7TMEeeYQd8Z9bqFog")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    IEnumerable<IReferredDocumentInformation7> ReferredDocumentInformation { get; }

    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [IsoId("_s3jcpbTMEeeYQd8Z9bqFog")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    IRemittanceAmount2? ReferredDocumentAmount { get; }

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_s3jcp7TMEeeYQd8Z9bqFog")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    ICreditorReferenceInformation2? CreditorReferenceInformation { get; }

    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [IsoId("_s3jcqbTMEeeYQd8Z9bqFog")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    IPartyIdentification125? Invoicer { get; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("_s3jcq7TMEeeYQd8Z9bqFog")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    IPartyIdentification125? Invoicee { get; }

    /// <summary>
    /// Provides remittance information about a payment made for tax-related purposes.
    /// </summary>
    [IsoId("_s3jcrbTMEeeYQd8Z9bqFog")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    ITaxInformation7? TaxRemittance { get; }

    /// <summary>
    /// Provides remittance information about a payment for garnishment-related purposes.
    /// </summary>
    [IsoId("_s3jcr7TMEeeYQd8Z9bqFog")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    IGarnishment2? GarnishmentRemittance { get; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_s3jcsbTMEeeYQd8Z9bqFog")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    IEnumerable<string> AdditionalRemittanceInformation { get; }
}
