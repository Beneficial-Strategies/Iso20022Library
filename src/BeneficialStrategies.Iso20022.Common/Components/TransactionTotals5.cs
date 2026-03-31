// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total of credit or debit transactions.
/// </summary>
[IsoId("_xVxxEXu-EeSLmfFG0DG7zQ")]
[DisplayName("Transaction Totals")]
public record TransactionTotals5
{
    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// </summary>
    [IsoId("_FRyMgHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Number of all financial transactions.
    /// </summary>
    [IsoId("_Jv4vgHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Number { get; init; }

    /// <summary>
    /// Cumulative amount of all chargeback transactions exclusive of any fees.
    /// </summary>
    [IsoId("_OZXcEHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Charge Back Amount")]
    [IsoXmlTag("ChrgBckAmt")]
    public required ImpliedCurrencyAndAmount ChargeBackAmount { get; init; }

    /// <summary>
    /// Total number of chargeback transactions.
    /// </summary>
    [IsoId("_RTCX4Hu_EeSLmfFG0DG7zQ")]
    [DisplayName("Charge Back Number")]
    [IsoXmlTag("ChrgBckNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ChargeBackNumber { get; init; }

    /// <summary>
    /// Cumulative amount of all reversal transactions exclusive of any fees.
    /// </summary>
    [IsoId("_WkGo4Hu_EeSLmfFG0DG7zQ")]
    [DisplayName("Reversal Amount")]
    [IsoXmlTag("RvslAmt")]
    public required ImpliedCurrencyAndAmount ReversalAmount { get; init; }

    /// <summary>
    /// Total number of reversal transactions.
    /// </summary>
    [IsoId("_ZPLIAHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Reversal Number")]
    [IsoXmlTag("RvslNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ReversalNumber { get; init; }

    /// <summary>
    /// Sum amount of all fees.
    /// </summary>
    [IsoId("_efytEHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Fee Amounts")]
    [IsoXmlTag("FeeAmts")]
    public ImpliedCurrencyAndAmount? FeeAmounts { get; init; }
}
