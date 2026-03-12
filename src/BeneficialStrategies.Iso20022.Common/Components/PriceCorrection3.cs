// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original and corrected price information of an investment fund.
/// </summary>
[IsoId("_RLuxVdp-Ed-ak6NoX_4Aeg_993416543")]
[DisplayName("Price Correction")]
public partial record PriceCorrection3
{
    #nullable enable
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument sent in a previous price report.
    /// </summary>
    [IsoId("_RLuxVtp-Ed-ak6NoX_4Aeg_993416821")]
    [DisplayName("Previously Sent Price Details")]
    [IsoXmlTag("PrevslySntPricDtls")]
    public required PriceValuation3 PreviouslySentPriceDetails { get; init; } 
    
    /// <summary>
    /// Information related to the new price valuation of a financial instrument, which overrides previously sent information.
    /// </summary>
    [IsoId("_RLuxV9p-Ed-ak6NoX_4Aeg_993416865")]
    [DisplayName("Corrected Price Details")]
    [IsoXmlTag("CrrctdPricDtls")]
    public PriceValuation3? CorrectedPriceDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RLuxWNp-Ed-ak6NoX_4Aeg_993416570")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
