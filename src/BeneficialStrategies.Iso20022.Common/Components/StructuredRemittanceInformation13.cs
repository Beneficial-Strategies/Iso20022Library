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
[IsoId("_0Pit5zq4EeWZFYSPlduMhw")]
[DisplayName("Structured Remittance Information")]
public record StructuredRemittanceInformation13
{
    /// <summary>
    /// Provides the identification and the content of the referred document.
    /// </summary>
    [IsoId("_0X1uQzq4EeWZFYSPlduMhw")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation7> ReferredDocumentInformation { get; init; } = [];

    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [IsoId("_0X1uRTq4EeWZFYSPlduMhw")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_0X1uRzq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [IsoId("_0X1uSTq4EeWZFYSPlduMhw")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification43? Invoicer { get; init; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("_0X1uSzq4EeWZFYSPlduMhw")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification43? Invoicee { get; init; }

    /// <summary>
    /// Provides remittance information about a payment made for tax-related purposes.
    /// </summary>
    [IsoId("_0X1uTTq4EeWZFYSPlduMhw")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxInformation4? TaxRemittance { get; init; }

    /// <summary>
    /// Provides remittance information about a payment for garnishment-related purposes.
    /// </summary>
    [IsoId("_0X1uTzq4EeWZFYSPlduMhw")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment1? GarnishmentRemittance { get; init; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_0X1uUTq4EeWZFYSPlduMhw")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<System.String> AdditionalRemittanceInformation { get; init; } = [];
}
