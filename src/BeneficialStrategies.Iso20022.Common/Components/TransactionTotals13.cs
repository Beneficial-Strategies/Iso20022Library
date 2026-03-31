// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals of the reconciliation.
/// </summary>
[IsoId("_QtX6MZMjEeuleeHpFMMhmQ")]
[DisplayName("Transaction Totals")]
public record TransactionTotals13
{
    /// <summary>
    /// Date and identification of reconciliation.
    /// </summary>
    [IsoId("_Q0DxAZMjEeuleeHpFMMhmQ")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; }

    /// <summary>
    /// Total of credit transactions.
    /// </summary>
    [IsoId("_Q0DxA5MjEeuleeHpFMMhmQ")]
    [DisplayName("Financial Reconciliation")]
    [IsoXmlTag("FinRcncltn")]
    public ValueList<FinancialReconciliation2> FinancialReconciliation { get; init; } = [];

    /// <summary>
    /// Contains total message count.
    /// </summary>
    [IsoId("_Q0DxBZMjEeuleeHpFMMhmQ")]
    [DisplayName("Message Reconciliation")]
    [IsoXmlTag("MsgRcncltn")]
    public ValueList<MessageReconciliation3> MessageReconciliation { get; init; } = [];

    /// <summary>
    /// Contains additional fee reconciliation data.
    /// </summary>
    [IsoId("_Q0DxB5MjEeuleeHpFMMhmQ")]
    [DisplayName("Additional Fee Reconciliation")]
    [IsoXmlTag("AddtlFeeRcncltn")]
    public ValueList<AdditionalFeeReconciliation2> AdditionalFeeReconciliation { get; init; } = [];

    /// <summary>
    /// Currency of the transaction.
    /// </summary>
    [IsoId("_Q0DxCZMjEeuleeHpFMMhmQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public required IsoMin2Max3NumericText Currency { get; init; }

    /// <summary>
    /// Net amount of reconciliation.
    /// ISO 8583:87/93 bit 97
    /// </summary>
    [IsoId("_Q0DxC5MjEeuleeHpFMMhmQ")]
    [DisplayName("Net Amount Reconciliation")]
    [IsoXmlTag("NetAmtRcncltn")]
    public Amount16? NetAmountReconciliation { get; init; }
}
