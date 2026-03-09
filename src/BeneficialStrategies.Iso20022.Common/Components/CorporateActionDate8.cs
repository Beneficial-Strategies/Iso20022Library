// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_TY_6KNp-Ed-ak6NoX_4Aeg_-402338190")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_TZJEENp-Ed-ak6NoX_4Aeg_758429431")]
    [DisplayName("Early Response Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyRspnDdln")]
    #endif
    [IsoXmlTag("EarlyRspnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? EarlyResponseDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? EarlyResponseDeadline { get; init; } 
    #else
    public DateFormat6Choice_? EarlyResponseDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_TZJEEdp-Ed-ak6NoX_4Aeg_1688383659")]
    [DisplayName("Cover Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverXprtnDt")]
    #endif
    [IsoXmlTag("CoverXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? CoverExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? CoverExpirationDate { get; init; } 
    #else
    public DateFormat6Choice_? CoverExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [IsoId("_TZJEEtp-Ed-ak6NoX_4Aeg_-1638733490")]
    [DisplayName("Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctDt")]
    #endif
    [IsoXmlTag("PrtctDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? ProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? ProtectDate { get; init; } 
    #else
    public DateFormat6Choice_? ProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond, with an instruction, to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_TZJEE9p-Ed-ak6NoX_4Aeg_-402337260")]
    [DisplayName("Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktDdln")]
    #endif
    [IsoXmlTag("MktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? MarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? MarketDeadline { get; init; } 
    #else
    public DateFormat6Choice_? MarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_TZJEFNp-Ed-ak6NoX_4Aeg_-402337235")]
    [DisplayName("Response Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnDdln")]
    #endif
    [IsoXmlTag("RspnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat7Choice_? ResponseDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat7Choice_? ResponseDeadline { get; init; } 
    #else
    public DateFormat7Choice_? ResponseDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [IsoId("_TZJEFdp-Ed-ak6NoX_4Aeg_-402337175")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? ExpiryDate { get; init; } 
    #else
    public DateFormat6Choice_? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [IsoId("_TZJEFtp-Ed-ak6NoX_4Aeg_-402337063")]
    [DisplayName("Subscription Cost Debit Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptCostDbtDt")]
    #endif
    [IsoXmlTag("SbcptCostDbtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? SubscriptionCostDebitDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? SubscriptionCostDebitDate { get; init; } 
    #else
    public DateFormat6Choice_? SubscriptionCostDebitDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day that a participant of the depository can deliver securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_TZJEF9p-Ed-ak6NoX_4Aeg_1409521176")]
    [DisplayName("Depository Cover Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstryCoverXprtnDt")]
    #endif
    [IsoXmlTag("DpstryCoverXprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? DepositoryCoverExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? DepositoryCoverExpirationDate { get; init; } 
    #else
    public DateFormat6Choice_? DepositoryCoverExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day an investor can become a lead plaintiff.
    /// </summary>
    [IsoId("_TZJEGNp-Ed-ak6NoX_4Aeg_-1456762623")]
    [DisplayName("Lead Plaintiff Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LeadPlntffDdln")]
    #endif
    [IsoXmlTag("LeadPlntffDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? LeadPlaintiffDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? LeadPlaintiffDeadline { get; init; } 
    #else
    public DateFormat6Choice_? LeadPlaintiffDeadline { get; set; } 
    #endif
    
    
    #nullable disable
    
}
