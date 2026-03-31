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
[IsoId("_ee_EgddnEeispNOuywCdbA")]
[DisplayName("Price Information")]
public record PriceInformation21
{
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_eyBVQ9dnEeispNOuywCdbA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice48Choice_ Type { get; init; }

    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_eyBVS9dnEeispNOuywCdbA")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; }

    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_eyBVU9dnEeispNOuywCdbA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknown2Choice_ Value { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_eyLGQddnEeispNOuywCdbA")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification89? SourceOfPrice { get; init; }

    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_eyLGSddnEeispNOuywCdbA")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime2Choice_? QuotationDate { get; init; }
}
