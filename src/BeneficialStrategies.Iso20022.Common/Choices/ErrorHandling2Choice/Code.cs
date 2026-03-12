// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ErrorHandling2Choice
{
    /// <summary>
    /// Specification of the error, in coded form.
    /// </summary>
    [IsoId("_jwIVARbvEeOy-PlRuFSUzQ")]
    [DisplayName("Code")]
    public partial record Code : ErrorHandling2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Error codes generated when the response to a query exceeds the maximum size or the data is not available.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ErrorHandling1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
