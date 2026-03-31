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
[IsoId("_k6N0ofFoEd-Vb-3Q5jpLDA")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown9
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_k6N0o_FoEd-Vb-3Q5jpLDA")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public Number2Choice_? LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_k6N0pfFoEd-Vb-3Q5jpLDA")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; }

    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_AzNUwfFpEd-Vb-3Q5jpLDA")]
    [DisplayName("Securities Sub Balance Type")]
    [IsoXmlTag("SctiesSubBalTp")]
    public GenericIdentification19? SecuritiesSubBalanceType { get; init; }

    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_k6N0p_FoEd-Vb-3Q5jpLDA")]
    [DisplayName("Lot Date Time")]
    [IsoXmlTag("LotDtTm")]
    public DateAndDateTimeChoice_? LotDateTime { get; init; }

    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_k6N0qfFoEd-Vb-3Q5jpLDA")]
    [DisplayName("Lot Price")]
    [IsoXmlTag("LotPric")]
    public Price2? LotPrice { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_k6N0q_FoEd-Vb-3Q5jpLDA")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; }
}
