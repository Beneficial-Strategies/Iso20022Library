// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction50.
/// </summary>
[IsoId("_GqGUcaEqEe-MRKYsaX6JDg")]
[DisplayName("ATM Transaction50")]
public partial record ATMTransaction50
{
    #nullable enable

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
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public AmountAndCurrency1? TotalAmount { get; init; } 

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
