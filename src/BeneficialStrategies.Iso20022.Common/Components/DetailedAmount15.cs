// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("__KPDEZZ8EeWuSaWgzo19MQ")]
[DisplayName("Detailed Amount")]
public record DetailedAmount15
{
    /// <summary>
    /// Amount of purchase goods and services without tax.
    /// </summary>
    [IsoId("_MknkkJZ9EeWuSaWgzo19MQ")]
    [DisplayName("Amount Goods And Services")]
    [IsoXmlTag("AmtGoodsAndSvcs")]
    public ImpliedCurrencyAndAmount? AmountGoodsAndServices { get; init; }

    /// <summary>
    /// Cash-back amount.
    /// </summary>
    [IsoId("__WKmQZZ8EeWuSaWgzo19MQ")]
    [DisplayName("Cash Back")]
    [IsoXmlTag("CshBck")]
    public ImpliedCurrencyAndAmount? CashBack { get; init; }

    /// <summary>
    /// Gratuity amount.
    /// </summary>
    [IsoId("__WKmQ5Z8EeWuSaWgzo19MQ")]
    [DisplayName("Gratuity")]
    [IsoXmlTag("Grtty")]
    public ImpliedCurrencyAndAmount? Gratuity { get; init; }

    /// <summary>
    /// Fees amount.
    /// </summary>
    [IsoId("__WKmRZZ8EeWuSaWgzo19MQ")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public ValueList<DetailedAmount4> Fees { get; init; } = [];

    /// <summary>
    /// Global rebate of the transaction. This amount is counted as a negative amount.
    /// </summary>
    [IsoId("__WKmR5Z8EeWuSaWgzo19MQ")]
    [DisplayName("Rebate")]
    [IsoXmlTag("Rbt")]
    public ValueList<DetailedAmount4> Rebate { get; init; } = [];

    /// <summary>
    /// Value added tax amount.
    /// </summary>
    [IsoId("__WKmSZZ8EeWuSaWgzo19MQ")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public ValueList<DetailedAmount4> ValueAddedTax { get; init; } = [];

    /// <summary>
    /// Additional charge paid by the cardholder. For example airline credit card surcharge.
    /// </summary>
    [IsoId("__WKmS5Z8EeWuSaWgzo19MQ")]
    [DisplayName("Surcharge")]
    [IsoXmlTag("Srchrg")]
    public ValueList<DetailedAmount4> Surcharge { get; init; } = [];
}
