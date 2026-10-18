// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_QFsWV9p-Ed-ak6NoX_4Aeg_-92384845")]
public interface IRemittanceInformation1 : IIsoComponent
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system in an unstructured form.
    /// </summary>
    [IsoId("_QFsWWNp-Ed-ak6NoX_4Aeg_-92384592")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    IEnumerable<IsoMax140Text> Unstructured { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system in a structured form.
    /// </summary>
    [IsoId("_QF2HUNp-Ed-ak6NoX_4Aeg_-92384550")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    IEnumerable<IStructuredRemittanceInformation6> Structured { get; }
}
