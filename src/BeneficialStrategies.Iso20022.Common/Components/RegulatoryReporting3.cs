// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and/or statutory requirements.
/// </summary>
[IsoId("_SnYP99p-Ed-ak6NoX_4Aeg_-1655670600")]
[DisplayName("Regulatory Reporting")]
public record RegulatoryReporting3
{
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// </summary>
    [IsoId("_SnYP-Np-Ed-ak6NoX_4Aeg_-1655670598")]
    [DisplayName("Debit Credit Reporting Indicator")]
    [IsoXmlTag("DbtCdtRptgInd")]
    public RegulatoryReportingType1Code? DebitCreditReportingIndicator { get; init; }

    /// <summary>
    /// Entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_SnhZ4Np-Ed-ak6NoX_4Aeg_-1655670538")]
    [DisplayName("Authority")]
    [IsoXmlTag("Authrty")]
    public RegulatoryAuthority2? Authority { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the regulatory reporting information.
    /// </summary>
    [IsoId("_SnhZ4dp-Ed-ak6NoX_4Aeg_-1655670493")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public StructuredRegulatoryReporting3? Details { get; init; }
}
