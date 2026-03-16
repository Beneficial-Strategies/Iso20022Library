// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Allocation1.
/// </summary>
[IsoId("_GlhY8GdWEe6jWPHmQqpKMw")]
[DisplayName("Transaction Allocation1")]
public record TransactionAllocation1
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount40 Account { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Purpose.
    /// </summary>
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public required Purpose2Choice_ Purpose { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Related References.
    /// </summary>
    [DisplayName("Related References")]
    [IsoXmlTag("RltdRefs")]
    public ValueList<References74Choice_> RelatedReferences { get; init; } = [];
}
