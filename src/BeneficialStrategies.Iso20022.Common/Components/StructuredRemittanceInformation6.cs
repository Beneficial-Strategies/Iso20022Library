// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured information supplied to enable the matching, i.e. reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an accounts receivable system.
/// </summary>
[IsoId("_QFZbYtp-Ed-ak6NoX_4Aeg_-141764551")]
[DisplayName("Structured Remittance Information")]
public record StructuredRemittanceInformation6
{
    /// <summary>
    /// Reference information to allow the identification of the underlying reference documents.
    /// </summary>
    [IsoId("_QFZbY9p-Ed-ak6NoX_4Aeg_758670115")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ReferredDocumentInformation1? ReferredDocumentInformation { get; init; }

    /// <summary>
    /// Date associated with the referred document, eg, date of issue.
    /// </summary>
    [IsoId("_QFZbZNp-Ed-ak6NoX_4Aeg_-141764239")]
    [DisplayName("Referred Document Related Date")]
    [IsoXmlTag("RfrdDocRltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReferredDocumentRelatedDate { get; init; }

    /// <summary>
    /// Amount of money and currency of a document referred to in the remittance section. The amount is typically either the original amount due and payable, or the amount actually remitted for the referred document.
    /// </summary>
    [IsoId("_QFZbZdp-Ed-ak6NoX_4Aeg_-141764204")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public ValueList<ReferredDocumentAmount1Choice_> ReferredDocumentAmount { get; init; } = [];

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_QFZbZtp-Ed-ak6NoX_4Aeg_1486861224")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation1? CreditorReferenceInformation { get; init; }

    /// <summary>
    /// Identification of the organization issuing the invoice when different than the creditor or final party.
    /// </summary>
    [IsoId("_QFZbZ9p-Ed-ak6NoX_4Aeg_-141763664")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification8? Invoicer { get; init; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when different than the originator or debtor.
    /// </summary>
    [IsoId("_QFZbaNp-Ed-ak6NoX_4Aeg_-141763290")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification8? Invoicee { get; init; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_QFjMYNp-Ed-ak6NoX_4Aeg_-141764179")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalRemittanceInformation { get; init; }
}
