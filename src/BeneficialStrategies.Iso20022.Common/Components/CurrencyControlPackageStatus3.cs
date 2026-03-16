// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Control Package Status3.
/// </summary>
[IsoId("_2_P8MTEyEe6g-ffJsqGiSA")]
[DisplayName("Currency Control Package Status3")]
public record CurrencyControlPackageStatus3
{
    /// <summary>
    /// Package Identification.
    /// </summary>
    [DisplayName("Package Identification")]
    [IsoXmlTag("PackgId")]
    public required IsoMax35Text PackageIdentification { get; init; }

    /// <summary>
    /// Record Status.
    /// </summary>
    [DisplayName("Record Status")]
    [IsoXmlTag("RcrdSts")]
    public ValueList<CurrencyControlRecordStatus3> RecordStatus { get; init; } = [];

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required StatisticalReportingStatus1Code Status { get; init; }

    /// <summary>
    /// Status Date Time.
    /// </summary>
    [DisplayName("Status Date Time")]
    [IsoXmlTag("StsDtTm")]
    public IsoISODateTime? StatusDateTime { get; init; }

    /// <summary>
    /// Status Reason.
    /// </summary>
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<ValidationStatusReason3> StatusReason { get; init; } = [];
}
