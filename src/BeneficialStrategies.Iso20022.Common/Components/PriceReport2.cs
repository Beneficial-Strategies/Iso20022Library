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
[IsoId("_RLuxUtp-Ed-ak6NoX_4Aeg_166863578")]
[DisplayName("Price Report")]
public record PriceReport2
{
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_RLuxU9p-Ed-ak6NoX_4Aeg_167787161")]
    [DisplayName("Price Valuation Details")]
    [IsoXmlTag("PricValtnDtls")]
    public ValueList<PriceValuation3> PriceValuationDetails { get; init; } = [];

    // ID for the above is _RLuxU9p-Ed-ak6NoX_4Aeg_167787161

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RLuxVNp-Ed-ak6NoX_4Aeg_166864214")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
