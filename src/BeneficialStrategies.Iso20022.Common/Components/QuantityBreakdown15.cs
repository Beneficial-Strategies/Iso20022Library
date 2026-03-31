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
[IsoId("_19hFYf_qEeCiHMrKuf9tBw")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown15
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_19hFZ__qEeCiHMrKuf9tBw")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public required GenericIdentification37 LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_19hFcf_qEeCiHMrKuf9tBw")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; }
}
