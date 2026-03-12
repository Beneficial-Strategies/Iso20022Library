// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus70Choice
{
    /// <summary>
    /// Specifies the processing status of the instruction in a coded format.
    /// </summary>
    [IsoId("_mXWx0eGHEeWCAvUNsZ5u6g")]
    [DisplayName("Code")]
    public partial record Code : ProcessingStatus70Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransactionProcessingStatus4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
