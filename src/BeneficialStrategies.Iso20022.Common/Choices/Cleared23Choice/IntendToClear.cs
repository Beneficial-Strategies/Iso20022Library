// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Cleared23Choice
{
    /// <summary>
    /// Indicates that the contract is intended to be cleared.
    /// </summary>
    [IsoId("_zX2RYwtuEe2eQ-C-GTDpFA")]
    [DisplayName("Intend To Clear")]
    public partial record IntendToClear : Cleared23Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
