// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: Amount price per amount.||Example:|ISIN US629377AS17. Repurchase USD1087.17 cash for every USD1000 stock (NRG Energy Inc 8% Senior Notes 15/12/13).
/// </summary>
[IsoId("_QbAfAtp-Ed-ak6NoX_4Aeg_-795428506")]
[DisplayName("Amount Price Per Amount")]
public record AmountPricePerAmount1
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_QbAfA9p-Ed-ak6NoX_4Aeg_-512832907")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; }

    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QbAfBNp-Ed-ak6NoX_4Aeg_-512832899")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }

    /// <summary>
    /// The amount.
    /// </summary>
    [IsoId("_QbAfBdp-Ed-ak6NoX_4Aeg_-510984913")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }
}
