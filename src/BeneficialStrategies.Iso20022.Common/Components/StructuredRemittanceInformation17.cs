// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
/// </summary>
[IsoId("_n5V1sd4lEeqt1ZcLzWyWFw")]
[DisplayName("Structured Remittance Information")]
public record StructuredRemittanceInformation17
{
    /// <summary>
    /// Provides the identification and the content of the referred document.
    /// </summary>
    [IsoId("_n7Ds8d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ReferredDocumentInformation7? ReferredDocumentInformation { get; init; }

    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [IsoId("_n7Ds894lEeqt1ZcLzWyWFw")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_n7Ds9d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [IsoId("_n7Ds994lEeqt1ZcLzWyWFw")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification135? Invoicer { get; init; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("_n7Ds-d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification135? Invoicee { get; init; }

    /// <summary>
    /// Provides remittance information about a payment made for tax-related purposes.
    /// </summary>
    [IsoId("_n7Ds-94lEeqt1ZcLzWyWFw")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxData1? TaxRemittance { get; init; }

    /// <summary>
    /// Provides remittance information about a payment for garnishment-related purposes.
    /// </summary>
    [IsoId("_n7Ds_d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment3? GarnishmentRemittance { get; init; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_n7Ds_94lEeqt1ZcLzWyWFw")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<System.String> AdditionalRemittanceInformation { get; init; } = [];
}
