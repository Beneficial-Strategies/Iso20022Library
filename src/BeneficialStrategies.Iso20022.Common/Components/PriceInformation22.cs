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
[IsoId("_Z0yAm_fVEeiNZp_PtLohLw")]
[DisplayName("Price Information")]
public record PriceInformation22
{
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_Z0yAn_fVEeiNZp_PtLohLw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice33Choice_ Type { get; init; }

    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_Z0yAp_fVEeiNZp_PtLohLw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknown3Choice_ Value { get; init; }

    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_Z0yAr_fVEeiNZp_PtLohLw")]
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_Z0yAt_fVEeiNZp_PtLohLw")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification91? SourceOfPrice { get; init; }

    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_Z0yAv_fVEeiNZp_PtLohLw")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime2Choice_? QuotationDate { get; init; }
}
