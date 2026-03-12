// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus8Choice
{
    /// <summary>
    /// Rejected status of an instruction, advice or request.
    /// </summary>
    [IsoId("_Vl2wKZNSEeWGlc8L7oPDIg")]
    [DisplayName("Rejected")]
    public partial record Rejected : ResponseStatus8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
