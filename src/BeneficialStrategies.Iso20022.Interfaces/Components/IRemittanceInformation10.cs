// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_WqtVQR77EeSxevWRRWxNAg")]
public interface IRemittanceInformation10 : IIsoComponent
{
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in an unstructured form.
    /// </summary>
    [IsoId("_W8isIx77EeSxevWRRWxNAg")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    IEnumerable<Max140Text> Unstructured { get; }

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
    /// </summary>
    [IsoId("_W8isJR77EeSxevWRRWxNAg")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    IEnumerable<IStructuredRemittanceInformation12> Structured { get; }
}
