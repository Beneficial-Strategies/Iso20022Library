// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies various prices of a corporate action.
/// </summary>
[IsoId("_o9HQ8RbTEeyroI8qKgB7Mg")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice72
{
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_pSRooxbTEeyroI8qKgB7Mg")]
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat44Choice_? MaximumPrice { get; init; }

    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_pSRoqxbTEeyroI8qKgB7Mg")]
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat44Choice_? MinimumPrice { get; init; }

    /// <summary>
    /// First acceptable price after the Minimum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_qXkcwhbTEeyroI8qKgB7Mg")]
    [DisplayName("First Bid Increment Price")]
    [IsoXmlTag("FrstBidIncrmtPric")]
    public PriceFormat44Choice_? FirstBidIncrementPrice { get; init; }

    /// <summary>
    /// Last acceptable price before the Maximum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_9r6bQRbTEeyroI8qKgB7Mg")]
    [DisplayName("Last Bid Increment Price")]
    [IsoXmlTag("LastBidIncrmtPric")]
    public PriceFormat44Choice_? LastBidIncrementPrice { get; init; }
}
