// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus2Choice
{
    /// <summary>
    /// Status advising on the processing of the instruction.
    /// </summary>
    [IsoId("_RWwVkNp-Ed-ak6NoX_4Aeg_-1271508072")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public record ProcessingStatus : InstructionStatus2Choice_
    {
        /// <summary>
        /// Status on the processing of the instructions.
        /// </summary>
        [IsoId("_RWwVk9p-Ed-ak6NoX_4Aeg_-316967473")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required Status3Code Status { get; init; }

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RWwVlNp-Ed-ak6NoX_4Aeg_-316967450")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
