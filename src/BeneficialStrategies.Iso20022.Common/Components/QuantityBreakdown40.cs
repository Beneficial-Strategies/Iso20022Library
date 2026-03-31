// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
[IsoId("_5eUspJNLEeWGlc8L7oPDIg")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown40
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_5eUsppNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification39? LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_5eUsrpNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public Balance11? LotQuantity { get; init; }

    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_5eUstpNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Date Time")]
    [IsoXmlTag("LotDtTm")]
    public DateAndDateTimeChoice_? LotDateTime { get; init; }

    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_5eUsvpNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Price")]
    [IsoXmlTag("LotPric")]
    public Price3? LotPrice { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_5eUsxpNLEeWGlc8L7oPDIg")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice32Choice_? TypeOfPrice { get; init; }
}
