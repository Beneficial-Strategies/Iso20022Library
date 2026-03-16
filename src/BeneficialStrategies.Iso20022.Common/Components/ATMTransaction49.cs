// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction49.
/// </summary>
[IsoId("_tMMWsaEpEe-MRKYsaX6JDg")]
[DisplayName("ATM Transaction49")]
public partial record ATMTransaction49
{
    #nullable enable

    /// <summary>
    /// Account Data.
    /// </summary>
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount22? AccountData { get; init; } 

    /// <summary>
    /// Account Information.
    /// </summary>
    [DisplayName("Account Information")]
    [IsoXmlTag("AcctInf")]
    public ValueList<CardAccount18> AccountInformation { get; init; } = [];

    /// <summary>
    /// Additional Charge.
    /// </summary>
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public ValueList<DetailedAmount13> AdditionalCharge { get; init; } = [];

    /// <summary>
    /// Authorisation Result.
    /// </summary>
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult20 AuthorisationResult { get; init; } 

    /// <summary>
    /// Command.
    /// </summary>
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];

    /// <summary>
    /// Completion Required.
    /// </summary>
    [DisplayName("Completion Required")]
    [IsoXmlTag("CmpltnReqrd")]
    public IsoTrueFalseIndicator? CompletionRequired { get; init; } 

    /// <summary>
    /// Currency Conversion Eligibility.
    /// </summary>
    [DisplayName("Currency Conversion Eligibility")]
    [IsoXmlTag("CcyConvsElgblty")]
    public CurrencyConversion32? CurrencyConversionEligibility { get; init; } 

    /// <summary>
    /// Detailed Requested Amount.
    /// </summary>
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 

    /// <summary>
    /// Limits.
    /// </summary>
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts6? Limits { get; init; } 

    /// <summary>
    /// Mix.
    /// </summary>
    [DisplayName("Mix")]
    [IsoXmlTag("Mix")]
    public ValueList<ATMMediaMix1> Mix { get; init; } = [];

    /// <summary>
    /// Mix Type.
    /// </summary>
    [DisplayName("Mix Type")]
    [IsoXmlTag("MixTp")]
    public IsoMax35Text? MixType { get; init; } 

    /// <summary>
    /// Protected Account Data.
    /// </summary>
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; } 

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 

    /// <summary>
    /// Total Authorised Amount.
    /// </summary>
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 

    /// <summary>
    /// Total Requested Amount.
    /// </summary>
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier3 TransactionIdentification { get; init; } 

    
    #nullable disable
    
}
