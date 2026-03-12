// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Channel2Choice
{
    /// <summary>
    /// Specifies a channel by means of a code.
    /// </summary>
    [IsoId("_-FRIsBg2EeKnW4lR85q-0A")]
    [DisplayName("Code")]
    public partial record Code : Channel2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Communication method used for the transmission of documents.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CommunicationMethod3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
