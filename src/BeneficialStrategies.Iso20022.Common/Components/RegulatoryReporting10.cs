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
[IsoId("_FyCZkXeKEfCdoODv2ypKfw")]
[DisplayName("Regulatory Reporting10")]
public record RegulatoryReporting10
{
    /// <summary>
    /// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
    /// </summary>
    [IsoId("_F6fK8XeKEfCdoODv2ypKfw")]
    [DisplayName("Debit Credit Reporting Indicator")]
    [IsoXmlTag("DbtCdtRptgInd")]
    public required RegulatoryReportingType1Code DebitCreditReportingIndicator { get; init; }

    /// <summary>
    /// Entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_F6fK83eKEfCdoODv2ypKfw")]
    [DisplayName("Authority")]
    [IsoXmlTag("Authrty")]
    public RegulatoryAuthority2? Authority { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the regulatory reporting information.
    /// </summary>
    [IsoId("_F6fK9XeKEfCdoODv2ypKfw")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public ValueList<StructuredRegulatoryReporting5> Details { get; init; } = [];
}
