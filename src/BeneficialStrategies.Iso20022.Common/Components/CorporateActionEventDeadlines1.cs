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
/// Specifies corporate action event deadlines.
/// </summary>
[IsoId("_mNYgtJcFEee8S7xwGG7Veg")]
[DisplayName("Corporate Action Event Deadlines")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionEventDeadlines1
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
    [IsoId("_mNYgtpcFEee8S7xwGG7Veg")]
    [DisplayName("Early Response Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyRspnDdln")]
    #endif
    [IsoXmlTag("EarlyRspnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat43Choice_? EarlyResponseDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat43Choice_? EarlyResponseDeadline { get; init; } 
    #else
    public DateFormat43Choice_? EarlyResponseDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_mNYgu5cFEee8S7xwGG7Veg")]
    [DisplayName("Response Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnDdln")]
    #endif
    [IsoXmlTag("RspnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat44Choice_? ResponseDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat44Choice_? ResponseDeadline { get; init; } 
    #else
    public DateFormat44Choice_? ResponseDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_mNYgvZcFEee8S7xwGG7Veg")]
    [DisplayName("Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktDdln")]
    #endif
    [IsoXmlTag("MktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat43Choice_? MarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat43Choice_? MarketDeadline { get; init; } 
    #else
    public DateFormat43Choice_? MarketDeadline { get; set; } 
    #endif
    
    
    #nullable disable
    
}
