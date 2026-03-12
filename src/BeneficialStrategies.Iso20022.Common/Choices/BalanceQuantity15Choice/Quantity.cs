// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceQuantity15Choice
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_ch-MQTi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity")]
    public partial record Quantity : BalanceQuantity15Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
