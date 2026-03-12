// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the monetary or converted amount for the derivatives transaction.
/// </summary>
[IsoId("_k1n04WEfEe2P-L9DBerEgA")]
[DisplayName("Notional Amount Legs")]
public partial record NotionalAmountLegs5
{
    #nullable enable
    
    /// <summary>
    /// Notional amount of leg 1 which indicates monetary or converted amount for the derivatives transaction.
    /// </summary>
    [IsoId("_k2hMwWEfEe2P-L9DBerEgA")]
    [DisplayName("First Leg")]
    [IsoXmlTag("FrstLeg")]
    public NotionalAmount5? FirstLeg { get; init; } 
    
    /// <summary>
    /// Notional amount of leg 2 which indicates monetary or converted amount for the derivatives transaction.
    /// </summary>
    [IsoId("_k2hMw2EfEe2P-L9DBerEgA")]
    [DisplayName("Second Leg")]
    [IsoXmlTag("ScndLeg")]
    public NotionalAmount6? SecondLeg { get; init; } 
    
    
    #nullable disable
    
}
