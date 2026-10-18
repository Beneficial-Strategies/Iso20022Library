// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRegulatoryReporting2"/>
[IsoId("_SnYP89p-Ed-ak6NoX_4Aeg_-2022088805")]
[DisplayName("Regulatory Reporting")]
public partial record RegulatoryReporting2
{
    /// <inheritdoc cref="IRegulatoryReporting2.DebitCreditReportingIndicator"/>
    [IsoId("_SnYP9Np-Ed-ak6NoX_4Aeg_-1566793972")]
    [DisplayName("Debit Credit Reporting Indicator")]
    [IsoXmlTag("DbtCdtRptgInd")]
    public RegulatoryReportingType1Code? DebitCreditReportingIndicator { get; init; }

    /// <inheritdoc cref="IRegulatoryReporting2.Authority"/>
    [IsoId("_SnYP9dp-Ed-ak6NoX_4Aeg_-688527268")]
    [DisplayName("Authority")]
    [IsoXmlTag("Authrty")]
    public RegulatoryAuthority? Authority { get; init; }

    /// <inheritdoc cref="IRegulatoryReporting2.RegulatoryDetails"/>
    [IsoId("_SnYP9tp-Ed-ak6NoX_4Aeg_2118187672")]
    [DisplayName("Regulatory Details")]
    [IsoXmlTag("RgltryDtls")]
    public StructuredRegulatoryReporting2? RegulatoryDetails { get; init; }
}
