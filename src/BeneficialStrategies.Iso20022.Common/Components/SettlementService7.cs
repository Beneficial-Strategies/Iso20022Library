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
[IsoId("_ommxURUJEfC_aaedwHHlmw")]
[DisplayName("Settlement Service7")]
public record SettlementService7
{
    /// <summary>
    /// Proposed type of settlement service.
    /// </summary>
    [IsoId("_otjG0RUJEfC_aaedwHHlmw")]
    [DisplayName("Proposed Type")]
    [IsoXmlTag("PropsdTp")]
    public IsoMax35Text? ProposedType { get; init; }

    /// <summary>
    /// Identification of proposed settlement service.
    /// </summary>
    [IsoId("_otjG0xUJEfC_aaedwHHlmw")]
    [DisplayName("Proposed Identification")]
    [IsoXmlTag("PropsdId")]
    public IsoMax35Text? ProposedIdentification { get; init; }

    /// <summary>
    /// Type of settlement service applied
    /// </summary>
    [IsoId("_otjG1RUJEfC_aaedwHHlmw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Identification of settlement service applied.
    /// </summary>
    [IsoId("_otjG1xUJEfC_aaedwHHlmw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Indicate the date the transaction will be settled.
    /// </summary>
    [IsoId("_otjG2RUJEfC_aaedwHHlmw")]
    [DisplayName("Deferred Date")]
    [IsoXmlTag("DfrrdDt")]
    public IsoISODate? DeferredDate { get; init; }

    /// <summary>
    /// Actual date of settlement.
    /// </summary>
    [IsoId("_otjG3RUJEfC_aaedwHHlmw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Actual time of settlement.
    /// </summary>
    [IsoId("_otjG3xUJEfC_aaedwHHlmw")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; }

    /// <summary>
    /// Identifies the settlement period, cycle or group. May contain settlement frequency or the identification of specific settlement period. For example, daily, monthly or settlementperiod123acd.
    /// </summary>
    [IsoId("_otjG4RUJEfC_aaedwHHlmw")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public IsoMax35Text? Period { get; init; }

    /// <summary>
    /// Identifies the effective end time of the settlement date and/or period. 
    /// </summary>
    [IsoId("_otjG4xUJEfC_aaedwHHlmw")]
    [DisplayName("Cut Off Time")]
    [IsoXmlTag("CutOffTm")]
    public IsoISODateTime? CutOffTime { get; init; }

    /// <summary>
    /// Identifies the type of settlement reporting entity
    /// </summary>
    [IsoId("_otjG5RUJEfC_aaedwHHlmw")]
    [DisplayName("Reporting Entity Type")]
    [IsoXmlTag("RptgNttyTp")]
    public IsoMax35Text? ReportingEntityType { get; init; }

    /// <summary>
    /// Identification of the settlement reporting entity.
    /// </summary>
    [IsoId("_otjG5xUJEfC_aaedwHHlmw")]
    [DisplayName("Reporting Entity Identification")]
    [IsoXmlTag("RptgNttyId")]
    public IsoMax35Text? ReportingEntityIdentification { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_mtkiokVaEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_mtkio0VaEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
