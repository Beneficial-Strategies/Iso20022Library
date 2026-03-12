// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus60Choice
{
    /// <summary>
    /// Instruction/Request has been rejected for further processing.
    /// </summary>
    [IsoId("_6P-Ma5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus60Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
