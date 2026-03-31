// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numerical representation of the nett increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
/// </summary>
[IsoId("_7xjgAS43EeK7-OZOLIksSw")]
[DisplayName("Report Data")]
public record ReportData4
{
    /// <summary>
    /// Identification of the report as assigned by the sender.
    /// </summary>
    [IsoId("_8AsvRS43EeK7-OZOLIksSw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Value date for which the pay-in schedule is generated.
    /// </summary>
    [IsoId("_8AsvSS43EeK7-OZOLIksSw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; }

    /// <summary>
    /// Date and time on which the report is generated. The offset with UTC may also be specified.
    /// </summary>
    [IsoId("_8AsvTS43EeK7-OZOLIksSw")]
    [DisplayName("Date And Time Stamp")]
    [IsoXmlTag("DtAndTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateAndTimeStamp { get; init; }

    /// <summary>
    /// Type of pay-in schedule.
    /// </summary>
    [IsoId("_8AsvUS43EeK7-OZOLIksSw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required Entry2Code Type { get; init; }

    /// <summary>
    /// Defines the schedule timing that is, whether it is an initial or a revised schedule.
    /// </summary>
    [IsoId("_qFT-gJXDEeK3CZeLifG0eA")]
    [DisplayName("Schedule Type")]
    [IsoXmlTag("SchdlTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText ScheduleType { get; init; }

    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_CPlTYi44EeK7-OZOLIksSw")]
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; }
}
