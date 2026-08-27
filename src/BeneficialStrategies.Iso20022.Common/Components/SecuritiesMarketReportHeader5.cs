// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the Consolidated Tape Provider (CTP) report header.
/// </summary>
[IsoId("_MpVqYQJ4EfGh4rQVEvIxOg")]
[DisplayName("Securities Market Report Header5")]
public record SecuritiesMarketReportHeader5
{
    /// <summary>
    /// Identification of the venue which generates the report.
    /// </summary>
    [IsoId("_MqjLUQJ4EfGh4rQVEvIxOg")]
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required TradingVenueIdentification1Choice_ ReportingEntity { get; init; }

    /// <summary>
    /// Date or date range the report relates to.
    /// </summary>
    [IsoId("_MqjLVwJ4EfGh4rQVEvIxOg")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required Period11Choice_ ReportingPeriod { get; init; }

    /// <summary>
    /// Date and time of the report originally submitted by the reporting entity when the file is generated for submission to their reporting authority.
    /// </summary>
    [IsoId("_MqjLYwJ4EfGh4rQVEvIxOg")]
    [DisplayName("Submission Date Time")]
    [IsoXmlTag("SubmissnDtTm")]
    public IsoISODateTime? SubmissionDateTime { get; init; }

    /// <summary>
    /// Page number of the message (within the report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_MqjLaQJ4EfGh4rQVEvIxOg")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; }

    /// <summary>
    /// Indicates the number of records in the page.
    /// </summary>
    [IsoId("_MqjLbwJ4EfGh4rQVEvIxOg")]
    [DisplayName("Number Records")]
    [IsoXmlTag("NbRcrds")]
    public IsoNumber? NumberRecords { get; init; }
}
