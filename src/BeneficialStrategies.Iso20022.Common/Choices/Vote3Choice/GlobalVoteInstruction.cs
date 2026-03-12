// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Vote3Choice
{
    /// <summary>
    /// Instruction specifying a vote instruction per resolution for the entire entitlement.
    /// </summary>
    [IsoId("_iNq0xV66EeSjaerr_EM7AQ")]
    [DisplayName("Global Vote Instruction")]
    public partial record GlobalVoteInstruction : Vote3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Numbering of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_C_kSoV69EeSjaerr_EM7AQ")]
        [DisplayName("Issuer Label")]
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text IssuerLabel { get; init; } 
        
        /// <summary>
        /// Specifies the different instructions that can be used to vote.
        /// </summary>
        [IsoId("_C_kSo169EeSjaerr_EM7AQ")]
        [DisplayName("Vote Option")]
        [IsoXmlTag("VoteOptn")]
        public required VoteInstruction3Code VoteOption { get; init; } 
        
        
        #nullable disable
        
    }
}
