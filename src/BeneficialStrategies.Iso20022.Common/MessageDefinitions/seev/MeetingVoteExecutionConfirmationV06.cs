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
/// This record is an implementation of the seev.007.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingVoteExecutionConfirmation message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to confirm, to the Sender of the MeetingInstruction message, that their vote has been recorded and counted by the Issuer.
/// Usage
/// This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting.
/// This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(@"Scope|The MeetingVoteExecutionConfirmation message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to confirm, to the Sender of the MeetingInstruction message, that their vote has been recorded and counted by the Issuer.|Usage|This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting.|This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.|This message definition is intended for use with the Business Application Header.")]
[IsoId("_yXBbxayREemMosWmlQ33EA")]
[DisplayName("Meeting Vote Execution Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingVoteExecutionConfirmationV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.06";
    
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
    /// Constructs a MeetingVoteExecutionConfirmationV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingVoteExecutionConfirmationV06( System.String reqMeetingInstructionIdentification,MeetingReference8 reqMeetingReference,SecurityIdentification19 reqFinancialInstrumentIdentification )
    {
        MeetingInstructionIdentification = reqMeetingInstructionIdentification;
        MeetingReference = reqMeetingReference;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the original meeting instruction message for which the vote execution  confirmation is provided.
    /// </summary>
    [IsoId("_yXBbx6yREemMosWmlQ33EA")]
    [DisplayName("Meeting Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgInstrId")]
    #endif
    [IsoXmlTag("MtgInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MeetingInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MeetingInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MeetingInstructionIdentification { get; init; } 
    #else
    public System.String MeetingInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements that allow to identify unambiguously a meeting.
    /// </summary>
    [IsoId("_yXBbyayREemMosWmlQ33EA")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference8 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingReference8 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference8 MeetingReference { get; init; } 
    #else
    public MeetingReference8 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Securities for which the meeting is organised.
    /// </summary>
    [IsoId("_yXBby6yREemMosWmlQ33EA")]
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
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_yXBbzayREemMosWmlQ33EA")]
    [DisplayName("Vote Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrs")]
    #endif
    [IsoXmlTag("VoteInstrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedInstructionStatus13? VoteInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedInstructionStatus13? VoteInstructions { get; init; } 
    #else
    public DetailedInstructionStatus13? VoteInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Address to use over the www (HTTP) service where the confirmations of the vote instructions can be found.
    /// </summary>
    [IsoId("_04BDUMKIEemAX8h_sVjY5g")]
    [DisplayName("Vote Instructions Confirmation URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrsConfURLAdr")]
    #endif
    [IsoXmlTag("VoteInstrsConfURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? VoteInstructionsConfirmationURLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VoteInstructionsConfirmationURLAddress { get; init; } 
    #else
    public System.String? VoteInstructionsConfirmationURLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yXBbz6yREemMosWmlQ33EA")]
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


// Since MeetingVoteExecutionConfirmationV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingVoteExecutionConfirmationV06.

