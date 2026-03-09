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
/// Withdrawal transaction for which the completion is sent.
/// </summary>
[IsoId("_9LnHMa4KEeWZgJQOa6iKCQ")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction17( TransactionIdentifier1 reqTransactionIdentification,ATMTransactionStatus1Code reqTransactionStatus,ATMTransactionStatus2Code reqPresentedAmountStatus,AmountAndCurrency1 reqTotalPresentedAmount )
    {
        TransactionIdentification = reqTransactionIdentification;
        TransactionStatus = reqTransactionStatus;
        PresentedAmountStatus = reqPresentedAmountStatus;
        TotalPresentedAmount = reqTotalPresentedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_9XiDUa4KEeWZgJQOa6iKCQ")]
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
    [IsoId("_9XrNQa4KEeWZgJQOa6iKCQ")]
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
    /// Multi bundle dispense.
    /// </summary>
    [IsoId("_9XrNQ64KEeWZgJQOa6iKCQ")]
    [DisplayName("Multi Bundle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MultiBndl")]
    #endif
    [IsoXmlTag("MultiBndl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MultiBundle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MultiBundle { get; init; } 
    #else
    public System.String? MultiBundle { get; set; } 
    #endif
    
    /// <summary>
    /// Amount per bundle in the currency of the total presented amount, in the order of the presentation.
    /// </summary>
    [IsoId("_9XrNRa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Bundle Presented Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BndlPresntdAmt")]
    #endif
    [IsoXmlTag("BndlPresntdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? BundlePresentedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? BundlePresentedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? BundlePresentedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the amount presented to the customer in the last bundle.
    /// </summary>
    [IsoId("_9XrNR64KEeWZgJQOa6iKCQ")]
    [DisplayName("Presented Amount Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntdAmtSts")]
    #endif
    [IsoXmlTag("PresntdAmtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMTransactionStatus2Code PresentedAmountStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMTransactionStatus2Code PresentedAmountStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionStatus2Code PresentedAmountStatus { get; init; } 
    #else
    public ATMTransactionStatus2Code PresentedAmountStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    [IsoId("_9XrNSa4KEeWZgJQOa6iKCQ")]
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
    [IsoId("_9XrNS64KEeWZgJQOa6iKCQ")]
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
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_9XrNTa4KEeWZgJQOa6iKCQ")]
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
    /// Unprotected account information.
    /// </summary>
    [IsoId("_9XrNT64KEeWZgJQOa6iKCQ")]
    [DisplayName("Account Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctData")]
    #endif
    [IsoXmlTag("AcctData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount11? AccountData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount11? AccountData { get; init; } 
    #else
    public CardAccount11? AccountData { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_9XrNUa4KEeWZgJQOa6iKCQ")]
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
    /// Total amount presented to the customer.
    /// </summary>
    [IsoId("_9XrNU64KEeWZgJQOa6iKCQ")]
    [DisplayName("Total Presented Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPresntdAmt")]
    #endif
    [IsoXmlTag("TtlPresntdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndCurrency1 TotalPresentedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndCurrency1 TotalPresentedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrency1 TotalPresentedAmount { get; init; } 
    #else
    public AmountAndCurrency1 TotalPresentedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    [IsoId("_9XrNVa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Total Authorised Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAuthrsdAmt")]
    #endif
    [IsoXmlTag("TtlAuthrsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_9XrNV64KEeWZgJQOa6iKCQ")]
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
    /// Detail of the requested amounts for the withdrawal transaction.
    /// </summary>
    [IsoId("_9XrNWa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Detailed Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldReqdAmt")]
    #endif
    [IsoXmlTag("DtldReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    #else
    public DetailedAmount12? DetailedRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    [IsoId("_9XrNW64KEeWZgJQOa6iKCQ")]
    [DisplayName("Currency Conversion Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsRslt")]
    #endif
    [IsoXmlTag("CcyConvsRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion9? CurrencyConversionResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion9? CurrencyConversionResult { get; init; } 
    #else
    public CurrencyConversion9? CurrencyConversionResult { get; set; } 
    #endif
    
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_9XrNXa4KEeWZgJQOa6iKCQ")]
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
    [IsoId("_9XrNX64KEeWZgJQOa6iKCQ")]
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
    [IsoId("_9XrNYa4KEeWZgJQOa6iKCQ")]
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
    /// Explicit consent expressed by a customer on a card-related service proposed by an acquirer or an issuer or any agent acting on behalf of one of them.
    /// </summary>
    [IsoId("_TySUgPysEeWVMqALyuondw")]
    [DisplayName("Customer Consent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrCnsnt")]
    #endif
    [IsoXmlTag("CstmrCnsnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerConsent { get; init; } 
    #else
    public System.String? CustomerConsent { get; set; } 
    #endif
    
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    [IsoId("_9XrNZa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Limits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lmts")]
    #endif
    [IsoXmlTag("Lmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTransactionAmounts6? Limits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionAmounts6? Limits { get; init; } 
    #else
    public ATMTransactionAmounts6? Limits { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    [IsoId("_9XrNZ64KEeWZgJQOa6iKCQ")]
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
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_9XrNaa4KEeWZgJQOa6iKCQ")]
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
    
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_9XrNa64KEeWZgJQOa6iKCQ")]
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
    [IsoId("_9XrNba4KEeWZgJQOa6iKCQ")]
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
    
    
    #nullable disable
    
}
