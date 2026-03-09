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
/// Response to the deposit request.
/// </summary>
[IsoId("_YM1VAa4PEeWZgJQOa6iKCQ")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction19( TransactionIdentifier1 reqTransactionIdentification,ATMTransactionStatus1Code reqTransactionStatus,AmountAndCurrency1 reqTotalDepositedAmount,ImpliedCurrencyAndAmount reqTotalAuthorisedAmount )
    {
        TransactionIdentification = reqTransactionIdentification;
        TransactionStatus = reqTransactionStatus;
        TotalDepositedAmount = reqTotalDepositedAmount;
        TotalAuthorisedAmount = reqTotalAuthorisedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_YXa0Ya4PEeWZgJQOa6iKCQ")]
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
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    [IsoId("_lv87wK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionStatus1Code TransactionStatus { get; init; } 
    #else
    public ATMTransactionStatus1Code TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_YXa0Y64PEeWZgJQOa6iKCQ")]
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
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    [IsoId("_tR7fcK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Incident")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incdnt")]
    #endif
    [IsoXmlTag("Incdnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FailureReason7Code? Incident { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FailureReason7Code? Incident { get; init; } 
    #else
    public FailureReason7Code? Incident { get; set; } 
    #endif
    
    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    [IsoId("_wxbsMK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Incident Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncdntDtl")]
    #endif
    [IsoXmlTag("IncdntDtl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? IncidentDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IncidentDetail { get; init; } 
    #else
    public System.String? IncidentDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_YXa0Z64PEeWZgJQOa6iKCQ")]
    [DisplayName("Account Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctData")]
    #endif
    [IsoXmlTag("AcctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount8? AccountData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount8? AccountData { get; init; } 
    #else
    public CardAccount8? AccountData { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_YXa0aa4PEeWZgJQOa6iKCQ")]
    [DisplayName("Protected Account Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdAcctData")]
    #endif
    [IsoXmlTag("PrtctdAcctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    #else
    public ContentInformationType10? ProtectedAccountData { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount deposed by the customer.
    /// </summary>
    [IsoId("_ANP58K4QEeWZgJQOa6iKCQ")]
    [DisplayName("Total Deposited Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDpstdAmt")]
    #endif
    [IsoXmlTag("TtlDpstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndCurrency1 TotalDepositedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndCurrency1 TotalDepositedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrency1 TotalDepositedAmount { get; init; } 
    #else
    public AmountAndCurrency1 TotalDepositedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total authorised amount of the deposit transaction.
    /// </summary>
    [IsoId("_YXa0a64PEeWZgJQOa6iKCQ")]
    [DisplayName("Total Authorised Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAuthrsdAmt")]
    #endif
    [IsoXmlTag("TtlAuthrsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount TotalAuthorisedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount TotalAuthorisedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount TotalAuthorisedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount TotalAuthorisedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_YXa0ba4PEeWZgJQOa6iKCQ")]
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
    /// Amounts of the deposit transaction.
    /// </summary>
    [IsoId("_YXa0b64PEeWZgJQOa6iKCQ")]
    [DisplayName("Detailed Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldReqdAmt")]
    #endif
    [IsoXmlTag("DtldReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount16? DetailedRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount16? DetailedRequestedAmount { get; init; } 
    #else
    public DetailedAmount16? DetailedRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_YXa0ca4PEeWZgJQOa6iKCQ")]
    [DisplayName("Additional Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlChrg")]
    #endif
    [IsoXmlTag("AddtlChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount13? AdditionalCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount13? AdditionalCharge { get; init; } 
    #else
    public DetailedAmount13? AdditionalCharge { get; set; } 
    #endif
    
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    [IsoId("_MCVRkK4QEeWZgJQOa6iKCQ")]
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
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    [IsoId("_TNzZwK4QEeWZgJQOa6iKCQ")]
    [DisplayName("Receipt Printed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctPrtd")]
    #endif
    [IsoXmlTag("RctPrtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiptPrinted { get; init; } 
    #else
    public System.String? ReceiptPrinted { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the deposit authorisation.
    /// </summary>
    [IsoId("_YXa0c64PEeWZgJQOa6iKCQ")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult13? AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Deposited media put in the safe.
    /// </summary>
    [IsoId("_asex0K4QEeWZgJQOa6iKCQ")]
    [DisplayName("Deposited Media")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstdMdia")]
    #endif
    [IsoXmlTag("DpstdMdia")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMDepositedMedia1? DepositedMedia { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMDepositedMedia1? DepositedMedia { get; init; } 
    #else
    public ATMDepositedMedia1? DepositedMedia { get; set; } 
    #endif
    
    /// <summary>
    /// Media unit not put in the safe. These deposits have to be reconciliated.
    /// </summary>
    [IsoId("_nqGe0K4QEeWZgJQOa6iKCQ")]
    [DisplayName("To Be Reconciled Media Counters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToBeRcncldMdiaCntrs")]
    #endif
    [IsoXmlTag("ToBeRcncldMdiaCntrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMDepositedMedia3? ToBeReconciledMediaCounters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMDepositedMedia3? ToBeReconciledMediaCounters { get; init; } 
    #else
    public ATMDepositedMedia3? ToBeReconciledMediaCounters { get; set; } 
    #endif
    
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_9m6UYK4QEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMTtls")]
    #endif
    [IsoXmlTag("ATMTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTotals1? ATMTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTotals1? ATMTotals { get; init; } 
    #else
    public ATMTotals1? ATMTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the cassettes of the ATM.
    /// </summary>
    [IsoId("_BIZeIK4REeWZgJQOa6iKCQ")]
    [DisplayName("Cassette")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Csstt")]
    #endif
    [IsoXmlTag("Csstt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCassette2? Cassette { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCassette2? Cassette { get; init; } 
    #else
    public ATMCassette2? Cassette { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_YXa0da4PEeWZgJQOa6iKCQ")]
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
