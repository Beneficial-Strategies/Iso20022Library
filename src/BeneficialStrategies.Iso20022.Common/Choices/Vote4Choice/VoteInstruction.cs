// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Vote4Choice
{
    /// <summary>
    /// Instruction specifying the instructed quantity of voting rights per resolution. Split votes can be indicated. If only one type of decision is indicated, the number of votes cast must not be adjusted if the position of the voting party increases.
    /// </summary>
    [IsoId("_Y98Ls64cEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction")]
    public partial record VoteInstruction : Vote4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_bVfaI6-WEemJ1NnLPsTFaw")]
        [DisplayName("Issuer Label")]
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text IssuerLabel { get; init; } 
        
        /// <summary>
        /// Number of votes in favour of one resolution.
        /// </summary>
        [IsoId("_bVfaJa-WEemJ1NnLPsTFaw")]
        [DisplayName("For")]
        [IsoXmlTag("For")]
        public QuantityOrCode1Choice_? For { get; init; } 
        
        /// <summary>
        /// Number of votes against one resolution.
        /// </summary>
        [IsoId("_bVfaJ6-WEemJ1NnLPsTFaw")]
        [DisplayName("Against")]
        [IsoXmlTag("Agnst")]
        public QuantityOrCode1Choice_? Against { get; init; } 
        
        /// <summary>
        /// Number of abstention votes for one resolution.
        /// </summary>
        [IsoId("_bVfaKa-WEemJ1NnLPsTFaw")]
        [DisplayName("Abstain")]
        [IsoXmlTag("Abstn")]
        public QuantityOrCode1Choice_? Abstain { get; init; } 
        
        /// <summary>
        /// Number of votes withheld for one resolution.
        /// </summary>
        [IsoId("_bVfaK6-WEemJ1NnLPsTFaw")]
        [DisplayName("Withhold")]
        [IsoXmlTag("Wthhld")]
        public QuantityOrCode1Choice_? Withhold { get; init; } 
        
        /// <summary>
        /// Number of votes in line with the votes of the management.
        /// </summary>
        [IsoId("_bVfaLa-WEemJ1NnLPsTFaw")]
        [DisplayName("With Management")]
        [IsoXmlTag("WthMgmt")]
        public QuantityOrCode1Choice_? WithManagement { get; init; } 
        
        /// <summary>
        /// Number of votes against the voting recommendation of the management.
        /// </summary>
        [IsoId("_bVfaL6-WEemJ1NnLPsTFaw")]
        [DisplayName("Against Management")]
        [IsoXmlTag("AgnstMgmt")]
        public QuantityOrCode1Choice_? AgainstManagement { get; init; } 
        
        /// <summary>
        /// Number of votes for which decision is left to the party that will exercise the voting right.
        /// </summary>
        [IsoId("_bVfaMa-WEemJ1NnLPsTFaw")]
        [DisplayName("Discretionary")]
        [IsoXmlTag("Dscrtnry")]
        public QuantityOrCode1Choice_? Discretionary { get; init; } 
        
        /// <summary>
        /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
        /// </summary>
        [IsoId("_bVfaM6-WEemJ1NnLPsTFaw")]
        [DisplayName("One Year")]
        [IsoXmlTag("OneYr")]
        public QuantityOrCode1Choice_? OneYear { get; init; } 
        
        /// <summary>
        /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
        /// </summary>
        [IsoId("_bVfaNa-WEemJ1NnLPsTFaw")]
        [DisplayName("Two Years")]
        [IsoXmlTag("TwoYrs")]
        public QuantityOrCode1Choice_? TwoYears { get; init; } 
        
        /// <summary>
        /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
        /// </summary>
        [IsoId("_bVfaN6-WEemJ1NnLPsTFaw")]
        [DisplayName("Three Years")]
        [IsoXmlTag("ThreeYrs")]
        public QuantityOrCode1Choice_? ThreeYears { get; init; } 
        
        /// <summary>
        /// Do not vote.
        /// </summary>
        [IsoId("_bVfaOa-WEemJ1NnLPsTFaw")]
        [DisplayName("No Action")]
        [IsoXmlTag("NoActn")]
        public QuantityOrCode1Choice_? NoAction { get; init; } 
        
        /// <summary>
        /// Vote is cast as empty but the vote is counted.
        /// </summary>
        [IsoId("_EnkbQK-XEemJ1NnLPsTFaw")]
        [DisplayName("Blank")]
        [IsoXmlTag("Blnk")]
        public QuantityOrCode1Choice_? Blank { get; init; } 
        
        /// <summary>
        /// Other type of vote expressed as a proprietary code.
        /// </summary>
        [IsoId("_tkrR8K-XEemJ1NnLPsTFaw")]
        [DisplayName("Proprietary")]
        [IsoXmlTag("Prtry")]
        [MinLength(0)]
        [MaxLength(4)]
        public ValueList<ProprietaryVote1> Proprietary { get; init; } = [];
        
        
        #nullable disable
        
    }
}
