// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus6Choice
{
    /// <summary>
    /// Pending status of an instruction, advice or request.
    /// </summary>
    [IsoId("_mdrUlTzpEeWeNtT0s2RbkQ")]
    [DisplayName("Pending")]
    public partial record Pending : ResponseStatus6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
