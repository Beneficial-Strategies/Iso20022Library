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
[IsoId("_U1YYmtp-Ed-ak6NoX_4Aeg_-666628245")]
[DisplayName("Price Report")]
public record PriceReport1
{
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_U1iJkNp-Ed-ak6NoX_4Aeg_-621374829")]
    [DisplayName("Price Valuation Details")]
    [IsoXmlTag("PricValtnDtls")]
    public ValueList<PriceValuation2> PriceValuationDetails { get; init; } = [];

    // ID for the above is _U1iJkNp-Ed-ak6NoX_4Aeg_-621374829

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U1iJkdp-Ed-ak6NoX_4Aeg_-622300758")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
