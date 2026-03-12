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
/// This record is an implementation of the acmt.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to an account servicer, for example, a registrar, transfer agent or custodian to instruct the opening of an account or the opening of an account and establishing an investment plan.
/// Usage
/// The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.
/// In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.
/// Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Description(@"Scope|An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to an account servicer, for example, a registrar, transfer agent or custodian to instruct the opening of an account or the opening of an account and establishing an investment plan.|Usage|The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.|In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.|Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.")]
[IsoId("_uPJGqNE9Ed-BzquC8wXy7w_374979403")]
[DisplayName("Account Opening Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountOpeningInstructionV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.001.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngInstrV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.001.001.02";
    
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
    /// Constructs a AccountOpeningInstructionV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountOpeningInstructionV02( MessageIdentification1 reqMessageIdentification,InvestmentAccountOpeningDetails reqInstructionDetails,InvestmentAccount26 reqInvestmentAccount,AccountParties5 reqAccountParties )
    {
        MessageIdentification = reqMessageIdentification;
        InstructionDetails = reqInstructionDetails;
        InvestmentAccount = reqInvestmentAccount;
        AccountParties = reqAccountParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_uPJGqdE9Ed-BzquC8wXy7w_-732849931")]
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
    /// Identifies a related order.
    /// </summary>
    [IsoId("_uPJGqtE9Ed-BzquC8wXy7w_-1194676409")]
    [DisplayName("Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRef")]
    #endif
    [IsoXmlTag("OrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundOrder4? OrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundOrder4? OrderReference { get; init; } 
    #else
    public InvestmentFundOrder4? OrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_uPJGq9E9Ed-BzquC8wXy7w_374981384")]
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
    /// Provide detailed information about the opening instruction.
    /// </summary>
    [IsoId("_uPSQkNE9Ed-BzquC8wXy7w_374981349")]
    [DisplayName("Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrDtls")]
    #endif
    [IsoXmlTag("InstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccountOpeningDetails InstructionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccountOpeningDetails InstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOpeningDetails InstructionDetails { get; init; } 
    #else
    public InvestmentAccountOpeningDetails InstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the investment account to be opened.
    /// </summary>
    [IsoId("_uPSQkdE9Ed-BzquC8wXy7w_374979807")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount26 InvestmentAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount26 InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount26 InvestmentAccount { get; init; } 
    #else
    public InvestmentAccount26 InvestmentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to parties who are related to an investment account; eg. primary account owner.
    /// </summary>
    [IsoId("_uPSQktE9Ed-BzquC8wXy7w_374979944")]
    [DisplayName("Account Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPties")]
    #endif
    [IsoXmlTag("AcctPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountParties5 AccountParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountParties5 AccountParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties5 AccountParties { get; init; } 
    #else
    public AccountParties5 AccountParties { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_uPSQk9E9Ed-BzquC8wXy7w_374980359")]
    [DisplayName("Intermediaries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmies")]
    #endif
    [IsoXmlTag("Intrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary12> Intermediaries { get; init; } = new ValueList<Intermediary12>(){};
    
    /// <summary>
    /// Placement agent for the hedge fund industry.
    /// </summary>
    [IsoId("_uPSQlNE9Ed-BzquC8wXy7w_374980316")]
    [DisplayName("Placement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Plcmnt")]
    #endif
    [IsoXmlTag("Plcmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredAgent1? Placement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredAgent1? Placement { get; init; } 
    #else
    public ReferredAgent1? Placement { get; set; } 
    #endif
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_uPSQldE9Ed-BzquC8wXy7w_374980737")]
    [DisplayName("New Issue Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewIsseAllcn")]
    #endif
    [IsoXmlTag("NewIsseAllcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NewIssueAllocation1? NewIssueAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NewIssueAllocation1? NewIssueAllocation { get; init; } 
    #else
    public NewIssueAllocation1? NewIssueAllocation { get; set; } 
    #endif
    
    /// <summary>
    /// Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, eg, retirement.
    /// </summary>
    [IsoId("_uPSQltE9Ed-BzquC8wXy7w_374979849")]
    [DisplayName("Savings Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvgsInvstmtPlan")]
    #endif
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan4> SavingsInvestmentPlan { get; init; } = new ValueList<InvestmentPlan4>(){};
    
    /// <summary>
    /// Plan through which an investment fund investor&apos;s holdings are depleted through regular withdrawals at specified intervals.
    /// </summary>
    [IsoId("_uPSQl9E9Ed-BzquC8wXy7w_374979909")]
    [DisplayName("Withdrawal Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlInvstmtPlan")]
    #endif
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan4> WithdrawalInvestmentPlan { get; init; } = new ValueList<InvestmentPlan4>(){};
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment fund transaction.
    /// </summary>
    [IsoId("_uPSQmNE9Ed-BzquC8wXy7w_374980394")]
    [DisplayName("Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlm")]
    #endif
    [IsoXmlTag("CshSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundCashSettlementInformation3? CashSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundCashSettlementInformation3? CashSettlement { get; init; } 
    #else
    public InvestmentFundCashSettlementInformation3? CashSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_uPcBkNE9Ed-BzquC8wXy7w_374980454")]
    [DisplayName("Service Level Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvlAgrmt")]
    #endif
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend1> ServiceLevelAgreement { get; init; } = new ValueList<DocumentToSend1>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_uPcBkdE9Ed-BzquC8wXy7w_374980797")]
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


// Since AccountOpeningInstructionV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningInstructionV02.

