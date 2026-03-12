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
/// This record is an implementation of the seev.006.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.
/// The message gives the status of a complete message or of one or more specific instructions within the message.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.
/// Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).
/// Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.
/// </summary>
[Description(@"Scope|The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.|The message gives the status of a complete message or of one or more specific instructions within the message.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.|Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).|Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.")]
[IsoId("_TqXTUNEwEd-BzquC8wXy7w_99042676")]
[DisplayName("Meeting Instruction Status V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingInstructionStatusV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.04";
    
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
    /// Constructs a MeetingInstructionStatusV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingInstructionStatusV04( MessageIdentification1 reqIdentification,InstructionType1Choice_ reqInstructionType,MeetingReference4 reqMeetingReference,PartyIdentification9Choice_ reqReportingParty,SecurityIdentification11 reqSecurityIdentification,InstructionTypeStatus1Choice_ reqInstructionTypeStatus )
    {
        Identification = reqIdentification;
        InstructionType = reqInstructionType;
        MeetingReference = reqMeetingReference;
        ReportingParty = reqReportingParty;
        SecurityIdentification = reqSecurityIdentification;
        InstructionTypeStatus = reqInstructionTypeStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the meeting instruction status message.
    /// </summary>
    [IsoId("_TqXTUdEwEd-BzquC8wXy7w_-693693241")]
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
    /// Type of instruction.
    /// </summary>
    [IsoId("_TqXTUtEwEd-BzquC8wXy7w_-28327531")]
    [DisplayName("Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrTp")]
    #endif
    [IsoXmlTag("InstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionType1Choice_ InstructionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionType1Choice_ InstructionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionType1Choice_ InstructionType { get; init; } 
    #else
    public InstructionType1Choice_ InstructionType { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TqXTU9EwEd-BzquC8wXy7w_-1403252543")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference4 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingReference4 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference4 MeetingReference { get; init; } 
    #else
    public MeetingReference4 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party reporting the status.
    /// </summary>
    [IsoId("_TqXTVNEwEd-BzquC8wXy7w_-2038284389")]
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
    [IsoId("_TqXTVdEwEd-BzquC8wXy7w_-363218248")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification11 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification11 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification11 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of instruction status.
    /// </summary>
    [IsoId("_TqXTVtEwEd-BzquC8wXy7w_1595413206")]
    [DisplayName("Instruction Type Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrTpSts")]
    #endif
    [IsoXmlTag("InstrTpSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionTypeStatus1Choice_ InstructionTypeStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionTypeStatus1Choice_ InstructionTypeStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionTypeStatus1Choice_ InstructionTypeStatus { get; init; } 
    #else
    public InstructionTypeStatus1Choice_ InstructionTypeStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TqXTV9EwEd-BzquC8wXy7w_510788685")]
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


// Since MeetingInstructionStatusV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionStatusV04.

