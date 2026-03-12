// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus6Choice
{
    /// <summary>
    /// Rejected status of an instruction, advice or request.
    /// </summary>
    [IsoId("_mdrUkzzpEeWeNtT0s2RbkQ")]
    [DisplayName("Rejected")]
    public partial record Rejected : ResponseStatus6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
