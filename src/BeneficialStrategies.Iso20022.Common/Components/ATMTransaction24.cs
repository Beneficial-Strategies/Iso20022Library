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
[IsoId("_Ez0uka4zEeWpsoxRhdX-8A")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction24
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction24 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction24( TransactionIdentifier1 reqTransactionIdentification,ResponseType7 reqTransactionResponse,AmountAndCurrency1 reqTotalAuthorisedAmount )
    {
        TransactionIdentification = reqTransactionIdentification;
        TransactionResponse = reqTransactionResponse;
        TotalAuthorisedAmount = reqTotalAuthorisedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_E_40oa4zEeWpsoxRhdX-8A")]
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
    [IsoId("_E_40pa4zEeWpsoxRhdX-8A")]
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
    [IsoId("_E_40p64zEeWpsoxRhdX-8A")]
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
    [IsoId("_E_40qa4zEeWpsoxRhdX-8A")]
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
    /// Identifier of the approved transfer transaction for the bank.
    /// </summary>
    [IsoId("_dSkVYK4zEeWpsoxRhdX-8A")]
    [DisplayName("Transfer Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfIdr")]
    #endif
    [IsoXmlTag("TrfIdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TransferIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferIdentifier { get; init; } 
    #else
    public System.String? TransferIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the payment.
    /// </summary>
    [IsoId("_E_40q64zEeWpsoxRhdX-8A")]
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
    /// Result of the fund transfer request.
    /// </summary>
    [IsoId("_m6ZyUK4zEeWpsoxRhdX-8A")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType7 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType7 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType7 TransactionResponse { get; init; } 
    #else
    public ResponseType7 TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("_smZr0K4zEeWpsoxRhdX-8A")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action7? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action7? Action { get; init; } 
    #else
    public Action7? Action { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the source account of the transfer.
    /// </summary>
    [IsoId("_E_40ra4zEeWpsoxRhdX-8A")]
    [DisplayName("Account From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctFr")]
    #endif
    [IsoXmlTag("AcctFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount13? AccountFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount13? AccountFrom { get; init; } 
    #else
    public CardAccount13? AccountFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of the source account information.
    /// </summary>
    [IsoId("_E_40r64zEeWpsoxRhdX-8A")]
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
    [IsoId("_E_40sa4zEeWpsoxRhdX-8A")]
    [DisplayName("Account To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTo")]
    #endif
    [IsoXmlTag("AcctTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount13? AccountTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount13? AccountTo { get; init; } 
    #else
    public CardAccount13? AccountTo { get; set; } 
    #endif
    
    /// <summary>
    /// Encryption of the destination account information.
    /// </summary>
    [IsoId("_E_40s64zEeWpsoxRhdX-8A")]
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
    /// Total authorised amount.
    /// </summary>
    [IsoId("_lca78K40EeWpsoxRhdX-8A")]
    [DisplayName("Total Authorised Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAuthrsdAmt")]
    #endif
    [IsoXmlTag("TtlAuthrsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    #else
    public AmountAndCurrency1 TotalAuthorisedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_E_40ta4zEeWpsoxRhdX-8A")]
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
    [IsoId("_E_40t64zEeWpsoxRhdX-8A")]
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
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_vu1m8K40EeWpsoxRhdX-8A")]
    [DisplayName("Additional Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlChrg")]
    #endif
    [IsoXmlTag("AddtlChrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount18? AdditionalCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount18? AdditionalCharge { get; init; } 
    #else
    public DetailedAmount18? AdditionalCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    [IsoId("_MlN8YK41EeWpsoxRhdX-8A")]
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
    /// Requested date of the execution of the transfer.
    /// </summary>
    [IsoId("_E_40ua4zEeWpsoxRhdX-8A")]
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
    /// Proposed date of the execution of the transfer.
    /// </summary>
    [IsoId("_RhPxgK41EeWpsoxRhdX-8A")]
    [DisplayName("Proposed Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PropsdExctnDt")]
    #endif
    [IsoXmlTag("PropsdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ProposedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ProposedExecutionDate { get; init; } 
    #else
    public System.DateOnly? ProposedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the instant transfer program.
    /// </summary>
    [IsoId("_E_40u64zEeWpsoxRhdX-8A")]
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
    [IsoId("_E_40va4zEeWpsoxRhdX-8A")]
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
    /// Outcome of the transfer authorisation.
    /// </summary>
    [IsoId("_aHrb0K41EeWpsoxRhdX-8A")]
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
    [IsoId("_E_40wa4zEeWpsoxRhdX-8A")]
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
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_irfP8K41EeWpsoxRhdX-8A")]
    [DisplayName("Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmd")]
    #endif
    [IsoXmlTag("Cmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand7? Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand7? Command { get; init; } 
    #else
    public ATMCommand7? Command { get; set; } 
    #endif
    
    
    #nullable disable
    
}
