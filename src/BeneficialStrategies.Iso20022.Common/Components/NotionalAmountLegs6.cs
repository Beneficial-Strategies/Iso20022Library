// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Notional Amount Legs6.
/// </summary>
[IsoId("_NNn4oRT0Ee61h9tfoUrWyw")]
[DisplayName("Notional Amount Legs6")]
public partial record NotionalAmountLegs6
{
    #nullable enable

    /// <summary>
    /// First Leg.
    /// </summary>
    [DisplayName("First Leg")]
    [IsoXmlTag("FrstLeg")]
    public NotionalAmount7? FirstLeg { get; init; } 

    /// <summary>
    /// Second Leg.
    /// </summary>
    [DisplayName("Second Leg")]
    [IsoXmlTag("ScndLeg")]
    public NotionalAmount7? SecondLeg { get; init; } 

    
    #nullable disable
    
}
