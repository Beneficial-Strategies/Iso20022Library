// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.
/// Usage
/// The MeetingCancellation message is used in two different situations.
/// First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.
/// Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.
/// </summary>
[Description(@"Scope|The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.|Usage|The MeetingCancellation message is used in two different situations.|First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.|Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.")]
[IsoId("_TlJcItEwEd-BzquC8wXy7w_-976963352")]
[DisplayName("Meeting Cancellation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingCancellationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgCxl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingCancellationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingCancellationV02( MessageIdentification1 reqCancellationIdentification,MeetingReference2 reqMeetingReference,MeetingCancellationReason1 reqReason )
    {
        CancellationIdentification = reqCancellationIdentification;
        MeetingReference = reqMeetingReference;
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the cancellation message.
    /// </summary>
    [IsoId("_TlJcI9EwEd-BzquC8wXy7w_-1270178957")]
    [DisplayName("Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlId")]
    #endif
    [IsoXmlTag("CxlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 CancellationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 CancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 CancellationIdentification { get; init; } 
    #else
    public MessageIdentification1 CancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information indicating that the cancellation of a message previously sent is requested (and not the cancellation of the meeting).
    /// </summary>
    [IsoId("_TlJcJNEwEd-BzquC8wXy7w_-976963274")]
    [DisplayName("Message Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCxl")]
    #endif
    [IsoXmlTag("MsgCxl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmendInformation1? MessageCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmendInformation1? MessageCancellation { get; init; } 
    #else
    public AmendInformation1? MessageCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TlJcJdEwEd-BzquC8wXy7w_-976963350")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference2 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingReference2 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference2 MeetingReference { get; init; } 
    #else
    public MeetingReference2 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party notifying the cancellation of the meeting.
    /// </summary>
    [IsoId("_TlJcJtEwEd-BzquC8wXy7w_-976963316")]
    [DisplayName("Notifying Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtifngPty")]
    #endif
    [IsoXmlTag("NtifngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification9Choice_? NotifyingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification9Choice_? NotifyingParty { get; init; } 
    #else
    public PartyIdentification9Choice_? NotifyingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the security for which the meeting was organised.
    /// </summary>
    [IsoId("_TlJcJ9EwEd-BzquC8wXy7w_-976963334")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    [MinLength(0)]
    [MaxLength(200)]
    public ValueList<SecurityPosition5> Security { get; init; } = new ValueList<SecurityPosition5>(){};
    
    /// <summary>
    /// Defines the justification for the cancellation.
    /// </summary>
    [IsoId("_TlJcKNEwEd-BzquC8wXy7w_-976963291")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingCancellationReason1 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingCancellationReason1 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingCancellationReason1 Reason { get; init; } 
    #else
    public MeetingCancellationReason1 Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MeetingCancellationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingCancellationV02.

