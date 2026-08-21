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
[IsoId("_7sv01TEsEe6GxLzpkVnWYg")]
[Description(
    @"Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form."
)]
[DisplayName("Structured Remittance Information18")]
public record StructuredRemittanceInformation18
{
    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    public SimpleValueList<IsoMax140Text> AdditionalRemittanceInformation { get; init; } = [];

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation3? CreditorReferenceInformation { get; init; }

    /// <summary>
    /// Provides remittance information about a payment for garnishment-related purposes.
    /// </summary>
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment4? GarnishmentRemittance { get; init; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification272? Invoicee { get; init; }

    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification272? Invoicer { get; init; }

    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount4? ReferredDocumentAmount { get; init; }

    /// <summary>
    /// Provides the identification and the content of the referred document.
    /// </summary>
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation8> ReferredDocumentInformation { get; init; } = [];

    /// <summary>
    /// Provides remittance information about a payment made for tax-related purposes.
    /// </summary>
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxData1? TaxRemittance { get; init; }
}
