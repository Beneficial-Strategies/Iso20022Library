// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
/// </summary>
[IsoId("_QFQRctp-Ed-ak6NoX_4Aeg_216518890")]
public interface IStructuredRemittanceInformation8 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to identify the documents referred to in the remittance information.
    /// </summary>
    [IsoId("_QFQRc9p-Ed-ak6NoX_4Aeg_-1276003119")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    IEnumerable<IReferredDocumentInformation3> ReferredDocumentInformation { get; }

    /// <summary>
    /// Set of elements used to provide details on the amounts of the referred document.
    /// </summary>
    [IsoId("_QFQRdNp-Ed-ak6NoX_4Aeg_-515237966")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    IRemittanceAmount1? ReferredDocumentAmount { get; }

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_QFQRddp-Ed-ak6NoX_4Aeg_-2008205652")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    ICreditorReferenceInformation2? CreditorReferenceInformation { get; }

    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [IsoId("_QFQRdtp-Ed-ak6NoX_4Aeg_1758673695")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    IPartyIdentification43? Invoicer { get; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("_QFQRd9p-Ed-ak6NoX_4Aeg_-2082206332")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    IPartyIdentification43? Invoicee { get; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_QFQReNp-Ed-ak6NoX_4Aeg_-1674377978")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    IEnumerable<string> AdditionalRemittanceInformation { get; }
}
