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
/// This record is an implementation of the seev.014.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to the issuer (or its agent) to request the cancellation of a previously sent Agent Corporate Action Election Advice message.
/// Usage
/// This message may only be used to cancel an entire Agent Corporate Action Election Advice message that was previously sent by the CSD. No partial cancellation is allowed.
/// This message must contain the identification of the Agent Corporate Action Election Advice to be cancelled, the agent identification and the corporate action references. This message may also contain details of the election advice to be cancelled, but this is not recommended.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to the issuer (or its agent) to request the cancellation of a previously sent Agent Corporate Action Election Advice message.|Usage|This message may only be used to cancel an entire Agent Corporate Action Election Advice message that was previously sent by the CSD. No partial cancellation is allowed.|This message must contain the identification of the Agent Corporate Action Election Advice to be cancelled, the agent identification and the corporate action references. This message may also contain details of the election advice to be cancelled, but this is not recommended.")]
[IsoId("_TNTj4NEwEd-BzquC8wXy7w_-1473498229")]
[DisplayName("Agent CA Election Cancellation Request V")]
public partial record AgentCAElectionCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.014.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAElctnCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.014.001.01";
    
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
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TNTj4dEwEd-BzquC8wXy7w_691501595")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Identification of the Agent CA Election Advice to be cancelled.
    /// </summary>
    [IsoId("_TNTj4tEwEd-BzquC8wXy7w_704429510")]
    [DisplayName("Agent CA Election Advice Identification")]
    [IsoXmlTag("AgtCAElctnAdvcId")]
    public required DocumentIdentification8 AgentCAElectionAdviceIdentification { get; init; } 
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TNTj49EwEd-BzquC8wXy7w_-444231690")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Provides information about the election advice to be cancelled.
    /// </summary>
    [IsoId("_TNTj5NEwEd-BzquC8wXy7w_-178719566")]
    [DisplayName("Election Details")]
    [IsoXmlTag("ElctnDtls")]
    public CorporateActionElection3? ElectionDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since AgentCAElectionCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAElectionCancellationRequestV01.

