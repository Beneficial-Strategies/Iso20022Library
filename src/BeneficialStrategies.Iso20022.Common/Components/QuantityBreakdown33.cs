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
[IsoId("_5NbJy5NLEeWGlc8L7oPDIg")]
[DisplayName("Quantity Breakdown")]
public record QuantityBreakdown33
{
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_5NbJzZNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public required GenericIdentification39 LotNumber { get; init; }

    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_5NbJ1ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public FinancialInstrumentQuantity15Choice_? LotQuantity { get; init; }
}
