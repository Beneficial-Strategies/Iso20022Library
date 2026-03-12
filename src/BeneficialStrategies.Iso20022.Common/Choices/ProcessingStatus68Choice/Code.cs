// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus68Choice
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_TMjAEeFWEeWIA4E9cYSxxQ")]
    [DisplayName("Code")]
    public partial record Code : ProcessingStatus68Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the processing status of a transaction (at account servicer level).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransactionProcessingStatus3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
