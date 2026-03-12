// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PlannedQuantity1Choice
{
    /// <summary>
    /// Planned quantity of financial instrument or lot of rights/warrants to be purchased.
    /// </summary>
    [IsoId("_1FFw4DF0EeGKkIZzgd38VA")]
    [DisplayName("Quantity")]
    public partial record Quantity : PlannedQuantity1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
