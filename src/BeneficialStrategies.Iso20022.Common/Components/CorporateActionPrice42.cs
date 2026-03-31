// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices of a corporate action.
/// </summary>
[IsoId("_B6p5oSXoEeO4bIO_HtGo9Q")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice42
{
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_CSnGoyXoEeO4bIO_HtGo9Q")]
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat23Choice_? MaximumPrice { get; init; }

    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_CSwQkSXoEeO4bIO_HtGo9Q")]
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat23Choice_? MinimumPrice { get; init; }
}
