// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IncentivePremiumType2Choice
{
    /// <summary>
    /// Quantity of votes per type of vote giving right to a premium.
    /// </summary>
    [IsoId("_vMYu8_NBEeqRfth943bvEA")]
    [DisplayName("Per Vote")]
    public partial record PerVote : IncentivePremiumType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Types of vote instruction allowed for resolutions to be voted on in general meeting.
        /// </summary>
        [IsoId("_joPWUPNBEeqRfth943bvEA")]
        [DisplayName("Vote Instruction Type")]
        [IsoXmlTag("VoteInstrTp")]
        public required VoteInstructionType1Choice_ VoteInstructionType { get; init; } 
        
        /// <summary>
        /// Quantity of vote expressed for the specified type of vote instruction.
        /// </summary>
        [IsoId("_n-JmoPNBEeqRfth943bvEA")]
        [DisplayName("Vote Quantity")]
        [IsoXmlTag("VoteQty")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber VoteQuantity { get; init; } 
        
        
        #nullable disable
        
    }
}
