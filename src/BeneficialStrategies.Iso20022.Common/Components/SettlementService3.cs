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
[IsoId("_wGxUkSbUEeyhZIgCcGlTyA")]
[DisplayName("Settlement Service")]
public record SettlementService3
{
    /// <summary>
    /// Type of settlement service proposed.
    /// </summary>
    [IsoId("_wOtIkSbUEeyhZIgCcGlTyA")]
    [DisplayName("Settlement Service Proposed")]
    [IsoXmlTag("SttlmSvcPropsd")]
    public SettlementServiceMode1? SettlementServiceProposed { get; init; }

    /// <summary>
    /// Settlement service actually applied to the transaction.
    /// </summary>
    [IsoId("_wOtIkybUEeyhZIgCcGlTyA")]
    [DisplayName("Settlement Service Applied")]
    [IsoXmlTag("SttlmSvcApld")]
    public SettlementServiceMode1? SettlementServiceApplied { get; init; }

    /// <summary>
    /// Dates related to the settlement service related to the transaction.
    /// </summary>
    [IsoId("_wOtIlSbUEeyhZIgCcGlTyA")]
    [DisplayName("Settlement Service Dates")]
    [IsoXmlTag("SttlmSvcDts")]
    public SettlementServiceDate2? SettlementServiceDates { get; init; }

    /// <summary>
    /// Entity in charge of the settlement reporting service.
    /// </summary>
    [IsoId("_wOtIlybUEeyhZIgCcGlTyA")]
    [DisplayName("Settlement Reporting Entity")]
    [IsoXmlTag("SttlmRptgNtty")]
    public SettlementReportingEntity1? SettlementReportingEntity { get; init; }

    /// <summary>
    /// Additional Settlement Information.
    /// </summary>
    [IsoId("_DnSG0CbVEeyhZIgCcGlTyA")]
    [DisplayName("Additional Settlement Information")]
    [IsoXmlTag("AddtlSttlmInf")]
    public ValueList<AdditionalData1> AdditionalSettlementInformation { get; init; } = [];
}
