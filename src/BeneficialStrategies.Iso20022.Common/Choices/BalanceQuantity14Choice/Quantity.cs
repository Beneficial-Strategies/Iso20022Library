// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceQuantity14Choice
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("__ZNdASp7EeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    public partial record Quantity : BalanceQuantity14Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
