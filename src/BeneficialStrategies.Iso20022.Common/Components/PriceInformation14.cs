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
[IsoId("_5W2yjZNLEeWGlc8L7oPDIg")]
[DisplayName("Price Information")]
public record PriceInformation14
{
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_5W2ykZNLEeWGlc8L7oPDIg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice33Choice_ Type { get; init; }

    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_5W2ymZNLEeWGlc8L7oPDIg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknown1Choice_ Value { get; init; }

    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_5W2yoZNLEeWGlc8L7oPDIg")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_5W2yqZNLEeWGlc8L7oPDIg")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification91? SourceOfPrice { get; init; }

    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_5W2ysZNLEeWGlc8L7oPDIg")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTimeChoice_? QuotationDate { get; init; }
}
