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
/// Contains transaction details.
/// </summary>
[IsoId("_BmYzEYKzEeu4svNQ5N-l6w")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction146
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction146 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction146( string reqTransactionType,TransactionIdentification18 reqTransactionIdentification )
    {
        TransactionType = reqTransactionType;
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_BrTvUYKzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISO8583TransactionTypeCode TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string TransactionType { get; init; } 
    #else
    public string TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_BrTvU4KzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSubTp")]
    #endif
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionSubType { get; init; } 
    #else
    public System.String? TransactionSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 &amp; bit 24
    /// </summary>
    [IsoId("_BrTvV4KzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAttr")]
    #endif
    [IsoXmlTag("TxAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionAttribute2Code? TransactionAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAttribute2Code? TransactionAttribute { get; init; } 
    #else
    public TransactionAttribute2Code? TransactionAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_BrTvWYKzEeu4svNQ5N-l6w")]
    [DisplayName("Other Transaction Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTxAttr")]
    #endif
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherTransactionAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherTransactionAttribute { get; init; } 
    #else
    public System.String? OtherTransactionAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_cBQIN8sIEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? MessageReason { get; init; } 
    #else
    public string? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    [IsoId("_BrTvXYKzEeu4svNQ5N-l6w")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_BrTvVYKzEeu4svNQ5N-l6w")]
    [DisplayName("Additional Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSvc")]
    #endif
    [IsoXmlTag("AddtlSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalService2? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalService2? AdditionalService { get; init; } 
    #else
    public AdditionalService2? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_BrTvX4KzEeu4svNQ5N-l6w")]
    [DisplayName("Special Programme Qualification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclPrgrmmQlfctn")]
    #endif
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #else
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_BrTvYYKzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification18 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification18 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification18 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification18 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction currency of the acceptor.
    /// ISO 4217
    /// </summary>
    [IsoId("_BrTvY4KzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCcy")]
    #endif
    [IsoXmlTag("TxCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? TransactionCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TransactionCurrency { get; init; } 
    #else
    public string? TransactionCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of some or all amounts in the transaction amount.   
    /// The detailed amount is used to calculate the reconciliation amount for messages in which the transaction amount is absent. 
    /// </summary>
    [IsoId("_BrTvZYKzEeu4svNQ5N-l6w")]
    [DisplayName("Detailed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldAmt")]
    #endif
    [IsoXmlTag("DtldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount23? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount23? DetailedAmount { get; init; } 
    #else
    public DetailedAmount23? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    [IsoId("_BrTvZ4KzEeu4svNQ5N-l6w")]
    [DisplayName("Reconciliation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnAmt")]
    #endif
    [IsoXmlTag("RcncltnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount15? ReconciliationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount15? ReconciliationAmount { get; init; } 
    #else
    public Amount15? ReconciliationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_BrTvaYKzEeu4svNQ5N-l6w")]
    [DisplayName("Additional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAmt")]
    #endif
    [IsoXmlTag("AddtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalAmounts3? AdditionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalAmounts3? AdditionalAmount { get; init; } 
    #else
    public AdditionalAmounts3? AdditionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_BrTva4KzEeu4svNQ5N-l6w")]
    [DisplayName("Additional Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFee")]
    #endif
    [IsoXmlTag("AddtlFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? AdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? AdditionalFee { get; init; } 
    #else
    public AdditionalFee2? AdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_BrTvbYKzEeu4svNQ5N-l6w")]
    [DisplayName("Funds Services")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndsSvcs")]
    #endif
    [IsoXmlTag("FndsSvcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundingService2? FundsServices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundingService2? FundsServices { get; init; } 
    #else
    public FundingService2? FundsServices { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_BrTvb4KzEeu4svNQ5N-l6w")]
    [DisplayName("Account From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctFr")]
    #endif
    [IsoXmlTag("AcctFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountDetails3? AccountFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountDetails3? AccountFrom { get; init; } 
    #else
    public AccountDetails3? AccountFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_BrTvcYKzEeu4svNQ5N-l6w")]
    [DisplayName("Account To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTo")]
    #endif
    [IsoXmlTag("AcctTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountDetails3? AccountTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountDetails3? AccountTo { get; init; } 
    #else
    public AccountDetails3? AccountTo { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_BrTvc4KzEeu4svNQ5N-l6w")]
    [DisplayName("Transaction Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDesc")]
    #endif
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? TransactionDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionDescription { get; init; } 
    #else
    public System.String? TransactionDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_BrTvdYKzEeu4svNQ5N-l6w")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
