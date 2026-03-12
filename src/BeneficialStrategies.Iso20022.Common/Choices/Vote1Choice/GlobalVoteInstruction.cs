// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Vote1Choice
{
    /// <summary>
    /// Instruction specifiying a vote instruction per resolution for the entire entitlement.
    /// </summary>
    [IsoId("_Rb-Mydp-Ed-ak6NoX_4Aeg_4446117")]
    [DisplayName("Global Vote Instruction")]
    public partial record GlobalVoteInstruction : Vote1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Numbering of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_TK_TV9p-Ed-ak6NoX_4Aeg_696615862")]
        [DisplayName("Issuer Label")]
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text IssuerLabel { get; init; } 
        
        /// <summary>
        /// Specifies the different instructions which can be used to vote.
        /// </summary>
        [IsoId("_TK_TWNp-Ed-ak6NoX_4Aeg_1196241389")]
        [DisplayName("Vote Option")]
        [IsoXmlTag("VoteOptn")]
        public required VoteInstruction2Code VoteOption { get; init; } 
        
        
        #nullable disable
        
    }
}
