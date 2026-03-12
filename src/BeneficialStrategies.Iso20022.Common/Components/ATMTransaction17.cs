// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal transaction for which the completion is sent.
/// </summary>
[IsoId("_9LnHMa4KEeWZgJQOa6iKCQ")]
[DisplayName("ATM Transaction")]
public partial record ATMTransaction17
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_9XiDUa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    [IsoId("_9XrNQa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 
    
    /// <summary>
    /// Multi bundle dispense.
    /// </summary>
    [IsoId("_9XrNQ64KEeWZgJQOa6iKCQ")]
    [DisplayName("Multi Bundle")]
    [IsoXmlTag("MultiBndl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MultiBundle { get; init; } 
    
    /// <summary>
    /// Amount per bundle in the currency of the total presented amount, in the order of the presentation.
    /// </summary>
    [IsoId("_9XrNRa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Bundle Presented Amount")]
    [IsoXmlTag("BndlPresntdAmt")]
    public ImpliedCurrencyAndAmount? BundlePresentedAmount { get; init; } 
    
    /// <summary>
    /// Status of the amount presented to the customer in the last bundle.
    /// </summary>
    [IsoId("_9XrNR64KEeWZgJQOa6iKCQ")]
    [DisplayName("Presented Amount Status")]
    [IsoXmlTag("PresntdAmtSts")]
    public required ATMTransactionStatus2Code PresentedAmountStatus { get; init; } 
    
    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    [IsoId("_9XrNSa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public FailureReason7Code? Incident { get; init; } 
    
    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    [IsoId("_9XrNS64KEeWZgJQOa6iKCQ")]
    [DisplayName("Incident Detail")]
    [IsoXmlTag("IncdntDtl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? IncidentDetail { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_9XrNTa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_9XrNT64KEeWZgJQOa6iKCQ")]
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount11? AccountData { get; init; } 
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_9XrNUa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    
    /// <summary>
    /// Total amount presented to the customer.
    /// </summary>
    [IsoId("_9XrNU64KEeWZgJQOa6iKCQ")]
    [DisplayName("Total Presented Amount")]
    [IsoXmlTag("TtlPresntdAmt")]
    public required AmountAndCurrency1 TotalPresentedAmount { get; init; } 
    
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    [IsoId("_9XrNVa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public ImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; } 
    
    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_9XrNV64KEeWZgJQOa6iKCQ")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    
    /// <summary>
    /// Detail of the requested amounts for the withdrawal transaction.
    /// </summary>
    [IsoId("_9XrNWa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    
    /// <summary>
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    [IsoId("_9XrNW64KEeWZgJQOa6iKCQ")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion9? CurrencyConversionResult { get; init; } 
    
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_9XrNXa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public DetailedAmount13? AdditionalCharge { get; init; } 
    
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    [IsoId("_9XrNX64KEeWZgJQOa6iKCQ")]
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    
    /// <summary>
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    [IsoId("_9XrNYa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Receipt Printed")]
    [IsoXmlTag("RctPrtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; } 
    
    /// <summary>
    /// Explicit consent expressed by a customer on a card-related service proposed by an acquirer or an issuer or any agent acting on behalf of one of them.
    /// </summary>
    [IsoId("_TySUgPysEeWVMqALyuondw")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    [IsoId("_9XrNZa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts6? Limits { get; init; } 
    
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    [IsoId("_9XrNZ64KEeWZgJQOa6iKCQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_9XrNaa4KEeWZgJQOa6iKCQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_9XrNa64KEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ATMTotals1? ATMTotals { get; init; } 
    
    /// <summary>
    /// Information on the cassettes of the ATM.
    /// </summary>
    [IsoId("_9XrNba4KEeWZgJQOa6iKCQ")]
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ATMCassette2? Cassette { get; init; } 
    
    
    #nullable disable
    
}
