// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity attributes of a derivative where the type is multi commodity exotic.
/// </summary>
[IsoId("_iNuUgFr0EeWN79Bl6BUd3g")]
[DisplayName("Asset Class Commodity Multi Commodity Exotic")]
public partial record AssetClassCommodityMultiCommodityExotic1
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_6Eul4Fr0EeWN79Bl6BUd3g")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType13Code BaseProduct { get; init; } 
    
    
    #nullable disable
    
}
