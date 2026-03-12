// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderStatus4Choice
{
    /// <summary>
    /// Status of the switch order is in repair.
    /// </summary>
    [IsoId("_9wxHy0H8EeaV3ab_pHzFIQ")]
    [DisplayName("In Repair")]
    public partial record InRepair : OrderStatus4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
