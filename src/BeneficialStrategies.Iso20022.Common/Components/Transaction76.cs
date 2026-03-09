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
[IsoId("_yn0cAVgPEeedJb6VxsnkPg")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction76
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction76 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction76( System.String reqTransactionType,TransactionIdentification8 reqTransactionIdentification )
    {
        TransactionType = reqTransactionType;
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_yzSFIVgPEeedJb6VxsnkPg")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact2AlphaNumericText TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionType { get; init; } 
    #else
    public System.String TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    [IsoId("_mrIB0BqjEeqH1IQNpbVpEw")]
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
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_l3yOMN3iEeieV46qhAnbyQ")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4NumericText? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageReason { get; init; } 
    #else
    public System.String? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_l3yOMd3iEeieV46qhAnbyQ")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_yzSFM1gPEeedJb6VxsnkPg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification8 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification8 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification8 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification8 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted new Personal Identification Number (PIN) and related information.	
    /// </summary>
    [IsoId("_6TzOEMsYEeizUq4cFQ71-Q")]
    [DisplayName("New PIN Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewPINData")]
    #endif
    [IsoXmlTag("NewPINData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PINData1? NewPINData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PINData1? NewPINData { get; init; } 
    #else
    public PINData1? NewPINData { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction currency of the acceptor.
    /// ISO 4217
    /// </summary>
    [IsoId("_4ylwIf-0EeiIQOwg4ol7gQ")]
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
    [IsoId("_LKIAUa0wEeiBP5PZ97xcEA")]
    [DisplayName("Detailed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldAmt")]
    #endif
    [IsoXmlTag("DtldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount20? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount20? DetailedAmount { get; init; } 
    #else
    public DetailedAmount20? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    [IsoId("_kD980a0yEeiBP5PZ97xcEA")]
    [DisplayName("Reconciliation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnAmt")]
    #endif
    [IsoXmlTag("RcncltnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount4? ReconciliationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount4? ReconciliationAmount { get; init; } 
    #else
    public Amount4? ReconciliationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    [IsoId("_iWqAEa0qEeiBP5PZ97xcEA")]
    [DisplayName("Additional Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAmts")]
    #endif
    [IsoXmlTag("AddtlAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalAmounts2? AdditionalAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalAmounts2? AdditionalAmounts { get; init; } 
    #else
    public AdditionalAmounts2? AdditionalAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_Z4Bn4fF7EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFees")]
    #endif
    [IsoXmlTag("AddtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? AdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? AdditionalFees { get; init; } 
    #else
    public AdditionalFee1? AdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_dySw4EJqEeiO-KV5ZjnZnQ")]
    [DisplayName("Account From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctFr")]
    #endif
    [IsoXmlTag("AcctFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountDetails2? AccountFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountDetails2? AccountFrom { get; init; } 
    #else
    public AccountDetails2? AccountFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_dySw4UJqEeiO-KV5ZjnZnQ")]
    [DisplayName("Account To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTo")]
    #endif
    [IsoXmlTag("AcctTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountDetails2? AccountTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountDetails2? AccountTo { get; init; } 
    #else
    public AccountDetails2? AccountTo { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_yFzqgRqlEeqH1IQNpbVpEw")]
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
