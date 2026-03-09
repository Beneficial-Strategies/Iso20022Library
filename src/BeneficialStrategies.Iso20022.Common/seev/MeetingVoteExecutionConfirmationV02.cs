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
/// This record is an implementation of the seev.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingVoteExecutionConfirmation message to confirm to the Sender of the MeetingInstruction message, the execution of their voting instruction.
/// Usage
/// This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting and confirms that the vote has been processed as instructed via the MeetingInstruction message.
/// This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.
/// </summary>
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingVoteExecutionConfirmation message to confirm to the Sender of the MeetingInstruction message, the execution of their voting instruction.|Usage|This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting and confirms that the vote has been processed as instructed via the MeetingInstruction message.|This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.")]
[IsoId("_Ttyay9EwEd-BzquC8wXy7w_1192448161")]
[DisplayName("Meeting Vote Execution Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingVoteExecutionConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02";
    
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
    /// Constructs a MeetingVoteExecutionConfirmationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingVoteExecutionConfirmationV02( MessageIdentification1 reqVoteExecutionConfirmationIdentification,MessageIdentification reqRelatedReference,MeetingReference3 reqMeetingReference,PartyIdentification9Choice_ reqReportingParty,SecurityIdentification3 reqSecurityIdentification,DetailedInstructionStatus2 reqVoteInstruction )
    {
        VoteExecutionConfirmationIdentification = reqVoteExecutionConfirmationIdentification;
        RelatedReference = reqRelatedReference;
        MeetingReference = reqMeetingReference;
        ReportingParty = reqReportingParty;
        SecurityIdentification = reqSecurityIdentification;
        VoteInstruction = reqVoteInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the vote execution confirmation message.
    /// </summary>
    [IsoId("_TtyazNEwEd-BzquC8wXy7w_1192448199")]
    [DisplayName("Vote Execution Confirmation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteExctnConfId")]
    #endif
    [IsoXmlTag("VoteExctnConfId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 VoteExecutionConfirmationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 VoteExecutionConfirmationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 VoteExecutionConfirmationIdentification { get; init; } 
    #else
    public MessageIdentification1 VoteExecutionConfirmationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the meeting instruction message.
    /// </summary>
    [IsoId("_Tt8LwNEwEd-BzquC8wXy7w_1192448163")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification RelatedReference { get; init; } 
    #else
    public MessageIdentification RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Tt8LwdEwEd-BzquC8wXy7w_1192448179")]
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
    /// Party confirming the votes.
    /// </summary>
    [IsoId("_Tt8LwtEwEd-BzquC8wXy7w_1192448214")]
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
    [IsoId("_Tt8Lw9EwEd-BzquC8wXy7w_-1409853595")]
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
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_Tt8LxNEwEd-BzquC8wXy7w_603156788")]
    [DisplayName("Vote Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstr")]
    #endif
    [IsoXmlTag("VoteInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DetailedInstructionStatus2 VoteInstruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DetailedInstructionStatus2 VoteInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedInstructionStatus2 VoteInstruction { get; init; } 
    #else
    public DetailedInstructionStatus2 VoteInstruction { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MeetingVoteExecutionConfirmationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingVoteExecutionConfirmationV02.

