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
/// This record is an implementation of the seev.020.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to a CSD to request the cancellation of (a) movement(s) previously sent via an Agent Corporate Action Movement Instruction.
/// Usage
/// This message may be used to cancel an entire Agent Corporate Action Movement Instruction message that was previously sent by the issuer (or its agent) or specific movements.
/// This message must contain the identification of the Agent Corporate Action Movement Instruction containing the movement(s) to be cancelled, the agent identification and the corporate action references. This message must also contain details of the movement(s) to be cancelled.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to a CSD to request the cancellation of (a) movement(s) previously sent via an Agent Corporate Action Movement Instruction.|Usage|This message may be used to cancel an entire Agent Corporate Action Movement Instruction message that was previously sent by the issuer (or its agent) or specific movements.|This message must contain the identification of the Agent Corporate Action Movement Instruction containing the movement(s) to be cancelled, the agent identification and the corporate action references. This message must also contain details of the movement(s) to be cancelled.")]
[IsoId("_TOWFvNEwEd-BzquC8wXy7w_1509391155")]
[DisplayName("Agent CA Movement Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAMovementCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.020.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAMvmntCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.020.001.01";
    
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
    /// Constructs a AgentCAMovementCancellationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAMovementCancellationRequestV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAMovementInstructionIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation )
    {
        Identification = reqIdentification;
        AgentCAMovementInstructionIdentification = reqAgentCAMovementInstructionIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TOf2sNEwEd-BzquC8wXy7w_1790490668")]
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
    /// Identification of the Agent CA Movement Instruction to be cancelled.
    /// </summary>
    [IsoId("_TOf2sdEwEd-BzquC8wXy7w_1808039955")]
    [DisplayName("Agent CA Movement Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAMvmntInstrId")]
    #endif
    [IsoXmlTag("AgtCAMvmntInstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAMovementInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAMovementInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAMovementInstructionIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAMovementInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TOf2stEwEd-BzquC8wXy7w_2016403103")]
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
    /// Details of the movement instructions to be cancelled.
    /// </summary>
    [IsoId("_TOf2s9EwEd-BzquC8wXy7w_1913625535")]
    [DisplayName("Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntDtls")]
    #endif
    [IsoXmlTag("MvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MovementInstruction1? MovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MovementInstruction1? MovementDetails { get; init; } 
    #else
    public MovementInstruction1? MovementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAMovementCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAMovementCancellationRequestV01.

