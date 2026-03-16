// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price96.
/// </summary>
[IsoId("_nLgeZZt3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Price96")]
public partial record CorporateActionPrice96
{
    #nullable enable

    /// <summary>
    /// First Bid Increment Price.
    /// </summary>
    [DisplayName("First Bid Increment Price")]
    [IsoXmlTag("FrstBidIncrmtPric")]
    public PriceFormat91Choice_? FirstBidIncrementPrice { get; init; } 

    /// <summary>
    /// Last Bid Increment Price.
    /// </summary>
    [DisplayName("Last Bid Increment Price")]
    [IsoXmlTag("LastBidIncrmtPric")]
    public PriceFormat91Choice_? LastBidIncrementPrice { get; init; } 

    /// <summary>
    /// Maximum Price.
    /// </summary>
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat91Choice_? MaximumPrice { get; init; } 

    /// <summary>
    /// Minimum Price.
    /// </summary>
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat91Choice_? MinimumPrice { get; init; } 

    
    #nullable disable
    
}
