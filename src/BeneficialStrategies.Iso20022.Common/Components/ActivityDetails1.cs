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
/// Describes the activities that took place during a certain period for one trade transaction.
/// </summary>
[IsoId("_RJDQwNp-Ed-ak6NoX_4Aeg_2070733092")]
[DisplayName("Activity Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActivityDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActivityDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActivityDetails1( System.DateTime reqDateTime,Activity1 reqActivity,BICIdentification1 reqInitiator )
    {
        DateTime = reqDateTime;
        Activity = reqActivity;
        Initiator = reqInitiator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time when the activity occurred.
    /// </summary>
    [IsoId("_RJDQwdp-Ed-ak6NoX_4Aeg_-1926860432")]
    [DisplayName("Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtTm")]
    #endif
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime DateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime DateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime DateTime { get; init; } 
    #else
    public System.DateTime DateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the reported activities.
    /// </summary>
    [IsoId("_RJDQwtp-Ed-ak6NoX_4Aeg_-108739135")]
    [DisplayName("Activity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actvty")]
    #endif
    [IsoXmlTag("Actvty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Activity1 Activity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Activity1 Activity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Activity1 Activity { get; init; } 
    #else
    public Activity1 Activity { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution which initiated the activity.
    /// </summary>
    [IsoId("_RJDQw9p-Ed-ak6NoX_4Aeg_-1724607144")]
    [DisplayName("Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Initr")]
    #endif
    [IsoXmlTag("Initr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 Initiator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 Initiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 Initiator { get; init; } 
    #else
    public BICIdentification1 Initiator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
