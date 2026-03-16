// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus3Choice
{
    /// <summary>
    /// Status applying to individual instructions of a MeetingInstruction.
    /// </summary>
    [IsoId("_RCpGxNp-Ed-ak6NoX_4Aeg_-1175269447")]
    [DisplayName("Detailed Instruction Status")]
    public record DetailedInstructionStatus : InstructionStatus3Choice_
    {
        /// <summary>
        /// Identifies the detailed instruction within an instruction message.
        /// </summary>
        [IsoId("_RCy3xNp-Ed-ak6NoX_4Aeg_1948673741")]
        [DisplayName("Instruction Identification")]
        [IsoXmlTag("InstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text InstructionIdentification { get; init; }

        /// <summary>
        /// Identifies the safekeeping account.
        /// </summary>
        [IsoId("_RCy3xdp-Ed-ak6NoX_4Aeg_1948673433")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? AccountIdentification { get; init; }

        /// <summary>
        /// Identifies the subaccount of the safekeeping account.
        /// </summary>
        [IsoId("_RCy3xtp-Ed-ak6NoX_4Aeg_1948673493")]
        [DisplayName("Sub Account Identification")]
        [IsoXmlTag("SubAcctId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SubAccountIdentification { get; init; }

        /// <summary>
        /// Status applying to individual instructions of a MeetingInstruction.
        /// </summary>
        [IsoId("_RCy3x9p-Ed-ak6NoX_4Aeg_-949932186")]
        [DisplayName("Instruction Status")]
        [IsoXmlTag("InstrSts")]
        public required InstructionStatus4Choice_ InstructionStatus { get; init; }
    }
}
