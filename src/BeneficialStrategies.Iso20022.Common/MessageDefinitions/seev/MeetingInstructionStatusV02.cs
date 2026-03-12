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
/// This record is an implementation of the seev.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.
/// The message gives the status of a complete message or of one or more specific instructions within the message.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, ie, whether the request message is rejected or accepted.
/// Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, ie, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).
/// Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.
/// </summary>
[Description(@"Scope|The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.|The message gives the status of a complete message or of one or more specific instructions within the message.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, ie, whether the request message is rejected or accepted.|Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, ie, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).|Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.")]
[IsoId("_Tpw2YNEwEd-BzquC8wXy7w_322491691")]
[DisplayName("Meeting Instruction Status V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingInstructionStatusV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.02";
    
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
    /// Constructs a MeetingInstructionStatusV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingInstructionStatusV02( MessageIdentification1 reqMeetingInstructionStatusIdentification,MessageIdentification reqInstructionIdentification,MessageIdentification reqInstructionCancellationIdentification,MeetingReference3 reqMeetingReference,PartyIdentification9Choice_ reqReportingParty,SecurityIdentification3 reqSecurityIdentification,InstructionStatus1Choice_ reqInstructionStatus,CancellationStatus1Choice_ reqCancellationStatus )
    {
        MeetingInstructionStatusIdentification = reqMeetingInstructionStatusIdentification;
        InstructionIdentification = reqInstructionIdentification;
        InstructionCancellationIdentification = reqInstructionCancellationIdentification;
        MeetingReference = reqMeetingReference;
        ReportingParty = reqReportingParty;
        SecurityIdentification = reqSecurityIdentification;
        InstructionStatus = reqInstructionStatus;
        CancellationStatus = reqCancellationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the meeting instruction status message.
    /// </summary>
    [IsoId("_Tpw2YdEwEd-BzquC8wXy7w_322491753")]
    [DisplayName("Meeting Instruction Status Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgInstrStsId")]
    #endif
    [IsoXmlTag("MtgInstrStsId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MeetingInstructionStatusIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MeetingInstructionStatusIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MeetingInstructionStatusIdentification { get; init; } 
    #else
    public MessageIdentification1 MeetingInstructionStatusIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the meeting instruction message for which the status is provided.
    /// </summary>
    [IsoId("_Tpw2YtEwEd-BzquC8wXy7w_2026535768")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification InstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification InstructionIdentification { get; init; } 
    #else
    public MessageIdentification InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the meeting instruction cancellation request message for which the status is provided.
    /// </summary>
    [IsoId("_Tpw2Y9EwEd-BzquC8wXy7w_-1459248718")]
    [DisplayName("Instruction Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrCxlId")]
    #endif
    [IsoXmlTag("InstrCxlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification InstructionCancellationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification InstructionCancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification InstructionCancellationIdentification { get; init; } 
    #else
    public MessageIdentification InstructionCancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Tpw2ZNEwEd-BzquC8wXy7w_322491723")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference3 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingReference3 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference3 MeetingReference { get; init; } 
    #else
    public MeetingReference3 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party reporting the status.
    /// </summary>
    [IsoId("_Tpw2ZdEwEd-BzquC8wXy7w_322491769")]
    [DisplayName("Reporting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPty")]
    #endif
    [IsoXmlTag("RptgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification9Choice_ ReportingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification9Choice_ ReportingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification9Choice_ ReportingParty { get; init; } 
    #else
    public PartyIdentification9Choice_ ReportingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_Tpw2ZtEwEd-BzquC8wXy7w_322491740")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification3 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification3 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification3 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification3 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Status applying to the instruction request received. The instruction is identified by the InstructionIdentification.
    /// </summary>
    [IsoId("_Tp6nYNEwEd-BzquC8wXy7w_-1918238262")]
    [DisplayName("Instruction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrSts")]
    #endif
    [IsoXmlTag("InstrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionStatus1Choice_ InstructionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionStatus1Choice_ InstructionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionStatus1Choice_ InstructionStatus { get; init; } 
    #else
    public InstructionStatus1Choice_ InstructionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status applying to the instruction cancellation request received. The instruction cancellation is identified by the InstructionCancellationIdentification.
    /// </summary>
    [IsoId("_Tp6nYdEwEd-BzquC8wXy7w_-1891306191")]
    [DisplayName("Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlSts")]
    #endif
    [IsoXmlTag("CxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationStatus1Choice_ CancellationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationStatus1Choice_ CancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatus1Choice_ CancellationStatus { get; init; } 
    #else
    public CancellationStatus1Choice_ CancellationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MeetingInstructionStatusV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionStatusV02.

