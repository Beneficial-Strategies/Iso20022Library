// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity6Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be turned.
    /// </summary>
    [IsoId("_dJcclzi8Eeydid5dcNPKvg")]
    [DisplayName("Turned Quantity")]
    public partial record TurnedQuantity : PairedOrTurnedQuantity6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
