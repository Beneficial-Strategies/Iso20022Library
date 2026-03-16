// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities Market Report Header3.
/// </summary>
[IsoId("_g8XmYTguEe60j93i-cxu5Q")]
[DisplayName("Securities Market Report Header3")]
public partial record SecuritiesMarketReportHeader3
{
    #nullable enable

    /// <summary>
    /// ISIN.
    /// </summary>
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public ValueList<IsoISINOct2015Identifier> ISIN { get; init; } = [];

    /// <summary>
    /// Message Pagination.
    /// </summary>
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; } 

    /// <summary>
    /// Number Records.
    /// </summary>
    [DisplayName("Number Records")]
    [IsoXmlTag("NbRcrds")]
    public IsoNumber? NumberRecords { get; init; } 

    /// <summary>
    /// Reporting Entity.
    /// </summary>
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required TradingVenueIdentification1Choice_ ReportingEntity { get; init; } 

    /// <summary>
    /// Reporting Period.
    /// </summary>
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required Period11Choice_ ReportingPeriod { get; init; } 

    /// <summary>
    /// Submission Date Time.
    /// </summary>
    [DisplayName("Submission Date Time")]
    [IsoXmlTag("SubmissnDtTm")]
    public IsoISODateTime? SubmissionDateTime { get; init; } 

    
    #nullable disable
    
}
