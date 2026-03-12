// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Cleared23Choice
{
    /// <summary>
    /// Indicates that the contract has not been cleared.
    /// </summary>
    [IsoId("_zX2RZQtuEe2eQ-C-GTDpFA")]
    [DisplayName("Non Cleared")]
    public partial record NonCleared : Cleared23Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
