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
/// This record is an implementation of the seev.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to the CSD to report the status, or a change in status, of:
/// - a corporate action election advice;
/// - an election cancellation request; or
/// - an election amendment request.
/// Usage
/// This message must be sent in response to an:
/// - Agent Corporation Action Election Advice to provide the status of an election advice in the case of a rejection. However, it may also be used in all other situations, in which case, the building blocks Election Advice Identification and the Election Advice Status must be present.
/// - Agent Corporation Action Election Cancellation Request to provide the status of the cancellation request, in which case, the building blocks Election Cancellation Request Identification and the Election Cancellation Request Status must be present.
/// - Agent Corporation Action Election Amendment Request to provide the status of the amendment request, in which case, the building blocks Election Amendment Request Identification and the Election Amendment Request Status must be present.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to the CSD to report the status, or a change in status, of:|- a corporate action election advice;|- an election cancellation request; or|- an election amendment request.|Usage|This message must be sent in response to an:|- Agent Corporation Action Election Advice to provide the status of an election advice in the case of a rejection. However, it may also be used in all other situations, in which case, the building blocks Election Advice Identification and the Election Advice Status must be present.|- Agent Corporation Action Election Cancellation Request to provide the status of the cancellation request, in which case, the building blocks Election Cancellation Request Identification and the Election Cancellation Request Status must be present.|- Agent Corporation Action Election Amendment Request to provide the status of the amendment request, in which case, the building blocks Election Amendment Request Identification and the Election Amendment Request Status must be present.")]
[IsoId("_TNct0NEwEd-BzquC8wXy7w_1059605864")]
[DisplayName("Agent CA Election Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAElectionStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.015.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAElctnStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.015.001.01";
    
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
    /// Constructs a AgentCAElectionStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAElectionStatusAdviceV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAElectionAdviceIdentification,DocumentIdentification8 reqAgentCAElectionCancellationRequestIdentification,DocumentIdentification8 reqAgentCAElectionAmendmentRequestIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation,ElectionAdviceStatus1Choice_ reqElectionAdviceStatus,ElectionCancellationStatus1Choice_ reqElectionCancellationRequestStatus,ElectionAmendmentStatus1Choice_ reqElectionAmendmentRequestStatus )
    {
        Identification = reqIdentification;
        AgentCAElectionAdviceIdentification = reqAgentCAElectionAdviceIdentification;
        AgentCAElectionCancellationRequestIdentification = reqAgentCAElectionCancellationRequestIdentification;
        AgentCAElectionAmendmentRequestIdentification = reqAgentCAElectionAmendmentRequestIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        ElectionAdviceStatus = reqElectionAdviceStatus;
        ElectionCancellationRequestStatus = reqElectionCancellationRequestStatus;
        ElectionAmendmentRequestStatus = reqElectionAmendmentRequestStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TNct0dEwEd-BzquC8wXy7w_790316963")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 Identification { get; init; } 
    #else
    public DocumentIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Election Advice for which a status is given.
    /// </summary>
    [IsoId("_TNct0tEwEd-BzquC8wXy7w_530213864")]
    [DisplayName("Agent CA Election Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnAdvcId")]
    #endif
    [IsoXmlTag("AgtCAElctnAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAElectionAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAElectionAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAElectionAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAElectionAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Election Cancellation Request for which a status is given.
    /// </summary>
    [IsoId("_TNct09EwEd-BzquC8wXy7w_532984396")]
    [DisplayName("Agent CA Election Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnCxlReqId")]
    #endif
    [IsoXmlTag("AgtCAElctnCxlReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAElectionCancellationRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAElectionCancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAElectionCancellationRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAElectionCancellationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Election Amendment Request for which a status is given.
    /// </summary>
    [IsoId("_TNct1NEwEd-BzquC8wXy7w_-2098719707")]
    [DisplayName("Agent CA Election Amendment Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnAmdmntReqId")]
    #endif
    [IsoXmlTag("AgtCAElctnAmdmntReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAElectionAmendmentRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAElectionAmendmentRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAElectionAmendmentRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAElectionAmendmentRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TNct1dEwEd-BzquC8wXy7w_276354236")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionInformation1 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the election advice sent by the CSD.
    /// </summary>
    [IsoId("_TNct1tEwEd-BzquC8wXy7w_995320668")]
    [DisplayName("Election Advice Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnAdvcSts")]
    #endif
    [IsoXmlTag("ElctnAdvcSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ElectionAdviceStatus1Choice_ ElectionAdviceStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ElectionAdviceStatus1Choice_ ElectionAdviceStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElectionAdviceStatus1Choice_ ElectionAdviceStatus { get; init; } 
    #else
    public ElectionAdviceStatus1Choice_ ElectionAdviceStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the election cancellation request sent by the CSD.
    /// </summary>
    [IsoId("_TNct19EwEd-BzquC8wXy7w_1701814671")]
    [DisplayName("Election Cancellation Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnCxlReqSts")]
    #endif
    [IsoXmlTag("ElctnCxlReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ElectionCancellationStatus1Choice_ ElectionCancellationRequestStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ElectionCancellationStatus1Choice_ ElectionCancellationRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElectionCancellationStatus1Choice_ ElectionCancellationRequestStatus { get; init; } 
    #else
    public ElectionCancellationStatus1Choice_ ElectionCancellationRequestStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the amendment request sent by the CSD.
    /// </summary>
    [IsoId("_TNme0NEwEd-BzquC8wXy7w_-2039764418")]
    [DisplayName("Election Amendment Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnAmdmntReqSts")]
    #endif
    [IsoXmlTag("ElctnAmdmntReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ElectionAmendmentStatus1Choice_ ElectionAmendmentRequestStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ElectionAmendmentStatus1Choice_ ElectionAmendmentRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElectionAmendmentStatus1Choice_ ElectionAmendmentRequestStatus { get; init; } 
    #else
    public ElectionAmendmentStatus1Choice_ ElectionAmendmentRequestStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAElectionStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAElectionStatusAdviceV01.

