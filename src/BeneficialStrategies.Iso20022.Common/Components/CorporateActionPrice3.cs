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
[IsoId("_TZcmFtp-Ed-ak6NoX_4Aeg_-910030421")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice3
{
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_TZcmF9p-Ed-ak6NoX_4Aeg_-910030396")]
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat11Choice_? MaximumPrice { get; init; }

    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_TZcmGNp-Ed-ak6NoX_4Aeg_-910030379")]
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat11Choice_? MinimumPrice { get; init; }
}
