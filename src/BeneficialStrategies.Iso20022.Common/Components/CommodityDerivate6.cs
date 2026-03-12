// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transparency calculation specific details for an energy commodity.
/// </summary>
[IsoId("_e4TTIX5zEeasY4u9QTizPQ")]
[DisplayName("Commodity Derivate")]
public partial record CommodityDerivate6
{
    #nullable enable
    
    /// <summary>
    /// Place where the delivery and the cash settlement of the base product occurs.
    /// </summary>
    [IsoId("_fDBVYX5zEeasY4u9QTizPQ")]
    [DisplayName("Settlement Location")]
    [IsoXmlTag("SttlmLctn")]
    [IsoSimpleType(IsoSimpleType.Max25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    public required IsoMax25Text SettlementLocation { get; init; } 
    
    
    #nullable disable
    
}
