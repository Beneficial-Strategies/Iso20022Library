// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus8Choice
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_Vl2wJ5NSEeWGlc8L7oPDIg")]
    [DisplayName("Consented")]
    public partial record Consented : ResponseStatus8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
