// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction44.
/// </summary>
[IsoId("_f_z-UaEQEe-MRKYsaX6JDg")]
[DisplayName("ATM Transaction44")]
public partial record ATMTransaction44
{
    #nullable enable

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
    public AuthorisationResult20? AuthorisationResult { get; init; } 

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
    /// Deposited Media.
    /// </summary>
    [DisplayName("Deposited Media")]
    [IsoXmlTag("DpstdMdia")]
    public ValueList<ATMDepositedMedia4> DepositedMedia { get; init; } = [];

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 

    /// <summary>
    /// Sub Deposit.
    /// </summary>
    [DisplayName("Sub Deposit")]
    [IsoXmlTag("SubDpst")]
    public ValueList<ATMDepositComponent1> SubDeposit { get; init; } = [];

    /// <summary>
    /// Total Authorised Amount.
    /// </summary>
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public ValueList<AmountAndCurrency1> TotalAuthorisedAmount { get; init; } = [];

    /// <summary>
    /// Total Requested Amount.
    /// </summary>
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public ValueList<ImpliedCurrencyAndAmount> TotalRequestedAmount { get; init; } = [];

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier3 TransactionIdentification { get; init; } 

    
    #nullable disable
    
}
