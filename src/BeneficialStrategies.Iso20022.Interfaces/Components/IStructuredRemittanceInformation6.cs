// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured information supplied to enable the matching, i.e. reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an accounts receivable system.
/// </summary>
[IsoId("_QFZbYtp-Ed-ak6NoX_4Aeg_-141764551")]
public interface IStructuredRemittanceInformation6 : IIsoComponent
{
    /// <summary>
    /// Reference information to allow the identification of the underlying reference documents.
    /// </summary>
    [IsoId("_QFZbY9p-Ed-ak6NoX_4Aeg_758670115")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    IReferredDocumentInformation1? ReferredDocumentInformation { get; }

    /// <summary>
    /// Date associated with the referred document, eg, date of issue.
    /// </summary>
    [IsoId("_QFZbZNp-Ed-ak6NoX_4Aeg_-141764239")]
    [DisplayName("Referred Document Related Date")]
    [IsoXmlTag("RfrdDocRltdDt")]
    IsoISODate? ReferredDocumentRelatedDate { get; }

    /// <summary>
    /// Amount of money and currency of a document referred to in the remittance section. The amount is typically either the original amount due and payable, or the amount actually remitted for the referred document.
    /// </summary>
    [IsoId("_QFZbZdp-Ed-ak6NoX_4Aeg_-141764204")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    IEnumerable<IReferredDocumentAmount1Choice> ReferredDocumentAmount { get; }

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_QFZbZtp-Ed-ak6NoX_4Aeg_1486861224")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    ICreditorReferenceInformation1? CreditorReferenceInformation { get; }

    /// <summary>
    /// Identification of the organization issuing the invoice when different than the creditor or final party.
    /// </summary>
    [IsoId("_QFZbZ9p-Ed-ak6NoX_4Aeg_-141763664")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    IPartyIdentification8? Invoicer { get; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when different than the originator or debtor.
    /// </summary>
    [IsoId("_QFZbaNp-Ed-ak6NoX_4Aeg_-141763290")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    IPartyIdentification8? Invoicee { get; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_QFjMYNp-Ed-ak6NoX_4Aeg_-141764179")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    IsoMax140Text? AdditionalRemittanceInformation { get; }
}
