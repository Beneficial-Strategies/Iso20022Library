// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a settlement service.
/// </summary>
[IsoId("_9FG4MUNJEeiut6dbx3wnBg")]
[DisplayName("Settlement Service")]
public record SettlementService2
{
    /// <summary>
    /// Settlement service actually applied to the transaction.
    /// </summary>
    [IsoId("_9SDIA0NJEeiut6dbx3wnBg")]
    [DisplayName("Settlement Service Applied")]
    [IsoXmlTag("SttlmSvcApld")]
    public SettlementServiceMode1? SettlementServiceApplied { get; init; }

    /// <summary>
    /// Dates related to the settlement service related to the transaction.
    /// </summary>
    [IsoId("_9SDIBUNJEeiut6dbx3wnBg")]
    [DisplayName("Settlement Service Dates")]
    [IsoXmlTag("SttlmSvcDts")]
    public SettlementServiceDate1? SettlementServiceDates { get; init; }

    /// <summary>
    /// Entity in charge of the settlement reporting service.
    /// </summary>
    [IsoId("_9SDIB0NJEeiut6dbx3wnBg")]
    [DisplayName("Settlement Reporting Entity")]
    [IsoXmlTag("SttlmRptgNtty")]
    public SettlementReportingEntity1? SettlementReportingEntity { get; init; }
}
