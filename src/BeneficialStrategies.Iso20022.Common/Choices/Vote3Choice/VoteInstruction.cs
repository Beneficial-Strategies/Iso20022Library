// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Vote3Choice
{
    /// <summary>
    /// Instruction specifying the instructed quantity of voting rights per resolution. Split votes can be indicated. If only one type of decision is indicated, the number of votes cast must not be adjusted if the position of the voting party increases.
    /// </summary>
    [IsoId("_iNq0w166EeSjaerr_EM7AQ")]
    [DisplayName("Vote Instruction")]
    [IsoXmlTag("VoteInstr")]
    public record VoteInstruction : Vote3Choice_
    {
        /// <summary>
        /// Numbering of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_ipWEI166EeSjaerr_EM7AQ")]
        [DisplayName("Issuer Label")]
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text IssuerLabel { get; init; }

        /// <summary>
        /// Number of votes in favour of one resolution.
        /// </summary>
        [IsoId("_ipWEJV66EeSjaerr_EM7AQ")]
        [DisplayName("For")]
        [IsoXmlTag("For")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? For { get; init; }

        /// <summary>
        /// Number of votes against one resolution.
        /// </summary>
        [IsoId("_ipWEJ166EeSjaerr_EM7AQ")]
        [DisplayName("Against")]
        [IsoXmlTag("Agnst")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Against { get; init; }

        /// <summary>
        /// Number of votes expressed as abstain for one resolution.
        /// </summary>
        [IsoId("_ipWEKV66EeSjaerr_EM7AQ")]
        [DisplayName("Abstain")]
        [IsoXmlTag("Abstn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Abstain { get; init; }

        /// <summary>
        /// Number of votes withheld for one resolution.
        /// </summary>
        [IsoId("_ipWEK166EeSjaerr_EM7AQ")]
        [DisplayName("Withhold")]
        [IsoXmlTag("Wthhld")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Withhold { get; init; }

        /// <summary>
        /// Number of votes in line with the votes of the management.
        /// </summary>
        [IsoId("_ipWELV66EeSjaerr_EM7AQ")]
        [DisplayName("With Management")]
        [IsoXmlTag("WthMgmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? WithManagement { get; init; }

        /// <summary>
        /// Number of votes against the voting recommendation of the management.
        /// </summary>
        [IsoId("_ipWEL166EeSjaerr_EM7AQ")]
        [DisplayName("Against Management")]
        [IsoXmlTag("AgnstMgmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? AgainstManagement { get; init; }

        /// <summary>
        /// Number of votes for which decision is left to the party that will exercise the voting right.
        /// </summary>
        [IsoId("_ipWEMV66EeSjaerr_EM7AQ")]
        [DisplayName("Discretionary")]
        [IsoXmlTag("Dscrtnry")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Discretionary { get; init; }

        /// <summary>
        /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
        /// </summary>
        [IsoId("_8KEsYF66EeSjaerr_EM7AQ")]
        [DisplayName("One Year")]
        [IsoXmlTag("OneYr")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? OneYear { get; init; }

        /// <summary>
        /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
        /// </summary>
        [IsoId("_SgHhUF67EeSjaerr_EM7AQ")]
        [DisplayName("Two Years")]
        [IsoXmlTag("TwoYrs")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? TwoYears { get; init; }

        /// <summary>
        /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
        /// </summary>
        [IsoId("_aA05sF67EeSjaerr_EM7AQ")]
        [DisplayName("Three Years")]
        [IsoXmlTag("ThreeYrs")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? ThreeYears { get; init; }

        /// <summary>
        /// Number of votes for which no action has been taken.
        /// </summary>
        [IsoId("_ipWEM166EeSjaerr_EM7AQ")]
        [DisplayName("No Action")]
        [IsoXmlTag("NoActn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? NoAction { get; init; }
    }
}
