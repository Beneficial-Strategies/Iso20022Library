// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_QeScg9p-Ed-ak6NoX_4Aeg_1124078643")]
[DisplayName("Price Information")]
public record PriceInformation6
{
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_QeSchNp-Ed-ak6NoX_4Aeg_1010239577")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice6Choice_ Type { get; init; }

    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_QeSchdp-Ed-ak6NoX_4Aeg_13167224")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QeSchtp-Ed-ak6NoX_4Aeg_-1162023801")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknownChoice_ Value { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_QeSch9p-Ed-ak6NoX_4Aeg_-1867138416")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification6? SourceOfPrice { get; init; }

    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_QebmcNp-Ed-ak6NoX_4Aeg_-221870981")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTimeChoice_? QuotationDate { get; init; }
}
