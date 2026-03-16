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
[IsoId("_b2XNYEX7Eeegp_DADCe7HQ")]
[DisplayName("Settlement Service")]
public record SettlementService1
{
    /// <summary>
    /// Type of settlement service proposed.
    /// </summary>
    [IsoId("_57F3AEq2Eeenp6hmNprBHg")]
    [DisplayName("Settlement Service Proposed")]
    [IsoXmlTag("SttlmSvcPropsd")]
    public SettlementServiceMode1? SettlementServiceProposed { get; init; }

    /// <summary>
    /// Settlement service actually applied to the transaction.
    /// </summary>
    [IsoId("_COc0UEq3Eeenp6hmNprBHg")]
    [DisplayName("Settlement Service Applied")]
    [IsoXmlTag("SttlmSvcApld")]
    public SettlementServiceMode1? SettlementServiceApplied { get; init; }

    /// <summary>
    /// Dates related to the settlement service related to the transaction.
    /// </summary>
    [IsoId("_L6cYgEq3Eeenp6hmNprBHg")]
    [DisplayName("Settlement Service Dates")]
    [IsoXmlTag("SttlmSvcDts")]
    public SettlementServiceDate1? SettlementServiceDates { get; init; }

    /// <summary>
    /// Entity in charge of the settlement reporting service.
    /// </summary>
    [IsoId("_eG2ekEq3Eeenp6hmNprBHg")]
    [DisplayName("Settlement Reporting Entity")]
    [IsoXmlTag("SttlmRptgNtty")]
    public SettlementReportingEntity1? SettlementReportingEntity { get; init; }
}
