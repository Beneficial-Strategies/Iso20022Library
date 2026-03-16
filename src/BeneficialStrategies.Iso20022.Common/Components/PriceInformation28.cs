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
[IsoId("_UkvvcQgfEe2fOITqoTnSLQ")]
[DisplayName("Price Information")]
public record PriceInformation28
{
    /// <summary>
    /// Value of the price, for instance, as a currency and value.
    /// </summary>
    [IsoId("_U-XwYwgfEe2fOITqoTnSLQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required Price14 Value { get; init; }

    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_U-XwZQgfEe2fOITqoTnSLQ")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime1Choice_? QuotationDate { get; init; }

    /// <summary>
    /// Period during which the price of a security is determined (For outturn securities).
    /// </summary>
    [IsoId("_U-XwbQgfEe2fOITqoTnSLQ")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public DateTimePeriod1Choice_? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_U-XwbwgfEe2fOITqoTnSLQ")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification93? SourceOfPrice { get; init; }
}
