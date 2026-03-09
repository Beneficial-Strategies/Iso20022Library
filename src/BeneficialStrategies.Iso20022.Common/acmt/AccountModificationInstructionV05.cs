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
/// This record is an implementation of the acmt.003.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, for example, an investor or its designated agent, sends the AccountModificationInstruction message to the account servicer, for example, a registrar, transfer agent or custodian bank to modify, that is, create, update or delete specific details of an existing investment fund account.
/// Usage
/// The AccountModificationInstruction message is used to modify the details of an existing account.
/// The AccountModificationInstruction message has three specific uses:
/// - to maintain/update any of the existing account details, for example, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,
/// - to add/create specific details to the existing account when these details were not yet recorded at the time of account creation, for example, to add a second address or to establish new cash settlement standing instructions, or,
/// - to delete specific account details, for example, delete cash standing instructions.
/// This message cannot be used to delete an entire account, as institution specific and regulatory rules pertaining to account deletion are diverse.
/// The usage of this message may be subject to service level agreement (SLA) between the counterparties.
/// Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Description(@"Scope|An account owner, for example, an investor or its designated agent, sends the AccountModificationInstruction message to the account servicer, for example, a registrar, transfer agent or custodian bank to modify, that is, create, update or delete specific details of an existing investment fund account.|Usage|The AccountModificationInstruction message is used to modify the details of an existing account.|The AccountModificationInstruction message has three specific uses:|- to maintain/update any of the existing account details, for example, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,|- to add/create specific details to the existing account when these details were not yet recorded at the time of account creation, for example, to add a second address or to establish new cash settlement standing instructions, or,|- to delete specific account details, for example, delete cash standing instructions.|This message cannot be used to delete an entire account, as institution specific and regulatory rules pertaining to account deletion are diverse.|The usage of this message may be subject to service level agreement (SLA) between the counterparties.|Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.")]
[IsoId("_rM_TIQgpEeSUG-8hqXsVMQ")]
[DisplayName("Account Modification Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountModificationInstructionV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.003.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctModInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.003.001.05";
    
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
    /// Constructs a AccountModificationInstructionV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountModificationInstructionV05( MessageIdentification1 reqMessageIdentification,InvestmentAccountSelection2 reqInvestmentAccountSelection )
    {
        MessageIdentification = reqMessageIdentification;
        InvestmentAccountSelection = reqInvestmentAccountSelection;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_rM_TMQgpEeSUG-8hqXsVMQ")]
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
    [IsoId("_rM_TMwgpEeSUG-8hqXsVMQ")]
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
    /// Provides detailed information about the application modification instruction.
    /// </summary>
    [IsoId("_rM_TNQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrDtls")]
    #endif
    [IsoXmlTag("InstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountModification1? InstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountModification1? InstructionDetails { get; init; } 
    #else
    public InvestmentAccountModification1? InstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Investment account selection information used to identify the account for which the information is modified.
    /// </summary>
    [IsoId("_rM_TNwgpEeSUG-8hqXsVMQ")]
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
    [IsoId("_rM_TOQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modified Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdInvstmtAcct")]
    #endif
    [IsoXmlTag("ModfdInvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount47? ModifiedInvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount47? ModifiedInvestmentAccount { get; init; } 
    #else
    public InvestmentAccount47? ModifiedInvestmentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the account related parties, for example, primary owner to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TOwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modified Account Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdAcctPties")]
    #endif
    [IsoXmlTag("ModfdAcctPties")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<AccountParties11> ModifiedAccountParties { get; init; } = new ValueList<AccountParties11>(){};
    
    /// <summary>
    /// Information related to intermediaries to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TPQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modified Intermediaries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdIntrmies")]
    #endif
    [IsoXmlTag("ModfdIntrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope20> ModifiedIntermediaries { get; init; } = new ValueList<ModificationScope20>(){};
    
    /// <summary>
    /// Information related to referred placement agent in the hedge fund industry to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TPwgpEeSUG-8hqXsVMQ")]
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
    [IsoId("_rM_TQQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modified Issue Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdIsseAllcn")]
    #endif
    [IsoXmlTag("ModfdIsseAllcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationScope21? ModifiedIssueAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationScope21? ModifiedIssueAllocation { get; init; } 
    #else
    public ModificationScope21? ModifiedIssueAllocation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a savings plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TQwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modified Savings Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdSvgsInvstmtPlan")]
    #endif
    [IsoXmlTag("ModfdSvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<ModificationScope25> ModifiedSavingsInvestmentPlan { get; init; } = new ValueList<ModificationScope25>(){};
    
    /// <summary>
    /// Information related to a withdrawal plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TRQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modified Withdrawal Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdWdrwlInvstmtPlan")]
    #endif
    [IsoXmlTag("ModfdWdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope25> ModifiedWithdrawalInvestmentPlan { get; init; } = new ValueList<ModificationScope25>(){};
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment fund transaction and to be either inserted or deleted.
    /// </summary>
    [IsoId("_rM_TRwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modified Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdCshSttlm")]
    #endif
    [IsoXmlTag("ModfdCshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<InvestmentFundCashSettlementInformation8> ModifiedCashSettlement { get; init; } = new ValueList<InvestmentFundCashSettlementInformation8>(){};
    
    /// <summary>
    /// Information related to documents to be added, deleted or updated.|.
    /// </summary>
    [IsoId("_rM_TSQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Modified Service Level Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdSvcLvlAgrmt")]
    #endif
    [IsoXmlTag("ModfdSvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<ModificationScope22> ModifiedServiceLevelAgreement { get; init; } = new ValueList<ModificationScope22>(){};
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_rM_TSwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Market Practice Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPrctcVrsn")]
    #endif
    [IsoXmlTag("MktPrctcVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #else
    public MarketPracticeVersion1? MarketPracticeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rM_TTQgpEeSUG-8hqXsVMQ")]
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


// Since AccountModificationInstructionV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountModificationInstructionV05.

