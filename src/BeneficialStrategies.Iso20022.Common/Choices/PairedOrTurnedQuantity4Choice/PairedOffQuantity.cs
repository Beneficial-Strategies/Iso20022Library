// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity4Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off.
    /// </summary>
    [IsoId("_5xlno5NLEeWGlc8L7oPDIg")]
    [DisplayName("Paired Off Quantity")]
    public partial record PairedOffQuantity : PairedOrTurnedQuantity4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
