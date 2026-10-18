// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and/or statutory requirements.
/// </summary>
[IsoId("_FyCZkXeKEfCdoODv2ypKfw")]
public interface IRegulatoryReporting10 : IIsoComponent
{
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// </summary>
    [IsoId("_F6fK8XeKEfCdoODv2ypKfw")]
    [DisplayName("Debit Credit Reporting Indicator")]
    [IsoXmlTag("DbtCdtRptgInd")]
    RegulatoryReportingType1Code DebitCreditReportingIndicator { get; }

    /// <summary>
    /// Entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_F6fK83eKEfCdoODv2ypKfw")]
    [DisplayName("Authority")]
    [IsoXmlTag("Authrty")]
    IRegulatoryAuthority2? Authority { get; }

    /// <summary>
    /// Set of elements used to provide details on the regulatory reporting information.
    /// </summary>
    [IsoId("_F6fK9XeKEfCdoODv2ypKfw")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    IEnumerable<IStructuredRegulatoryReporting5> Details { get; }
}
