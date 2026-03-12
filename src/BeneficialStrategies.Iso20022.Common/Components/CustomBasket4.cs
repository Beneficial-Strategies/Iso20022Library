// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of constituents for a basket of indexes.
/// </summary>
[IsoId("_muRycVo2Ee23K4GXSpBSeg")]
[DisplayName("Custom Basket")]
public partial record CustomBasket4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the structurer of the customer basket.
    /// </summary>
    [IsoId("_mv1RoVo2Ee23K4GXSpBSeg")]
    [DisplayName("Structurer")]
    [IsoXmlTag("Strr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? Structurer { get; init; } 
    
    /// <summary>
    /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
    /// </summary>
    [IsoId("_mv1Ro1o2Ee23K4GXSpBSeg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? Identification { get; init; } 
    
    /// <summary>
    /// Identifier of the underliers that represent the constituents of a custom basket.
    /// </summary>
    [IsoId("_mv1RpVo2Ee23K4GXSpBSeg")]
    [DisplayName("Constituents")]
    [IsoXmlTag("Cnsttnts")]
    public BasketConstituents3? Constituents { get; init; } 
    
    
    #nullable disable
    
}
