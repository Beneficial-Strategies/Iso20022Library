// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity3Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off.
    /// </summary>
    [IsoId("_DzNR0ztCEeWRTLSN0i0tng")]
    [DisplayName("Paired Off Quantity")]
    public partial record PairedOffQuantity : PairedOrTurnedQuantity3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
