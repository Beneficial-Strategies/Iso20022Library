// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies information about the penalty report.
/// </summary>
[IsoId("_8l9EMdfMEeiJ1vId85LeLw")]
[DisplayName("Penalty Report1")]
public record PenaltyReport1
{
    /// <summary>
    /// Unique identification of the report as assigned by the account servicer.
    /// </summary>
    [IsoId("_9BiXkdfMEeiJ1vId85LeLw")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required IsoMax35Text ReportIdentification { get; init; }

    /// <summary>
    /// Date and time of the report.
    /// </summary>
    [IsoId("_9BiXkvfMEeiJ1vId85LeLw")]
    [DisplayName("Report Date")]
    [IsoXmlTag("RptDt")]
    public DateAndDateTime2Choice_? ReportDate { get; init; }

    /// <summary>
    /// Period covered by the report.
    /// </summary>
    [IsoId("_9BiXk_fMEeiJ1vId85LeLw")]
    [DisplayName("Report Period")]
    [IsoXmlTag("RptPrd")]
    public DatePeriod1Choice_? ReportPeriod { get; init; }

    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_9BiXlPfMEeiJ1vId85LeLw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency22Choice_? Frequency { get; init; }

    /// <summary>
    /// Type of the penalty list.
    /// </summary>
    [IsoId("_9BiXlffMEeiJ1vId85LeLw")]
    [DisplayName("Penalty List Type")]
    [IsoXmlTag("PnltyListTp")]
    public PenaltyListType1Choice_? PenaltyListType { get; init; }

    /// <summary>
    /// Specifies the type of the update.
    /// </summary>
    [IsoId("_9BiXlvfMEeiJ1vId85LeLw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType15Choice_? UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is penalty activity.
    /// </summary>
    [IsoId("_9BiXl_fMEeiJ1vId85LeLw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
