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
    
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TNct0dEwEd-BzquC8wXy7w_790316963")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Identification of the linked Agent CA Election Advice for which a status is given.
    /// </summary>
    [IsoId("_TNct0tEwEd-BzquC8wXy7w_530213864")]
    [DisplayName("Agent CA Election Advice Identification")]
    [IsoXmlTag("AgtCAElctnAdvcId")]
    public required DocumentIdentification8 AgentCAElectionAdviceIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the linked Agent CA Election Cancellation Request for which a status is given.
    /// </summary>
    [IsoId("_TNct09EwEd-BzquC8wXy7w_532984396")]
    [DisplayName("Agent CA Election Cancellation Request Identification")]
    [IsoXmlTag("AgtCAElctnCxlReqId")]
    public required DocumentIdentification8 AgentCAElectionCancellationRequestIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the linked Agent CA Election Amendment Request for which a status is given.
    /// </summary>
    [IsoId("_TNct1NEwEd-BzquC8wXy7w_-2098719707")]
    [DisplayName("Agent CA Election Amendment Request Identification")]
    [IsoXmlTag("AgtCAElctnAmdmntReqId")]
    public required DocumentIdentification8 AgentCAElectionAmendmentRequestIdentification { get; init; } 
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TNct1dEwEd-BzquC8wXy7w_276354236")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Status of the election advice sent by the CSD.
    /// </summary>
    [IsoId("_TNct1tEwEd-BzquC8wXy7w_995320668")]
    [DisplayName("Election Advice Status")]
    [IsoXmlTag("ElctnAdvcSts")]
    public required ElectionAdviceStatus1Choice_ ElectionAdviceStatus { get; init; } 
    
    /// <summary>
    /// Status of the election cancellation request sent by the CSD.
    /// </summary>
    [IsoId("_TNct19EwEd-BzquC8wXy7w_1701814671")]
    [DisplayName("Election Cancellation Request Status")]
    [IsoXmlTag("ElctnCxlReqSts")]
    public required ElectionCancellationStatus1Choice_ ElectionCancellationRequestStatus { get; init; } 
    
    /// <summary>
    /// Status of the amendment request sent by the CSD.
    /// </summary>
    [IsoId("_TNme0NEwEd-BzquC8wXy7w_-2039764418")]
    [DisplayName("Election Amendment Request Status")]
    [IsoXmlTag("ElctnAmdmntReqSts")]
    public required ElectionAmendmentStatus1Choice_ ElectionAmendmentRequestStatus { get; init; } 
    
    
    #nullable disable
    
}


// Since AgentCAElectionStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAElectionStatusAdviceV01.

