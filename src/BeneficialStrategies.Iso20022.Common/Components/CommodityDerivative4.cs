// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transparency calculation specific details for an commodity derivatives.
/// </summary>
[IsoId("_exiPYU-nEeiVsYLJl6hleg")]
[DisplayName("Commodity Derivative")]
public partial record CommodityDerivative4
{
    #nullable enable
    
    /// <summary>
    /// Provides specific information related to commodity derivatives.
    /// </summary>
    [IsoId("_e8jMkU-nEeiVsYLJl6hleg")]
    [DisplayName("Class Specific")]
    [IsoXmlTag("ClssSpcfc")]
    public CommodityDerivative2Choice_? ClassSpecific { get; init; } 
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_e8jMk0-nEeiVsYLJl6hleg")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    
    
    #nullable disable
    
}
