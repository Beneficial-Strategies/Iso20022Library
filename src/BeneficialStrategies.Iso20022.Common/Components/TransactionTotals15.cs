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
    [IsoId("_BAE1gWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    [IsoId("_BAE1g2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    [IsoId("_BAE1hWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Checkpoint Reference")]
    [IsoXmlTag("ChckptRef")]
    public IsoMax35Text? CheckpointReference { get; init; }

    [IsoId("_BAE1h2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Financial")]
    [IsoXmlTag("Fin")]
    public ValueList<FinancialReconciliation4> Financial { get; init; } = [];

    [IsoId("_BAE1iWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Message")]
    [IsoXmlTag("Msg")]
    public ValueList<MessageReconciliation4> Message { get; init; } = [];

    [IsoId("_BAE1i2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Additional Fee Reconciliation")]
    [IsoXmlTag("AddtlFeeRcncltn")]
    public ValueList<AdditionalFeeReconciliation4> AdditionalFeeReconciliation { get; init; } = [];

    [IsoId("_BAE1jWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ISO3NumericCurrencyCode Currency { get; init; }

    [IsoId("_BAE1j2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    [IsoId("_BAE1kWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
