// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity5Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off.
    /// </summary>
    [IsoId("_YcjksSqHEeyR9JrVGfaMKw")]
    [DisplayName("Paired Off Quantity")]
    public partial record PairedOffQuantity : PairedOrTurnedQuantity5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
