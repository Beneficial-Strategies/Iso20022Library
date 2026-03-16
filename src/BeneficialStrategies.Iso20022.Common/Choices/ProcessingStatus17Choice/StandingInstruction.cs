// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus17Choice
{
    /// <summary>
    /// Trade is standing instruction.
    /// </summary>
    [IsoId("_A5JrA9okEeC60axPepSq7g_1018532153")]
    [DisplayName("Standing Instruction")]
    public record StandingInstruction : ProcessingStatus17Choice_
    {
        /// <summary>
        /// Proprietary identification of the reason related to a status.
        /// </summary>
        [IsoId("_UatOxdp-Ed-ak6NoX_4Aeg_-1135929071")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public GenericIdentification20? Reason { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_UatOxtp-Ed-ak6NoX_4Aeg_-1133156666")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
