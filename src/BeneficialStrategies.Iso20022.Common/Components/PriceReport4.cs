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
[IsoId("3d9c790d-ff3d-4d0c-a885-31c66f3e7965")]
[DisplayName("Price Report4")]
public record PriceReport4
{
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("471c0639-6026-45ca-9690-3ece2afe4e30")]
    [DisplayName("Price Valuation Details")]
    [IsoXmlTag("PricValtnDtls")]
    [MinLength(1)]
    public ValueList<PriceValuation5> PriceValuationDetails { get; init; } = [];
}
