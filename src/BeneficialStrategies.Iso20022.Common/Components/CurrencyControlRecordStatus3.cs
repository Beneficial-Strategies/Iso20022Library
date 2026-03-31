// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Control Record Status3.
/// </summary>
[IsoId("_3BkQazEyEe6g-ffJsqGiSA")]
[DisplayName("Currency Control Record Status3")]
public record CurrencyControlRecordStatus3
{
    /// <summary>
    /// Document Identification.
    /// </summary>
    [DisplayName("Document Identification")]
    [IsoXmlTag("DocId")]
    public DocumentIdentification28? DocumentIdentification { get; init; }

    /// <summary>
    /// Record Identification.
    /// </summary>
    [DisplayName("Record Identification")]
    [IsoXmlTag("RcrdId")]
    public required IsoMax35Text RecordIdentification { get; init; }

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
