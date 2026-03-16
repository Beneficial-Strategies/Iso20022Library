// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Request8.
/// </summary>
[IsoId("_B5tVUaEvEe-MRKYsaX6JDg")]
[DisplayName("Report Request8")]
public record ReportRequest8
{
    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment81 Environment { get; init; }

    /// <summary>
    /// Report Get Totals Request.
    /// </summary>
    [DisplayName("Report Get Totals Request")]
    [IsoXmlTag("RptGetTtlsReq")]
    public ReportGetTotalsRequest1? ReportGetTotalsRequest { get; init; }

    /// <summary>
    /// Report Transaction Request.
    /// </summary>
    [DisplayName("Report Transaction Request")]
    [IsoXmlTag("RptTxReq")]
    public ReportTransactionRequest1? ReportTransactionRequest { get; init; }

    /// <summary>
    /// Service Content.
    /// </summary>
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService6Code ServiceContent { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
