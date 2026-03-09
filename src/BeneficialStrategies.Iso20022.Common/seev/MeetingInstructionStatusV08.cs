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
/// This record is an implementation of the seev.006.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingInstructionStatus message is sent by an intermediary to the sender of an instruction to confirm the status of such an instruction. The message gives the status of a complete message or of one or more specific instructions within the message.
/// The message may also be sent by the issuer or the intermediary to confirm that a vote has been cast.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Second, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.
/// Third, it is used to provide a detailed processing or rejection status of one or more instructions within the MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the SingleInstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// Fourth, it is used to confirm that the related vote instruction has been confirmed as cast by the issuer or its agent.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(@"Scope|The MeetingInstructionStatus message is sent by an intermediary to the sender of an instruction to confirm the status of such an instruction. The message gives the status of a complete message or of one or more specific instructions within the message.|The message may also be sent by the issuer or the intermediary to confirm that a vote has been cast.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Second, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.|Third, it is used to provide a detailed processing or rejection status of one or more instructions within the MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the SingleInstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|Fourth, it is used to confirm that the related vote instruction has been confirmed as cast by the issuer or its agent.|This message definition is intended for use with the Business Application Header (BAH).")]
[IsoId("_lKgSZxrdEeyhRdHRjakS2w")]
[DisplayName("Meeting Instruction Status V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingInstructionStatusV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.08";
    
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
    /// Constructs a MeetingInstructionStatusV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingInstructionStatusV08( InstructionType2Choice_ reqInstructionType,MeetingReference10 reqMeetingReference,SecurityIdentification19 reqFinancialInstrumentIdentification,InstructionTypeStatus5Choice_ reqInstructionTypeStatus,PartyIdentification226Choice_ reqConfirmingParty,PartyIdentification226Choice_ reqVoteCastingParty )
    {
        InstructionType = reqInstructionType;
        MeetingReference = reqMeetingReference;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        InstructionTypeStatus = reqInstructionTypeStatus;
        ConfirmingParty = reqConfirmingParty;
        VoteCastingParty = reqVoteCastingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of instruction.
    /// </summary>
    [IsoId("_lKgScRrdEeyhRdHRjakS2w")]
    [DisplayName("Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrTp")]
    #endif
    [IsoXmlTag("InstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionType2Choice_ InstructionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionType2Choice_ InstructionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionType2Choice_ InstructionType { get; init; } 
    #else
    public InstructionType2Choice_ InstructionType { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_lKgScxrdEeyhRdHRjakS2w")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference10 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingReference10 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference10 MeetingReference { get; init; } 
    #else
    public MeetingReference10 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_lKgSdRrdEeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of instruction status.
    /// </summary>
    [IsoId("_lKgSdxrdEeyhRdHRjakS2w")]
    [DisplayName("Instruction Type Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrTpSts")]
    #endif
    [IsoXmlTag("InstrTpSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionTypeStatus5Choice_ InstructionTypeStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionTypeStatus5Choice_ InstructionTypeStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionTypeStatus5Choice_ InstructionTypeStatus { get; init; } 
    #else
    public InstructionTypeStatus5Choice_ InstructionTypeStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Party that confirms the receipt of the vote cast.
    /// </summary>
    [IsoId("_lKgSeRrdEeyhRdHRjakS2w")]
    [DisplayName("Confirming Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnfrmgPty")]
    #endif
    [IsoXmlTag("CnfrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification226Choice_ ConfirmingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification226Choice_ ConfirmingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification226Choice_ ConfirmingParty { get; init; } 
    #else
    public PartyIdentification226Choice_ ConfirmingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that cast the voting ballot.
    /// </summary>
    [IsoId("_lKgSexrdEeyhRdHRjakS2w")]
    [DisplayName("Vote Casting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteCstgPty")]
    #endif
    [IsoXmlTag("VoteCstgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification226Choice_ VoteCastingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification226Choice_ VoteCastingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification226Choice_ VoteCastingParty { get; init; } 
    #else
    public PartyIdentification226Choice_ VoteCastingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_lKgSfRrdEeyhRdHRjakS2w")]
    [DisplayName("Rights Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsHldr")]
    #endif
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(250)]
    public ValueList<PartyIdentification237Choice_> RightsHolder { get; init; } = new ValueList<PartyIdentification237Choice_>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_lKgSfxrdEeyhRdHRjakS2w")]
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


// Since MeetingInstructionStatusV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionStatusV08.

