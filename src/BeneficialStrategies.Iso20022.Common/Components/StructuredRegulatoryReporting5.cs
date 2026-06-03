// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and statutory requirements.
/// </summary>
[IsoId("_F6fyAXeKEfCdoODv2ypKfw")]
[DisplayName("Structured Regulatory Reporting5")]
public record StructuredRegulatoryReporting5
{
    [IsoId("_GC8jYXeKEfCdoODv2ypKfw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public RegulatoryReportingType1Choice? Type { get; init; }

    [IsoId("_GC8jY3eKEfCdoODv2ypKfw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    [IsoId("_GC8jZXeKEfCdoODv2ypKfw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    [IsoId("_GC8jZ3eKEfCdoODv2ypKfw")]
    [DisplayName("Reporting Code")]
    [IsoXmlTag("RptgCd")]
    public IsoMax10Text? ReportingCode { get; init; }

    [IsoId("_GC8jaXeKEfCdoODv2ypKfw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    [IsoId("_GC8ja3eKEfCdoODv2ypKfw")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    public SimpleValueList<IsoMax35Text> Information { get; init; } = [];
}
