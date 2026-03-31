// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a price report.
/// </summary>
[IsoId("_brky0RmCEeKxsrht2duUcg")]
[DisplayName("Price Report")]
public record PriceReport3
{
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_cAvKhRmCEeKxsrht2duUcg")]
    [DisplayName("Price Valuation Details")]
    [IsoXmlTag("PricValtnDtls")]
    public ValueList<PriceValuation4> PriceValuationDetails { get; init; } = [];
    // ID for the above is _cAvKhRmCEeKxsrht2duUcg
}
