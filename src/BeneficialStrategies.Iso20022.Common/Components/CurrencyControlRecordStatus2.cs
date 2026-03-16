// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each individual currency control record.
/// </summary>
[IsoId("_9rC4vW48EeiU9cctagi5ow")]
[DisplayName("Currency Control Record Status")]
public record CurrencyControlRecordStatus2
{
    /// <summary>
    /// Unique and unambiguous identification of each entry/record within the package of transactions.
    /// </summary>
    [IsoId("_91eAAW48EeiU9cctagi5ow")]
    [DisplayName("Record Identification")]
    [IsoXmlTag("RcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RecordIdentification { get; init; }

    /// <summary>
    /// Defines the status of the reported record.
    /// </summary>
    [IsoId("_91eAA248EeiU9cctagi5ow")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required StatisticalReportingStatus1Code Status { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_91eABW48EeiU9cctagi5ow")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<ValidationStatusReason2> StatusReason { get; init; } = [];

    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    [IsoId("_91eAB248EeiU9cctagi5ow")]
    [DisplayName("Status Date Time")]
    [IsoXmlTag("StsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDateTime { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the document.
    /// </summary>
    [IsoId("_91eACW48EeiU9cctagi5ow")]
    [DisplayName("Document Identification")]
    [IsoXmlTag("DocId")]
    public DocumentIdentification28? DocumentIdentification { get; init; }
}
