// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action event deadlines.
/// </summary>
[IsoId("_mNYgtJcFEee8S7xwGG7Veg")]
[DisplayName("Corporate Action Event Deadlines")]
public record CorporateActionEventDeadlines1
{
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_mNYgtpcFEee8S7xwGG7Veg")]
    [DisplayName("Early Response Deadline")]
    [IsoXmlTag("EarlyRspnDdln")]
    public DateFormat43Choice_? EarlyResponseDeadline { get; init; }

    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_mNYgu5cFEee8S7xwGG7Veg")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat44Choice_? ResponseDeadline { get; init; }

    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_mNYgvZcFEee8S7xwGG7Veg")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat43Choice_? MarketDeadline { get; init; }
}
