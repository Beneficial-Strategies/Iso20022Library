// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Element to define an equity instrument.
/// </summary>
[IsoId("_PVUIgWlNEeaLAKoEUNsD9g")]
[DisplayName("Equity Derivative")]
public partial record EquityDerivative2
{
    #nullable enable
    
    /// <summary>
    /// Underlying type of the equity derivative.
    /// </summary>
    [IsoId("_PeXW0WlNEeaLAKoEUNsD9g")]
    [DisplayName("Underlying Type")]
    [IsoXmlTag("UndrlygTp")]
    public required EquityDerivative3Choice_ UnderlyingType { get; init; } 
    
    /// <summary>
    /// Return parameter for the equity derivative.
    /// </summary>
    [IsoId("_PeXW02lNEeaLAKoEUNsD9g")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public EquityReturnParameter1Code? Parameter { get; init; } 
    
    
    #nullable disable
    
}
