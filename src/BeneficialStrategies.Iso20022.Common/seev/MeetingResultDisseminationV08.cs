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
/// This record is an implementation of the seev.008.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingResultDissemination message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.
/// Usage
/// The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.
/// This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(@"Scope|The MeetingResultDissemination message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.|Usage|The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.|This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.|This message definition is intended for use with the Business Application Header (BAH).")]
[IsoId("_nIzH7TQ7Ee22Z83HpR5E8w")]
[DisplayName("Meeting Result Dissemination V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingResultDisseminationV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.008.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.08";
    
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
    /// Constructs a MeetingResultDisseminationV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingResultDisseminationV08( NotificationType2Code reqMeetingResultsDisseminationType,MeetingReference10 reqMeetingReference )
    {
        MeetingResultsDisseminationType = reqMeetingResultsDisseminationType;
        MeetingReference = reqMeetingReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part result dissemination message is to continue or that the message is the last page of the multi-part result dissemination.
    /// </summary>
    [IsoId("_irQrYTUHEe2tRf29bleifQ")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? Pagination { get; init; } 
    #else
    public Pagination1? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the group of result dissemination messages when the result dissemination is split in multiple (paginated) messages.
    /// </summary>
    [IsoId("_qwfGEDUHEe2tRf29bleifQ")]
    [DisplayName("Meeting Result Dissemination Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRsltDssmntnId")]
    #endif
    [IsoXmlTag("MtgRsltDssmntnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MeetingResultDisseminationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MeetingResultDisseminationIdentification { get; init; } 
    #else
    public System.String? MeetingResultDisseminationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of dissemination report, that is, whether the report is new or a replacement.
    /// </summary>
    [IsoId("_nIzH9zQ7Ee22Z83HpR5E8w")]
    [DisplayName("Meeting Results Dissemination Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRsltsDssmntnTp")]
    #endif
    [IsoXmlTag("MtgRsltsDssmntnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationType2Code MeetingResultsDisseminationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationType2Code MeetingResultsDisseminationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationType2Code MeetingResultsDisseminationType { get; init; } 
    #else
    public NotificationType2Code MeetingResultsDisseminationType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the previously sent meeting result dissemination message.
    /// </summary>
    [IsoId("_nIzH_zQ7Ee22Z83HpR5E8w")]
    [DisplayName("Previous Meeting Results Dissemination Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsMtgRsltsDssmntnId")]
    #endif
    [IsoXmlTag("PrvsMtgRsltsDssmntnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PreviousMeetingResultsDisseminationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousMeetingResultsDisseminationIdentification { get; init; } 
    #else
    public System.String? PreviousMeetingResultsDisseminationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_nIzIATQ7Ee22Z83HpR5E8w")]
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
    /// Securities for which the meeting is organised.
    /// </summary>
    [IsoId("_nIzIAzQ7Ee22Z83HpR5E8w")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition19> Security { get; init; } = new ValueList<SecurityPosition19>(){};
    
    /// <summary>
    /// Results per resolution.
    /// </summary>
    [IsoId("_nIzIBTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Vote Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteRslt")]
    #endif
    [IsoXmlTag("VoteRslt")]
    [MinLength(1)]
    [MaxLength(1000)]
    public ValueList<Vote18> VoteResult { get; init; } = new ValueList<Vote18>(){};
    
    /// <summary>
    /// Information about the participation to the voting process.
    /// </summary>
    [IsoId("_nIzIBzQ7Ee22Z83HpR5E8w")]
    [DisplayName("Participation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtcptn")]
    #endif
    [IsoXmlTag("Prtcptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Participation5? Participation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Participation5? Participation { get; init; } 
    #else
    public Participation5? Participation { get; set; } 
    #endif
    
    /// <summary>
    /// Information on where additional information can be received.
    /// </summary>
    [IsoId("_nIzICTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress11? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress11? AdditionalInformation { get; init; } 
    #else
    public CommunicationAddress11? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIzICzQ7Ee22Z83HpR5E8w")]
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


// Since MeetingResultDisseminationV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingResultDisseminationV08.

