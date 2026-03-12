// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ParticipationMethod3Choice
{
    /// <summary>
    /// Method of participation in the general meeting vote expressed as a code.
    /// </summary>
    [IsoId("_XuYKkRrlEeyhRdHRjakS2w")]
    [DisplayName("Code")]
    public partial record Code : ParticipationMethod3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required VotingParticipationMethod3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
