// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_keWygbTLEeeYQd8Z9bqFog")]
public interface IRemittanceInformation15 : IIsoComponent
{
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in an unstructured form.
    /// </summary>
    [IsoId("_km0K87TLEeeYQd8Z9bqFog")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    IEnumerable<IsoMax140Text> Unstructured { get; }

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
    /// </summary>
    [IsoId("_km0K9bTLEeeYQd8Z9bqFog")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    IEnumerable<IStructuredRemittanceInformation15> Structured { get; }
}
