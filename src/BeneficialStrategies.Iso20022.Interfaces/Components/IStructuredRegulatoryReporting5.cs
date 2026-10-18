// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and statutory requirements.
/// </summary>
[IsoId("_F6fyAXeKEfCdoODv2ypKfw")]
public interface IStructuredRegulatoryReporting5 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of the information supplied in the regulatory reporting details.
    /// </summary>
    [IsoId("_GC8jYXeKEfCdoODv2ypKfw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IRegulatoryReportingType1Choice? Type { get; }

    /// <summary>
    /// Date related to the specified type of regulatory reporting details.
    /// </summary>
    [IsoId("_GC8jY3eKEfCdoODv2ypKfw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    ISODate? Date { get; }

    /// <summary>
    /// Country related to the specified type of regulatory reporting details.
    /// </summary>
    [IsoId("_GC8jZXeKEfCdoODv2ypKfw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    CountryCode? Country { get; }

    /// <summary>
    /// Specifies the nature, purpose, and reason for the transaction to be reported for regulatory and statutory requirements in a coded form.
    /// </summary>
    [IsoId("_GC8jZ3eKEfCdoODv2ypKfw")]
    [DisplayName("Reporting Code")]
    [IsoXmlTag("RptgCd")]
    Max10Text? ReportingCode { get; }

    /// <summary>
    /// Amount of money to be reported for regulatory and statutory requirements.
    /// </summary>
    [IsoId("_GC8jaXeKEfCdoODv2ypKfw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount? Amount { get; }

    /// <summary>
    /// Additional details that cater for specific domestic regulatory requirements.
    /// </summary>
    [IsoId("_GC8ja3eKEfCdoODv2ypKfw")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    IEnumerable<Max35Text> Information { get; }
}
