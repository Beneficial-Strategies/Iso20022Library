// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original and corrected price information of an investment fund.
/// </summary>
[IsoId("_U1YYltp-Ed-ak6NoX_4Aeg_243480882")]
[DisplayName("Price Correction")]
public record PriceCorrection2
{
    /// <summary>
    /// Information related to the price valuation of a financial instrument sent in a previous price report.
    /// </summary>
    [IsoId("_U1YYl9p-Ed-ak6NoX_4Aeg_243480943")]
    [DisplayName("Previously Sent Price Details")]
    [IsoXmlTag("PrevslySntPricDtls")]
    public required PriceValuation2 PreviouslySentPriceDetails { get; init; }

    /// <summary>
    /// Information related to the new price valuation of a financial instrument, which overrides previously sent information.
    /// </summary>
    [IsoId("_U1YYmNp-Ed-ak6NoX_4Aeg_243480909")]
    [DisplayName("Corrected Price Details")]
    [IsoXmlTag("CrrctdPricDtls")]
    public PriceValuation2? CorrectedPriceDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U1YYmdp-Ed-ak6NoX_4Aeg_-884858901")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
