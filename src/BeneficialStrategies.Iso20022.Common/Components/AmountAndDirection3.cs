// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_SVo_t9p-Ed-ak6NoX_4Aeg_-1470222118")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection3
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_SVo_uNp-Ed-ak6NoX_4Aeg_-1434202561")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_SVywsNp-Ed-ak6NoX_4Aeg_-1412039409")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public required CreditDebitCode CreditDebit { get; init; }
}
