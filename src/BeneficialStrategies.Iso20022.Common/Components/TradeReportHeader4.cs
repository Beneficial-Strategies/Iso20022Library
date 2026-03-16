// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the header for a trade transaction query message.
/// </summary>
[IsoId("_hxrf4RZ6Ee27wrM4RUjLog")]
[DisplayName("Trade Report Header")]
public record TradeReportHeader4
{
    /// <summary>
    /// Indicates the as-at day for which the report was produced.
    /// </summary>
    [IsoId("_hzTQgRZ6Ee27wrM4RUjLog")]
    [DisplayName("Report Execution Date")]
    [IsoXmlTag("RptExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReportExecutionDate { get; init; }

    /// <summary>
    /// Page number of the message (within the report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_hzTQgxZ6Ee27wrM4RUjLog")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; }

    /// <summary>
    /// Indicates the number of records in the page.
    /// </summary>
    [IsoId("_hzTQhRZ6Ee27wrM4RUjLog")]
    [DisplayName("Number Records")]
    [IsoXmlTag("NbRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberRecords { get; init; }

    /// <summary>
    /// Specifies the competent authority that requires reporting of the transaction.
    /// </summary>
    [IsoId("_hzTQhxZ6Ee27wrM4RUjLog")]
    [DisplayName("Competent Authority")]
    [IsoXmlTag("CmptntAuthrty")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100, MinimumLength = 1)]
    public IsoMax100Text? CompetentAuthority { get; init; }

    /// <summary>
    /// Identifies the new trade repository to which the derivative is transfered to.
    /// </summary>
    [IsoId("_hzTQiRZ6Ee27wrM4RUjLog")]
    [DisplayName("New Trade Repository Identifier")]
    [IsoXmlTag("NewTradRpstryIdr")]
    public OrganisationIdentification15Choice_? NewTradeRepositoryIdentifier { get; init; }

    /// <summary>
    /// Underlying reason for reporting the derivative transaction.
    /// </summary>
    [IsoId("_Uu4gsCLrEe2KAJot-YBP6w")]
    [DisplayName("Reporting Purpose")]
    [IsoXmlTag("RptgPurp")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100, MinimumLength = 1)]
    public IsoMax100Text? ReportingPurpose { get; init; }
}
