// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action event deadlines.
/// </summary>
[IsoId("_D3XajffQEeiNZp_PtLohLw")]
[DisplayName("Corporate Action Event Deadlines")]
public partial record CorporateActionEventDeadlines4
{
    #nullable enable
    
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_D3XakffQEeiNZp_PtLohLw")]
    [DisplayName("Early Response Deadline")]
    [IsoXmlTag("EarlyRspnDdln")]
    public DateFormat49Choice_? EarlyResponseDeadline { get; init; } 
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_D3XamffQEeiNZp_PtLohLw")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat54Choice_? ResponseDeadline { get; init; } 
    
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_D3XaoffQEeiNZp_PtLohLw")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat49Choice_? MarketDeadline { get; init; } 
    
    /// <summary>
    /// Deadline for protect instructions.
    /// </summary>
    [IsoId("_D3XaqffQEeiNZp_PtLohLw")]
    [DisplayName("Protect Deadline")]
    [IsoXmlTag("PrtctDdln")]
    public DateFormat49Choice_? ProtectDeadline { get; init; } 
    
    /// <summary>
    /// Deadline for covering a protect instruction.
    /// </summary>
    [IsoId("_D3Xaq_fQEeiNZp_PtLohLw")]
    [DisplayName("Cover Protect Deadline")]
    [IsoXmlTag("CoverPrtctDdln")]
    public DateFormat49Choice_? CoverProtectDeadline { get; init; } 
    
    
    #nullable disable
    
}
