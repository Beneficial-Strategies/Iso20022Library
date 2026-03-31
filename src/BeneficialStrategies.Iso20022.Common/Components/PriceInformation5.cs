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
[IsoId("_QebmdNp-Ed-ak6NoX_4Aeg_-1444606274")]
[DisplayName("Price Information")]
public record PriceInformation5
{
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_Qebmddp-Ed-ak6NoX_4Aeg_-671252004")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice4Choice_ Type { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_Qebmdtp-Ed-ak6NoX_4Aeg_200661161")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknownChoice_ Value { get; init; }

    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_Qebmd9p-Ed-ak6NoX_4Aeg_1853288669")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_QebmeNp-Ed-ak6NoX_4Aeg_-796411192")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification6? SourceOfPrice { get; init; }

    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_Qebmedp-Ed-ak6NoX_4Aeg_742377250")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTimeChoice_? QuotationDate { get; init; }
}
