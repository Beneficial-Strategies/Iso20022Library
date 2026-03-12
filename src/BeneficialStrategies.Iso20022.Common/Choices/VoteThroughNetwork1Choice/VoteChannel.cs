// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.VoteThroughNetwork1Choice
{
    /// <summary>
    /// Voting is performed via message sent through an alternate network channel, that is, either via the chain of intermediaries or via the channel as described in the processing text for next intermediary information field.
    /// </summary>
    [IsoId("_Cph1QDT8Ee2tRf29bleifQ")]
    [DisplayName("Vote Channel")]
    public partial record VoteChannel : VoteThroughNetwork1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the network channel through which the vote should be sent.
        /// </summary>
        [IsoXmlTag("VoteChanl")]
        public required VoteChannel1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
