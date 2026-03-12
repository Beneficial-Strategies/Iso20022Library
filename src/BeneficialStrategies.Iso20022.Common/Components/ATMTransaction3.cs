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
[IsoId("_UGw1MYqQEeSRT5rEzcAHEw")]
[DisplayName("ATM Transaction")]
public partial record ATMTransaction3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_US2wcYqQEeSRT5rEzcAHEw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    [IsoId("_cBZekIqSEeSRT5rEzcAHEw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 
    
    /// <summary>
    /// Multi bundle dispense.
    /// </summary>
    [IsoId("_ksoJUIqSEeSRT5rEzcAHEw")]
    [DisplayName("Multi Bundle")]
    [IsoXmlTag("MultiBndl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MultiBundle { get; init; } 
    
    /// <summary>
    /// Amount per bundle in the currency of the total presented amount, in the order of the presentation.
    /// </summary>
    [IsoId("_r6HqwIqSEeSRT5rEzcAHEw")]
    [DisplayName("Bundle Presented Amount")]
    [IsoXmlTag("BndlPresntdAmt")]
    public ImpliedCurrencyAndAmount? BundlePresentedAmount { get; init; } 
    
    /// <summary>
    /// Status of the amount presented to the customer in the last bundle.
    /// </summary>
    [IsoId("_HPYywIqTEeSRT5rEzcAHEw")]
    [DisplayName("Presented Amount Status")]
    [IsoXmlTag("PresntdAmtSts")]
    public required ATMTransactionStatus2Code PresentedAmountStatus { get; init; } 
    
    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    [IsoId("_FvzZ4IqUEeSRT5rEzcAHEw")]
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public FailureReason4Code? Incident { get; init; } 
    
    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    [IsoId("_nDZfgCvMEeW-qbryg71zJw")]
    [DisplayName("Incident Detail")]
    [IsoXmlTag("IncdntDtl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? IncidentDetail { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_US2wc4qQEeSRT5rEzcAHEw")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_US2wd4qQEeSRT5rEzcAHEw")]
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount5? AccountData { get; init; } 
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_US2weYqQEeSRT5rEzcAHEw")]
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    
    /// <summary>
    /// Total amount presented to the customer.
    /// </summary>
    [IsoId("_OWn7MIqTEeSRT5rEzcAHEw")]
    [DisplayName("Total Presented Amount")]
    [IsoXmlTag("TtlPresntdAmt")]
    public required AmountAndCurrency1 TotalPresentedAmount { get; init; } 
    
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    [IsoId("_Ee0z8CyXEeWFrdXv6dBUzw")]
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public ImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; } 
    
    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_N0UjsCyXEeWFrdXv6dBUzw")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    
    /// <summary>
    /// Detail of the requested amounts for the withdrawal transaction.
    /// </summary>
    [IsoId("_cS8JYCyXEeWFrdXv6dBUzw")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    
    /// <summary>
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    [IsoId("_US2wf4qQEeSRT5rEzcAHEw")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion4? CurrencyConversion { get; init; } 
    
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_kdrWMCyXEeWFrdXv6dBUzw")]
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public DetailedAmount13? AdditionalCharge { get; init; } 
    
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    [IsoId("_5c4goIqcEeS4a4abTJTSSw")]
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    
    /// <summary>
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    [IsoId("_8qrSUIqcEeS4a4abTJTSSw")]
    [DisplayName("Receipt Printed")]
    [IsoXmlTag("RctPrtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; } 
    
    /// <summary>
    /// True when the card was captured by the ATM.
    /// </summary>
    [IsoId("__LMHQIqcEeS4a4abTJTSSw")]
    [DisplayName("Captured Card")]
    [IsoXmlTag("CaptrdCard")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CapturedCard { get; init; } 
    
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    [IsoId("_US2wfYqQEeSRT5rEzcAHEw")]
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts2? Limits { get; init; } 
    
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    [IsoId("_US2whYqQEeSRT5rEzcAHEw")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult9? AuthorisationResult { get; init; } 
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_US2wh4qQEeSRT5rEzcAHEw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_eMdm8IqdEeS4a4abTJTSSw")]
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ATMTotals1? ATMTotals { get; init; } 
    
    /// <summary>
    /// Information on the cassettes of the ATM.
    /// </summary>
    [IsoId("_FSoUsIqfEeS4a4abTJTSSw")]
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ATMCassette1? Cassette { get; init; } 
    
    
    #nullable disable
    
}
