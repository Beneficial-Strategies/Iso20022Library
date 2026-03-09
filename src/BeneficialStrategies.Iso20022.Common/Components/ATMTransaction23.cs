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
/// Transfer information for the transaction.
/// </summary>
[IsoId("_t-Wk8a4tEeWLdt0vLARX2Q")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction23( TransactionIdentifier1 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_uJO_Qa4tEeWLdt0vLARX2Q")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_uJO_Ra4tEeWLdt0vLARX2Q")]
    [DisplayName("Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnId")]
    #endif
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationIdentification { get; init; } 
    #else
    public System.String? ReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the transfer for the creditor.
    /// </summary>
    [IsoId("_GgHqkK4uEeWLdt0vLARX2Q")]
    [DisplayName("Creditor Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrLabl")]
    #endif
    [IsoXmlTag("CdtrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CreditorLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorLabel { get; init; } 
    #else
    public System.String? CreditorLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the transfer for the debtor.
    /// </summary>
    [IsoId("_JmHLIK4uEeWLdt0vLARX2Q")]
    [DisplayName("Debtor Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrLabl")]
    #endif
    [IsoXmlTag("DbtrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DebtorLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebtorLabel { get; init; } 
    #else
    public System.String? DebtorLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the payment.
    /// </summary>
    [IsoId("_QDmzAK4uEeWLdt0vLARX2Q")]
    [DisplayName("Payment Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRef")]
    #endif
    [IsoXmlTag("PmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PaymentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentReference { get; init; } 
    #else
    public System.String? PaymentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the source account of the transfer.
    /// </summary>
    [IsoId("_uJO_Ta4tEeWLdt0vLARX2Q")]
    [DisplayName("Account From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctFr")]
    #endif
    [IsoXmlTag("AcctFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount7? AccountFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount7? AccountFrom { get; init; } 
    #else
    public CardAccount7? AccountFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of the source account information.
    /// </summary>
    [IsoId("_uJO_T64tEeWLdt0vLARX2Q")]
    [DisplayName("Protected Account From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdAcctFr")]
    #endif
    [IsoXmlTag("PrtctdAcctFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedAccountFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedAccountFrom { get; init; } 
    #else
    public ContentInformationType10? ProtectedAccountFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the destination account of the transfer.
    /// </summary>
    [IsoId("_dtODUK4uEeWLdt0vLARX2Q")]
    [DisplayName("Account To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTo")]
    #endif
    [IsoXmlTag("AcctTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount7? AccountTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount7? AccountTo { get; init; } 
    #else
    public CardAccount7? AccountTo { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of the destination account information.
    /// </summary>
    [IsoId("_iK1eIK4uEeWLdt0vLARX2Q")]
    [DisplayName("Protected Account To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdAcctTo")]
    #endif
    [IsoXmlTag("PrtctdAcctTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedAccountTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedAccountTo { get; init; } 
    #else
    public ContentInformationType10? ProtectedAccountTo { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the transaction to be authorised.
    /// </summary>
    [IsoId("_uJO_Va4tEeWLdt0vLARX2Q")]
    [DisplayName("Total Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlReqdAmt")]
    #endif
    [IsoXmlTag("TtlReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the transfer transaction amounts.
    /// </summary>
    [IsoId("_uJO_V64tEeWLdt0vLARX2Q")]
    [DisplayName("Detailed Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldReqdAmt")]
    #endif
    [IsoXmlTag("DtldReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount17? DetailedRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount17? DetailedRequestedAmount { get; init; } 
    #else
    public DetailedAmount17? DetailedRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Requested date of the execution of the transfer.
    /// </summary>
    [IsoId("_RQ724K4wEeWpsoxRhdX-8A")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedExecutionDate { get; init; } 
    #else
    public System.DateOnly? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the instant transfer program.
    /// </summary>
    [IsoId("_WXYMQK4wEeWpsoxRhdX-8A")]
    [DisplayName("Instant Transfer Program")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstntTrfPrgm")]
    #endif
    [IsoXmlTag("InstntTrfPrgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InstantTransferProgram { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstantTransferProgram { get; init; } 
    #else
    public System.String? InstantTransferProgram { get; set; } 
    #endif
    
    /// <summary>
    /// Information for reccurring transfer or standing orders.
    /// </summary>
    [IsoId("_aYAJEK4wEeWpsoxRhdX-8A")]
    [DisplayName("Recurring Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrngTrf")]
    #endif
    [IsoXmlTag("RcrngTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RecurringTransaction3? RecurringTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecurringTransaction3? RecurringTransfer { get; init; } 
    #else
    public RecurringTransaction3? RecurringTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    [IsoId("_uJO_W64tEeWLdt0vLARX2Q")]
    [DisplayName("Requested Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdRct")]
    #endif
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestedReceipt { get; init; } 
    #else
    public System.String? RequestedReceipt { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_uJO_aa4tEeWLdt0vLARX2Q")]
    [DisplayName("ICC Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRltdData")]
    #endif
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ICCRelatedData { get; init; } 
    #else
    public System.Byte[]? ICCRelatedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
