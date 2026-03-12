// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus5Choice
{
    /// <summary>
    /// Status of the transfer is reversed.
    /// </summary>
    [IsoId("_WY1VT-ijEeuLe8v4JEtDDg")]
    [DisplayName("Reversed")]
    public partial record Reversed : TransferStatus5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
