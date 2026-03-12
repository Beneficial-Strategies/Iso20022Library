// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a paper derivative of type newsprint.
/// </summary>
[IsoId("_MIeJURZaEe2QNcZTDeoKnQ")]
[DisplayName("Paper Commodity Newsprint")]
public partial record PaperCommodityNewsprint2
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_MJVE8RZaEe2QNcZTDeoKnQ")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType8Code BaseProduct { get; init; } 
    
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_MJVE8xZaEe2QNcZTDeoKnQ")]
    [DisplayName("Sub Product")]
    [IsoXmlTag("SubPdct")]
    public AssetClassSubProductType36Code? SubProduct { get; init; } 
    
    
    #nullable disable
    
}
