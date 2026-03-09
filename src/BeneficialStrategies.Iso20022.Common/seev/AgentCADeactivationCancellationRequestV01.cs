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
/// This record is an implementation of the seev.029.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to the CSD to request the cancellation of a previously sent corporate action deactivation instruction.
/// Usage
/// This message is used to request the cancellation of a pending deactivation instruction. The cancellation must apply to exactly the same level as the original instruction, ie to the entire CA event or to an option as per the original instruction.
/// This message must be sent before the deactivation execution date.
/// In case a corporate action or option is already deactivated, this message can not be used to reactivate the corporate action entire event or option; the notification advice message must be used to reactivate a corporate action or option.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to the CSD to request the cancellation of a previously sent corporate action deactivation instruction.|Usage|This message is used to request the cancellation of a pending deactivation instruction. The cancellation must apply to exactly the same level as the original instruction, ie to the entire CA event or to an option as per the original instruction.|This message must be sent before the deactivation execution date.|In case a corporate action or option is already deactivated, this message can not be used to reactivate the corporate action entire event or option; the notification advice message must be used to reactivate a corporate action or option.")]
[IsoId("_TL9gGdEwEd-BzquC8wXy7w_1830397138")]
[DisplayName("Agent CA Deactivation Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCADeactivationCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.029.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCADeactvtnCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.029.001.01";
    
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
    /// Constructs a AgentCADeactivationCancellationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCADeactivationCancellationRequestV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCADeactivationInstructionIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation )
    {
        Identification = reqIdentification;
        AgentCADeactivationInstructionIdentification = reqAgentCADeactivationInstructionIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TMHRENEwEd-BzquC8wXy7w_118262265")]
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
    /// Identification of the Agent CA Deactivation Instruction to be cancelled.
    /// </summary>
    [IsoId("_TMHREdEwEd-BzquC8wXy7w_-1093662480")]
    [DisplayName("Agent CA Deactivation Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCADeactvtnInstrId")]
    #endif
    [IsoXmlTag("AgtCADeactvtnInstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TMHREtEwEd-BzquC8wXy7w_-541518720")]
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
    /// Details of the deactivation instruction to be cancelled.
    /// </summary>
    [IsoId("_TMHRE9EwEd-BzquC8wXy7w_-1594611016")]
    [DisplayName("Deactivation Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeactvtnInstrDtls")]
    #endif
    [IsoXmlTag("DeactvtnInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDeactivationInstruction1? DeactivationInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDeactivationInstruction1? DeactivationInstructionDetails { get; init; } 
    #else
    public CorporateActionDeactivationInstruction1? DeactivationInstructionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCADeactivationCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCADeactivationCancellationRequestV01.

