// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatementBasis3Choice
{
    /// <summary>
    /// Statement basis expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QrsmZdp-Ed-ak6NoX_4Aeg_-997314468")]
    [DisplayName("Code")]
    public partial record Code : StatementBasis3Choice_
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
