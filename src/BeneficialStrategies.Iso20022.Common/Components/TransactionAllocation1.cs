// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITransactionAllocation1"/>
[IsoId("_GlhY8GdWEe6jWPHmQqpKMw")]
[DisplayName("Transaction Allocation1")]
public partial record TransactionAllocation1
{
    /// <inheritdoc cref="ITransactionAllocation1.Account"/>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount40 Account { get; init; }

    /// <inheritdoc cref="ITransactionAllocation1.Amount"/>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="ITransactionAllocation1.CreditDebitIndicator"/>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <inheritdoc cref="ITransactionAllocation1.Purpose"/>
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public required Purpose2Choice_ Purpose { get; init; }

    /// <inheritdoc cref="ITransactionAllocation1.Reference"/>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IsoMax35Text Reference { get; init; }

    /// <inheritdoc cref="ITransactionAllocation1.RelatedReferences"/>
    [DisplayName("Related References")]
    [IsoXmlTag("RltdRefs")]
    public ValueList<References74Choice_> RelatedReferences { get; init; } = [];
}
