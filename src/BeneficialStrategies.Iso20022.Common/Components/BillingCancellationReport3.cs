// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report on cancelled billing data.
/// </summary>
[IsoId("_2oUp8TEyEe6g-ffJsqGiSA")]
[DisplayName("Billing Cancellation Report3")]
public record BillingCancellationReport3
{
    /// <summary>
    /// Information about legal and regulatory data exchanged between invoicing and paying party.
    /// </summary>
    [IsoId("_2qnwATEyEe6g-ffJsqGiSA")]
    [DisplayName("Regulatory Data")]
    [IsoXmlTag("RgltryData")]
    public InvoiceLegalIssue5? RegulatoryData { get; init; }

    /// <summary>
    /// Identification of the service or system for which the billing cancellation is provided.
    /// </summary>
    [IsoId("_2qnwAzEyEe6g-ffJsqGiSA")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public SystemAndCurrency1? Service { get; init; }

    /// <summary>
    /// Date at which the billing report was created.
    /// </summary>
    [IsoId("_2qnwBTEyEe6g-ffJsqGiSA")]
    [DisplayName("Invoice Date")]
    [IsoXmlTag("InvcDt")]
    public required IsoISODate InvoiceDate { get; init; }

    /// <summary>
    /// Identification of the billing report.
    /// </summary>
    [IsoId("_2qnwBzEyEe6g-ffJsqGiSA")]
    [DisplayName("Billing Identification")]
    [IsoXmlTag("BllgId")]
    public required IsoMax35Text BillingIdentification { get; init; }

    /// <summary>
    /// Date period which for which the report data is valid.
    /// </summary>
    [IsoId("_2qnwCTEyEe6g-ffJsqGiSA")]
    [DisplayName("Billing Period")]
    [IsoXmlTag("BllgPrd")]
    public required DatePeriod2 BillingPeriod { get; init; }

    /// <summary>
    /// Reason why requested billing information is cancelled.
    /// </summary>
    [IsoId("_2qnwCzEyEe6g-ffJsqGiSA")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CancellationReason16Choice CancellationReason { get; init; }
}
