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
/// This record is an implementation of the seev.021.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to confirm the settlement of resource movements.
/// Usage
/// This message is used to confirm the settlement of the movements resulting from an:
/// - Agent Corporate Action Movement Instruction message. It confirms the settlement of the exercised resources and/or proceeds movements in which case the building block Agent Corporate Action Movement Instruction Identification must be present. An Agent Corporate Action Movement Instruction message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.
/// - Agent Corporate Action Global Distribution Status Advice authorising the global distribution. It confirms the settlement of the exercised resources and/or proceeds movements. The building block Agent Corporate Action Global Distribution Status Advice Identification must be present. An Agent Corporate Action Global Distribution Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.
/// - Agent Corporate Action Election Status Advice that rejects an election advice. It confirms the return of the exercised resources. The building block Agent Corporate Action Election Status Advice Identification must be present. An Agent Corporate Action Election Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.
/// - Agent Corporate Action Election Status Advice where an election cancellation request has been accepted. It confirms the return of the exercised resources. The building block Agent Corporate Action Election Status Advice Identification must be present. An Agent Corporate Action Election Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to an issuer (or its agent) to confirm the settlement of resource movements.|Usage|This message is used to confirm the settlement of the movements resulting from an:|- Agent Corporate Action Movement Instruction message. It confirms the settlement of the exercised resources and/or proceeds movements in which case the building block Agent Corporate Action Movement Instruction Identification must be present. An Agent Corporate Action Movement Instruction message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.|- Agent Corporate Action Global Distribution Status Advice authorising the global distribution. It confirms the settlement of the exercised resources and/or proceeds movements. The building block Agent Corporate Action Global Distribution Status Advice Identification must be present. An Agent Corporate Action Global Distribution Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.|- Agent Corporate Action Election Status Advice that rejects an election advice. It confirms the return of the exercised resources. The building block Agent Corporate Action Election Status Advice Identification must be present. An Agent Corporate Action Election Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.|- Agent Corporate Action Election Status Advice where an election cancellation request has been accepted. It confirms the return of the exercised resources. The building block Agent Corporate Action Election Status Advice Identification must be present. An Agent Corporate Action Election Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.")]
[IsoId("_TOf2vdEwEd-BzquC8wXy7w_550595772")]
[DisplayName("Agent CA Movement Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAMovementConfirmationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.021.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAMvmntConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.021.001.01";
    
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
    /// Constructs a AgentCAMovementConfirmationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAMovementConfirmationV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAMovementInstructionIdentification,DocumentIdentification8 reqAgentCAElectionStatusAdviceIdentification,DocumentIdentification8 reqAgentCAGlobalDistributionStatusAdviceIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation )
    {
        Identification = reqIdentification;
        AgentCAMovementInstructionIdentification = reqAgentCAMovementInstructionIdentification;
        AgentCAElectionStatusAdviceIdentification = reqAgentCAElectionStatusAdviceIdentification;
        AgentCAGlobalDistributionStatusAdviceIdentification = reqAgentCAGlobalDistributionStatusAdviceIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the confirmation.
    /// </summary>
    [IsoId("_TOpAoNEwEd-BzquC8wXy7w_2121112833")]
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
    /// Identification of the Agent CA Movement Instruction that triggered the movement(s).
    /// </summary>
    [IsoId("_TOpAodEwEd-BzquC8wXy7w_2124804747")]
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
    /// Identification of the Agent CA Election Status Advice that triggered the movement(s).
    /// </summary>
    [IsoId("_TOpAotEwEd-BzquC8wXy7w_-1143801782")]
    [DisplayName("Agent CA Election Status Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnStsAdvcId")]
    #endif
    [IsoXmlTag("AgtCAElctnStsAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Agent CA Global Distribution Status Advice that triggered the movement(s).
    /// </summary>
    [IsoId("_TOpAo9EwEd-BzquC8wXy7w_1161636580")]
    [DisplayName("Agent CA Global Distribution Status Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAGblDstrbtnStsAdvcId")]
    #endif
    [IsoXmlTag("AgtCAGblDstrbtnStsAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TOpApNEwEd-BzquC8wXy7w_-279320255")]
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
    /// Information about the securities movements.
    /// </summary>
    [IsoId("_TOpApdEwEd-BzquC8wXy7w_1725377056")]
    [DisplayName("Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSecuritiesMovement1? SecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSecuritiesMovement1? SecuritiesMovementDetails { get; init; } 
    #else
    public CorporateActionSecuritiesMovement1? SecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the cash movement.
    /// </summary>
    [IsoId("_TQR_YNEwEd-BzquC8wXy7w_-1609125049")]
    [DisplayName("Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmntDtls")]
    #endif
    [IsoXmlTag("CshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashMovement3? CashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashMovement3? CashMovementDetails { get; init; } 
    #else
    public CashMovement3? CashMovementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAMovementConfirmationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAMovementConfirmationV01.

