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
    
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TMHRENEwEd-BzquC8wXy7w_118262265")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Identification of the Agent CA Deactivation Instruction to be cancelled.
    /// </summary>
    [IsoId("_TMHREdEwEd-BzquC8wXy7w_-1093662480")]
    [DisplayName("Agent CA Deactivation Instruction Identification")]
    [IsoXmlTag("AgtCADeactvtnInstrId")]
    public required DocumentIdentification8 AgentCADeactivationInstructionIdentification { get; init; } 
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TMHREtEwEd-BzquC8wXy7w_-541518720")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Details of the deactivation instruction to be cancelled.
    /// </summary>
    [IsoId("_TMHRE9EwEd-BzquC8wXy7w_-1594611016")]
    [DisplayName("Deactivation Instruction Details")]
    [IsoXmlTag("DeactvtnInstrDtls")]
    public CorporateActionDeactivationInstruction1? DeactivationInstructionDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since AgentCADeactivationCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCADeactivationCancellationRequestV01.

