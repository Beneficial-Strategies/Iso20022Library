// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRegulatoryReporting10"/>
[IsoId("_FyCZkXeKEfCdoODv2ypKfw")]
[DisplayName("Regulatory Reporting10")]
public partial record RegulatoryReporting10
{
    /// <inheritdoc cref="IRegulatoryReporting10.DebitCreditReportingIndicator"/>
    [IsoId("_F6fK8XeKEfCdoODv2ypKfw")]
    [DisplayName("Debit Credit Reporting Indicator")]
    [IsoXmlTag("DbtCdtRptgInd")]
    public required RegulatoryReportingType1Code DebitCreditReportingIndicator { get; init; }

    /// <inheritdoc cref="IRegulatoryReporting10.Authority"/>
    [IsoId("_F6fK83eKEfCdoODv2ypKfw")]
    [DisplayName("Authority")]
    [IsoXmlTag("Authrty")]
    public RegulatoryAuthority2? Authority { get; init; }

    /// <inheritdoc cref="IRegulatoryReporting10.Details"/>
    [IsoId("_F6fK9XeKEfCdoODv2ypKfw")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public ValueList<StructuredRegulatoryReporting5> Details { get; init; } = [];
}
