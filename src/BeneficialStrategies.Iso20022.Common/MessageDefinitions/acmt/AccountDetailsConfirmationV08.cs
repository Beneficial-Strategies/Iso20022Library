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
/// This record is an implementation of the acmt.002.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountDetailsConfirmation message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner, for example, an investor to confirm the opening of an account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.
/// Usage
/// The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.
/// When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it may:
/// - contain the modified subsets of account details that were specified in the AccountModificationInstruction, and/or
/// - provide the status of the account.
/// When the AccountModificationInstruction message is used to instruct the closure of an account, the AccountDetailsConfirmation message is used to confirm the account has been closed. 
/// When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.
/// </summary>
[Description(@"Scope|The AccountDetailsConfirmation message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner, for example, an investor to confirm the opening of an account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.|Usage|The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.|When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it may:|- contain the modified subsets of account details that were specified in the AccountModificationInstruction, and/or|- provide the status of the account.|When the AccountModificationInstruction message is used to instruct the closure of an account, the AccountDetailsConfirmation message is used to confirm the account has been closed. |When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.")]
[IsoId("_lUvrIZDiEem7fvtoGpNpow")]
[DisplayName("Account Details Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountDetailsConfirmationV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.002.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctDtlsConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.002.001.08";
    
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
    /// Constructs a AccountDetailsConfirmationV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountDetailsConfirmationV08( MessageIdentification1 reqMessageIdentification,AccountManagementConfirmation5 reqConfirmationDetails )
    {
        MessageIdentification = reqMessageIdentification;
        ConfirmationDetails = reqConfirmationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_lUvrJ5DiEem7fvtoGpNpow")]
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
    /// Identifies a related order or settlement transaction.
    /// </summary>
    [IsoId("_lUvrKZDiEem7fvtoGpNpow")]
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
    [IsoId("_lUvrK5DiEem7fvtoGpNpow")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference13? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference13? RelatedReference { get; init; } 
    #else
    public AdditionalReference13? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the request or instruction which triggered this confirmation.
    /// </summary>
    [IsoId("_lUvrLZDiEem7fvtoGpNpow")]
    [DisplayName("Confirmation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfDtls")]
    #endif
    [IsoXmlTag("ConfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountManagementConfirmation5 ConfirmationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountManagementConfirmation5 ConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountManagementConfirmation5 ConfirmationDetails { get; init; } 
    #else
    public AccountManagementConfirmation5 ConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of the information related to the investment account.
    /// </summary>
    [IsoId("_lUvrL5DiEem7fvtoGpNpow")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount74? InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount74? InvestmentAccount { get; init; } 
    #else
    public InvestmentAccount74? InvestmentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of information related to parties that are related to the account, for example, primary account owner.
    /// </summary>
    [IsoId("_lUvrMZDiEem7fvtoGpNpow")]
    [DisplayName("Account Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPties")]
    #endif
    [IsoXmlTag("AcctPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountParties17? AccountParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties17? AccountParties { get; init; } 
    #else
    public AccountParties17? AccountParties { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of an intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_lUvrM5DiEem7fvtoGpNpow")]
    [DisplayName("Intermediaries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmies")]
    #endif
    [IsoXmlTag("Intrmies")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary46? Intermediaries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary46? Intermediaries { get; init; } 
    #else
    public Intermediary46? Intermediaries { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of referral information.
    /// </summary>
    [IsoId("_lUvrNZDiEem7fvtoGpNpow")]
    [DisplayName("Placement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Plcmnt")]
    #endif
    [IsoXmlTag("Plcmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredAgent3? Placement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredAgent3? Placement { get; init; } 
    #else
    public ReferredAgent3? Placement { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_lUvrN5DiEem7fvtoGpNpow")]
    [DisplayName("New Issue Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewIsseAllcn")]
    #endif
    [IsoXmlTag("NewIsseAllcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NewIssueAllocation2? NewIssueAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NewIssueAllocation2? NewIssueAllocation { get; init; } 
    #else
    public NewIssueAllocation2? NewIssueAllocation { get; set; } 
    #endif
    
    /// <summary>
    /// Confirmation of the information related to a savings plan that is related to the account.
    /// </summary>
    [IsoId("_lUvrOZDiEem7fvtoGpNpow")]
    [DisplayName("Savings Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvgsInvstmtPlan")]
    #endif
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan17> SavingsInvestmentPlan { get; init; } = new ValueList<InvestmentPlan17>(){};
    
    /// <summary>
    /// Confirmation of the information related to a withdrawal plan that is related to the account.
    /// </summary>
    [IsoId("_lUvrO5DiEem7fvtoGpNpow")]
    [DisplayName("Withdrawal Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlInvstmtPlan")]
    #endif
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan17> WithdrawalInvestmentPlan { get; init; } = new ValueList<InvestmentPlan17>(){};
    
    /// <summary>
    /// Confirmation of a cash settlement standing instruction associated to transactions on the account.
    /// </summary>
    [IsoId("_lUvrPZDiEem7fvtoGpNpow")]
    [DisplayName("Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlm")]
    #endif
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement3> CashSettlement { get; init; } = new ValueList<CashSettlement3>(){};
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_lUvrP5DiEem7fvtoGpNpow")]
    [DisplayName("Service Level Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvlAgrmt")]
    #endif
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend4> ServiceLevelAgreement { get; init; } = new ValueList<DocumentToSend4>(){};
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the party and or limitations and restrictions.
    /// </summary>
    [IsoId("_lUvrQZDiEem7fvtoGpNpow")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditiononalInformation13? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditiononalInformation13? AdditionalInformation { get; init; } 
    #else
    public AdditiononalInformation13? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_lUvrQ5DiEem7fvtoGpNpow")]
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
    [IsoId("_lUvrRZDiEem7fvtoGpNpow")]
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


// Since AccountDetailsConfirmationV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountDetailsConfirmationV08.

