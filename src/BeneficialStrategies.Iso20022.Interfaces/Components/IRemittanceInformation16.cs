// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_-v4Z3W48EeiU9cctagi5ow")]
public interface IRemittanceInformation16 : IIsoComponent
{
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in an unstructured form.
    /// </summary>
    [IsoId("_-5awU248EeiU9cctagi5ow")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    IEnumerable<Max140Text> Unstructured { get; }

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
    /// </summary>
    [IsoId("_-5awVW48EeiU9cctagi5ow")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    IEnumerable<IStructuredRemittanceInformation16> Structured { get; }
}
