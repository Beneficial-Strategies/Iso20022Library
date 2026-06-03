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
    [IsoId("_otjG0RUJEfC_aaedwHHlmw")]
    [DisplayName("Proposed Type")]
    [IsoXmlTag("PropsdTp")]
    public IsoMax35Text? ProposedType { get; init; }

    [IsoId("_otjG0xUJEfC_aaedwHHlmw")]
    [DisplayName("Proposed Identification")]
    [IsoXmlTag("PropsdId")]
    public IsoMax35Text? ProposedIdentification { get; init; }

    [IsoId("_otjG1RUJEfC_aaedwHHlmw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; }

    [IsoId("_otjG1xUJEfC_aaedwHHlmw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    [IsoId("_otjG2RUJEfC_aaedwHHlmw")]
    [DisplayName("Deferred Date")]
    [IsoXmlTag("DfrrdDt")]
    public IsoISODate? DeferredDate { get; init; }

    [IsoId("_otjG3RUJEfC_aaedwHHlmw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    [IsoId("_otjG3xUJEfC_aaedwHHlmw")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; }

    [IsoId("_otjG4RUJEfC_aaedwHHlmw")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public IsoMax35Text? Period { get; init; }

    [IsoId("_otjG4xUJEfC_aaedwHHlmw")]
    [DisplayName("Cut Off Time")]
    [IsoXmlTag("CutOffTm")]
    public IsoISODateTime? CutOffTime { get; init; }

    [IsoId("_otjG5RUJEfC_aaedwHHlmw")]
    [DisplayName("Reporting Entity Type")]
    [IsoXmlTag("RptgNttyTp")]
    public IsoMax35Text? ReportingEntityType { get; init; }

    [IsoId("_otjG5xUJEfC_aaedwHHlmw")]
    [DisplayName("Reporting Entity Identification")]
    [IsoXmlTag("RptgNttyId")]
    public IsoMax35Text? ReportingEntityIdentification { get; init; }

    [IsoId("_mtkiokVaEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_mtkio0VaEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
