// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action date.
/// </summary>
[IsoId("_TW6Pfdp-Ed-ak6NoX_4Aeg_1109592297")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate6
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_TW6Pftp-Ed-ak6NoX_4Aeg_1109592759")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat6Choice_? ResponseDeadline { get; init; } 
    
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [IsoId("_TW6Pf9p-Ed-ak6NoX_4Aeg_1109593160")]
    [DisplayName("Subscription Cost Debit Date")]
    [IsoXmlTag("SbcptCostDbtDt")]
    public DateFormat6Choice_? SubscriptionCostDebitDate { get; init; } 
    
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond, with an instruction, to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_TXEAcNp-Ed-ak6NoX_4Aeg_1109592729")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat6Choice_? MarketDeadline { get; init; } 
    
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [IsoId("_TXEAcdp-Ed-ak6NoX_4Aeg_1109592851")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat6Choice_? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_TXEActp-Ed-ak6NoX_4Aeg_-1259743507")]
    [DisplayName("Cover Expiration Date")]
    [IsoXmlTag("CoverXprtnDt")]
    public DateFormat6Choice_? CoverExpirationDate { get; init; } 
    
    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [IsoId("_TXEAc9p-Ed-ak6NoX_4Aeg_-1220032173")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    public DateFormat6Choice_? ProtectDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the deal (rights) was agreed.
    /// </summary>
    [IsoId("_TXEAdNp-Ed-ak6NoX_4Aeg_-1190480582")]
    [DisplayName("Trading Date")]
    [IsoXmlTag("TradgDt")]
    public DateFormat6Choice_? TradingDate { get; init; } 
    
    
    #nullable disable
    
}
