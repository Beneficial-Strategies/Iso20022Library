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


namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.003.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, eg, and investor or its designated agent, sends the AccountModificationInstruction message to an account servicer, eg, a registrar, transfer agent or custodian bank to modify, ie, create, update or delete specific details of an existing investment fund account.
/// Usage
/// The AccountModificationInstruction message is used to modify the details of an existing account.
/// The AccountModificationInstruction message has three specific uses:
/// - to maintain/update any of the existing account details, eg, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,
/// - to add/create specific details to the existing account when these details were not yet recorded at the time of account creation, eg, to add a second address or to establish new cash settlement standing instructions, or,
/// - to delete specific account details, eg, delete cash standing instructions.
/// This message cannot be used to delete an entire account, as institution specific and regulatory rules pertaining to account deletion are diverse.
/// The usage of this message may be subject to service level agreement (SLA) between the counterparties.
/// Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Description(@"Scope|An account owner, eg, and investor or its designated agent, sends the AccountModificationInstruction message to an account servicer, eg, a registrar, transfer agent or custodian bank to modify, ie, create, update or delete specific details of an existing investment fund account.|Usage|The AccountModificationInstruction message is used to modify the details of an existing account.|The AccountModificationInstruction message has three specific uses:|- to maintain/update any of the existing account details, eg, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,|- to add/create specific details to the existing account when these details were not yet recorded at the time of account creation, eg, to add a second address or to establish new cash settlement standing instructions, or,|- to delete specific account details, eg, delete cash standing instructions.|This message cannot be used to delete an entire account, as institution specific and regulatory rules pertaining to account deletion are diverse.|The usage of this message may be subject to service level agreement (SLA) between the counterparties.|Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.")]
[IsoId("_sfFeRdE9Ed-BzquC8wXy7w_-1423179150")]
[DisplayName("Account Modification Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountModificationInstructionV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.003.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctModInstrV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02";
    
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
    /// Constructs a AccountModificationInstructionV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountModificationInstructionV02( MessageIdentification1 reqMessageIdentification,InvestmentAccountSelection2 reqInvestmentAccountSelection )
    {
        MessageIdentification = reqMessageIdentification;
        InvestmentAccountSelection = reqInvestmentAccountSelection;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_sfFeRtE9Ed-BzquC8wXy7w_-1821354979")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_sfFeR9E9Ed-BzquC8wXy7w_-1423178721")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PreviousReference { get; init; } 
    #else
    public AdditionalReference3? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Provide detailed information about the application modification instruction.
    /// </summary>
    [IsoId("_sfFeSNE9Ed-BzquC8wXy7w_-1423178686")]
    [DisplayName("Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrDtls")]
    #endif
    [IsoXmlTag("InstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountModificationDetails? InstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountModificationDetails? InstructionDetails { get; init; } 
    #else
    public InvestmentAccountModificationDetails? InstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Investment account selection information used to identify the account for which the information is modified.
    /// </summary>
    [IsoId("_sfFeSdE9Ed-BzquC8wXy7w_-1423178644")]
    [DisplayName("Investment Account Selection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctSelctn")]
    #endif
    [IsoXmlTag("InvstmtAcctSelctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccountSelection2 InvestmentAccountSelection { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccountSelection2 InvestmentAccountSelection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountSelection2 InvestmentAccountSelection { get; init; } 
    #else
    public InvestmentAccountSelection2 InvestmentAccountSelection { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to general characteristics of an investment account to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_sfOoMNE9Ed-BzquC8wXy7w_-1423178591")]
    [DisplayName("Modified Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdInvstmtAcct")]
    #endif
    [IsoXmlTag("ModfdInvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount28? ModifiedInvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount28? ModifiedInvestmentAccount { get; init; } 
    #else
    public InvestmentAccount28? ModifiedInvestmentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the account related parties (eg. account owner) to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_sfOoMdE9Ed-BzquC8wXy7w_-1423178194")]
    [DisplayName("Modified Account Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdAcctPties")]
    #endif
    [IsoXmlTag("ModfdAcctPties")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<AccountParties4> ModifiedAccountParties { get; init; } = new ValueList<AccountParties4>(){};
    
    /// <summary>
    /// Information related to intermediaries to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_sfOoMtE9Ed-BzquC8wXy7w_-1423178454")]
    [DisplayName("Modified Intermediaries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdIntrmies")]
    #endif
    [IsoXmlTag("ModfdIntrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope7> ModifiedIntermediaries { get; init; } = new ValueList<ModificationScope7>(){};
    
    /// <summary>
    /// Information related to referred placement agent in the hedge fund industry to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_sfOoM9E9Ed-BzquC8wXy7w_-1423178159")]
    [DisplayName("Modified Placement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdPlcmnt")]
    #endif
    [IsoXmlTag("ModfdPlcmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredAgent1? ModifiedPlacement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredAgent1? ModifiedPlacement { get; init; } 
    #else
    public ReferredAgent1? ModifiedPlacement { get; set; } 
    #endif
    
    /// <summary>
    /// Eligibility conditions information related to new issues allocation to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_sfOoNNE9Ed-BzquC8wXy7w_-1252846017")]
    [DisplayName("Modified Issue Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdIsseAllcn")]
    #endif
    [IsoXmlTag("ModfdIsseAllcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationScope9? ModifiedIssueAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationScope9? ModifiedIssueAllocation { get; init; } 
    #else
    public ModificationScope9? ModifiedIssueAllocation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a savings plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_sfOoNdE9Ed-BzquC8wXy7w_-1423178549")]
    [DisplayName("Modified Savings Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdSvgsInvstmtPlan")]
    #endif
    [IsoXmlTag("ModfdSvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<ModificationScope8> ModifiedSavingsInvestmentPlan { get; init; } = new ValueList<ModificationScope8>(){};
    
    /// <summary>
    /// Information related to a withrawal plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_sfOoNtE9Ed-BzquC8wXy7w_-1423178506")]
    [DisplayName("Modified Withdrawal Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdWdrwlInvstmtPlan")]
    #endif
    [IsoXmlTag("ModfdWdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope8> ModifiedWithdrawalInvestmentPlan { get; init; } = new ValueList<ModificationScope8>(){};
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment fund transaction and to be either inserted or deleted.
    /// </summary>
    [IsoId("_sfOoN9E9Ed-BzquC8wXy7w_-1423178117")]
    [DisplayName("Modified Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdCshSttlm")]
    #endif
    [IsoXmlTag("ModfdCshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<InvestmentFundCashSettlementInformation4> ModifiedCashSettlement { get; init; } = new ValueList<InvestmentFundCashSettlementInformation4>(){};
    
    /// <summary>
    /// Information related to documents to be added, deleted or updated.|.
    /// </summary>
    [IsoId("_sfYZMNE9Ed-BzquC8wXy7w_-1423178082")]
    [DisplayName("Modified Service Level Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdSvcLvlAgrmt")]
    #endif
    [IsoXmlTag("ModfdSvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<ModificationScope10> ModifiedServiceLevelAgreement { get; init; } = new ValueList<ModificationScope10>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sfYZMdE9Ed-BzquC8wXy7w_-1423177731")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AccountModificationInstructionV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountModificationInstructionV02.

