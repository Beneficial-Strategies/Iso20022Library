// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and/or statutory requirements.
/// </summary>
[IsoId("_SnYP89p-Ed-ak6NoX_4Aeg_-2022088805")]
public interface IRegulatoryReporting2 : IIsoComponent
{
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// </summary>
    [IsoId("_SnYP9Np-Ed-ak6NoX_4Aeg_-1566793972")]
    [DisplayName("Debit Credit Reporting Indicator")]
    [IsoXmlTag("DbtCdtRptgInd")]
    RegulatoryReportingType1Code? DebitCreditReportingIndicator { get; }

    /// <summary>
    /// Entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_SnYP9dp-Ed-ak6NoX_4Aeg_-688527268")]
    [DisplayName("Authority")]
    [IsoXmlTag("Authrty")]
    IRegulatoryAuthority? Authority { get; }

    /// <summary>
    /// Details related to the regulatory reporting information.
    /// </summary>
    [IsoId("_SnYP9tp-Ed-ak6NoX_4Aeg_2118187672")]
    [DisplayName("Regulatory Details")]
    [IsoXmlTag("RgltryDtls")]
    IStructuredRegulatoryReporting2? RegulatoryDetails { get; }
}
