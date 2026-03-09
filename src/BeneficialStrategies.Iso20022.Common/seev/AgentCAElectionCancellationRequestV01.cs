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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AgentCAElectionCancellationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAElectionCancellationRequestV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAElectionAdviceIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation )
    {
        Identification = reqIdentification;
        AgentCAElectionAdviceIdentification = reqAgentCAElectionAdviceIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TNTj4dEwEd-BzquC8wXy7w_691501595")]
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
    /// Identification of the Agent CA Election Advice to be cancelled.
    /// </summary>
    [IsoId("_TNTj4tEwEd-BzquC8wXy7w_704429510")]
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
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TNTj49EwEd-BzquC8wXy7w_-444231690")]
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
    /// Provides information about the election advice to be cancelled.
    /// </summary>
    [IsoId("_TNTj5NEwEd-BzquC8wXy7w_-178719566")]
    [DisplayName("Election Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnDtls")]
    #endif
    [IsoXmlTag("ElctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionElection3? ElectionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionElection3? ElectionDetails { get; init; } 
    #else
    public CorporateActionElection3? ElectionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAElectionCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAElectionCancellationRequestV01.

