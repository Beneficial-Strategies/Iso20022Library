// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction51.
/// </summary>
[IsoId("_-8zlsaE2Ee-MRKYsaX6JDg")]
[DisplayName("ATM Transaction51")]
public partial record ATMTransaction51
{
    #nullable enable

    /// <summary>
    /// Additional Charge.
    /// </summary>
    [DisplayName("Additional Charge")]
    [IsoXmlTag("AddtlChrg")]
    public ValueList<DetailedAmount13> AdditionalCharge { get; init; } = [];

    /// <summary>
    /// ATM Totals.
    /// </summary>
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ValueList<ATMTotals4> ATMTotals { get; init; } = [];

    /// <summary>
    /// Authorisation Result.
    /// </summary>
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult20? AuthorisationResult { get; init; } 

    /// <summary>
    /// Cassette.
    /// </summary>
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ValueList<ATMCassette3> Cassette { get; init; } = [];

    /// <summary>
    /// Detailed Requested Amount.
    /// </summary>
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount16? DetailedRequestedAmount { get; init; } 

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 

    /// <summary>
    /// Incident.
    /// </summary>
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public ValueList<FailureReason9Code> Incident { get; init; } = [];

    /// <summary>
    /// Incident Detail.
    /// </summary>
    [DisplayName("Incident Detail")]
    [IsoXmlTag("IncdntDtl")]
    public ValueList<IsoMax70Text> IncidentDetail { get; init; } = [];

    /// <summary>
    /// Receipt Printed.
    /// </summary>
    [DisplayName("Receipt Printed")]
    [IsoXmlTag("RctPrtd")]
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; } 

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 

    /// <summary>
    /// Requested Receipt.
    /// </summary>
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 

    /// <summary>
    /// Sub Deposit.
    /// </summary>
    [DisplayName("Sub Deposit")]
    [IsoXmlTag("SubDpst")]
    public ValueList<ATMDepositComponent1> SubDeposit { get; init; } = [];

    /// <summary>
    /// To Be Reconciled Media Counters.
    /// </summary>
    [DisplayName("To Be Reconciled Media Counters")]
    [IsoXmlTag("ToBeRcncldMdiaCntrs")]
    public ValueList<ATMDepositedMedia4> ToBeReconciledMediaCounters { get; init; } = [];

    /// <summary>
    /// Total Authorised Amount.
    /// </summary>
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public ValueList<ImpliedCurrencyAndAmount> TotalAuthorisedAmount { get; init; } = [];

    /// <summary>
    /// Total Deposited Amount.
    /// </summary>
    [DisplayName("Total Deposited Amount")]
    [IsoXmlTag("TtlDpstdAmt")]
    public ValueList<AmountAndCurrency1> TotalDepositedAmount { get; init; } = [];

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

    /// <summary>
    /// Transaction Status.
    /// </summary>
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 

    
    #nullable disable
    
}
