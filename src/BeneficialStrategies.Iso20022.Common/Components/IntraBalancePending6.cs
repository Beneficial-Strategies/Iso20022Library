// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[IsoId("_Y3sq1zneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Pending")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalancePending6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraBalancePending6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalancePending6( System.String reqAccountOwnerTransactionIdentification,CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceFrom,CashSubBalanceTypeAndQuantityBreakdown3 reqBalanceTo,Amount2Choice_ reqSettlementAmount,DateAndDateTime2Choice_ reqIntendedSettlementDate,System.DateTime reqCreationDateTime )
    {
        AccountOwnerTransactionIdentification = reqAccountOwnerTransactionIdentification;
        BalanceFrom = reqBalanceFrom;
        BalanceTo = reqBalanceTo;
        SettlementAmount = reqSettlementAmount;
        IntendedSettlementDate = reqIntendedSettlementDate;
        CreationDateTime = reqCreationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_ZCu2IzneEem7JZMuWtwtsg")]
    [DisplayName("Status And Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsAndRsn")]
    #endif
    [IsoXmlTag("StsAndRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingStatusAndReason2? StatusAndReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingStatusAndReason2? StatusAndReason { get; init; } 
    #else
    public PendingStatusAndReason2? StatusAndReason { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_ZCu2KzneEem7JZMuWtwtsg")]
    [DisplayName("Account Owner Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrTxId")]
    #endif
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountOwnerTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountOwnerTransactionIdentification { get; init; } 
    #else
    public System.String AccountOwnerTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_ZCu2MzneEem7JZMuWtwtsg")]
    [DisplayName("Account Servicer Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrTxId")]
    #endif
    [IsoXmlTag("AcctSvcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicerTransactionIdentification { get; init; } 
    #else
    public System.String? AccountServicerTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_ZCu2OzneEem7JZMuWtwtsg")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktInfrstrctrTxId")]
    #endif
    [IsoXmlTag("MktInfrstrctrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MarketInfrastructureTransactionIdentification { get; init; } 
    #else
    public System.String? MarketInfrastructureTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction as assigned by the processor.
    /// </summary>
    [IsoId("_ZCu2QzneEem7JZMuWtwtsg")]
    [DisplayName("Processor Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcrTxId")]
    #endif
    [IsoXmlTag("PrcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProcessorTransactionIdentification { get; init; } 
    #else
    public System.String? ProcessorTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_ZCu2RTneEem7JZMuWtwtsg")]
    [DisplayName("Pool Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolId")]
    #endif
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PoolIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PoolIdentification { get; init; } 
    #else
    public System.String? PoolIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_ZCu2TTneEem7JZMuWtwtsg")]
    [DisplayName("Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtId")]
    #endif
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CorporateActionEventIdentification { get; init; } 
    #else
    public System.String? CorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Balance from which the amount of money is moved.
    /// </summary>
    [IsoId("_ZCu2VTneEem7JZMuWtwtsg")]
    [DisplayName("Balance From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalFr")]
    #endif
    [IsoXmlTag("BalFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    #else
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [IsoId("_ZCu2XTneEem7JZMuWtwtsg")]
    [DisplayName("Balance To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTo")]
    #endif
    [IsoXmlTag("BalTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    #else
    public CashSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner&apos;s cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_ZCu2ZTneEem7JZMuWtwtsg")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2Choice_ SettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2Choice_ SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_ SettlementAmount { get; init; } 
    #else
    public Amount2Choice_ SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the amount of money is intended to be moved.
    /// </summary>
    [IsoId("_ZCu2ZzneEem7JZMuWtwtsg")]
    [DisplayName("Intended Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntnddSttlmDt")]
    #endif
    [IsoXmlTag("IntnddSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ IntendedSettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ IntendedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ IntendedSettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ IntendedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_ZCu2bzneEem7JZMuWtwtsg")]
    [DisplayName("Status Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsDt")]
    #endif
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StatusDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StatusDate { get; init; } 
    #else
    public System.DateTime? StatusDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_ZCu2dzneEem7JZMuWtwtsg")]
    [DisplayName("Cash Sub Balance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSubBalId")]
    #endif
    [IsoXmlTag("CshSubBalId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? CashSubBalanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? CashSubBalanceIdentification { get; init; } 
    #else
    public GenericIdentification37? CashSubBalanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_ZCu2eTneEem7JZMuWtwtsg")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages57? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages57? Linkages { get; init; } 
    #else
    public Linkages57? Linkages { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_ZCu2ezneEem7JZMuWtwtsg")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriorityNumeric4Choice_? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriorityNumeric4Choice_? Priority { get; init; } 
    #else
    public PriorityNumeric4Choice_? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_ZCu2gzneEem7JZMuWtwtsg")]
    [DisplayName("Message Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgOrgtr")]
    #endif
    [IsoXmlTag("MsgOrgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification8? MessageOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8? MessageOriginator { get; init; } 
    #else
    public SystemPartyIdentification8? MessageOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_ZCu2hTneEem7JZMuWtwtsg")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_ZCu2jTneEem7JZMuWtwtsg")]
    [DisplayName("Instruction Processing Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrcgAddtlDtls")]
    #endif
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? InstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZCu2lTneEem7JZMuWtwtsg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
