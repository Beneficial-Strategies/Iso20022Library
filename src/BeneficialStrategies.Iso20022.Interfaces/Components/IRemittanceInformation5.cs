// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_QF2HWNp-Ed-ak6NoX_4Aeg_414888716")]
public interface IRemittanceInformation5 : IIsoComponent
{
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in an unstructured form.
    /// </summary>
    [IsoId("_QF2HWdp-Ed-ak6NoX_4Aeg_414888747")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    IEnumerable<IsoMax140Text> Unstructured { get; }

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
    /// </summary>
    [IsoId("_QF_4UNp-Ed-ak6NoX_4Aeg_414888840")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    IEnumerable<IStructuredRemittanceInformation7> Structured { get; }
}
