// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderStatus3Choice
{
    /// <summary>
    /// Status of all the orders in the order message is suspended.
    /// </summary>
    [IsoId("_vIDnaUH7EeaV3ab_pHzFIQ")]
    [DisplayName("Suspended")]
    public partial record Suspended : OrderStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
