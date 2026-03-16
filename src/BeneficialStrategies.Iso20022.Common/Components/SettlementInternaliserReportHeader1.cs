// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies parameters of the report
/// </summary>
[IsoId("_rJ-pkO3kEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Report Header")]
public record SettlementInternaliserReportHeader1
{
    /// <summary>
    /// Provides the reporting timestamp, when the report was submitted from the Settlement Internaliser to the Competent Authority.
    /// </summary>
    [IsoId("_2Xg5AO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Last day of the reporting period.
    /// </summary>
    [IsoId("_4oFNcO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Reporting Date")]
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ReportingDate { get; init; }

    /// <summary>
    /// Specifies the currency of the reported transactions.
    /// </summary>
    [IsoId("_641IEO3kEeaWjpoyrnG6Rw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Provides the status of the report.
    /// </summary>
    [IsoId("_eVMmQHBLEeeD5_FeE1GEtw")]
    [DisplayName("Report Status")]
    [IsoXmlTag("RptSts")]
    public required TransactionOperationType4Code ReportStatus { get; init; }
}
