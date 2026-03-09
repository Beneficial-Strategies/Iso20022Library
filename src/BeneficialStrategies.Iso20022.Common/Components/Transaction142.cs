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
[IsoId("_EyN00cL8EeujWbERHVYCew")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction142
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction142 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction142( string reqTransactionType,TransactionIdentification51 reqTransactionIdentification,TransactionAmounts2 reqTransactionAmounts )
    {
        TransactionType = reqTransactionType;
        TransactionIdentification = reqTransactionIdentification;
        TransactionAmounts = reqTransactionAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code that indicates the type of transaction being undertaken in accordance with ISO 8583, Transaction Type.
    /// </summary>
    [IsoId("_E3L0YcL8EeujWbERHVYCew")]
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
    [IsoId("_E3L0Y8L8EeujWbERHVYCew")]
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
    [IsoId("_E3L0ZcL8EeujWbERHVYCew")]
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
    [IsoId("_E3L0Z8L8EeujWbERHVYCew")]
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
    [IsoId("_PPQxh8sKEeuNe7RtB4qFHw")]
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
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_E3L0a8L8EeujWbERHVYCew")]
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
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// ISO8583:1993 and ISO 8583:2003 Bit 57
    /// </summary>
    [IsoId("_E3L0bcL8EeujWbERHVYCew")]
    [DisplayName("Pre Authorisation Time Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreAuthstnTmLmt")]
    #endif
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreAuthorisationTimeLimit { get; init; } 
    #else
    public System.String? PreAuthorisationTimeLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_E3L0b8L8EeujWbERHVYCew")]
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
    /// Indicates that additional data will be provided in a separate addendum message.
    /// </summary>
    [IsoId("_E3L0ccL8EeujWbERHVYCew")]
    [DisplayName("Associated Data Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDataInd")]
    #endif
    [IsoXmlTag("AssoctdDataInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AssociatedDataIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedDataIndicator { get; init; } 
    #else
    public System.String? AssociatedDataIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to additional transaction details to be conveyed separately from this message.
    /// </summary>
    [IsoId("_E3L0c8L8EeujWbERHVYCew")]
    [DisplayName("Associated Data Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDataRef")]
    #endif
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AssociatedDataReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedDataReference { get; init; } 
    #else
    public System.String? AssociatedDataReference { get; set; } 
    #endif
    
    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_E3L0dcL8EeujWbERHVYCew")]
    [DisplayName("Associated Data Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDataDstn")]
    #endif
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AssociatedDataDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedDataDestination { get; init; } 
    #else
    public System.String? AssociatedDataDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_E3L0d8L8EeujWbERHVYCew")]
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
    [IsoId("_E3L0ecL8EeujWbERHVYCew")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification51 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification51 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification51 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification51 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the dispute.
    /// </summary>
    [IsoId("_E3L0e8L8EeujWbERHVYCew")]
    [DisplayName("Dispute Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptData")]
    #endif
    [IsoXmlTag("DsptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisputeData3? DisputeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisputeData3? DisputeData { get; init; } 
    #else
    public DisputeData3? DisputeData { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_E3L0fcL8EeujWbERHVYCew")]
    [DisplayName("Transaction Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmts")]
    #endif
    [IsoXmlTag("TxAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionAmounts2 TransactionAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionAmounts2 TransactionAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAmounts2 TransactionAmounts { get; init; } 
    #else
    public TransactionAmounts2 TransactionAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_E3L0f8L8EeujWbERHVYCew")]
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
    [IsoId("_E3L0h8L8EeujWbERHVYCew")]
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
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_E3L0icL8EeujWbERHVYCew")]
    [DisplayName("Original Additional Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAddtlFee")]
    #endif
    [IsoXmlTag("OrgnlAddtlFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? OriginalAdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? OriginalAdditionalFee { get; init; } 
    #else
    public AdditionalFee2? OriginalAdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Contains ATM deposit details.
    /// </summary>
    [IsoId("_E3L0l8L8EeujWbERHVYCew")]
    [DisplayName("Deposit Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstDtls")]
    #endif
    [IsoXmlTag("DpstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DepositDetails2? DepositDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DepositDetails2? DepositDetails { get; init; } 
    #else
    public DepositDetails2? DepositDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_E3L0mcL8EeujWbERHVYCew")]
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
    [IsoId("_E3L0m8L8EeujWbERHVYCew")]
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
    [IsoId("_E3L0ncL8EeujWbERHVYCew")]
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
    /// ISO 8583:87/93 bit 104
    /// ISO 8583:2003 bit 104-71
    /// </summary>
    [IsoId("_E3L0n8L8EeujWbERHVYCew")]
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
    [IsoId("_E3L0ocL8EeujWbERHVYCew")]
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
