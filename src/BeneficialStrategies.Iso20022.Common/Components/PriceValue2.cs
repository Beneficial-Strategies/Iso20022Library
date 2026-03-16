// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value given to a price.
/// </summary>
[IsoId("_Vb-eh9p-Ed-ak6NoX_4Aeg_390890355")]
[DisplayName("Price Value")]
public record PriceValue2
{
    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_Vb-eiNp-Ed-ak6NoX_4Aeg_-1145201803")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; }

    /// <summary>
    /// Price expressed as a rate, ie, percentage.
    /// </summary>
    [IsoId("_Vb-eidp-Ed-ak6NoX_4Aeg_-1071317691")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }
}
