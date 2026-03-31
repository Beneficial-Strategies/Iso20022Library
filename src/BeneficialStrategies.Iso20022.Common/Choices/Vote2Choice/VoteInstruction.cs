// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Vote2Choice
{
    /// <summary>
    /// Instruction specifying the instructed quantity of voting rights per resolution. Split votes can be indicated. If only one type of decision is indicated, the number of votes cast must not be adjusted if the position of the voting party increases.
    /// </summary>
    [IsoId("_RDPjutp-Ed-ak6NoX_4Aeg_116941373")]
    [DisplayName("Vote Instruction")]
    [IsoXmlTag("VoteInstr")]
    public record VoteInstruction : Vote2Choice_
    {
        /// <summary>
        /// Numbering of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_TK1iVNp-Ed-ak6NoX_4Aeg_62627585")]
        [DisplayName("Issuer Label")]
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text IssuerLabel { get; init; }

        /// <summary>
        /// Number of votes in favour of one resolution.
        /// </summary>
        [IsoId("_TK1iVdp-Ed-ak6NoX_4Aeg_62627600")]
        [DisplayName("For")]
        [IsoXmlTag("For")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? For { get; init; }

        /// <summary>
        /// Number of votes against one resolution.
        /// </summary>
        [IsoId("_TK1iVtp-Ed-ak6NoX_4Aeg_62627618")]
        [DisplayName("Against")]
        [IsoXmlTag("Agnst")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Against { get; init; }

        /// <summary>
        /// Number of votes expressed as abstain for one resolution.
        /// </summary>
        [IsoId("_TK_TUNp-Ed-ak6NoX_4Aeg_62627643")]
        [DisplayName("Abstain")]
        [IsoXmlTag("Abstn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Abstain { get; init; }

        /// <summary>
        /// Number of votes withheld for one resolution.
        /// </summary>
        [IsoId("_TK_TUdp-Ed-ak6NoX_4Aeg_62627660")]
        [DisplayName("Withhold")]
        [IsoXmlTag("Wthhld")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Withhold { get; init; }

        /// <summary>
        /// Number of votes in line with the votes of the management.
        /// </summary>
        [IsoId("_TK_TUtp-Ed-ak6NoX_4Aeg_62627678")]
        [DisplayName("With Management")]
        [IsoXmlTag("WthMgmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? WithManagement { get; init; }

        /// <summary>
        /// Number of votes against the voting recommendation of the management.
        /// </summary>
        [IsoId("_TK_TU9p-Ed-ak6NoX_4Aeg_62627937")]
        [DisplayName("Against Management")]
        [IsoXmlTag("AgnstMgmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? AgainstManagement { get; init; }

        /// <summary>
        /// Number of votes for which decision is left to the party that will exercise the voting right.
        /// </summary>
        [IsoId("_TK_TVNp-Ed-ak6NoX_4Aeg_62627955")]
        [DisplayName("Discretionary")]
        [IsoXmlTag("Dscrtnry")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Discretionary { get; init; }

        /// <summary>
        /// Number of votes for which no action has been taken.
        /// </summary>
        [IsoId("_TK_TVdp-Ed-ak6NoX_4Aeg_128196007")]
        [DisplayName("No Action")]
        [IsoXmlTag("NoActn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? NoAction { get; init; }
    }
}
