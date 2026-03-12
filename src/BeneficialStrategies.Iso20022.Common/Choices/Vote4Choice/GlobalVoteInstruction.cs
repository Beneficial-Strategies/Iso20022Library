// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Vote4Choice
{
    /// <summary>
    /// Instruction specifying a vote instruction per resolution for the entire entitlement.
    /// </summary>
    [IsoId("_Y98Lta4cEemG7MmivSuE5g")]
    [DisplayName("Global Vote Instruction")]
    public partial record GlobalVoteInstruction : Vote4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_ZRuqYa4cEemG7MmivSuE5g")]
        [DisplayName("Issuer Label")]
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text IssuerLabel { get; init; } 
        
        /// <summary>
        /// Vote instructed.
        /// </summary>
        [IsoId("_ZRuqY64cEemG7MmivSuE5g")]
        [DisplayName("Vote Option")]
        [IsoXmlTag("VoteOptn")]
        public required VoteInstructionType1Choice_ VoteOption { get; init; } 
        
        
        #nullable disable
        
    }
}
