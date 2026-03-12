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
/// This record is an implementation of the acmt.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, eg, a registrar, transfer agent or custodian bank sends the AccountDetailsConfirmation message to an account owner, eg, an investor to confirm the opening of an investment fund account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.
/// Usage
/// The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.
/// When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.
/// When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.
/// </summary>
[Description(@"Scope|An account servicer, eg, a registrar, transfer agent or custodian bank sends the AccountDetailsConfirmation message to an account owner, eg, an investor to confirm the opening of an investment fund account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.|Usage|The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.|When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.|When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.")]
[IsoId("_o6y4K9E9Ed-BzquC8wXy7w_-1762172506")]
[DisplayName("Account Details Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountDetailsConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctDtlsConfV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.002.001.02";
    
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
    /// Constructs a AccountDetailsConfirmationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountDetailsConfirmationV02( MessageIdentification1 reqMessageIdentification,AccountManagementConfirmation1 reqConfirmationDetails )
    {
        MessageIdentification = reqMessageIdentification;
        ConfirmationDetails = reqConfirmationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_o6y4LNE9Ed-BzquC8wXy7w_-1885939941")]
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
    [IsoId("_o68pINE9Ed-BzquC8wXy7w_203534418")]
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
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_o68pIdE9Ed-BzquC8wXy7w_-1762172463")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? RelatedReference { get; init; } 
    #else
    public AdditionalReference3? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Provide detailed information about the request or instruction which triggered this confirmation.
    /// </summary>
    [IsoId("_o68pItE9Ed-BzquC8wXy7w_-1762172095")]
    [DisplayName("Confirmation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfDtls")]
    #endif
    [IsoXmlTag("ConfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountManagementConfirmation1 ConfirmationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountManagementConfirmation1 ConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountManagementConfirmation1 ConfirmationDetails { get; init; } 
    #else
    public AccountManagementConfirmation1 ConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of the information related to a selected investment account.
    /// </summary>
    [IsoId("_o68pI9E9Ed-BzquC8wXy7w_-1762172042")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount27? InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount27? InvestmentAccount { get; init; } 
    #else
    public InvestmentAccount27? InvestmentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of information related to parties who are related to a selected investment account.
    /// </summary>
    [IsoId("_o68pJNE9Ed-BzquC8wXy7w_-1762171905")]
    [DisplayName("Account Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPties")]
    #endif
    [IsoXmlTag("AcctPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountParties5? AccountParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties5? AccountParties { get; init; } 
    #else
    public AccountParties5? AccountParties { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of information related to intermediaries who are related to a selected investment account.
    /// </summary>
    [IsoId("_o68pJdE9Ed-BzquC8wXy7w_-1762171845")]
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
    [IsoId("_o68pJtE9Ed-BzquC8wXy7w_-1762171473")]
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
    [IsoId("_o7FzENE9Ed-BzquC8wXy7w_-1761251466")]
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
    /// Confirmation of the information related to a savings plan that is related to a selected investment account.
    /// </summary>
    [IsoId("_o7FzEdE9Ed-BzquC8wXy7w_-1762171940")]
    [DisplayName("Savings Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvgsInvstmtPlan")]
    #endif
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan4> SavingsInvestmentPlan { get; init; } = new ValueList<InvestmentPlan4>(){};
    
    /// <summary>
    /// Confirmation of the information related to a withrawal plan that is related to a selected investment account.
    /// </summary>
    [IsoId("_o7FzEtE9Ed-BzquC8wXy7w_-1762172000")]
    [DisplayName("Withdrawal Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlInvstmtPlan")]
    #endif
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan4> WithdrawalInvestmentPlan { get; init; } = new ValueList<InvestmentPlan4>(){};
    
    /// <summary>
    /// Confirmation of the cash settlement standing instruction associated to the investment fund transaction.
    /// </summary>
    [IsoId("_o7FzE9E9Ed-BzquC8wXy7w_-1762171568")]
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
    [IsoId("_o7FzFNE9Ed-BzquC8wXy7w_-1762171533")]
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
    [IsoId("_o7FzFdE9Ed-BzquC8wXy7w_-1762172420")]
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


// Since AccountDetailsConfirmationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountDetailsConfirmationV02.

