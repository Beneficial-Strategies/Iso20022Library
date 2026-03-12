// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the notional quantity of the underlying assets.
/// </summary>
[IsoId("_Wc1UsSJFEe2zWP9pqvmqdw")]
[DisplayName("Notional Quantity Legs")]
public partial record NotionalQuantityLegs5
{
    #nullable enable
    
    /// <summary>
    /// Aggregate notional quantity of the underlying asset of leg 1 for the term of the transaction. Where the total notional quantity is not known when a new transaction is reported, the total notional quantity is updated as it becomes available. 
    /// </summary>
    [IsoId("_WdpNASJFEe2zWP9pqvmqdw")]
    [DisplayName("First Leg")]
    [IsoXmlTag("FrstLeg")]
    public NotionalQuantity9? FirstLeg { get; init; } 
    
    /// <summary>
    /// Aggregate notional quantity of the underlying asset of leg 2 for the term of the transaction. Where the total notional quantity is not known when a new transaction is reported, the total notional quantity is updated as it becomes available. 
    /// </summary>
    [IsoId("_WdpNAyJFEe2zWP9pqvmqdw")]
    [DisplayName("Second Leg")]
    [IsoXmlTag("ScndLeg")]
    public NotionalQuantity9? SecondLeg { get; init; } 
    
    
    #nullable disable
    
}
