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
[IsoId("_duebxTi8Eeydid5dcNPKvg")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown75
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_duebyTi8Eeydid5dcNPKvg")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification39? LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_dueb0Ti8Eeydid5dcNPKvg")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public FinancialInstrumentQuantity36Choice_? LotQuantity { get; init; }

    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_dueb2Ti8Eeydid5dcNPKvg")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification47? SecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_dueb2zi8Eeydid5dcNPKvg")]
    [DisplayName("Lot Date Time")]
    [IsoXmlTag("LotDtTm")]
    public DateAndDateTime2Choice_? LotDateTime { get; init; }

    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_dueb4zi8Eeydid5dcNPKvg")]
    [DisplayName("Lot Price")]
    [IsoXmlTag("LotPric")]
    public Price3? LotPrice { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_dueb6zi8Eeydid5dcNPKvg")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice32Choice_? TypeOfPrice { get; init; }
}
