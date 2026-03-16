// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Paper Commodity Recovered Paper3.
/// </summary>
[IsoId("_FE6GUeFeEe64Zfh-zMOIZQ")]
[DisplayName("Paper Commodity Recovered Paper3")]
public partial record PaperCommodityRecoveredPaper3
{
    #nullable enable

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

    
    #nullable disable
    
}
