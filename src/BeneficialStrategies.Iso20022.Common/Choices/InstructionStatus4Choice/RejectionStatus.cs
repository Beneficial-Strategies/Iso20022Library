// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus4Choice
{
    /// <summary>
    /// Status advising on the rejection of the instruction.
    /// </summary>
    [IsoId("_RCpGx9p-Ed-ak6NoX_4Aeg_-1261069059")]
    [DisplayName("Rejection Status")]
    [IsoXmlTag("RjctnSts")]
    public record RejectionStatus : InstructionStatus4Choice_
    {
        /// <summary>
        /// Reason advising the rejection of the instruction.
        /// </summary>
        [IsoId("_RCfVw9p-Ed-ak6NoX_4Aeg_-1090217196")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required InstructionRejectionStatus1Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the reason.
        /// </summary>
        [IsoId("_RCfVxNp-Ed-ak6NoX_4Aeg_-1755939689")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
