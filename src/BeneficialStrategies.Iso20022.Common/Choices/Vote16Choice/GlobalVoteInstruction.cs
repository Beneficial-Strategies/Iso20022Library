// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Vote16Choice
{
    /// <summary>
    /// Instruction specifying a vote instruction per resolution for the entire entitlement.
    /// </summary>
    [IsoId("_XbSml_NoEeqRfth943bvEA")]
    [DisplayName("Global Vote Instruction")]
    public record GlobalVoteInstruction : Vote16Choice_
    {
        /// <summary>
        /// Number of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_XuyKUfNoEeqRfth943bvEA")]
        [DisplayName("Issuer Label")]
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text IssuerLabel { get; init; }

        /// <summary>
        /// Vote instructed.
        /// </summary>
        [IsoId("_XuyKU_NoEeqRfth943bvEA")]
        [DisplayName("Vote Option")]
        [IsoXmlTag("VoteOptn")]
        public required VoteInstructionType2Choice_ VoteOption { get; init; }
    }
}
