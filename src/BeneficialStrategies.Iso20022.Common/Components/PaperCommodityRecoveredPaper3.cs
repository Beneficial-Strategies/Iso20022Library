// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Paper Commodity Recovered Paper3.
/// </summary>
[IsoId("_FE6GUeFeEe64Zfh-zMOIZQ")]
[DisplayName("Paper Commodity Recovered Paper3")]
public record PaperCommodityRecoveredPaper3
{
    /// <summary>
    /// Base Product.
    /// </summary>
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType8Code BaseProduct { get; init; }

    /// <summary>
    /// Sub Product.
    /// </summary>
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public AssetClassSubProductType50Code? SubProduct { get; init; }
}
