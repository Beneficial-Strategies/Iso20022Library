// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and/or statutory requirements.
/// </summary>
[IsoId("_SnYP99p-Ed-ak6NoX_4Aeg_-1655670600")]
public interface IRegulatoryReporting3 : IIsoComponent
{
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// </summary>
    [IsoId("_SnYP-Np-Ed-ak6NoX_4Aeg_-1655670598")]
    [DisplayName("Debit Credit Reporting Indicator")]
    [IsoXmlTag("DbtCdtRptgInd")]
    RegulatoryReportingType1Code? DebitCreditReportingIndicator { get; }

    /// <summary>
    /// Entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_SnhZ4Np-Ed-ak6NoX_4Aeg_-1655670538")]
    [DisplayName("Authority")]
    [IsoXmlTag("Authrty")]
    IRegulatoryAuthority2? Authority { get; }

    /// <summary>
    /// Set of elements used to provide details on the regulatory reporting information.
    /// </summary>
    [IsoId("_SnhZ4dp-Ed-ak6NoX_4Aeg_-1655670493")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    IEnumerable<IStructuredRegulatoryReporting3> Details { get; }
}
