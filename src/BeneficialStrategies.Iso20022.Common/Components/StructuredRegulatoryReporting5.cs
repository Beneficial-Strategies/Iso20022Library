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
    /// <summary>
    /// Specifies the type of the information supplied in the regulatory reporting details.
    /// </summary>
    [IsoId("_GC8jYXeKEfCdoODv2ypKfw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public RegulatoryReportingType1Choice_? Type { get; init; }

    /// <summary>
    /// Date related to the specified type of regulatory reporting details.
    /// </summary>
    [IsoId("_GC8jY3eKEfCdoODv2ypKfw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Country related to the specified type of regulatory reporting details.
    /// </summary>
    [IsoId("_GC8jZXeKEfCdoODv2ypKfw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Specifies the nature, purpose, and reason for the transaction to be reported for regulatory and statutory requirements in a coded form.
    /// </summary>
    [IsoId("_GC8jZ3eKEfCdoODv2ypKfw")]
    [DisplayName("Reporting Code")]
    [IsoXmlTag("RptgCd")]
    public IsoMax10Text? ReportingCode { get; init; }

    /// <summary>
    /// Amount of money to be reported for regulatory and statutory requirements.
    /// </summary>
    [IsoId("_GC8jaXeKEfCdoODv2ypKfw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Additional details that cater for specific domestic regulatory requirements.
    /// </summary>
    [IsoId("_GC8ja3eKEfCdoODv2ypKfw")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    public SimpleValueList<IsoMax35Text> Information { get; init; } = [];
}
