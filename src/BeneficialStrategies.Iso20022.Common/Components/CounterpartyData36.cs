// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to counterparties and related fields.
/// </summary>
[IsoId("_77_r0Xd5EeerYuOTCu2Zqg")]
[DisplayName("Counterparty Data")]
public record CounterpartyData36
{
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_8HGIlXd5EeerYuOTCu2Zqg")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier ReportSubmittingEntity { get; init; }

    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_8HGIl3d5EeerYuOTCu2Zqg")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier ReportingCounterparty { get; init; }
}
