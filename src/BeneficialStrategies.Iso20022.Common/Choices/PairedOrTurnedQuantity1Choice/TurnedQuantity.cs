// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity1Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be turned.
    /// </summary>
    [IsoId("_UdsRVdp-Ed-ak6NoX_4Aeg_508111545")]
    [DisplayName("Turned Quantity")]
    public partial record TurnedQuantity : PairedOrTurnedQuantity1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
