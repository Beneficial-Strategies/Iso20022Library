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
[IsoId("_gDEgMbtJEeilsanBGAzy4A")]
[DisplayName("Corporate Action Event Deadlines")]
public partial record CorporateActionEventDeadlines3
{
    #nullable enable
    
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_gU7FM7tJEeilsanBGAzy4A")]
    [DisplayName("Early Response Deadline")]
    [IsoXmlTag("EarlyRspnDdln")]
    public DateFormat43Choice_? EarlyResponseDeadline { get; init; } 
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_gU7FO7tJEeilsanBGAzy4A")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat44Choice_? ResponseDeadline { get; init; } 
    
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_gU7FQ7tJEeilsanBGAzy4A")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat43Choice_? MarketDeadline { get; init; } 
    
    /// <summary>
    /// Deadline for protect instructions.
    /// </summary>
    [IsoId("_wt6s4LtJEeilsanBGAzy4A")]
    [DisplayName("Protect Deadline")]
    [IsoXmlTag("PrtctDdln")]
    public DateFormat43Choice_? ProtectDeadline { get; init; } 
    
    /// <summary>
    /// Deadline for covering a protect instruction.
    /// </summary>
    [IsoId("_0ujQwLtJEeilsanBGAzy4A")]
    [DisplayName("Cover Protect Deadline")]
    [IsoXmlTag("CoverPrtctDdln")]
    public DateFormat43Choice_? CoverProtectDeadline { get; init; } 
    
    
    #nullable disable
    
}
