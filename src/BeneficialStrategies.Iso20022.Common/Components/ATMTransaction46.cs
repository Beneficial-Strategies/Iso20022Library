// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction46.
/// </summary>
[IsoId("_YCfF8aEREe-MRKYsaX6JDg")]
[DisplayName("ATM Transaction46")]
public partial record ATMTransaction46
{
    #nullable enable

    /// <summary>
    /// Account Data.
    /// </summary>
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount20? AccountData { get; init; } 

    /// <summary>
    /// Cash Dispensed.
    /// </summary>
    [DisplayName("Cash Dispensed")]
    [IsoXmlTag("CshDspnsd")]
    public IsoTrueFalseIndicator? CashDispensed { get; init; } 

    /// <summary>
    /// Currency Conversion Result.
    /// </summary>
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion32? CurrencyConversionResult { get; init; } 

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
    /// Requested Receipt.
    /// </summary>
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 

    /// <summary>
    /// Selected Mix.
    /// </summary>
    [DisplayName("Selected Mix")]
    [IsoXmlTag("SelctdMix")]
    public ValueList<ATMMediaMix1> SelectedMix { get; init; } = [];

    /// <summary>
    /// Selected Mix Type.
    /// </summary>
    [DisplayName("Selected Mix Type")]
    [IsoXmlTag("SelctdMixTp")]
    public IsoMax35Text? SelectedMixType { get; init; } 

    /// <summary>
    /// Total Requested Amount.
    /// </summary>
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public AmountAndCurrency1? TotalRequestedAmount { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier3 TransactionIdentification { get; init; } 

    
    #nullable disable
    
}
