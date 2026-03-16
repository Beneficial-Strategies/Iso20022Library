// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price expressed as an amount.
/// </summary>
[IsoId("_QaQ4J9p-Ed-ak6NoX_4Aeg_-1667090335")]
[DisplayName("Amount Price")]
public record AmountPrice3
{
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_QaQ4KNp-Ed-ak6NoX_4Aeg_-1667090318")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1Code AmountPriceType { get; init; }

    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QaQ4Kdp-Ed-ak6NoX_4Aeg_-1667090300")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; }
}
