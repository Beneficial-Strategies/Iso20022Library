// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatementBasis6Choice
{
    /// <summary>
    /// Statement basis expressed in coded form.
    /// </summary>
    [IsoId("_nAFOcfNBEeCuA5Tr22BnwA_129839687")]
    [DisplayName("Code")]
    public partial record Code : StatementBasis6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of balances on which the statement is prepared.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StatementBasis1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
