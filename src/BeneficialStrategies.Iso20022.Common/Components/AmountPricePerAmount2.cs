// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: Amount price per amount.|Example:|ISIN US629377AS17. Repurchase USD1087.17 cash for every USD1000 stock (NRG Energy Inc 8% Senior Notes 15/12/13).
/// </summary>
[IsoId("_QaHHJdp-Ed-ak6NoX_4Aeg_-531423812")]
[DisplayName("Amount Price Per Amount")]
public record AmountPricePerAmount2
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_QaHHJtp-Ed-ak6NoX_4Aeg_-219272751")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1Code AmountPriceType { get; init; }

    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QaHHJ9p-Ed-ak6NoX_4Aeg_-219272726")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

    /// <summary>
    /// The amount on which the price is based.
    /// </summary>
    [IsoId("_QaHHKNp-Ed-ak6NoX_4Aeg_-219272709")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }
}
