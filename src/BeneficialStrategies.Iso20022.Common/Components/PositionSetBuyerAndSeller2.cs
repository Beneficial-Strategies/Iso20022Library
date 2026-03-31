// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set Buyer And Seller2.
/// </summary>
[IsoId("_7KNIxRTuEe61h9tfoUrWyw")]
[DisplayName("Position Set Buyer And Seller2")]
public record PositionSetBuyerAndSeller2
{
    /// <summary>
    /// Buyer.
    /// </summary>
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PositionSetTotal2? Buyer { get; init; }

    /// <summary>
    /// Seller.
    /// </summary>
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public PositionSetTotal2? Seller { get; init; }
}
