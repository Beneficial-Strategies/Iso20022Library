// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction53.
/// </summary>
[IsoId("_eEG_caE4Ee-MRKYsaX6JDg")]
[DisplayName("ATM Transaction53")]
public record ATMTransaction53
{
    /// <summary>
    /// Account Data.
    /// </summary>
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount17? AccountData { get; init; }

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
    /// Bundle Presented Amount.
    /// </summary>
    [DisplayName("Bundle Presented Amount")]
    [IsoXmlTag("BndlPresntdAmt")]
    public ValueList<ImpliedCurrencyAndAmount> BundlePresentedAmount { get; init; } = [];

    /// <summary>
    /// Cassette.
    /// </summary>
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ValueList<ATMCassette3> Cassette { get; init; } = [];

    /// <summary>
    /// Currency Conversion Result.
    /// </summary>
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion32? CurrencyConversionResult { get; init; }

    /// <summary>
    /// Customer Consent.
    /// </summary>
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

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
    /// Limits.
    /// </summary>
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ATMTransactionAmounts6? Limits { get; init; }

    /// <summary>
    /// Multi Bundle.
    /// </summary>
    [DisplayName("Multi Bundle")]
    [IsoXmlTag("MultiBndl")]
    public IsoTrueFalseIndicator? MultiBundle { get; init; }

    /// <summary>
    /// Presented Amount Status.
    /// </summary>
    [DisplayName("Presented Amount Status")]
    [IsoXmlTag("PresntdAmtSts")]
    public required ATMTransactionStatus2Code PresentedAmountStatus { get; init; }

    /// <summary>
    /// Protected Account Data.
    /// </summary>
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; }

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
    /// Total Authorised Amount.
    /// </summary>
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public ImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; }

    /// <summary>
    /// Total Presented Amount.
    /// </summary>
    [DisplayName("Total Presented Amount")]
    [IsoXmlTag("TtlPresntdAmt")]
    public required AmountAndCurrency1 TotalPresentedAmount { get; init; }

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

    /// <summary>
    /// Transaction Status.
    /// </summary>
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required ATMTransactionStatus1Code TransactionStatus { get; init; }
}
