// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ParticipationMethod1Choice
{
    /// <summary>
    /// Method of participation in the general meeting vote expressed as a code.
    /// </summary>
    [IsoId("_vfpIwK31EemG7MmivSuE5g")]
    [DisplayName("Code")]
    public partial record Code : ParticipationMethod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a method for participating to the voting of agenda resolutions in a general meeting.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required VotingParticipationMethod1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
