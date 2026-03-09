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
/// Notification status of an event.
/// </summary>
[IsoId("_eXYv2a7QEemG7MmivSuE5g")]
[DisplayName("Event Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EventStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EventStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EventStatus1( EventCompletenessStatus1Code reqEventCompletenessStatus,EventConfirmationStatus1Code reqEventConfirmationStatus )
    {
        EventCompletenessStatus = reqEventCompletenessStatus;
        EventConfirmationStatus = reqEventConfirmationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the details provided about an event are complete or incomplete.
    /// </summary>
    [IsoId("_eXYv2q7QEemG7MmivSuE5g")]
    [DisplayName("Event Completeness Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtCmpltnsSts")]
    #endif
    [IsoXmlTag("EvtCmpltnsSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
    #else
    public EventCompletenessStatus1Code EventCompletenessStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the occurrence of an event.
    /// </summary>
    [IsoId("_eXYv267QEemG7MmivSuE5g")]
    [DisplayName("Event Confirmation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtConfSts")]
    #endif
    [IsoXmlTag("EvtConfSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
    #else
    public EventConfirmationStatus1Code EventConfirmationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
