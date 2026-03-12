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
/// This record is an implementation of the seev.008.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.
/// Usage
/// The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.
/// This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.|Usage|The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.|This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.|This message definition is intended for use with the Business Application Header.")]
[IsoId("_xDJ_IVtcEeSwKe7KuKvXhg")]
[DisplayName("Meeting Result Dissemination V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingResultDisseminationV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.008.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.05";
    
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
    /// Constructs a MeetingResultDisseminationV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingResultDisseminationV05( MeetingReference7 reqMeetingReference )
    {
        MeetingReference = reqMeetingReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information specific to an amendment.
    /// </summary>
    [IsoId("_xDJ_JVtcEeSwKe7KuKvXhg")]
    [DisplayName("Amendment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amdmnt")]
    #endif
    [IsoXmlTag("Amdmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmendInformation3? Amendment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmendInformation3? Amendment { get; init; } 
    #else
    public AmendInformation3? Amendment { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_xDJ_J1tcEeSwKe7KuKvXhg")]
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
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_xDJ_K1tcEeSwKe7KuKvXhg")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition8> Security { get; init; } = new ValueList<SecurityPosition8>(){};
    
    /// <summary>
    /// Results per resolution.
    /// </summary>
    [IsoId("_xDJ_LVtcEeSwKe7KuKvXhg")]
    [DisplayName("Vote Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteRslt")]
    #endif
    [IsoXmlTag("VoteRslt")]
    [MinLength(1)]
    [MaxLength(1000)]
    public ValueList<Vote7> VoteResult { get; init; } = new ValueList<Vote7>(){};
    
    /// <summary>
    /// Information about the participation to the voting process.
    /// </summary>
    [IsoId("_xDJ_L1tcEeSwKe7KuKvXhg")]
    [DisplayName("Participation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtcptn")]
    #endif
    [IsoXmlTag("Prtcptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Participation4? Participation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Participation4? Participation { get; init; } 
    #else
    public Participation4? Participation { get; set; } 
    #endif
    
    /// <summary>
    /// Information on where additional information can be received.
    /// </summary>
    [IsoId("_xDJ_MVtcEeSwKe7KuKvXhg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress4? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress4? AdditionalInformation { get; init; } 
    #else
    public CommunicationAddress4? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_xXGYQFtoEeSwKe7KuKvXhg")]
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


// Since MeetingResultDisseminationV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingResultDisseminationV05.

