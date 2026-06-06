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
[IsoId("_A8of8WP5EfCX7uJiAWHfoQ")]
[DisplayName("Transaction Totals15")]
public record TransactionTotals15
{
    /// <summary>
    /// Identification of the reconciliation.
    /// </summary>
    [IsoId("_BAE1gWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Date of the reconciliation.
    /// </summary>
    [IsoId("_BAE1g2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// A value used to allow a period within a reconciliation date.
    /// </summary>
    [IsoId("_BAE1hWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Checkpoint Reference")]
    [IsoXmlTag("ChckptRef")]
    public IsoMax35Text? CheckpointReference { get; init; }

    /// <summary>
    /// Total of credit transactions.
    /// </summary>
    [IsoId("_BAE1h2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Financial")]
    [IsoXmlTag("Fin")]
    public ValueList<FinancialReconciliation4> Financial { get; init; } = [];

    /// <summary>
    /// Contains total message count.
    /// </summary>
    [IsoId("_BAE1iWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Message")]
    [IsoXmlTag("Msg")]
    public ValueList<MessageReconciliation4> Message { get; init; } = [];

    /// <summary>
    /// Contains additional fee reconciliation data.
    /// </summary>
    [IsoId("_BAE1i2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Additional Fee Reconciliation")]
    [IsoXmlTag("AddtlFeeRcncltn")]
    public ValueList<AdditionalFeeReconciliation4> AdditionalFeeReconciliation { get; init; } = [];

    /// <summary>
    /// Currency of the transaction.
    /// </summary>
    [IsoId("_BAE1jWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ISO3NumericCurrencyCode Currency { get; init; }

    /// <summary>
    /// Net amount of reconciliation.
    /// </summary>
    [IsoId("_BAE1j2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Sign of the net reconciliation amount.
    /// </summary>
    [IsoId("_BAE1kWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
