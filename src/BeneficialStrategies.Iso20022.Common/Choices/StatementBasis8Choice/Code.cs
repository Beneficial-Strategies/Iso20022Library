// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatementBasis8Choice
{
    /// <summary>
    /// Statement basis expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_bZQ9MTp-EeWVrPy0StzzSg")]
    [DisplayName("Code")]
    public partial record Code : StatementBasis8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of balances on which the statement is prepared.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StatementBasis2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
