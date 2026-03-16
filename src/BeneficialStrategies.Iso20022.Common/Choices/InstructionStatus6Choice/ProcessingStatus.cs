// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus6Choice
{
    /// <summary>
    /// Status advising on the processing of the instruction.
    /// </summary>
    [IsoId("_sSu2s16uEeSyc4g_pm5hbw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public record ProcessingStatus : InstructionStatus6Choice_
    {
        /// <summary>
        /// Status on the processing of the instructions.
        /// </summary>
        [IsoId("_svC_QV6uEeSyc4g_pm5hbw")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required Status7Code Status { get; init; }

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_svC_Q16uEeSyc4g_pm5hbw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
