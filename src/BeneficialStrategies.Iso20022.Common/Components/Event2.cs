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
/// Provides information on an event that happened in a system.
/// </summary>
[IsoId("_whUBYU7TEeSGH6dwL1uJcg")]
[DisplayName("Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Event2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Event2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Event2( System.String reqEventCode )
    {
        EventCode = reqEventCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Proprietary code used to specify an event that occurred in a system.
    /// </summary>
    [IsoId("_w2BtIU7TEeSGH6dwL1uJcg")]
    [DisplayName("Event Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtCd")]
    #endif
    [IsoXmlTag("EvtCd")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText EventCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EventCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EventCode { get; init; } 
    #else
    public System.String EventCode { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the parameters of an event which occurred in a system.
    /// </summary>
    [IsoId("_w2BtI07TEeSGH6dwL1uJcg")]
    [DisplayName("Event Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtParam")]
    #endif
    [IsoXmlTag("EvtParam")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EventParameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventParameter { get; init; } 
    #else
    public System.String? EventParameter { get; set; } 
    #endif
    
    /// <summary>
    /// Free text used to describe an event which occurred in a system.
    /// </summary>
    [IsoId("_w2BtJU7TEeSGH6dwL1uJcg")]
    [DisplayName("Event Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDesc")]
    #endif
    [IsoXmlTag("EvtDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? EventDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventDescription { get; init; } 
    #else
    public System.String? EventDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the event occurred.
    /// </summary>
    [IsoId("_w2BtJ07TEeSGH6dwL1uJcg")]
    [DisplayName("Event Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTm")]
    #endif
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? EventTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? EventTime { get; init; } 
    #else
    public System.DateTime? EventTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
