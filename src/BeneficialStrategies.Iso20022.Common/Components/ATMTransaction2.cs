// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to the withdrawal transaction request.
/// </summary>
[IsoId("_xrLCMYp4EeS3NqNpgnMh2w")]
[DisplayName("ATM Transaction")]
public partial record ATMTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_x3F-U4p4EeS3NqNpgnMh2w")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_x3F-VYp4EeS3NqNpgnMh2w")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// True if a withdrawal completion advice has to be sent after the end of the transaction.
    /// </summary>
    [IsoId("_bDl74Ip5EeS3NqNpgnMh2w")]
    [DisplayName("Completion Required")]
    [IsoXmlTag("CmpltnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CompletionRequired { get; init; } 
    
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_x3F-V4p4EeS3NqNpgnMh2w")]
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount4? AccountData { get; init; } 
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_x3F-WYp4EeS3NqNpgnMh2w")]
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    [IsoId("_nbCDgCxoEeWFrdXv6dBUzw")]
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    
    /// <summary>
    /// Total requested amount.
    /// </summary>
    [IsoId("_u-pl8CxoEeWFrdXv6dBUzw")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    
    /// <summary>
    /// Detail of the requested amounts for the withdrawal transaction.
    /// </summary>
    [IsoId("_pXcKMCyGEeWFrdXv6dBUzw")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    
    /// <summary>
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    [IsoId("_x3F-X4p4EeS3NqNpgnMh2w")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion4? CurrencyConversion { get; init; } 
    
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    [IsoId("_6vQKkCyGEeWFrdXv6dBUzw")]
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public DetailedAmount13? AdditionalCharge { get; init; } 
    
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    [IsoId("_WidBEIp7EeS3NqNpgnMh2w")]
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts2? Limits { get; init; } 
    
    /// <summary>
    /// Media mix algorithm requested by the ATM Host, the identification of the algorithm is an agreement between the ATM and the ATM manager.
    /// </summary>
    [IsoId("_x3F-YYp4EeS3NqNpgnMh2w")]
    [DisplayName("Mix Type")]
    [IsoXmlTag("MixTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MixType { get; init; } 
    
    /// <summary>
    /// Media mix selected requested by the ATM Host.
    /// </summary>
    [IsoId("_x3F-Y4p4EeS3NqNpgnMh2w")]
    [DisplayName("Mix")]
    [IsoXmlTag("Mix")]
    public ATMMediaMix1? Mix { get; init; } 
    
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    [IsoId("_dfVeMIp8EeS3NqNpgnMh2w")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult9 AuthorisationResult { get; init; } 
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_x3F-Z4p4EeS3NqNpgnMh2w")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_NI69gIqJEeSRT5rEzcAHEw")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand1? Command { get; init; } 
    
    
    #nullable disable
    
}
