// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus3Choice
{
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_aeWNU1NUEeijdq8ilaxyOA")]
    [DisplayName("Pending Settlement")]
    public partial record PendingSettlement : TransferStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
