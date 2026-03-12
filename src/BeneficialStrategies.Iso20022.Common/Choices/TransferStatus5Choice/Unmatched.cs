// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus5Choice
{
    /// <summary>
    /// Status of the transfer is unmatched.
    /// </summary>
    [IsoId("_WY1VReijEeuLe8v4JEtDDg")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : TransferStatus5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
