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
/// This record is an implementation of the seev.005.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingInstructionCancellationRequest message is sent by the same party that sent the MeetingInstruction message. It is sent to request the cancellation of all instructions included in the original the MeetingInstruction message.
/// Usage
/// This message must be answered by a MeetingInstructionStatus message. Some instructions in the previously sent MeetingInstruction message may have already been executed and cannot be cancelled. This information should appear clearly in the status message.
/// </summary>
[Description(@"Scope|The MeetingInstructionCancellationRequest message is sent by the same party that sent the MeetingInstruction message. It is sent to request the cancellation of all instructions included in the original the MeetingInstruction message.|Usage|This message must be answered by a MeetingInstructionStatus message. Some instructions in the previously sent MeetingInstruction message may have already been executed and cannot be cancelled. This information should appear clearly in the status message.")]
[IsoId("_TniBy9EwEd-BzquC8wXy7w_-914512760")]
[DisplayName("Meeting Instruction Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingInstructionCancellationRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.005.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.005.001.04";
    
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
    /// Constructs a MeetingInstructionCancellationRequestV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingInstructionCancellationRequestV04( MessageIdentification1 reqIdentification,MessageIdentification reqPreviousReference )
    {
        Identification = reqIdentification;
        PreviousReference = reqPreviousReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the cancellation request.
    /// </summary>
    [IsoId("_TniBzNEwEd-BzquC8wXy7w_-194501010")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 Identification { get; init; } 
    #else
    public MessageIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the instruction to be cancelled.
    /// </summary>
    [IsoId("_TniBzdEwEd-BzquC8wXy7w_-1998274389")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification PreviousReference { get; init; } 
    #else
    public MessageIdentification PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TniBztEwEd-BzquC8wXy7w_452823918")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingReference4? MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference4? MeetingReference { get; init; } 
    #else
    public MeetingReference4? MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party requesting the cancellation.
    /// </summary>
    [IsoId("_TnrLsNEwEd-BzquC8wXy7w_1213589071")]
    [DisplayName("Requesting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqstngPty")]
    #endif
    [IsoXmlTag("RqstngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification9Choice_? RequestingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification9Choice_? RequestingParty { get; init; } 
    #else
    public PartyIdentification9Choice_? RequestingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the security for which the meeting is organised.
    /// </summary>
    [IsoId("_TnrLsdEwEd-BzquC8wXy7w_-1092424616")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification11? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification11? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the account and instructed positions for which the instruction cancellation request applies.
    /// </summary>
    [IsoId("_TnrLstEwEd-BzquC8wXy7w_738498553")]
    [DisplayName("Instructed Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdPos")]
    #endif
    [IsoXmlTag("InstdPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingAccount4? InstructedPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount4? InstructedPosition { get; init; } 
    #else
    public SafekeepingAccount4? InstructedPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TnrLs9EwEd-BzquC8wXy7w_-554493875")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension2? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension2? Extension { get; init; } 
    #else
    public Extension2? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MeetingInstructionCancellationRequestV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionCancellationRequestV04.

