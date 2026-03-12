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
/// This record is an implementation of the seev.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to a CSD to order:
/// - the global or individual debit of exercised resources (cash and/or securities), per event and optionally per option and per resource for all or individual CSD client&apos;s accounts;
/// - and/or the individual credits of the outturn resources per event and optionally per option and per resource for a given CSD client&apos;s account.
/// Usage
/// This message is used to instruct:
/// - the global debit of the exercised resources from the CSD client&apos;s available or sequestered balance, in which case, the order type must be &apos;global debit order&apos;;
/// - the individual debits and credits:
/// - the individual debit of the exercised resources from the CSD client&apos;s available or sequestered balance and/or
/// - the individual credit of the outturn resources to the CSD client&apos;s account.
/// The order type must be &apos;individual order&apos;;
/// - a return order, in the case of a scaleback, i.e. the return of the exercised resources to the CSD client&apos;s account. The order type must be either &apos;global return order&apos; or &apos;individual return order&apos;; and
/// change of option, e.g. in the case of the closure of an option, by moving the exercised resources from one option to another option within the sequestered balances in accordance to the new option conditions. The order type must be &apos;option change order&apos;.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to a CSD to order:|- the global or individual debit of exercised resources (cash and/or securities), per event and optionally per option and per resource for all or individual CSD client's accounts;|- and/or the individual credits of the outturn resources per event and optionally per option and per resource for a given CSD client's account.|Usage|This message is used to instruct:|- the global debit of the exercised resources from the CSD client's available or sequestered balance, in which case, the order type must be 'global debit order';|- the individual debits and credits:|- the individual debit of the exercised resources from the CSD client's available or sequestered balance and/or|- the individual credit of the outturn resources to the CSD client's account.|The order type must be 'individual order';|- a return order, in the case of a scaleback, i.e. the return of the exercised resources to the CSD client's account. The order type must be either 'global return order' or 'individual return order'; and|change of option, e.g. in the case of the closure of an option, by moving the exercised resources from one option to another option within the sequestered balances in accordance to the new option conditions. The order type must be 'option change order'.")]
[IsoId("_TQbwbNEwEd-BzquC8wXy7w_89976784")]
[DisplayName("Agent CA Movement Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAMovementInstructionV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.019.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAMvmntInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.019.001.01";
    
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
    /// Constructs a AgentCAMovementInstructionV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAMovementInstructionV01( DocumentIdentification8 reqIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation,CorporateActionMovement1 reqMovementGeneralInformation )
    {
        Identification = reqIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        MovementGeneralInformation = reqMovementGeneralInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_TQbwbdEwEd-BzquC8wXy7w_-1830305628")]
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
    /// Identification of the Agent CA ElectionAdvice when the movements are the result of an ElectionAdvice.
    /// </summary>
    [IsoId("_TQbwbtEwEd-BzquC8wXy7w_1167684393")]
    [DisplayName("Agent CA Election Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnAdvcId")]
    #endif
    [IsoXmlTag("AgtCAElctnAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification8? AgentCAElectionAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8? AgentCAElectionAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8? AgentCAElectionAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TQlhYNEwEd-BzquC8wXy7w_-1064437187")]
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
    /// Provides general information about the movement.
    /// </summary>
    [IsoId("_TQlhYdEwEd-BzquC8wXy7w_1865905670")]
    [DisplayName("Movement General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntGnlInf")]
    #endif
    [IsoXmlTag("MvmntGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMovement1 MovementGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionMovement1 MovementGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovement1 MovementGeneralInformation { get; init; } 
    #else
    public CorporateActionMovement1 MovementGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the movement of the underlying securities.
    /// </summary>
    [IsoId("_TQlhYtEwEd-BzquC8wXy7w_-380692038")]
    [DisplayName("Underlying Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygSctiesMvmntDtls")]
    #endif
    [IsoXmlTag("UndrlygSctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingSecurityMovement1? UnderlyingSecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingSecurityMovement1? UnderlyingSecuritiesMovementDetails { get; init; } 
    #else
    public UnderlyingSecurityMovement1? UnderlyingSecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the movement of the underlying cash.
    /// </summary>
    [IsoId("_TQlhY9EwEd-BzquC8wXy7w_940386448")]
    [DisplayName("Underlying Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygCshMvmntDtls")]
    #endif
    [IsoXmlTag("UndrlygCshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashMovement2? UnderlyingCashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashMovement2? UnderlyingCashMovementDetails { get; init; } 
    #else
    public CashMovement2? UnderlyingCashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the movement of the CA proceeds.
    /// </summary>
    [IsoId("_TQlhZNEwEd-BzquC8wXy7w_1511604786")]
    [DisplayName("Proceeds Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdsMvmntDtls")]
    #endif
    [IsoXmlTag("PrcdsMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProceedsMovement1? ProceedsMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProceedsMovement1? ProceedsMovementDetails { get; init; } 
    #else
    public ProceedsMovement1? ProceedsMovementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAMovementInstructionV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAMovementInstructionV01.

