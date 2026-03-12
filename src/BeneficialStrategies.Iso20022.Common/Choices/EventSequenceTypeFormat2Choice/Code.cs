// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EventSequenceTypeFormat2Choice
{
    /// <summary>
    /// Type of an event sequence, in a coded format.
    /// </summary>
    [IsoId("_6UsaIfyVEeiKOe8GCUL1Lg")]
    [DisplayName("Code")]
    public partial record Code : EventSequenceTypeFormat2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the event is an interim or a final event in a series of successive events. 
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EventSequenceType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
