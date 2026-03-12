// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to the deposit request.
/// </summary>
[IsoId("_YM1VAa4PEeWZgJQOa6iKCQ")]
[DisplayName("ATM Transaction")]
public partial record ATMTransaction19
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_YXa0Ya4PEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    [IsoId("_lv87wK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_YXa0Y64PEeWZgJQOa6iKCQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    [IsoId("_tR7fcK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public FailureReason7Code? Incident { get; init; } 
    
    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    [IsoId("_wxbsMK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Incident Detail")]
    [IsoXmlTag("IncdntDtl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? IncidentDetail { get; init; } 
    
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_YXa0Z64PEeWZgJQOa6iKCQ")]
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount8? AccountData { get; init; } 
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_YXa0aa4PEeWZgJQOa6iKCQ")]
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    
    /// <summary>
    /// Total amount deposed by the customer.
    /// </summary>
    [IsoId("_ANP58K4QEeWZgJQOa6iKCQ")]
    [DisplayName("Total Deposited Amount")]
    [IsoXmlTag("TtlDpstdAmt")]
    public required AmountAndCurrency1 TotalDepositedAmount { get; init; } 
    
    /// <summary>
    /// Total authorised amount of the deposit transaction.
    /// </summary>
    [IsoId("_YXa0a64PEeWZgJQOa6iKCQ")]
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public required ImpliedCurrencyAndAmount TotalAuthorisedAmount { get; init; } 
    
    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_YXa0ba4PEeWZgJQOa6iKCQ")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    
    /// <summary>
    /// Amounts of the deposit transaction.
    /// </summary>
    [IsoId("_YXa0b64PEeWZgJQOa6iKCQ")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount16? DetailedRequestedAmount { get; init; } 
    
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_YXa0ca4PEeWZgJQOa6iKCQ")]
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public DetailedAmount13? AdditionalCharge { get; init; } 
    
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    [IsoId("_MCVRkK4QEeWZgJQOa6iKCQ")]
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    
    /// <summary>
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    [IsoId("_TNzZwK4QEeWZgJQOa6iKCQ")]
    [DisplayName("Receipt Printed")]
    [IsoXmlTag("RctPrtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; } 
    
    /// <summary>
    /// Outcome of the deposit authorisation.
    /// </summary>
    [IsoId("_YXa0c64PEeWZgJQOa6iKCQ")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    
    /// <summary>
    /// Deposited media put in the safe.
    /// </summary>
    [IsoId("_asex0K4QEeWZgJQOa6iKCQ")]
    [DisplayName("Deposited Media")]
    [IsoXmlTag("DpstdMdia")]
    public ATMDepositedMedia1? DepositedMedia { get; init; } 
    
    /// <summary>
    /// Media unit not put in the safe. These deposits have to be reconciliated.
    /// </summary>
    [IsoId("_nqGe0K4QEeWZgJQOa6iKCQ")]
    [DisplayName("To Be Reconciled Media Counters")]
    [IsoXmlTag("ToBeRcncldMdiaCntrs")]
    public ATMDepositedMedia3? ToBeReconciledMediaCounters { get; init; } 
    
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_9m6UYK4QEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ATMTotals1? ATMTotals { get; init; } 
    
    /// <summary>
    /// Information on the cassettes of the ATM.
    /// </summary>
    [IsoId("_BIZeIK4REeWZgJQOa6iKCQ")]
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ATMCassette2? Cassette { get; init; } 
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_YXa0da4PEeWZgJQOa6iKCQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    
    #nullable disable
    
}
