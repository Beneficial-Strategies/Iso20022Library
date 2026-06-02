// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card account balance.
/// </summary>
[IsoId("_higIMRQTEfC1ZfCQz0xB3g")]
[DisplayName("Card Account Balance1")]
public record CardAccountBalance1
{
    /// <summary>
    /// Type of card account balance.
    /// </summary>
    [IsoId("_hp7l4RQTEfC1ZfCQz0xB3g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ISO8583AmountTypeCode Type { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_hp7l5RQTEfC1ZfCQz0xB3g")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency of the account.
    /// </summary>
    [IsoId("_hp7l5xQTEfC1ZfCQz0xB3g")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Indicates whether the value of the balance is positive or negative.
    /// </summary>
    [IsoId("_hp7l6RQTEfC1ZfCQz0xB3g")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Indicates whether the value of balance is expressed in the currency of the cardholder or not.
    /// </summary>
    [IsoId("_hp7l6xQTEfC1ZfCQz0xB3g")]
    [DisplayName("Cardholder Currency")]
    [IsoXmlTag("CrdhldrCcy")]
    public IsoTrueFalseIndicator? CardholderCurrency { get; init; }

    /// <summary>
    /// Date of the balance.
    /// </summary>
    [IsoId("_hp7l7RQTEfC1ZfCQz0xB3g")]
    [DisplayName("Balance Date")]
    [IsoXmlTag("BalDt")]
    public IsoISODate? BalanceDate { get; init; }
}
