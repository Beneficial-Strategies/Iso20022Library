// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommunicationMethod3Choice
{
    /// <summary>
    /// Method of transmission expressed as a code.
    /// </summary>
    [IsoId("_a0TYAggqEeSUG-8hqXsVMQ")]
    [DisplayName("Code")]
    public partial record Code : CommunicationMethod3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Communication method used for the transmission of documents.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CommunicationMethod1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
