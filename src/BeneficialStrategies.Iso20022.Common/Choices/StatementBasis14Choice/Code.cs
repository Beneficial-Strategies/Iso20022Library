// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatementBasis14Choice
{
    /// <summary>
    /// Statement basis expressed as code.
    /// </summary>
    [IsoId("_dOSH0MRyEeij-rSPpvD-Tw")]
    [DisplayName("Code")]
    public partial record Code : StatementBasis14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the basis on which the statement is prepared expressed as a code.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StatementBasis3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
