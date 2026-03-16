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
[IsoId("_kIBx569UEeeJJK1oRb-jTw")]
[DisplayName("Structured Remittance Information")]
public record StructuredRemittanceInformation14
{
    /// <summary>
    /// Set of elements used to identify the documents referred to in the remittance information.
    /// </summary>
    [IsoId("_kR4Rc69UEeeJJK1oRb-jTw")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation3> ReferredDocumentInformation { get; init; } = [];

    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [IsoId("_kR4Rda9UEeeJJK1oRb-jTw")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_kR4Rd69UEeeJJK1oRb-jTw")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [IsoId("_kR4Rea9UEeeJJK1oRb-jTw")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification125? Invoicer { get; init; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("_kR4Re69UEeeJJK1oRb-jTw")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification125? Invoicee { get; init; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_kR4Rfa9UEeeJJK1oRb-jTw")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<System.String> AdditionalRemittanceInformation { get; init; } = [];
}
