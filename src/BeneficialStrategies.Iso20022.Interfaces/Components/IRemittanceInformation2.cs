// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
/// </summary>
[IsoId("_QFsWVdp-Ed-ak6NoX_4Aeg_-1040515995")]
public interface IRemittanceInformation2 : IIsoComponent
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, for example, commercial invoices in an accounts&apos; receivable system in an unstructured form.
    /// </summary>
    [IsoId("_QFsWVtp-Ed-ak6NoX_4Aeg_-1039592586")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    IEnumerable<IsoMax140Text> Unstructured { get; }
}
