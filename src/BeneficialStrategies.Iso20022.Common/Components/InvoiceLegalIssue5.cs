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
[IsoId("_2qnwDTEyEe6g-ffJsqGiSA")]
[DisplayName("Invoice Legal Issue5")]
public record InvoiceLegalIssue5
{
    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [IsoId("_2s3LsTEyEe6g-ffJsqGiSA")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public required PartyIdentification272 Invoicer { get; init; }

    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("_2s3LszEyEe6g-ffJsqGiSA")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public required PartyIdentification272 Invoicee { get; init; }

    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_2s3LtTEyEe6g-ffJsqGiSA")]
    [DisplayName("Invoice Legal Statement")]
    [IsoXmlTag("InvcLglStmt")]
    public IsoMax210Text? InvoiceLegalStatement { get; init; }

    /// <summary>
    /// Method of payment for the remittance of the CSD or NCB to the invoicing party.
    /// </summary>
    [IsoId("_2s3LtzEyEe6g-ffJsqGiSA")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod3Choice? PaymentMethod { get; init; }
}
