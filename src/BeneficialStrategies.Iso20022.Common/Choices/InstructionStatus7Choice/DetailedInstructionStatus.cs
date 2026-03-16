// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus7Choice
{
    /// <summary>
    /// Status of an individual meeting instruction.
    /// </summary>
    [IsoId("_8bzrBa-nEemJ1NnLPsTFaw")]
    [DisplayName("Detailed Instruction Status")]
    public record DetailedInstructionStatus : InstructionStatus7Choice_
    {
        /// <summary>
        /// Identification of the specific individual instruction from the original meeting instruction message, element InstructionType/ InstructionIdentification, for which the status is provided.
        /// </summary>
        [IsoId("_8v5Epa-nEemJ1NnLPsTFaw")]
        [DisplayName("Single Instruction Identification")]
        [IsoXmlTag("SnglInstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SingleInstructionIdentification { get; init; }

        /// <summary>
        /// Identification of the securities account.
        /// </summary>
        [IsoId("_8v5Ep6-nEemJ1NnLPsTFaw")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? AccountIdentification { get; init; }

        /// <summary>
        /// Identification of the subaccount within the safekeeping account.
        /// </summary>
        [IsoId("_8v5Eqa-nEemJ1NnLPsTFaw")]
        [DisplayName("Sub Account Identification")]
        [IsoXmlTag("SubAcctId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SubAccountIdentification { get; init; }

        /// <summary>
        /// Status of an individual meeting instruction.
        /// </summary>
        [IsoId("_8v5Eq6-nEemJ1NnLPsTFaw")]
        [DisplayName("Instruction Status")]
        [IsoXmlTag("InstrSts")]
        public required InstructionStatus8Choice_ InstructionStatus { get; init; }
    }
}
