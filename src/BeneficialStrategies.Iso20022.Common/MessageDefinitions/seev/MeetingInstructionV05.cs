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
/// This record is an implementation of the seev.004.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A party holding the right to vote sends the MeetingInstruction message to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.
/// Usage
/// The MeetingInstruction message is used to register for a shareholders meeting, request blocking or registration of securities. It is used to assign a proxy, to specify the names of meeting attendees and to relay vote instructions per resolution electronically.
/// The MeetingInstruction message may only be sent for one security, though several safekeeping places may be specified.
/// Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the MeetingInstructionStatus message, a new MeetingInstruction message can be sent.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(@"Scope|A party holding the right to vote sends the MeetingInstruction message to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.|Usage|The MeetingInstruction message is used to register for a shareholders meeting, request blocking or registration of securities. It is used to assign a proxy, to specify the names of meeting attendees and to relay vote instructions per resolution electronically.|The MeetingInstruction message may only be sent for one security, though several safekeeping places may be specified.|Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the MeetingInstructionStatus message, a new MeetingInstruction message can be sent.|This message definition is intended for use with the Business Application Header.")]
[IsoId("_xDAOUVtcEeSwKe7KuKvXhg")]
[DisplayName("Meeting Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingInstructionV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.004.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.05";
    
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
    /// Constructs a MeetingInstructionV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingInstructionV05( MeetingReference7 reqMeetingReference,SecurityIdentification14 reqFinancialInstrumentIdentification,Instruction3 reqInstruction )
    {
        MeetingReference = reqMeetingReference;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        Instruction = reqInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_xDAOVVtcEeSwKe7KuKvXhg")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference7 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingReference7 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference7 MeetingReference { get; init; } 
    #else
    public MeetingReference7 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the security for which the meeting is organised.
    /// </summary>
    [IsoId("_xDAOWVtcEeSwKe7KuKvXhg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the position of the instructing party and the action that they want to take.
    /// </summary>
    [IsoId("_xDAOW1tcEeSwKe7KuKvXhg")]
    [DisplayName("Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instr")]
    #endif
    [IsoXmlTag("Instr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Instruction3 Instruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Instruction3 Instruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instruction3 Instruction { get; init; } 
    #else
    public Instruction3 Instruction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_vE2o0VtoEeSwKe7KuKvXhg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MeetingInstructionV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionV05.

